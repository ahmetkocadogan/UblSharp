// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Manual changes to this file will be overwritten if the code is regenerated.
//
// </auto-generated>
//------------------------------------------------------------------------------
namespace UblSharp.Xades
{
    using XmlDigitalSignature;
    
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ReferenceInfoType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class ReferenceInfoType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DigestMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public DigestMethodType @__DigestMethod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("DigestValue", Namespace = "http://www.w3.org/2000/09/xmldsig#", DataType="base64Binary")]
        public byte[] @__DigestValue;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
        public string @__URI;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public DigestMethodType DigestMethod
        {
            get
            {
                if (__DigestMethod == null) { __DigestMethod = new DigestMethodType(); }
                return __DigestMethod;
            }
            set
            {
                __DigestMethod = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public byte[] DigestValue
        {
            get
            {
                return __DigestValue;
            }
            set
            {
                __DigestValue = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string URI
        {
            get
            {
                return __URI;
            }
            set
            {
                __URI = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("IncludeType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class IncludeType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("URI", DataType="anyURI")]
        public string @__URI;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("referencedData")]
        public bool @__referencedData;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool @__referencedDataSpecified;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string URI
        {
            get
            {
                return __URI;
            }
            set
            {
                __URI = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool referencedData
        {
            get
            {
                return __referencedData;
            }
            set
            {
                __referencedData = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool referencedDataSpecified
        {
            get
            {
                return __referencedDataSpecified;
            }
            set
            {
                __referencedDataSpecified = value;
            }
        }

    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OtherTimeStampType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(XAdESTimeStampType))]
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("GenericTimeStampType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public abstract partial class GenericTimeStampType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("Include", typeof(IncludeType))]
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo", typeof(ReferenceInfoType))]
        public System.Collections.Generic.List<object> @__Items;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("CanonicalizationMethod", Namespace = "http://www.w3.org/2000/09/xmldsig#")]
        public CanonicalizationMethodType @__CanonicalizationMethod;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(AnyType))]
        public System.Collections.Generic.List<object> @__Items1;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<object> Items
        {
            get
            {
                if (__Items == null) { __Items = new System.Collections.Generic.List<object>(); }
                return __Items;
            }
            set
            {
                __Items = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                if (__CanonicalizationMethod == null) { __CanonicalizationMethod = new CanonicalizationMethodType(); }
                return __CanonicalizationMethod;
            }
            set
            {
                __CanonicalizationMethod = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<object> Items1
        {
            get
            {
                if (__Items1 == null) { __Items1 = new System.Collections.Generic.List<object>(); }
                return __Items1;
            }
            set
            {
                __Items1 = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("EncapsulatedPKIDataType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class EncapsulatedPKIDataType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Encoding", DataType="anyURI")]
        public string @__Encoding;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlTextAttribute(DataType="base64Binary")]
        public byte[] @__Value;
        
        public static implicit operator EncapsulatedPKIDataType(byte[] value)
        {
             return new EncapsulatedPKIDataType { Value = value };
        }

        public static implicit operator byte[](EncapsulatedPKIDataType value)
        {
             return value.Value;
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Encoding
        {
            get
            {
                return __Encoding;
            }
            set
            {
                __Encoding = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public byte[] Value
        {
            get
            {
                return __Value;
            }
            set
            {
                __Value = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("AnyType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class AnyType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlNode> @__Any;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XNode> @__Any;
#else
        public System.Collections.Generic.List<object> @__Any;
#endif
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlAttribute> @__AnyAttr;
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XAttribute> @__AnyAttr;
#else
        public System.Collections.Generic.List<object> @__AnyAttr;
#endif
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlNode> Any
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XNode> Any
#else
        public System.Collections.Generic.List<object> Any
#endif
        {
            get
            {
#if FEATURE_XMLDOCUMENT
                if (__Any == null) { __Any = new System.Collections.Generic.List<System.Xml.XmlNode>(); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                if (__Any == null) { __Any = new System.Collections.Generic.List<System.Xml.Linq.XNode>(); }
#else
                if (__Any == null) { __Any = new System.Collections.Generic.List<object>(); }
#endif
                return __Any;
            }
            set
            {
                __Any = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
#if FEATURE_XMLDOCUMENT
        public System.Collections.Generic.List<System.Xml.XmlAttribute> AnyAttr
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
        public System.Collections.Generic.List<System.Xml.Linq.XAttribute> AnyAttr
#else
        public System.Collections.Generic.List<object> AnyAttr
#endif
        {
            get
            {
#if FEATURE_XMLDOCUMENT
                if (__AnyAttr == null) { __AnyAttr = new System.Collections.Generic.List<System.Xml.XmlAttribute>(); }
#elif !FEATURE_XMLDOCUMENT && FEATURE_LINQ
                if (__AnyAttr == null) { __AnyAttr = new System.Collections.Generic.List<System.Xml.Linq.XAttribute>(); }
#else
                if (__AnyAttr == null) { __AnyAttr = new System.Collections.Generic.List<object>(); }
#endif
                return __AnyAttr;
            }
            set
            {
                __AnyAttr = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("OtherTimeStampType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class OtherTimeStampType : GenericTimeStampType
    {
    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("RevocationValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class RevocationValuesType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable=false)]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> @__CRLValues;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable=false)]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> @__OCSPValues;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable=false)]
        public System.Collections.Generic.List<AnyType> @__OtherValues;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> CRLValues
        {
            get
            {
                if (__CRLValues == null) { __CRLValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>(); }
                return __CRLValues;
            }
            set
            {
                __CRLValues = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<EncapsulatedPKIDataType> OCSPValues
        {
            get
            {
                if (__OCSPValues == null) { __OCSPValues = new System.Collections.Generic.List<EncapsulatedPKIDataType>(); }
                return __OCSPValues;
            }
            set
            {
                __OCSPValues = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<AnyType> OtherValues
        {
            get
            {
                if (__OtherValues == null) { __OtherValues = new System.Collections.Generic.List<AnyType>(); }
                return __OtherValues;
            }
            set
            {
                __OtherValues = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("CertificateValuesType", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    public partial class CertificateValuesType
    {
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedPKIDataType))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(AnyType))]
        public System.Collections.Generic.List<object> @__Items;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Xml.Serialization.XmlAttributeAttribute("Id", DataType="ID")]
        public string @__Id;
        
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Generic.List<object> Items
        {
            get
            {
                if (__Items == null) { __Items = new System.Collections.Generic.List<object>(); }
                return __Items;
            }
            set
            {
                __Items = value;
            }
        }

        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Id
        {
            get
            {
                return __Id;
            }
            set
            {
                __Id = value;
            }
        }

    }
    
#if FEATURE_SERIALIZATION
    [System.SerializableAttribute()]
#endif
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.3.2#")]
    [System.Xml.Serialization.XmlRootAttribute("ArchiveTimeStampV2", Namespace = "http://uri.etsi.org/01903/v1.4.1#", IsNullable=false)]
    public partial class XAdESTimeStampType : GenericTimeStampType
    {
    }
}