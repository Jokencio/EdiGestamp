using System;
using indice.Edi.Serialization;


namespace indice.Test
{
    class GESTAMP_DESADV_D98A
    {
        #region Interchange Header

        // UNB --> Comienzo, identificación y especificación de un mensaje.

        /// <summary>
        /// Identificador de sintáxis: Código que identifica la agencia controladora de sintáxis y el nivel usado en el intercambio.
        /// En este caso usaremos el valor UNOA --> Nivel A del organismo UN/ECE definido en la ISO 9735
        /// Syntax identifier: Coded identification of the agency controlling a syntax and syntax level used in an interchange.
        /// Formato: Cadena de cuatro caracteres
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/0/0")] // Equivalente a UNB/0/0
        public string IdentificadorSintaxis {
            get {
                return @"UNOA";
            }
        }

            /// <summary>
            /// Número de versión de sintáxis, Ejemplo: 2. No vienen descritos los posibles valores.  
            /// Syntax Version Number: Version number of the syntax identified in the syntax identifier (0001).
            /// Número de tamaño 1 dígito
            /// Uso: Obligatorio
            /// </summary>
            [EdiValue(Path = "UNB/0/1")]
        public string VersionSintaxis {
            get {
                return @"2";
            }
        }


        /// <summary>
        /// Nombre o código identificador del que envía la transmisión.
        /// Sender Identification: Name or coded representation of the sender of a data interchange.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/1")]
        public string codigoRemitente { get; set; }


        /// <summary>
        /// Identificador del receptor. El número de identificación de GESTAMP cambiará dependiendo de la sede.
        /// Contactar con el destino para solicitar el número. Ejemplo 0941A082790930
        /// Recipient Identification: Name or coded representation of the recipient of a data interchange.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/2")]
        public string CodigoReceptor { get; set; }


        /// <summary>
        /// Fecha de creación de la transmisión, yymmdd
        /// Date: Local date when an interchange or a functional group was prepared.
        /// Número de 6 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/3/0")]
        public string FechaTransmision { get; set; }


        /// <summary>
        /// Hora de creación de la transmisión, hhmm
        /// Time: Local time of day when an interchange or a functional group was prepared.
        /// Número de 4 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/3/1")]
        public string HoraTransmision { get; set; }


        /// <summary>
        /// Código único de identificación de la transmisión, asignado por el que la envía.
        /// Interchange Control Reference: Unique reference assigned by the sender to an interchange.
        /// Cadena de longitud máxima 14
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNB/4")]
        public string ReferenciaTransmision { get; set; }
        

        #endregion Interchange Header


        public Message_DESADVD98A Message { get; set; }



        #region Interchange Trailer

        // UNZ --> Final y chequeo de mensaje completado.

        /// <summary>
        /// Número de mensajes en el archivo de transmisión, por lo general 1.
        /// Interchange Control Count: Count either of the number of messages or, if used, of the number of functional groups in an interchange.
        /// Número de longitud máxima 6 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNZ/0")]
        public string CantidadMensajes { get; set; }


        /// <summary>
        /// Referencia única asignada por el que envía el mensaje, tiene que coincidir con el de la cabecera
        /// Interchange Control Reference: Unique reference assigned by the sender to an interchange.
        /// Cadena de longitud máxima 14
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNZ/1")]
        public string ControlReferenciaTransmision { get; set; }

        #endregion Interchange Trailer

    }

    [EdiMessage]
    public class Message_DESADVD98A {
        #region Message Header Info

        // UNH --> Cabecera del mensaje.

        /// <summary>
        /// Número de referencia del mensaje dentro de la transmisión, único y asignado por quien envía el mensaje y empezando en 1.
        /// Por lo general 1. Si enviásemos 2 mensajes dentro de una misma transmisión, el primero sería 1 y el otro 2.
        /// Message Reference Number: Unique message reference assigned by the sender.
        /// Cadena de longitud máxima 15
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNH/0")]
        public string NumeroMensaje { get; set; }


        /// <summary>
        /// Tipo de mensaje, en este caso DESADV (Albarán)
        /// Message Type Identifier: Code identifying a type of message and assigned by its controlling agency.
        /// Cadena de longitud máxima 6
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNH/1/0")]
        public string TipoMensaje {
            get {
                return @"DESADV";
            }
        }


        /// <summary>
        /// Versión del mensaje, en este caso D
        /// Message Type Version Number: Version number of a message type.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNH/1/1")]
        public string VersionMensaje {
            get {
                return @"D";
            }
        }

        /// <summary>
        /// Lanzamiento de la Edición, en este caso 98A
        /// Message Type Release Number: Release number within the current message type version number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNH/1/2")]
        public string LanzamientoEdicion {
            get {
                return @"98A";
            }
        }


        /// <summary>
        /// Agencia que controla la versión del mensaje, en este caso Naciones Unidas, UN
        /// Controlling Agency: Code identifying the agency controlling the specification, maintenance and publication of the message type.
        /// Cadena de longitud máxima 2
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNH/1/3")]
        public string AgenciaControl {
            get {
                return @"UN";
            }
        }


        #endregion Message Header Info


        public GESTAMP_BGM BGM { get; set; }
        public GESTAMP_DTM[] DTM { get; set; }
        public GESTAMP_MEA[] MEA { get; set; }
        
        public GESTAMP_NAD_Group2[] NAD_Group2 { get; set; }
        public GESTAMP_TDT TDT { get; set; }        
        public GESTAMP_CPS_Group10[] CPS_Group10 { get; set; }


        #region Message Trailer Info

        // UNT --> Cola del mensaje, proporciona el número total de segmentos en el mensaje y el número de referencia de control del mensaje.

        /// <summary>
        /// Número de segmentos del mensaje.
        /// Number Of Segments In A Message: Control count of number of segments in a message.
        /// Número de máximo 6 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNT/0")]
        public string NumeroSegmentos { get; set; }


        /// <summary>
        /// Número de referencia del mensaje, es similar al de la cabecera UNH (1, 2...)
        /// Message Reference Number: Unique message reference assigned by the sender.
        /// Cadena de longitud máxima 14
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "UNT/1")]
        public string ControlNumeroMensaje { get; set; }
        #endregion
    }

    #region EdiSegmentGroups
    

    [EdiSegmentGroup("NAD", SequenceEnd = "TDT")]
    public class GESTAMP_NAD_Group2
    {

        // NAD --> Identifica nombre, direcciones y sus funciones relativas al detalle del envío.
        // A segment for identifying names, addresses, and their functions relevant to the whole despatch Advice. Identification of the parties involved
        // is recommended for the Despatch Advice message, and is to be given in the NAD segment. It is recommended that where possible, only the coded
        // form of the party ID should be specified, e.g. the buyer and seller are known to each other, thus only the coded ID is required. The consignee or
        // delivery address may vary and would have to be clearly specified, preferably in structured format.

        /// <summary>
        /// Código que especifica la parte involucrada en el envío Remitente-Transportista-Receptor sobre la que vamos a porporcionar datos, en nuestro caso usamos tres, una línea por cada uno.
        /// FW: relativo a la empresa de transporte; CN: relativo al receptor; CZ: relativo al remitente.
        /// Party Qualifier: Code giving specific meaning to a party.
        /// Cadena de longitud máxima 3.
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "NAD/0")]
        public string ParteInvolucradaEnvio { get; set; }


        /// <summary>
        /// Código de la parte involucrada. En el caso de la empresa de transporte se puede poner "UNKNOWN" si no se conoce.
        /// Party Identification: Code identifying a party involved in a transaction.
        /// Cadena de longitud máxima 10
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "NAD/1/0")]
        public string CodigoParte { get; set; }


        /// <summary>
        /// NO SE USA, pero se mantiene el campo para que añada los ":" en la línea.
        /// Code List Qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "NAD/1/1")]
        public string CodigoLista { get; set; }


        /// <summary>
        /// Código de identificación de la agencia responsable de la lista de códigos. En este caso hay dos posibilidades
        /// 91: asignado por el proveedor; 92: asignado por el comprador
        /// Code List Reponsible Agency Coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud 2
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "NAD/1/2")]
        public string AgenciaResponsableCodigos { get; set; }

        public GESTAMP_LOC[] LOC { get; set; }
    }
    

    [EdiSegmentGroup("CPS", SequenceEnd = "UNT")]
    public class GESTAMP_CPS_Group10
    {

        // CPS --> Segmento que identifica la secuencia en la que se empaqueta el envío, por ejemplo cajas cargadas en un pallet.

        /// <summary>
        /// Números consecutivos que identifican cada paquete, unidad, etc. Empieza desde el 1.
        /// Hierarchical ID. Number: A unique number assigned by the sender to identify a level within a hierarchical structure.
        /// Cadena de longitud máxima 6
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "CPS/0")]
        public string PaqueteId { get; set; }


        /// <summary>
        /// Código del padre
        /// Hierarchical Parent ID: Identification number of the next higher hierarchical data segment in a hierarchical structure.
        /// Cadena de longitud máxima 6
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "CPS/1")]
        public string CodigoPadre { get; set; }


        /// <summary>
        /// Código que define el nivel de empaquetamiento.
        /// 1 = Interior, no sirve para unidades
        /// 2 = Nivel intermedio para cargas mixtas, si se da el caso, también para cargas homogéneas.
        /// 3 = Exterior, unidades de manipulación (paquete con subpaquete): nivel de embalaje más alto;
        /// A continuación tiene que ir al menos 1 segmento CPS para una unidad de entrega o un paquete de nivel intermedio.
        /// 4 = Sin jerarquía de empaquetado, no se usa para manejar unidades.
        /// Packaging Level, Coded: Indication of level of packaging specified.
        /// Cadena de longitud 1
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "CPS/2")]
        public string NivelEmpaquetamiento { get; set; }

        public GESTAMP_PAC_Group11[] PAC_Group11 { get; set; }
        public GESTAMP_LIN_Group16[] LIN_Group16 { get; set; }
    }

    [EdiSegmentGroup("PAC", SequenceEnd = "LIN")]
    public class GESTAMP_PAC_Group11
    {

        // PAC --> Un segmento que especifica el número y tipo de los paquetes/unidades físicas y el tipo físico de embalaje para los productos enviados.

        /// <summary>
        /// Número de paquetes
        /// Number Of Packages: Number of individual parts of a shipment either unpacked, or packed in such a way that they cannot be divided without first
        /// undoing the packing.
        /// Número de máximo 8 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PAC/0")]
        public string NumeroPaquetes { get; set; }


        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Packaging Level, Coded: Indication of level of packaging specified.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "PAC/1")]
        public string PackLevel { get; set; }


        /// <summary>
        /// Identificación del tipo de embalaje
        /// Type of Packages Identification: Coded description of the form in which goods are presented.
        /// Cadena de longitud máxima 17
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PAC/2/0")]
        public string TipoEmbalajeId { get; set; }

        /// <summary>
        /// NO SE USA, se mantiena para que aparezca el símbolo ":"
        /// Code List Qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "PAC/2/1")]
        public string ListQual { get; set; }


        /// <summary>
        /// Codigo agencia responsable de asignar códigos
        /// En nuestro caso usamos el código 92: Asignado por el comprador
        /// Code List Responsible Agency, Coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PAC/2/2")]
        public string PacCodigoResponsable {
            get {
                return @"92";
            }
        }
        

        public GESTAMP_QTY QTY { get; set; }

        public GESTAMP_PCI_Group13[] PCI_Group13 { get; set; }
    }

    [EdiSegmentGroup("PCI", SequenceEnd = "UNT")]
    public class GESTAMP_PCI_Group13
    {

        // PCI --> Identificación del paquete

        /// <summary>
        /// Código que indica instrucciones sobre el paquete
        /// En nuestro caso usamos el 17: Instrucciones del proveedor
        /// Marking instructions, coded: Code indicating instructions on how specified packages or physical units should be marked.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PCI/0")]
        public string TipoInstrucciones {
            get {
                return @"17";
            }
        }

        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Shipping marks: Marks and numbers identifying individual packages.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PCI/1")]
        public string ShippingMarks { get; set; }

        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// CONTAINER/PACKAGE STATUS, CODED: Code to identify whether goods of separate description or comprising separate consignments are contained in the same external packaging or to indicate that a container or similar unit load device is empty.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "PCI/2")]
        public string PackStatus { get; set; }


        /// <summary>
        /// Forma de marcado
        /// En nuestro caso usamos G: Unidades de carga mixta; M: Unidades de carga homogénea; S: Unidades sueltas
        /// Type of marking, coded: To specify the type of marking that reflects the method and the conventions adhered to for marking.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PCI/3/0")]
        public string  TipoMarcado { get; set; }


        /// <summary>
        /// NO SE USA, se mantiene el campo para que aparezca ":"
        /// Code list qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "PCI/3/1")]
        public string CodeListQual { get; set; }


        /// <summary>
        /// Agencia responsable asignar códigos
        /// En nuestro caso 10: Odette
        /// Code list responsible agency, coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PCI/3/2")]
        public string PCIResponsableCodigos {
            get {
                return @"10";
            }
        }


        public GESTAMP_GIN[] GIN { get; set; }
    }

    [EdiSegmentGroup("LIN", SequenceEnd = "UNT")]
    public class GESTAMP_LIN_Group16
    {

        // LIN --> Información sobre los productos enviados

        /// <summary>
        /// Número de línea de artículo.
        /// Line Item Number: Serial number designating each separate item within a series of articles.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "LIN/0")]
        public string NumeroLinea { get; set; }


        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Action Request/Notification, Coded: Code specifying the action to be taken or already taken.
        /// Uso: Condicional
        /// </summary>
        //[EdiValue(Path = "LIN/1")]
        //public string Action { get; set; }


        /// <summary>
        /// Código de producto
        /// En nuestro caso uno de GESTAMP
        /// Item Number: A number allocated to a group or item.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "LIN/2/0")]
        public string IdProducto { get; set; }


        /// <summary>
        /// Código sobre el tipo identificación del producto.
        /// En nuestro caso IN: Designado por el comprador.
        /// Item Number Type, Coded: Identification of the type of item number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "LIN/2/1")]
        public string TipoIdProducto {
            get {
                return @"IN";
            }
        }

        
        public GESTAMP_PIA PIA { get; set; }

        public GESTAMP_IMD IMD { get; set; }

        public GESTAMP_QTY[] QTY { get; set; }

        public GESTAMP_ALI[] ALI { get; set; }

        public GESTAMP_RFF_Group17[] RFF_Group17 { get; set; }

    }

    [EdiSegmentGroup("RFF", SequenceEnd = "UNT")]
    public class GESTAMP_RFF_Group17
    {
        // RFF --> Segmento que identifica documentos relacionados con la línea de pedido.

        /// <summary>
        /// Código que indica lo que significa el número de referencia.
        /// En nuestro caso AAU: Número de albarán.
        /// Reference Qualifier: Code giving specific meaning to a reference segment or a reference number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "RFF/0/0")]
        public string TipoReferencia {
            get {
                return @"AAU";
            }
        }


        /// <summary>
        /// Número de albarán, asignado por el proveedor
        /// Reference Number: Identification number.
        /// Número de longitud máxima 10
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "RFF/0/1")]
        public string NumeroReferencia { get; set; }


        /// <summary>
        /// Número de línea de albarán
        /// Line number: Number of the line in the document/message
        /// Número entero entre 001 y 999
        /// Cadena numérica de longitud obligatoria 3.
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "RFF/0/2")]
        public string NumeroLinea { get; set; }

        public GESTAMP_DTM RFFDTM { get; set; }
    }

    #endregion

    #region Segments

    [EdiSegment, EdiPath("BGM")]
    public class GESTAMP_BGM
    {

        // BGM --> Identificación del documento

        /// <summary>
        /// Código para identificar el tipo de documento, en este caso 351 (Aviso de envío)
        /// Document/Message Name, Coded: Document/message identifier expressed in code.
        /// Cadena de máximo 3 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "BGM/0")]
        public string TipoDocumento {
            get {
                return @"351";
            }
        }


        /// <summary>
        /// Código de envío, asignado por la empresa de transporte
        /// Document/Message Number: Reference number assigned to the document/message by the issuer.
        /// Cadena de máximo 17 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "BGM/1")]
        public string CodigoEnvio { get; set; }

    }

    [EdiSegment, EdiPath("DTM")]
    public class GESTAMP_DTM
    {

        // DTM --> Hora y fecha del documento

        /// <summary>
        /// Código del tipo de Fecha/Hora. En el caso de GESTAMP se usan tres en el mismo mensaje: 137, 11 y 191, una línea por cada uno.
        /// 137: Fecha/Hora a la que se crea el envío
        /// 11: Fecha/Hora a la que se estima se realizará el envío
        /// 191: Fecha/Hora a la  que se estima se entregará el envío
        /// 
        /// En las referencias del albaran se usa el código 171, fecha y hora del albarán de entrega.
        /// Date/Time/Period Qualifier: Code giving specific meaning to a date, time or period.
        /// Cadena de máximo 3 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "DTM/0/0")]
        public string FechaFaseEnvio { get; set; }


        /// <summary>
        /// Fecha y hora
        /// Date/Time/Period: The value of a date, a date and time, a time or of a period in a specified representation.
        /// Cadena de máximo 12 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "DTM/0/1")]
        public string FechaHora { get; set; }


        /// <summary>
        /// Código de formato de fecha, en nuestro caso 203, YYYYMMDDHHMM
        /// Date/Time/Period Format Qualifier: Specification of the representation of a date, a date and time or of a period.
        /// Cadena de máximo 3 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "DTM/0/2")]
        public string FormatoFecha {
            get {
                return @"203";
            }
        }

        public override string ToString() {

            if (!string.IsNullOrEmpty(FechaHora)) throw new ArgumentException("La fecha del mensaje no puede estar vacia");
            if (FechaHora.Trim().Length < 10) throw new ArgumentException("La longitud de la fecha del mensaje no puede estar vacia");

            var year = FechaHora.Substring(0, 4);
            var month = FechaHora.Substring(4, 2);
            var day = FechaHora.Substring(6, 2);

            var dt = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            return dt.ToString("d");
        }
    }

       
    [EdiSegment, EdiPath("MEA")]
    public class GESTAMP_MEA
    {

        // MEA --> Especificación del volumen y el peso del envío.

        /// <summary>
        /// Código de medida, en nuestro caso el "AAX" que hace referencia a que se van a detallar especificaciones del envío
        /// Measurement Application Qualifier: Specification of the application of the physical measurement used.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "MEA/0")]
        public string CodigoMedida {
            get {
                return @"AAX";
            }
        }


        /// <summary>
        /// Propiedad del envío que se va a medir, en nuestro caso usamos dos diferentes, una línea por cada uno.
        /// AAD: Peso bruto; SQ: Cantidad enviada.
        /// Measurement Dimension Code: Specification of the type of dimension to be measured.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "MEA/1")]
        public string PropiedadMedida { get; set; }


        /// <summary>
        /// Unidad de medida de la propiedad, en nuestro caso KGM para el peso y NMP para la cantidad enviada.
        /// KGM: Kilogramos; NMP: Número de paquetes
        /// Measure unit qualifier: Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "MEA/2/0")]
        public string UnidadMedida { get; set; }


        /// <summary>
        /// Valor de la de la propiedad, valores enteros.
        /// Measurement value: Value of the measured unit.
        /// Números de hasta 8 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "MEA/2/1")]
        public string ValorMedida { get; set; }
    }

    [EdiSegment, EdiPath("LOC")]
    public class GESTAMP_LOC
    {

        // LOC --> Detalle de lugares y localizaciones de las partes indicadas en el segmento NAD.
        // A segment indicating more details regarding specific places/locations related to the party specified in the NAD segment,
        // e.g. internal site/building number.

        /// <summary>
        /// Código que indica el lugar, en nuestro caso usamos el código 11 que hace referencia a "Lugar de descarga"
        /// Place/Location Qualifier: Code identifying the function of a location.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "LOC/0")]
        public string TipoLugar {
            get {
                return @"11";
            }
        }


        /// <summary>
        /// Código de lugar donde se recive la mercancía.
        /// Place/Location Identification: Identification of the name of place/location, other than 3164 City name.
        /// Cadena de longitud máxima 12
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "LOC/1/0")]
        public string CodigoLugar { get; set; }


        /// <summary>
        /// NO SE USA, pero se mantiene el campo para que añada los ":" en la línea.
        /// Code List Qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "LOC/1/1")]
        public string LocCodigoLista { get; set; }


        /// <summary>
        /// Código de identificación de la agencia responsable de la lista de códigos.
        /// En nuestro caso 92: Asignado por el comprador
        /// Code List Reponsible Agency Coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud 2
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "LOC/1/2")]
        public string LocAgenciaResponsableCodigos {
            get {
                return @"92";
            }
        }
    }

    [EdiSegment, EdiPath("TDT")]
    public class GESTAMP_TDT
    {
        // TDT --> Segmento donde se especifica el medio y modo de transporte del envío

        /// <summary>
        /// Código relativo a una especificación del transporte.
        /// En nuestro caso 12: Los materiales que se envían se transportan desde el punto de origen.
        /// Transport stage qualifier: Qualifier giving a specific meaning to the transport details.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "TDT/0")]
        public string CodigoTipoTransporte {
            get {
                return @"12";
            }
        }


        /// <summary>
        /// Código asignado por el transportista a algunos viajes o salidas 
        /// En los ejemplos no se usa.
        /// CONVEYANCE REFERENCE NUMBER: Unique reference given by the carrier to a certain journey or departure of a means of transport (generic term).
        /// Cadena de longitud máxima 17
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/1")]
        public string CodigoViaje { get; set; }


        /// <summary>
        /// Código del método de transporte.
        /// En nuestro caso, 30: por carretera
        /// Mode of transport, coded: Coded method of transport used for the carriage of the goods.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "TDT/2")]
        public string MetodoTransporte {
            get {
                return @"30";
            }
        }


        /// <summary>
        /// Código del vehículo de transporte.
        /// En nuestro caso, 31: camión
        /// Type of means of transport identification: Code defining the type of the means of transport being utilized.
        /// Cadena de longitud máxima 8
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/3")]
        public string VehiculoTransporte {
            get {
                return @"31";
            }
        }


        /// <summary>
        /// Código de la compañia de transportes.
        /// Se puede poner "UNKNOWN"
        /// Carrier identification: Identification of party undertaking or arranging transport of goods between named points.
        /// Cadena de longitud máxima 17
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/4/0")]
        public string CodigoTransportista { get; set; }


        /// <summary>
        /// NO SE USA, se define el campo para que aparezcan los ":"
        /// Code list qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/4/1")]
        public string CodeListQualifier { get; set; }


        /// <summary>
        /// Código que indica quién se encarga de los códigos
        /// En nuestro caso 91: Asignado por el proveedor; 92: Asignado por el comprador.
        /// Code list responsible agency, coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "TDT/4/2")]
        public string CodigoResponsable { get; set; }


        /// <summary>
        /// Código que indica Origen-Destino en términos generales.
        /// TRANSIT DIRECTION, CODED: Identification of the point of origin and point of direction.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/5")]
        public string CodigoOrigenDestino { get; set; }


        /// <summary>
        /// Razón de retraso en el transporte
        /// Excess transportation reason, coded: Indication of reason for excess transportation.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/6")]
        public string CodigoRetraso { get; set; }


        /// <summary>
        /// Identificación del medio de transporte por nombre o número.
        /// Id. of means of transport identification: Identification of the means of transport by name or number.
        /// Cadena de longitud máxima 9
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/7/0")]
        public string Matricula { get; set; }


        /// <summary>
        /// Identificación del medio de transporte por nombre o número.
        /// En nuestro caso 146: Matrícula
        /// Code list qualifier: Identification of a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/7/1")]
        public string TipoIdMedioTransporte {
            get {
                return @"146";
            }
        }


        /// <summary>
        /// Código agencia encargada de los códigos
        /// En nuestro caso 5: ISO (International Organization for Standarization)
        /// Code list responsible agency, coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/7/2")]
        public string ResponsableCodigo {
            get {
                return @"5";
            }
        }


        /// <summary>
        /// Código que indica la titularidad dle medio de transporte
        /// En nuestro caso
        /// 1: El propietario de los bienes transportados también es el propietario del medio de transporte o lo alquiló para este transporte.
        /// 2: El propietario de los bienes transportados no posee el medio de transporte o no lo ha alquilado para este transporte.
        /// TRANSPORT OWNERSHIP, CODED: Code indicating the ownership of the means of transport.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "TDT/8")]
        public string CodigoTitularidadTransporte { get; set; }

    }

    [EdiSegment, EdiPath("GIN")]
    public class GESTAMP_GIN
    {
        // GIN --> Identificación de los paquetes

        /// <summary>
        /// Código que indica el tipo de identificación que llevan los paquetes
        /// En nuestro caso usamos ML: Número de etiqueta.
        /// IDENTITY NUMBER QUALIFIER: Code specifying the type/source of identity number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "GIN/0")]
        public string TipoIdPaquete {
            get {
                return @"ML";
            }
        }

            /// <summary>
            /// Identificación de un paquete
            /// Identity number: The number given to an object for its unique identification.
            /// Número de longitud máxima 12
            /// Uso: Obligatorio
            /// </summary>
            [EdiValue(Path = "GIN/1/0")]
        public string IdPaquete { get; set; }

    }

    [EdiSegment, EdiPath("PIA")]
    public class GESTAMP_PIA
    {
        // PIA --> Información adicional sobre los productos

        /// <summary>
        /// Código que indica la función del código de producto
        /// En nuestro caso utilizamos 1: Información adicional sobre el producto.
        /// PRODUCT ID. FUNCTION QUALIFIER: Indication of the function of the product code.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/0")]
        public string FuncionIdPaquete {
            get {
                return @"1";
            }
        }

        /// <summary>
        /// Número asignado al producto
        /// Item number: A number allocated to a group or item.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/1/0")]
        public string NumeroIdPaquete { get; set; }


        /// <summary>
        /// Tipo de número de producto
        /// En nuestro caso ON: Número de pedido
        /// Item number type, coded: Identification of the type of item number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/1/1")]
        public string TipoNumeroPaquete {
            get {
                return @"ON";
            }
        }

        /// <summary>
        /// Número de lote.
        /// Si hay varios números de lote relacionados con un código de artículo, la cantidad de entrega debe dividirse
        /// y cada número de lote en un grupo diferente, comenzando con CPS, seguido de la cantidad de lote y el número de lote.
        /// Item number: A number allocated to a group or item.
        /// Cadena de longitud máxima 35
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/2/0")]
        public string IdLote { get; set; }


        /// <summary>
        /// Tipo de número de producto
        /// En nuestro caso BB: Número de lote
        /// Item number type, coded: Identification of the type of item number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/2/1")]
        public string TipoNumeroLote {
            get {
                return @"BB";
            }
        }

        /// <summary>
        /// Identificación asignada por el proveedor al artículo.
        /// Item number: A number allocated to a group or item.
        /// Cadena de longitud máxima 35
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "PIA/3/0")]
        public string CodigoArticuloProveedor { get; set; }


        /// <summary>
        /// Tipo de número de producto
        /// En nuestro caso SA: Número asignado a un artículo por el proveedor de ese artículo.
        /// Item number type, coded: Identification of the type of item number.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "PIA/3/1")]
        public string TipoNumeroProveedor {
            get {
                return @"SA";
            }
        }

    }

    [EdiSegment, EdiPath("IMD")]
    public class GESTAMP_IMD
    {
        // IMD --> Un segmento para describir el producto que se envía. Este segmento debe usarse para productos que no pueden identificarse mediante un código de producto o número de artículo.

        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// ITEM DESCRIPTION TYPE, CODED: Code indicating the format of a description.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "IMD/0")]
        public string ItemDescType { get; set; }

        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Item characteristic, coded: Code specifying the item characteristic being described.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "IMD/1")]
        public string ItemCharact { get; set; }


        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Item description identification: Code from an industry code list which provides specific data about a product characteristic.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "IMD/2/0")]
        public string ItemDescId { get; set; }


        /// <summary>
        /// NO SE USA, se mantiene para que aparezca el símbolo "+"
        /// Code list qualifier: Identification of a code list.
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "IMD/2/1")]
        public string CodeListQual { get; set; }


        /// <summary>
        /// Codigo para identificar la agencia responsable de asignar los códigos
        /// En nuestro caso 5: ISO (International Organization for Standarization)
        /// Code list responsible agency, coded: Code identifying the agency responsible for a code list.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "IMD/2/2")]
        public string IMDcodigoResponsable { get; set; }


        /// <summary>
        /// Descripción del artículo
        /// OPCIONAL
        /// Item description: Plain language description of articles or products.
        /// Cadena de longitud máxima 3
        /// Uso: Condicional
        /// </summary>
        [EdiValue(Path = "IMD/2/3")]
        public string ArticuloDescripcion { get; set; }
    }

    //[EdiSegment, EdiPath("RFF")]
    //public class GESTAMP_RFF
    //{

    //    // RFF --> To specify a reference.

    //    /// <summary>
    //    /// Reference Qualifier: Code giving specific meaning to a reference segment or a reference number.
    //    /// Usage: Mandatory
    //    /// </summary>
    //    [EdiValue(Path = "RFF/0/0")]
    //    public string RefQua { get; set; }


    //    /// <summary>
    //    /// Reference Number: Identification number the nature and function of which can be qualified by an entry in data element 1153 Reference qualifier.
    //    /// Usage: Mandatory
    //    /// </summary>
    //    [EdiValue(Path = "RFF/0/1")]
    //    public string RefNum { get; set; }

    //}

    [EdiSegment, EdiPath("QTY")]
    public class GESTAMP_QTY
    {

        // QTY --> Un segmento para especificar la cantidad por paquete descrito en el segmento PAC.

        /// <summary>
        /// Código que indica a qué se refiere la cantidad.
        /// En nuestro caso usamos 1: Paquetes separados; 52: Cantidad por paquete.
        /// Quantity Qualifier: Code giving specific meaning to a quantity.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "QTY/0/0")]
        public string TipoCantidad { get; set; }


        /// <summary>
        /// Cantidad
        /// Quantity: Numeric value of a quantity.
        /// Número de maxímo 10 dígitos
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "QTY/0/1")]
        public string Cantidad { get; set; }


        /// <summary>
        /// Unidad de medida.
        /// En nuestro caso KGM: Kilogramos, PCE: Unidades
        /// Measure Unit Qualifier: Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "QTY/0/2")]
        public string UnidadMedidaCantidad { get; set; }
    }

    [EdiSegment, EdiPath("ALI")]
    public class GESTAMP_ALI
    {

        // ALI --> Segmento que indica que la línea de pedido está sujeta a condiciones especiales debido a su origen, preferencia aduanera o factores comerciales.

        /// <summary>
        /// Pais de origen de los artículos.
        /// En nuestro caso "ES"
        /// Country Of Origin, Coded: Country in which the goods have been produced or manufactured, according to criteria laid down for the purposes
        /// of application of the Customs tariff, of quantitative restrictions, or of any other measure related to trade.
        /// Cadena de longitud máxima 3
        /// Uso: Obligatorio
        /// </summary>
        [EdiValue(Path = "ALI/0")]
        public string PaisOrigen {
            get {
                return @"ES";
            }
        }

    }
    #endregion
}
