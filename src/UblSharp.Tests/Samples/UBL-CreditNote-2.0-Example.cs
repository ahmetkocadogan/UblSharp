// Generated by UblSharp.Tests.Generator
using System;
using System.Collections.Generic;
using System.Xml;
using UblSharp;
using UblSharp.CommonAggregateComponents;
using UblSharp.CommonExtensionComponents;
using UblSharp.UnqualifiedDataTypes;
using UblSharp.XmlDigitalSignature;

namespace UblSharp.Tests.Samples
{
    internal class UBLCreditNote20Example
    {
        public static CreditNoteType Create()
        {
            var doc = new CreditNoteType
            {
                UBLVersionID = "2.0",
                CustomizationID = "urn:oasis:names:specification:ubl:xpath:CreditNote-2.0:sbs-1.0-draft",
                ProfileID = "bpid:urn:oasis:names:draft:bpss:ubl-2-sbs-credit-notification-draft",
                ID = "CN758494",
                CopyIndicator = false,
                UUID = "349ABBAE-DF9D-40B4-849F-94C5FF9D1AF4",
                IssueDate = "2005-06-25",
                TaxPointDate = "2005-06-21",
                Note = new List<TextType>()
                {
                    new TextType
                    {
                        Value = "sample"
                    }
                },
                AccountingSupplierParty = new SupplierPartyType
                {
                    CustomerAssignedAccountID = "CO001",
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "Consortial"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Busy Street",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Farthing",
                            PostalZone = "AA99 1BB",
                            CountrySubentity = "Heremouthshire",
                            AddressLine = new List<AddressLineType>()
                            {
                                new AddressLineType
                                {
                                    Line = "The Roundabout"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Farthing Purchasing Consortium",
                                CompanyID = "175 269 2355",
                                ExemptionReason = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "N/A"
                                    }
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "VAT",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mrs Bouquet",
                            Telephone = "0158 1233714",
                            Telefax = "0158 1233856",
                            ElectronicMail = "bouquet@fpconsortial.co.uk"
                        }
                    }
                },
                AccountingCustomerParty = new CustomerPartyType
                {
                    CustomerAssignedAccountID = "XFB01",
                    SupplierAssignedAccountID = "GT00978567",
                    Party = new PartyType
                    {
                        PartyName = new List<PartyNameType>()
                        {
                            new PartyNameType
                            {
                                Name = "IYT Corporation"
                            }
                        },
                        PostalAddress = new AddressType
                        {
                            StreetName = "Avon Way",
                            BuildingName = "Thereabouts",
                            BuildingNumber = "56A",
                            CityName = "Bridgtow",
                            PostalZone = "ZZ99 1ZZ",
                            CountrySubentity = "Avon",
                            AddressLine = new List<AddressLineType>()
                            {
                                new AddressLineType
                                {
                                    Line = "3rd Floor, Room 5"
                                }
                            },
                            Country = new CountryType
                            {
                                IdentificationCode = "GB"
                            }
                        },
                        PartyTaxScheme = new List<PartyTaxSchemeType>()
                        {
                            new PartyTaxSchemeType
                            {
                                RegistrationName = "Bridgtow District Council",
                                CompanyID = "12356478",
                                ExemptionReason = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "Local Authority"
                                    }
                                },
                                TaxScheme = new TaxSchemeType
                                {
                                    ID = "UK VAT",
                                    TaxTypeCode = "VAT"
                                }
                            }
                        },
                        Contact = new ContactType
                        {
                            Name = "Mr Fred Churchill",
                            Telephone = "0127 2653214",
                            Telefax = "0127 2653215",
                            ElectronicMail = "fred@iytcorporation.gov.uk"
                        }
                    }
                },
                TaxTotal = new List<TaxTotalType>()
                {
                    new TaxTotalType
                    {
                        TaxAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 17.50M
                        },
                        TaxEvidenceIndicator = true,
                        TaxSubtotal = new List<TaxSubtotalType>()
                        {
                            new TaxSubtotalType
                            {
                                TaxableAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 100.00M
                                },
                                TaxAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 17.50M
                                },
                                TaxCategory = new TaxCategoryType
                                {
                                    ID = "A",
                                    TaxScheme = new TaxSchemeType
                                    {
                                        ID = "UK VAT",
                                        TaxTypeCode = "VAT"
                                    }
                                }
                            }
                        },
                    }
                },
                LegalMonetaryTotal = new MonetaryTotalType
                {
                    LineExtensionAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 100.00M
                    },
                    TaxExclusiveAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 90.00M
                    },
                    PayableAmount = new AmountType
                    {
                        currencyID = "GBP",
                        Value = 107.50M
                    }
                },
                CreditNoteLine = new List<CreditNoteLineType>()
                {
                    new CreditNoteLineType
                    {
                        ID = "1",
                        Note = new List<TextType>()
                        {
                            new TextType
                            {
                                Value = "as agreed on phone, the invoice should have been cancelled earlier, apologies"
                            }
                        },
                        CreditedQuantity = new QuantityType
                        {
                            unitCode = "KGM",
                            Value = 100M
                        },
                        LineExtensionAmount = new AmountType
                        {
                            currencyID = "GBP",
                            Value = 100.00M
                        },
                        TaxPointDate = "2005-06-21",
                        DiscrepancyResponse = new List<ResponseType>()
                        {
                            new ResponseType
                            {
                                ReferenceID = "A00095678",
                                Description = new List<TextType>()
                                {
                                    new TextType
                                    {
                                        Value = "invoice cancelation"
                                    }
                                },
                            }
                        },
                        BillingReference = new List<BillingReferenceType>()
                        {
                            new BillingReferenceType
                            {
                                InvoiceDocumentReference = new DocumentReferenceType
                                {
                                    ID = "A00095678",
                                    UUID = "849FBBCE-E081-40B4-906C-94C5FF9D1AC3",
                                    IssueDate = "2005-06-21"
                                }
                            }
                        },
                        TaxTotal = new List<TaxTotalType>()
                        {
                            new TaxTotalType
                            {
                                TaxAmount = new AmountType
                                {
                                    currencyID = "GBP",
                                    Value = 17.50M
                                },
                                TaxEvidenceIndicator = true,
                                TaxSubtotal = new List<TaxSubtotalType>()
                                {
                                    new TaxSubtotalType
                                    {
                                        TaxableAmount = new AmountType
                                        {
                                            currencyID = "GBP",
                                            Value = 100.00M
                                        },
                                        TaxAmount = new AmountType
                                        {
                                            currencyID = "GBP",
                                            Value = 17.50M
                                        },
                                        TaxCategory = new TaxCategoryType
                                        {
                                            ID = "A",
                                            TaxScheme = new TaxSchemeType
                                            {
                                                ID = "UK VAT",
                                                TaxTypeCode = "VAT"
                                            }
                                        }
                                    }
                                },
                            }
                        },
                        Item = new ItemType
                        {
                            Description = new List<TextType>()
                            {
                                new TextType
                                {
                                    Value = "Acme beeswax"
                                }
                            },
                            Name = "beeswax",
                            BuyersItemIdentification = new ItemIdentificationType
                            {
                                ID = "6578489"
                            },
                            SellersItemIdentification = new ItemIdentificationType
                            {
                                ID = "17589683"
                            },
                            ItemInstance = new List<ItemInstanceType>()
                            {
                                new ItemInstanceType
                                {
                                    LotIdentification = new LotIdentificationType
                                    {
                                        LotNumberID = "546378239",
                                        ExpiryDate = "2010-01-01"
                                    }
                                }
                            },
                        },
                        Price = new PriceType
                        {
                            PriceAmount = new AmountType
                            {
                                currencyID = "GBP",
                                Value = 1.00M
                            },
                            BaseQuantity = new QuantityType
                            {
                                unitCode = "KGM",
                                Value = 1M
                            }
                        }
                    }
                },
            };
            doc.Xmlns = new System.Xml.Serialization.XmlSerializerNamespaces(new[]
            {
                new XmlQualifiedName("cac","urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"),
                new XmlQualifiedName("cbc","urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"),
            });
            return doc;
        }
    }
}