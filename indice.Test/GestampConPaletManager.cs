using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi;

namespace indice.Test
{
    class GestampConPaletManager
    {
        public GESTAMP_DESADV_D98A BuildPalletExample()
        {
            var albaran = new GESTAMP_DESADV_D98A();

            // Structure
            albaran.Message = new Message_DESADVD98A();

            albaran.Message.BGM = new GESTAMP_BGM();

            albaran.Message.DTM = new GESTAMP_DTM[3];
            for (var i = 0; i < 3; i++)
                albaran.Message.DTM[i] = new GESTAMP_DTM();


            albaran.Message.MEA = new GESTAMP_MEA[2];
            for (var i = 0; i < 2; i++)
                albaran.Message.MEA[i] = new GESTAMP_MEA();

            albaran.Message.NAD_Group2 = new GESTAMP_NAD_Group2[3];
            for (var i = 0; i < 3; i++)
                albaran.Message.NAD_Group2[i] = new GESTAMP_NAD_Group2();

            albaran.Message.TDT = new GESTAMP_TDT();

            albaran.Message.CPS_Group10 = new GESTAMP_CPS_Group10[6];
            for (var i = 0; i < 6; i++) 
                albaran.Message.CPS_Group10[i] = new GESTAMP_CPS_Group10();

            // Palet 1
            albaran.Message.CPS_Group10[0].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[0].PAC_Group11[0] = new GESTAMP_PAC_Group11();            

            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[1];
            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0] = new GESTAMP_GIN();

            // Cajas del palet 1
            albaran.Message.CPS_Group10[1].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[1].PAC_Group11[0] = new GESTAMP_PAC_Group11();

            albaran.Message.CPS_Group10[1].PAC_Group11[0].QTY = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[48];
            for (var i = 0; i < 48; i++)
                albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13[0].GIN[i] = new GESTAMP_GIN();

            albaran.Message.CPS_Group10[1].LIN_Group16 = new GESTAMP_LIN_Group16[1];
            albaran.Message.CPS_Group10[1].LIN_Group16[0] = new GESTAMP_LIN_Group16();

            albaran.Message.CPS_Group10[1].LIN_Group16[0].PIA = new GESTAMP_PIA();

            albaran.Message.CPS_Group10[1].LIN_Group16[0].QTY = new GESTAMP_QTY[1];
            albaran.Message.CPS_Group10[1].LIN_Group16[0].QTY[0] = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[1].LIN_Group16[0].ALI = new GESTAMP_ALI[1];
            albaran.Message.CPS_Group10[1].LIN_Group16[0].ALI[0] = new GESTAMP_ALI();

            albaran.Message.CPS_Group10[1].LIN_Group16[0].RFF_Group17 = new GESTAMP_RFF_Group17[1];
            albaran.Message.CPS_Group10[1].LIN_Group16[0].RFF_Group17[0] = new GESTAMP_RFF_Group17();

            // Palet 2
            albaran.Message.CPS_Group10[2].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[2].PAC_Group11[0] = new GESTAMP_PAC_Group11();

            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[1];
            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13[0].GIN[0] = new GESTAMP_GIN();

            // Cajas del palet 2
            albaran.Message.CPS_Group10[3].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[3].PAC_Group11[0] = new GESTAMP_PAC_Group11();

            albaran.Message.CPS_Group10[3].PAC_Group11[0].QTY = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[48];
            for (var i = 0; i < 48; i++)
                albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13[0].GIN[i] = new GESTAMP_GIN();

            albaran.Message.CPS_Group10[3].LIN_Group16 = new GESTAMP_LIN_Group16[1];
            albaran.Message.CPS_Group10[3].LIN_Group16[0] = new GESTAMP_LIN_Group16();

            albaran.Message.CPS_Group10[3].LIN_Group16[0].PIA = new GESTAMP_PIA();

            albaran.Message.CPS_Group10[3].LIN_Group16[0].QTY = new GESTAMP_QTY[1];
            albaran.Message.CPS_Group10[3].LIN_Group16[0].QTY[0] = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[3].LIN_Group16[0].ALI = new GESTAMP_ALI[1];
            albaran.Message.CPS_Group10[3].LIN_Group16[0].ALI[0] = new GESTAMP_ALI();

            albaran.Message.CPS_Group10[3].LIN_Group16[0].RFF_Group17 = new GESTAMP_RFF_Group17[1];
            albaran.Message.CPS_Group10[3].LIN_Group16[0].RFF_Group17[0] = new GESTAMP_RFF_Group17();

            // Palet 3
            albaran.Message.CPS_Group10[4].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[4].PAC_Group11[0] = new GESTAMP_PAC_Group11();

            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[1];
            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13[0].GIN[0] = new GESTAMP_GIN();

            // Cajas del palet 3
            albaran.Message.CPS_Group10[5].PAC_Group11 = new GESTAMP_PAC_Group11[1];
            albaran.Message.CPS_Group10[5].PAC_Group11[0] = new GESTAMP_PAC_Group11();

            albaran.Message.CPS_Group10[5].PAC_Group11[0].QTY = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13 = new GESTAMP_PCI_Group13[1];
            albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13[0] = new GESTAMP_PCI_Group13();

            albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13[0].GIN = new GESTAMP_GIN[48];
            for (var i = 0; i < 48; i++)
                albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13[0].GIN[i] = new GESTAMP_GIN();

            albaran.Message.CPS_Group10[5].LIN_Group16 = new GESTAMP_LIN_Group16[1];
            albaran.Message.CPS_Group10[5].LIN_Group16[0] = new GESTAMP_LIN_Group16();

            albaran.Message.CPS_Group10[5].LIN_Group16[0].PIA = new GESTAMP_PIA();

            albaran.Message.CPS_Group10[5].LIN_Group16[0].QTY = new GESTAMP_QTY[1];
            albaran.Message.CPS_Group10[5].LIN_Group16[0].QTY[0] = new GESTAMP_QTY();

            albaran.Message.CPS_Group10[5].LIN_Group16[0].ALI = new GESTAMP_ALI[1];
            albaran.Message.CPS_Group10[5].LIN_Group16[0].ALI[0] = new GESTAMP_ALI();

            albaran.Message.CPS_Group10[5].LIN_Group16[0].RFF_Group17 = new GESTAMP_RFF_Group17[1];
            albaran.Message.CPS_Group10[5].LIN_Group16[0].RFF_Group17[0] = new GESTAMP_RFF_Group17();


            // fill properties
            // UNB            
            //albaran.IdentificadorSintaxis = "UNOA";
            //albaran.VersionSintaxis = "2";
            albaran.codigoRemitente = "O0013000100ZZZZZZ";
            albaran.CodigoReceptor = "0941A082790930";
            albaran.FechaTransmision = "200218";
            albaran.HoraTransmision = "1337";
            albaran.ReferenciaTransmision = "004000924";


            // UNH             
            albaran.Message.NumeroMensaje = "1";
            //albaran.Message.TipoMensaje = "DESADV";
            //albaran.Message.VersionMensaje = "D";
            //albaran.Message.LanzamientoEdicion = "98A";
            //albaran.Message.AgenciaControl = "UN";

            // BGM
            //albaran.Message.BGM.TipoDocumento = "351";
            albaran.Message.BGM.CodigoEnvio = "60150229";

            // DTM
            albaran.Message.DTM[0].FechaFaseEnvio = "137";
            albaran.Message.DTM[0].FechaHora = "201311190000";
            //albaran.Message.DTM[0].FormatoFecha = "203";

            albaran.Message.DTM[1].FechaFaseEnvio = "11";
            albaran.Message.DTM[1].FechaHora = "201311201121";
            //albaran.Message.DTM[0].FormatoFecha = "203";

            albaran.Message.DTM[2].FechaFaseEnvio = "191";
            albaran.Message.DTM[2].FechaHora = "201311220000";
            //albaran.Message.DTM[0].FormatoFecha = "203";

            //MEA
            //albaran.Message.MEA[0].CodigoMedida = "AAX";
            albaran.Message.MEA[0].PropiedadMedida = "AAD";
            albaran.Message.MEA[0].UnidadMedida = "KGM";
            albaran.Message.MEA[0].ValorMedida = "1845";

            //albaran.Message.MEA[1].CodigoMedida = "AAX";
            albaran.Message.MEA[1].PropiedadMedida = "SQ";
            albaran.Message.MEA[1].UnidadMedida = "NMP";
            albaran.Message.MEA[1].ValorMedida = "144";

            // NAD
            albaran.Message.NAD_Group2[0].ParteInvolucradaEnvio = "FW";
            albaran.Message.NAD_Group2[0].CodigoParte = "0000011531";
            albaran.Message.NAD_Group2[0].AgenciaResponsableCodigos = "92";

            albaran.Message.NAD_Group2[1].ParteInvolucradaEnvio = "CN";
            albaran.Message.NAD_Group2[1].CodigoParte = "MBG";
            albaran.Message.NAD_Group2[1].AgenciaResponsableCodigos = "92";

            albaran.Message.NAD_Group2[2].ParteInvolucradaEnvio = "CZ";
            albaran.Message.NAD_Group2[2].CodigoParte = "51731P";
            albaran.Message.NAD_Group2[2].AgenciaResponsableCodigos = "92";

            //albaran.Message.TDT.CodigoTipoTransporte = "12";
            //albaran.Message.TDT.MetodoTransporte = "30";
            //albaran.Message.TDT.VehiculoTransporte = "31";
            albaran.Message.TDT.CodigoTransportista = "0000011531";
            albaran.Message.TDT.CodigoResponsable = "92";
            albaran.Message.TDT.Matricula = "1111BBB";
            //albaran.Message.TDT.TipoIdMedioTransporte = "146";
            //albaran.Message.TDT.ResponsableCodigo = "5";
            albaran.Message.TDT.CodigoTitularidadTransporte = "1";

            //Palet 1
            // CPS
            albaran.Message.CPS_Group10[0].PaqueteId = "1";
            albaran.Message.CPS_Group10[0].NivelEmpaquetamiento = "3";

            // PAC
            albaran.Message.CPS_Group10[0].PAC_Group11[0].NumeroPaquetes = "1";
            albaran.Message.CPS_Group10[0].PAC_Group11[0].TipoEmbalajeId = "CIPALLETP";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";            

            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "M";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].IdPaquete = "53946644";

            //Cajas del palet 1
            // CPS
            albaran.Message.CPS_Group10[1].PaqueteId = "2";
            albaran.Message.CPS_Group10[1].CodigoPadre = "1";
            albaran.Message.CPS_Group10[1].NivelEmpaquetamiento = "1";

            // PAC
            albaran.Message.CPS_Group10[1].PAC_Group11[0].NumeroPaquetes = "48";
            albaran.Message.CPS_Group10[1].PAC_Group11[0].TipoEmbalajeId = "CICARTON";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";

            // QTY
            albaran.Message.CPS_Group10[1].PAC_Group11[0].QTY.TipoCantidad = "52";
            albaran.Message.CPS_Group10[1].PAC_Group11[0].QTY.Cantidad = "140";
            albaran.Message.CPS_Group10[1].PAC_Group11[0].QTY.UnidadMedidaCantidad = "PCE";

            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "S";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            int idPaquete = 53946596;
            for (var i=0;i<48;i++) 
            {
                albaran.Message.CPS_Group10[1].PAC_Group11[0].PCI_Group13[0].GIN[i].IdPaquete = idPaquete.ToString();
                idPaquete++;
            }            

            // LIN
            albaran.Message.CPS_Group10[1].LIN_Group16[0].NumeroLinea = "2";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].IdProducto = "VA255K0M00";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].TipoIdProducto = "IN";

            //PIA
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.FuncionIdPaquete = "1";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].PIA.NumeroIdPaquete = "1605000476";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroPaquete "ON";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].PIA.IdLote = "103881301";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroLote = "BB";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].PIA.CodigoArticuloProveedor = "184852";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroProveedor = "SA";

            //QTY
            albaran.Message.CPS_Group10[1].LIN_Group16[0].QTY[0].TipoCantidad = "1";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].QTY[0].Cantidad = "6720";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].QTY[0].UnidadMedidaCantidad = "PCE";

            // ALI
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].ALI[0].PaisOrigen = "ES";


            // RFF
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].RFF_Group17[0].TipoReferencia = "AAU";
            albaran.Message.CPS_Group10[1].LIN_Group16[0].RFF_Group17[0].NumeroReferencia = "1605000476";

            //Palet 2
            // CPS
            albaran.Message.CPS_Group10[2].PaqueteId = "3";
            albaran.Message.CPS_Group10[2].NivelEmpaquetamiento = "3";

            // PAC
            albaran.Message.CPS_Group10[2].PAC_Group11[0].NumeroPaquetes = "1";
            albaran.Message.CPS_Group10[2].PAC_Group11[0].TipoEmbalajeId = "CIPALLETP";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";
            
            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "M";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            albaran.Message.CPS_Group10[2].PAC_Group11[0].PCI_Group13[0].GIN[0].IdPaquete = "53949729";
            
            //Cajas del palet 2
            // CPS
            albaran.Message.CPS_Group10[3].PaqueteId = "4";
            albaran.Message.CPS_Group10[3].CodigoPadre = "3";
            albaran.Message.CPS_Group10[3].NivelEmpaquetamiento = "1";

            // PAC
            albaran.Message.CPS_Group10[3].PAC_Group11[0].NumeroPaquetes = "48";
            albaran.Message.CPS_Group10[3].PAC_Group11[0].TipoEmbalajeId = "CICARTON";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";

            // QTY
            albaran.Message.CPS_Group10[3].PAC_Group11[0].QTY.TipoCantidad = "52";
            albaran.Message.CPS_Group10[3].PAC_Group11[0].QTY.Cantidad = "140";
            albaran.Message.CPS_Group10[3].PAC_Group11[0].QTY.UnidadMedidaCantidad = "PCE";

            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "S";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            idPaquete = 53949681;
            for (var i = 0; i < 48; i++) {
                albaran.Message.CPS_Group10[3].PAC_Group11[0].PCI_Group13[0].GIN[i].IdPaquete = idPaquete.ToString();
                idPaquete++;
            }

            // LIN
            albaran.Message.CPS_Group10[3].LIN_Group16[0].NumeroLinea = "4";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].IdProducto = "VA255K0M00";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].TipoIdProducto = "IN";

            //PIA
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.FuncionIdPaquete = "1";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].PIA.NumeroIdPaquete = "1605000476";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroPaquete "ON";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].PIA.IdLote = "103881303";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroLote = "BB";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].PIA.CodigoArticuloProveedor = "184852";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroProveedor = "SA";

            //QTY
            albaran.Message.CPS_Group10[3].LIN_Group16[0].QTY[0].TipoCantidad = "1";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].QTY[0].Cantidad = "6720";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].QTY[0].UnidadMedidaCantidad = "PCE";

            // ALI
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].ALI[0].PaisOrigen = "ES";
            
            // RFF
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].RFF_Group17[0].TipoReferencia = "AAU";
            albaran.Message.CPS_Group10[3].LIN_Group16[0].RFF_Group17[0].NumeroReferencia = "1605000476";


            //Palet 3
            // CPS
            albaran.Message.CPS_Group10[4].PaqueteId = "5";
            albaran.Message.CPS_Group10[4].NivelEmpaquetamiento = "3";

            // PAC
            albaran.Message.CPS_Group10[4].PAC_Group11[0].NumeroPaquetes = "1";
            albaran.Message.CPS_Group10[4].PAC_Group11[0].TipoEmbalajeId = "CIPALLETP";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";

            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "M";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            albaran.Message.CPS_Group10[4].PAC_Group11[0].PCI_Group13[0].GIN[0].IdPaquete = "53950781";

            //Cajas del palet 3
            // CPS
            albaran.Message.CPS_Group10[5].PaqueteId = "6";
            albaran.Message.CPS_Group10[5].CodigoPadre = "5";
            albaran.Message.CPS_Group10[5].NivelEmpaquetamiento = "1";

            // PAC
            albaran.Message.CPS_Group10[5].PAC_Group11[0].NumeroPaquetes = "48";
            albaran.Message.CPS_Group10[5].PAC_Group11[0].TipoEmbalajeId = "CICARTON";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PacCodigoResponsable = "92";

            // QTY
            albaran.Message.CPS_Group10[5].PAC_Group11[0].QTY.TipoCantidad = "52";
            albaran.Message.CPS_Group10[5].PAC_Group11[0].QTY.Cantidad = "140";
            albaran.Message.CPS_Group10[5].PAC_Group11[0].QTY.UnidadMedidaCantidad = "PCE";

            // PCI
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].TipoInstrucciones = "17";
            albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13[0].TipoMarcado = "S";
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].PCIResponsableCodigos = "10";

            //GIN
            //albaran.Message.CPS_Group10[0].PAC_Group11[0].PCI_Group13[0].GIN[0].TipoIdPaquete = "ML";
            idPaquete = 53950733;
            for (var i = 0; i < 48; i++) {
                albaran.Message.CPS_Group10[5].PAC_Group11[0].PCI_Group13[0].GIN[i].IdPaquete = idPaquete.ToString();
                idPaquete++;
            }

            // LIN
            albaran.Message.CPS_Group10[5].LIN_Group16[0].NumeroLinea = "6";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].IdProducto = "VA255K0M00";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].TipoIdProducto = "IN";

            //PIA
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.FuncionIdPaquete = "1";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].PIA.NumeroIdPaquete = "1605000476";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroPaquete "ON";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].PIA.IdLote = "103881304";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroLote = "BB";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].PIA.CodigoArticuloProveedor = "184852";
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].PIA.TipoNumeroProveedor = "SA";

            //QTY
            albaran.Message.CPS_Group10[5].LIN_Group16[0].QTY[0].TipoCantidad = "1";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].QTY[0].Cantidad = "6720";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].QTY[0].UnidadMedidaCantidad = "PCE";

            // ALI
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].ALI[0].PaisOrigen = "ES";

            // RFF
            //albaran.Message.CPS_Group10[0].LIN_Group16[0].RFF_Group17[0].TipoReferencia = "AAU";
            albaran.Message.CPS_Group10[5].LIN_Group16[0].RFF_Group17[0].NumeroReferencia = "1605000476";

            // UNT
            albaran.Message.NumeroSegmentos = "195";
            albaran.Message.ControlNumeroMensaje = "1";

            // UNZ
            albaran.CantidadMensajes = "1";
            albaran.ControlReferenciaTransmision = "004000924";

            return albaran;
        }
    }
}

