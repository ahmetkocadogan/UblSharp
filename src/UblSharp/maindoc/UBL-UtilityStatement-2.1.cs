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
    /// A supplement to an Invoice or Credit Note, containing information on the consumption of services provided by utility suppliers to private and public customers, including electricity, gas, water, and telephone services.
    /// <para />ComponentType: ABIE
    /// <para />DictionaryEntryName: Utility Statement. Details
    /// <para />ObjectClass: Utility Statement
    /// </summary>
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("UtilityStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UtilityStatement-2")]
    [System.Xml.Serialization.XmlRootAttribute("UtilityStatement", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:UtilityStatement-2", IsNullable=false)]
    public partial class UtilityStatementType : BaseDocument
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
        [System.Xml.Serialization.XmlElementAttribute("UtilityStatementTypeCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType @__UtilityStatementTypeCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public System.Collections.Generic.List<TextType> @__Note;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DocumentCurrencyCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType @__DocumentCurrencyCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountingCostCode", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType @__AccountingCostCode;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AccountingCost", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType @__AccountingCost;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ParentDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType @__ParentDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<DocumentReferenceType> @__AdditionalDocumentReference;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SenderParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__SenderParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("ReceiverParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__ReceiverParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType @__CustomerParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriberParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType @__SubscriberParty;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("MainOnAccountPayment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<OnAccountPaymentType> @__MainOnAccountPayment;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("SubscriberConsumption", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public System.Collections.Generic.List<SubscriberConsumptionType> @__SubscriberConsumption;
        
        /// <summary>
        /// Indicates whether this document is a copy (true) or not (false).
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Copy_ Indicator. Indicator
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
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
        /// <para />DictionaryEntryName: Utility Statement. Issue Date. Date
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Issue Date
        /// <para />RepresentationTerm: Date
        /// <para />DataType: Date. Type
        /// </summary>
        /// <example>2007-12-12</example>
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
        /// <para />DictionaryEntryName: Utility Statement. Issue Time. Time
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Issue Time
        /// <para />RepresentationTerm: Time
        /// <para />DataType: Time. Type
        /// </summary>
        /// <example>12:32:56</example>
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
        /// A code signifying the type of Utility Statement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Utility Statement Type Code. Code
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Utility Statement Type Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        /// <example>Electricity</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType UtilityStatementTypeCode
        {
            get
            {
                if (__UtilityStatementTypeCode == null) { __UtilityStatementTypeCode = new CodeType(); }
                return __UtilityStatementTypeCode;
            }
            set
            {
                __UtilityStatementTypeCode = value;
            }
        }

        /// <summary>
        /// Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Note. Text
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Note
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        /// <example>Concerning account remark</example>
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
        /// A code signifying the default currency for this document.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Document_ Currency Code. Code
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Document
        /// <para />PropertyTerm: Currency Code
        /// <para />RepresentationTerm: Code
        /// <para />DataTypeQualifier: Currency
        /// <para />DataType: Currency_ Code. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType DocumentCurrencyCode
        {
            get
            {
                if (__DocumentCurrencyCode == null) { __DocumentCurrencyCode = new CodeType(); }
                return __DocumentCurrencyCode;
            }
            set
            {
                __DocumentCurrencyCode = value;
            }
        }

        /// <summary>
        /// The buyer&apos;s accounting cost code, applied to the UtilityStatement.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Accounting Cost Code. Code
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Accounting Cost Code
        /// <para />RepresentationTerm: Code
        /// <para />DataType: Code. Type
        /// </summary>
        /// <example>5050.0</example>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CodeType AccountingCostCode
        {
            get
            {
                if (__AccountingCostCode == null) { __AccountingCostCode = new CodeType(); }
                return __AccountingCostCode;
            }
            set
            {
                __AccountingCostCode = value;
            }
        }

        /// <summary>
        /// The buyer&apos;s accounting cost code, applied to the UtilityStatement, expressed as text.
        /// <para />ComponentType: BBIE
        /// <para />DictionaryEntryName: Utility Statement. Accounting Cost. Text
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Accounting Cost
        /// <para />RepresentationTerm: Text
        /// <para />DataType: Text. Type
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TextType AccountingCost
        {
            get
            {
                if (__AccountingCost == null) { __AccountingCost = new TextType(); }
                return __AccountingCost;
            }
            set
            {
                __AccountingCost = value;
            }
        }

        /// <summary>
        /// A reference to the parent Invoice or Credit Note.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Parent_ Document Reference. Document Reference
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Parent
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DocumentReferenceType ParentDocumentReference
        {
            get
            {
                if (__ParentDocumentReference == null) { __ParentDocumentReference = new DocumentReferenceType(); }
                return __ParentDocumentReference;
            }
            set
            {
                __ParentDocumentReference = value;
            }
        }

        /// <summary>
        /// A reference to an additional document associated with this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Additional_ Document Reference. Document Reference
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Additional
        /// <para />PropertyTerm: Document Reference
        /// <para />AssociatedObjectClass: Document Reference
        /// <para />RepresentationTerm: Document Reference
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<DocumentReferenceType> AdditionalDocumentReference
        {
            get
            {
                if (__AdditionalDocumentReference == null) { __AdditionalDocumentReference = new System.Collections.Generic.List<DocumentReferenceType>(); }
                return __AdditionalDocumentReference;
            }
            set
            {
                __AdditionalDocumentReference = value;
            }
        }

        /// <summary>
        /// The party sending this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Sender_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
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
        /// The party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Receiver_ Party. Party
        /// <para />Cardinality: 1
        /// <para />ObjectClass: Utility Statement
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
        /// The buyer, if different from the receiver of the document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Customer Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Customer Party
        /// <para />AssociatedObjectClass: Customer Party
        /// <para />RepresentationTerm: Customer Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CustomerPartyType CustomerParty
        {
            get
            {
                if (__CustomerParty == null) { __CustomerParty = new CustomerPartyType(); }
                return __CustomerParty;
            }
            set
            {
                __CustomerParty = value;
            }
        }

        /// <summary>
        /// The subscriber (user or receiver of the service), if different from the buyer and from the party receiving this document.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Subscriber_ Party. Party
        /// <para />Cardinality: 0..1
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Subscriber
        /// <para />PropertyTerm: Party
        /// <para />AssociatedObjectClass: Party
        /// <para />RepresentationTerm: Party
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public PartyType SubscriberParty
        {
            get
            {
                if (__SubscriberParty == null) { __SubscriberParty = new PartyType(); }
                return __SubscriberParty;
            }
            set
            {
                __SubscriberParty = value;
            }
        }

        /// <summary>
        /// A payment on an account.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Main_ On Account Payment. On Account Payment
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTermQualifier: Main
        /// <para />PropertyTerm: On Account Payment
        /// <para />AssociatedObjectClass: On Account Payment
        /// <para />RepresentationTerm: On Account Payment
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<OnAccountPaymentType> MainOnAccountPayment
        {
            get
            {
                if (__MainOnAccountPayment == null) { __MainOnAccountPayment = new System.Collections.Generic.List<OnAccountPaymentType>(); }
                return __MainOnAccountPayment;
            }
            set
            {
                __MainOnAccountPayment = value;
            }
        }

        /// <summary>
        /// A utility statement for a particular consumption point.
        /// <para />ComponentType: ASBIE
        /// <para />DictionaryEntryName: Utility Statement. Subscriber Consumption
        /// <para />Cardinality: 0..n
        /// <para />ObjectClass: Utility Statement
        /// <para />PropertyTerm: Subscriber Consumption
        /// <para />AssociatedObjectClass: Subscriber Consumption
        /// <para />RepresentationTerm: Subscriber Consumption
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<SubscriberConsumptionType> SubscriberConsumption
        {
            get
            {
                if (__SubscriberConsumption == null) { __SubscriberConsumption = new System.Collections.Generic.List<SubscriberConsumptionType>(); }
                return __SubscriberConsumption;
            }
            set
            {
                __SubscriberConsumption = value;
            }
        }

    }
}