// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp
{
    using UnqualifiedDataTypes;
    using CommonAggregateComponents;
    using CommonExtensionComponents;
    
    
    /// <summary>
    /// A document sent from a transport service provider to a transportation network manager requesting a Transport Progress Status.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Transport Progress Status Request. Details
    /// <para />ObjectClass: Transport Progress Status Request
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("TransportProgressStatusRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportProgressStatusRequest-2")]
    [System.Xml.Serialization.XmlRootAttribute("TransportProgressStatusRequest", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportProgressStatusRequest-2", IsNullable=false)]
    public partial class TransportProgressStatusRequestType : BaseDocument
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CopyIndicator", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType @__CopyIndicator;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueDate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType @__IssueDate;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("IssueTime", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType @__IssueTime;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("TransportMeans", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransportMeansType @__TransportMeans;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("StatusLocation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<LocationType> @__StatusLocation;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTermQualifier: Copy
        /// <para />PropertyTerm: Indicator
        /// <para />RepresentationTerm: Indicator
        /// <para />DataType: Indicator. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public IndicatorType CopyIndicator
        {
            get
            {
                if (__CopyIndicator == null) { __CopyIndicator = new IndicatorType(); }
                return __CopyIndicator;
            }
            set
            {
                __CopyIndicator = value;
            }
        }

        /// <summary>
        /// The date, assigned by the sender, on which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DateType IssueDate
        {
            get
            {
                if (__IssueDate == null) { __IssueDate = new DateType(); }
                return __IssueDate;
            }
            set
            {
                __IssueDate = value;
            }
        }

        /// <summary>
        /// The time, assigned by the sender, at which this document was issued.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Issue Time. Time
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TimeType IssueTime
        {
            get
            {
                if (__IssueTime == null) { __IssueTime = new TimeType(); }
                return __IssueTime;
            }
            set
            {
                __IssueTime = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<TextType> Note
        {
            get
            {
                if (__Note == null) { __Note = new System.Collections.Generic.List<TextType>(); }
                return __Note;
            }
            set
            {
                __Note = value;
            }
        }

        /// <summary>
        /// The party sending the Transport Progress Status Request.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Sender_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTermQualifier: Sender
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SenderParty
        {
            get
            {
                if (__SenderParty == null) { __SenderParty = new PartyType(); }
                return __SenderParty;
            }
            set
            {
                __SenderParty = value;
            }
        }

        /// <summary>
        /// The party receiving the Transport Progress Status Request.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Receiver_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTermQualifier: Receiver
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType ReceiverParty
        {
            get
            {
                if (__ReceiverParty == null) { __ReceiverParty = new PartyType(); }
                return __ReceiverParty;
            }
            set
            {
                __ReceiverParty = value;
            }
        }

        /// <summary>
        /// The transport means by which the current transport service is effectuated and for which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Transport Means
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTerm: Transport Means
        /// <para />AssociatedObjectClass: Transport Means
        /// <para />RepresentationTerm: Transport Means
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TransportMeansType TransportMeans
        {
            get
            {
                if (__TransportMeans == null) { __TransportMeans = new TransportMeansType(); }
                return __TransportMeans;
            }
            set
            {
                __TransportMeans = value;
            }
        }

        /// <summary>
        /// A location for which status is requested.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Transport Progress Status Request. Status_ Location. Location
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Transport Progress Status Request
        /// <para />PropertyTermQualifier: Status
        /// <para />PropertyTerm: Location
        /// <para />AssociatedObjectClass: Location
        /// <para />RepresentationTerm: Location
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<LocationType> StatusLocation
        {
            get
            {
                if (__StatusLocation == null) { __StatusLocation = new System.Collections.Generic.List<LocationType>(); }
                return __StatusLocation;
            }
            set
            {
                __StatusLocation = value;
            }
        }

    }
}