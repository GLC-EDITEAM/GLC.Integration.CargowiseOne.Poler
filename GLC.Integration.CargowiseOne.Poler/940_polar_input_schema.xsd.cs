namespace GLC.Integration.CargowiseOne.Poler {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"WarehouseTransactionsInbound")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"WarehouseTransactionsInbound"})]
    public sealed class _940_polar_input_schema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""WarehouseTransactionsInbound"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""WarehouseTransaction"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""TransInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ReferenceNum"" type=""xs:unsignedInt"" />
                    <xs:element name=""AIMS360CustOrderNum"" type=""xs:unsignedInt"" />
                    <xs:element name=""PONum"" type=""xs:string"" />
                    <xs:element name=""ExpectedDate"" type=""xs:date"" />
                    <xs:element name=""EarliestShipDate"" type=""xs:date"" />
                    <xs:element name=""AIMS360ClientCode"" type=""xs:string"" />
                    <xs:element name=""AIMS360ClientName"" type=""xs:string"" />
                    <xs:element name=""CompanyName"" type=""xs:string"" />
                    <xs:element name=""Email"" type=""xs:string"" />
                    <xs:element name=""CompanyDivisionCode"" type=""xs:string"" />
                    <xs:element name=""CompanyDivisionDescription"" type=""xs:string"" />
                    <xs:element name=""OrderType"" type=""xs:string"" />
                    <xs:element name=""WarehouseCode"" type=""xs:unsignedByte"" />
                    <xs:element name=""WarehouseName"" type=""xs:string"" />
                    <xs:element name=""DepartmentCode"" type=""xs:anyType"" />
                    <xs:element name=""DepartmentDescription"" type=""xs:anyType"" />
                    <xs:element name=""DivisionCode"" type=""xs:anyType"" />
                    <xs:element name=""DivisionDescription"" type=""xs:anyType"" />
                    <xs:element name=""CustomerAcctCode"" type=""xs:string"" />
                    <xs:element name=""CustomerName"" type=""xs:string"" />
                    <xs:element name=""MarkForStoreNumber"" type=""xs:anyType"" />
                    <xs:element name=""MarkForStoreName"" type=""xs:string"" />
                    <xs:element name=""COD"" type=""xs:string"" />
                    <xs:element name=""ServiceLevel"" type=""xs:anyType"" />
                    <xs:element name=""MerchType"" type=""xs:anyType"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""BillTo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""BillToCode"" type=""xs:anyType"" />
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Address"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Address1"" type=""xs:string"" />
                          <xs:element name=""Address2"" type=""xs:anyType"" />
                          <xs:element name=""Address3"" type=""xs:anyType"" />
                          <xs:element name=""City"" type=""xs:string"" />
                          <xs:element name=""State"" type=""xs:string"" />
                          <xs:element name=""Zip"" type=""xs:unsignedInt"" />
                          <xs:element name=""Country"" type=""xs:anyType"" />
                          <xs:element name=""CountryCode"" type=""xs:anyType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PhoneNumber1"" type=""xs:anyType"" />
                    <xs:element name=""Email"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""MarkFor"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""MarkForCode"" type=""xs:anyType"" />
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""Address"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Address1"" type=""xs:string"" />
                          <xs:element name=""Address2"" type=""xs:anyType"" />
                          <xs:element name=""Address3"" type=""xs:anyType"" />
                          <xs:element name=""City"" type=""xs:string"" />
                          <xs:element name=""State"" type=""xs:string"" />
                          <xs:element name=""Zip"" type=""xs:unsignedInt"" />
                          <xs:element name=""Country"" type=""xs:anyType"" />
                          <xs:element name=""CountryCode"" type=""xs:anyType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PhoneNumber1"" type=""xs:anyType"" />
                    <xs:element name=""Email"" type=""xs:anyType"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ShipTo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Store"" type=""xs:anyType"" />
                    <xs:element name=""DCNo"" type=""xs:anyType"" />
                    <xs:element name=""ShipToCode"" type=""xs:anyType"" />
                    <xs:element name=""Name"" type=""xs:string"" />
                    <xs:element name=""CompanyName"" type=""xs:string"" />
                    <xs:element name=""Address"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Address1"" type=""xs:string"" />
                          <xs:element name=""Address2"" type=""xs:anyType"" />
                          <xs:element name=""Address3"" type=""xs:anyType"" />
                          <xs:element name=""City"" type=""xs:string"" />
                          <xs:element name=""State"" type=""xs:string"" />
                          <xs:element name=""Zip"" type=""xs:unsignedInt"" />
                          <xs:element name=""Country"" type=""xs:anyType"" />
                          <xs:element name=""CountryCode"" type=""xs:anyType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element name=""PhoneNumber1"" type=""xs:anyType"" />
                    <xs:element name=""Fax"" type=""xs:anyType"" />
                    <xs:element name=""Email"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ShippingInstructions"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SCACCode"" type=""xs:string"" />
                    <xs:element name=""Carrier"" type=""xs:string"" />
                    <xs:element name=""Mode"" type=""xs:string"" />
                    <xs:element name=""VASShippingServ"" type=""xs:anyType"" />
                    <xs:element name=""BillingCode"" type=""xs:string"" />
                    <xs:element name=""Account"" type=""xs:anyType"" />
                    <xs:element name=""ShippingNotes"" type=""xs:anyType"" />
                    <xs:element name=""PackingNotes"" type=""xs:anyType"" />
                    <xs:element name=""VASNotes"" type=""xs:anyType"" />
                    <xs:element name=""PackingSlipUrl"" type=""xs:anyType"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Notes"" type=""xs:anyType"" />
              <xs:element name=""SavedElements"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""CodeDescrPair"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""Code"" type=""xs:anyType"" />
                          <xs:element name=""Description"" type=""xs:anyType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""OrderItems"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""OrderItem"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""SKU"" type=""xs:string"" />
                          <xs:element name=""OrderQty"" type=""xs:unsignedByte"" />
                          <xs:element name=""Price"" type=""xs:decimal"" />
                          <xs:element name=""UPC"" type=""xs:unsignedLong"" />
                          <xs:element name=""BuyersPartNum"" type=""xs:anyType"" />
                          <xs:element name=""BuyersColorDescrp"" type=""xs:anyType"" />
                          <xs:element name=""UOM"" type=""xs:string"" />
                          <xs:element name=""Notes"" type=""xs:anyType"" />
                          <xs:element name=""OrderLineId"" type=""xs:string"" />
                          <xs:element name=""SavedElements"" type=""xs:anyType"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public _940_polar_input_schema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "WarehouseTransactionsInbound";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
