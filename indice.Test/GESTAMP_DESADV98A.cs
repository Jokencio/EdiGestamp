using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using indice.Edi.Serialization;


namespace indice.Test
{
    class GA_DESADV
    {
        #region Interchange Header

        // UNB --> To start, identify and specify an interchange.

        /// <summary>
        /// Syntax Identifier: Coded identification of the agency controlling a syntax and syntax level used in an interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/0")] // Equivalente a UNB/0/0
        public string Header_SyntaxId { get; set; }

                
        /// <summary>
        /// Syntax Version Number: Version number of the syntax identified in the syntax identifier (0001).
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/0/1")]
        public string Header_SyntaxVersion { get; set; }


        /// <summary>
        /// Sender Identification: Name or coded representation of the sender of a data interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/1/0")]
        public string Header_SenderId { get; set; }


        /// <summary>
        /// Partner Identification Code Qualifier: Qualifier referring to the source of codes for the identifiers of interchanging partners.
        /// Usage: Conditional
        /// </summary>
        [EdiValue(Path = "UNB/1/1")]
        public string Header_PartnerId { get; set; }


        /// <summary>
        /// Recipient Identification: Name or coded representation of the recipient of a data interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/2")]
        public string Header_RecId { get; set; }


        /// <summary>
        /// Date: Local date when an interchange or a functional group was prepared.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/3/0")]
        public string Header_Date { get; set; }


        /// <summary>
        /// Time: Local time of day when an interchange or a functional group was prepared.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/3/1")]
        public string Header_Time { get; set; }


        /// <summary>
        /// Interchange Control Reference: Unique reference assigned by the sender to an interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNB/4/0")]
        public string Header_CtrlRef { get; set; }


        /// <summary>
        /// Application Reference: Identification of the application area assigned by the sender, to which the messages in the interchange relate
        /// e.g. the message identifier if all the messages in the interchange are of the same type.
        /// Usage: Conditional
        /// </summary>
        [EdiValue(Path = "UNB/5")]
        public string Header_AppRef { get; set; }


        /// <summary>
        /// Processing Prior Code: Code determined by the sender requesting processing priority for the interchange.
        /// Usage: Conditional
        /// </summary>
        [EdiValue(Path = "UNB/6")]
        public string Header_PriorCode { get; set; }


        /// <summary>
        /// Acknowledgement Request: Code determined by the sender for acknowledgement of the interchange.
        /// Usage: Conditional
        /// </summary>
        [EdiValue(Path = "UNB/7")]
        public string Header_AckReq { get; set; }

        #endregion Interchange Header


        public Message_D96A Message { get; set; }



        #region Interchange Trailer

        // UNZ --> To end and check the completeness of an interchange.

        /// <summary>
        /// Interchange Control Count: Count either of the number of messages or, if used, of the number of functional groups in an interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNZ/0")]
        public string Trailer_ControlCount { get; set; }


        /// <summary>
        /// Interchange Control Reference: Unique reference assigned by the sender to an interchange.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNZ/1")]
        public string Trailer_ControlRef { get; set; }

        #endregion Interchange Trailer

    }

    [EdiMessage]
    public class Message_D96A
    {
        #region Message Header Info

        // UNH --> A service segment starting and uniquely identifying a message. The message type code for the Despatch advice message is DESADV.

        /// <summary>
        /// Message Reference Number: Unique message reference assigned by the sender.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNH/0")] //this is equivalent [EdiValue(Path = "UNH/0/0")]
        public string RefNumber { get; set; }


        /// <summary>
        /// Message Type Identifier: Code identifying a type of message and assigned by its controlling agency.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNH/1/0")]
        public string TypeId { get; set; }


        /// <summary>
        /// Message Type Version Number: Version number of a message type.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNH/1/1")]
        public string TypeVer { get; set; }


        /// <summary>
        /// Message Type Release Number: Release number within the current message type version number.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNH/1/2")]
        public string TypeRel { get; set; }


        /// <summary>
        /// Controlling Agency: Code identifying the agency controlling the specification, maintenance and publication of the message type.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNH/1/3")]
        public string ControlAg { get; set; }


        /// <summary>
        /// Association Assigned Code: Code, assigned by the association responsible for the design and maintenance of the message type concerned,
        /// which further identifies the message.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "UNH/1/4")]
        public string AssoCode { get; set; }

        #endregion Message Header Info


        public GA_BGM BGM { get; set; }
        public GA_DTM DTM { get; set; }
        public GA_MEA MEA { get; set; }


        public GA_NAD_Group2[] NAD_Group2 { get; set; }
        public GA_CPS_Group10[] CPS_Group10 { get; set; }


        #region Message Trailer Info

        // UNT --> A service segment ending a message, giving the total number of segments in the message and the control reference number of the message.

        /// <summary>
        /// Number Of Segments In A Message: Control count of number of segments in a message.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNT/0/0")]
        public string NumSegments { get; set; }


        /// <summary>
        /// Message Reference Number: Unique message reference assigned by the sender.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "UNT/0/1")]
        public string RefNum { get; set; }
        #endregion
    }

    #region EdiSegmentGroups

    [EdiSegmentGroup("NAD", SequenceEnd = "CPS")]
    public class GA_NAD_Group2
    {

        // NAD --> A segment for identifying names, addresses, and their functions relevant to the whole Despatch Advice. Identification of the parties involved
        // is recommended for the Despatch Advice message, and is to be given in the NAD segment. It is recommended that where possible, only the coded
        // form of the party ID should be specified, e.g. the buyer and seller are known to each other, thus only the coded ID is required. The consignee or
        // delivery address may vary and would have to be clearly specified, preferably in structured format.

        /// <summary>
        /// Party Qualifier: Code giving specific meaning to a party.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "NAD/0")]
        public string PartyQual { get; set; }


        /// <summary>
        /// Party Identification: Code identifying a party involved in a transaction.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "NAD/1/0")]
        public string PartyId { get; set; }


        /// <summary>
        /// Code List Qualifier: Identification of a code list.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "NAD/1/1")]
        public string ListQual { get; set; }


        /// <summary>
        /// Code List Reponsible Agency Coded: Code identifying the agency responsible for a code list. 
        /// </summary>
        [EdiValue(Path = "NAD/1/2")]
        public string ResAg { get; set; }

        public GA_LOC[] LOC { get; set; }

        public GA_RFF[] RFF { get; set; }        

    }
    

    [EdiSegmentGroup("CPS", SequenceEnd = "UNT")]
    public class GA_CPS_Group10
    {

        // CPS --> A segment identifying the sequence in which packing of the consignment occurs, e.g. boxes loaded onto a pallet.

        /// <summary>
        /// Hierarchical ID. Number: A unique number assigned by the sender to identify a level within a hierarchical structure.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "CPS/0")]
        public string HierId { get; set; }


        /// <summary>
        /// Hierarchical Parent ID: Identification number of the next higher hierarchical data segment in a hierarchical structure.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "CPS/1")]
        public string HierParent { get; set; }


        /// <summary>
        /// Packaging Level, Coded: Indication of level of packaging specified.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "CPS/2")]
        public string PackLevel { get; set; }

        public GA_PAC_Group11[] PAC_Group11 { get; set; }
        public GA_LIN_Group15[] LIN_Group15 { get; set; }
    }

    [EdiSegmentGroup("PAC", SequenceEnd = "LIN")]
    public class GA_PAC_Group11
    {

        // PAC --> A segment specifying the number and type of the packages/physical units and the physical type of packaging for the despatched goods.

        /// <summary>
        /// Number Of Packages: Number of individual parts of a shipment either unpacked, or packed in such a way that they cannot be divided without first
        /// undoing the packing.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "PAC/0")]
        public string NumPack { get; set; }


        /// <summary>
        /// Packaging Level, Coded: Indication of level of packaging specified.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "PAC/1/0")]
        public string PackLevel { get; set; }


        /// <summary>
        /// Packaging Related Information, Coded: Code giving packaging, handling and marking related information.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "PAC/1/1")]
        public string PackRel { get; set; }


        /// <summary>
        /// Packaging Terms and Conditions, Coded: Code identifying packaging terms and conditions.
        /// </summary>
        [EdiValue(Path = "PAC/1/2")]
        public string PackTerms { get; set; }


        /// <summary>
        /// Type of Packages Identification: Coded description of the form in which goods are presented.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "PAC/2/0")]
        public string TypePackId { get; set; }

        /// <summary>
        /// Code List Qualifier: Identification of a code list.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "PAC/2/1")]
        public string ListQual { get; set; }


        /// <summary>
        /// Code List Responsible Agency, Coded: Code identifying the agency responsible for a code list.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "PAC/2/2")]
        public string ListResp { get; set; }


        /// <summary>
        /// Type of Packages: Description of the form in which goods are presented.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "PAC/2/3")]
        public string TypePack { get; set; }

        public GA_QTY[] QTY { get; set; }

        public GA_PAC_Group13[] PAC_Group13 { get; set; }
    }

    [EdiSegmentGroup("PCI", SequenceEnd = "RFF")]
    public class GA_PAC_Group13
    {

        // PCI --> A segment specifying markings and/or labels used on individual physical units (packages) described in the PAC segment.

        /// <summary>
        /// Marking instructions, coded: Code indicating instructions on how specified packages or physical units should be marked.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "PCI/0")]
        public string MarkInst { get; set; }

        public GA_RFF[] RFF2 { get; set; }
    }

    [EdiSegmentGroup("LIN", SequenceEnd = "UNT")]
    public class GA_LIN_Group15
    {

        // LIN --> A segment identifying the product being despatched. All other segments in the detail section following the LIN segment refer to that line item.

        /// <summary>
        /// Line Item Number: Serial number designating each separate item within a series of articles.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "LIN/0")]
        public string LineItem { get; set; }


        /// <summary>
        /// Action Request/Notification, Coded: Code specifying the action to be taken or already taken.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "LIN/1")]
        public string Action { get; set; }


        /// <summary>
        /// Item Number: A number allocated to a group or item.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "LIN/2/0")]
        public string ItemNum { get; set; }


        /// <summary>
        /// Item Number Type, Coded: Identification of the type of item number.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "LIN/2/1")]
        public string ItemNumType { get; set; }


        /// <summary>
        /// Sub-Line Indicator, Coded: Indication that the segment and/or segment group is used for sub-line item information.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "LIN/3/0")]
        public string SubLineInd { get; set; }


        /// <summary>
        /// Line Item Number: Serial number designating each separate item within a series of articles.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "LIN/3/1")]
        public string LineItemNum { get; set; }


        /// <summary>
        /// Configuration Level: Number indicating the level of an object which is in a hierarchy.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "LIN/4")]
        public string ConfigLevel { get; set; }

        public GA_QTY[] QTY2 { get; set; }

        public GA_ALI[] ALI { get; set; }

        public GA_RFF[] RFF3 { get; set; }

    }
    #endregion

    #region Segments

    [EdiSegment, EdiPath("BGM")]
    public class GA_BGM
    {

        // BGM --> A segment for unique identification of the Despatch Advice document, by means of its name and its number.

        /// <summary>
        /// Document/Message Name, Coded: Document/message identifier expressed in code.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "BGM/0/0")]
        public string MsgName { get; set; }


        /// <summary>
        /// Code List Qualifier: Identification of a code list.
        /// Usage: Optional
        /// </summary>
        [EdiValue(Path = "BGM/0/1")]
        public string CodeListQua { get; set; }


        /// <summary>
        /// Code List Responsible Agency, Coded: Code identifying the agency responsible for a code list.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "BGM/0/2")]
        public string RespAgency { get; set; }


        /// <summary>
        /// Document/Message Number: Reference number assigned to the document/message by the issuer.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "BGM/1")]
        public string MsgNumber { get; set; }

    }

    [EdiSegment, EdiPath("DTM")]
    public class GA_DTM
    {

        // DTM --> Date/time/period related to the whole message. The DTM segment must be specified at least once to identify the Despatch Advice date.

        /// <summary>
        /// Date/Time/Period Qualifier: Code giving specific meaning to a date, time or period.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "DTM/0/0")]
        public string DateQual { get; set; }


        /// <summary>
        /// Date/Time/Period: The value of a date, a date and time, a time or of a period in a specified representation.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "DTM/0/1")]
        public string Date { get; set; }


        /// <summary>
        /// Date/Time/Period Format Qualifier: Specification of the representation of a date, a date and time or of a period.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "DTM/0/2")]
        public string DateFormat { get; set; }

        public override string ToString() {
            var year = Date.Substring(0, 4);
            var month = Date.Substring(4, 2);
            var day = Date.Substring(6, 2);

            var dt = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));

            return dt.ToString("d");
        }
    }

       
    [EdiSegment, EdiPath("MEA")]
    public class GA_MEA
    {

        // MEA --> A segment specifying the weight and volume of the consignment.

        /// <summary>
        /// Measurement Application Qualifier: Specification of the application of the physical measurement used.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "MEA/0")]
        public string MeaQual { get; set; }


        /// <summary>
        /// Measurement Dimension Code: Specification of the type of dimension to be measured.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "MEA/1")]
        public string MeaCode { get; set; }

    }

    [EdiSegment, EdiPath("LOC")]
    public class GA_LOC
    {

        // LOC --> A segment indicating more details regarding specific places/locations related to the party specified in the NAD segment,
        // e.g. internal site/building number.

        /// <summary>
        /// Place/Location Qualifier: Code identifying the function of a location.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "LOC/0")]
        public string LocQua { get; set; }


        /// <summary>
        /// Place/Location Identification: Identification of the name of place/location, other than 3164 City name.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "LOC/1")]
        public string LocId { get; set; }

    }

    [EdiSegment, EdiPath("RFF")]
    public class GA_RFF
    {

        // RFF --> To specify a reference.

        /// <summary>
        /// Reference Qualifier: Code giving specific meaning to a reference segment or a reference number.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "RFF/0/0")]
        public string RefQua { get; set; }


        /// <summary>
        /// Reference Number: Identification number the nature and function of which can be qualified by an entry in data element 1153 Reference qualifier.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "RFF/0/1")]
        public string RefNum { get; set; }

    }

    [EdiSegment, EdiPath("QTY")]
    public class GA_QTY
    {

        // QTY --> To specify a pertinent quantity.

        /// <summary>
        /// Quantity Qualifier: Code giving specific meaning to a quantity.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "QTY/0/0")]
        public string QttyQua { get; set; }


        /// <summary>
        /// Quantity: Numeric value of a quantity.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "QTY/0/1")]
        public string Qtty { get; set; }


        /// <summary>
        /// Measure Unit Qualifier: Indication of the unit of measurement in which weight (mass), capacity, length, area, volume or other quantity is expressed.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "QTY/0/2")]
        public string QttyMea { get; set; }

    }

    [EdiSegment, EdiPath("ALI")]
    public class GA_ALI
    {

        // ALI --> A segment indicating that the line item is subject to special conditions due to origin, customs preference, or commercial factors.

        /// <summary>
        /// Country Of Origin, Coded: Country in which the goods have been produced or manufactured, according to criteria laid down for the purposes
        /// of application of the Customs tariff, of quantitative restrictions, or of any other measure related to trade.
        /// Usage: Mandatory
        /// </summary>
        [EdiValue(Path = "ALI/0")]
        public string CodOrigin { get; set; }

    }
    #endregion
}
