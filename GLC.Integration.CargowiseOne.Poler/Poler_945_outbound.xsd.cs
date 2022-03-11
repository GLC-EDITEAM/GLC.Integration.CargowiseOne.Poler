namespace GLC.Integration.CargowiseOne.Poler {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"WarehouseTransactions")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"WarehouseTransactions"})]
    public sealed class Poler_945_outbound : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""WarehouseTransactions"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""WarehouseTransaction"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""WarehouseTransactionID"" type=""xs:string"" />
              <xs:element name=""WarehouseTransactionTypeID"" type=""xs:string"" />
              <xs:element name=""TransInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ReferenceNum"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ShippingInstructions"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""SCACCode"" type=""xs:string"" />
                    <xs:element name=""Carrier"" type=""xs:string"" />
                    <xs:element name=""CarrierDesc"" type=""xs:string"" />
                    <xs:element name=""ShipService"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""TrackingInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""BillOfLading"" type=""xs:string"" />
                    <xs:element name=""TrackingNumber"" type=""xs:string"" />
                    <xs:element name=""TrailerNumber"" type=""xs:string"" />
                    <xs:element name=""LoadNumber"" type=""xs:string"" />
                    <xs:element name=""PickupDate"" type=""xs:dateTime"" />
                    <xs:element name=""ProNumber"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""ShipmentInfo"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""FreightCost"" type=""xs:decimal"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element name=""Packages"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""Package"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element name=""PackageID"" type=""xs:string"" />
                          <xs:element name=""WarehouseTransactionID"" type=""xs:string"" />
                          <xs:element name=""DimensionUOM"" type=""xs:string"" />
                          <xs:element name=""Length"" type=""xs:decimal"" />
                          <xs:element name=""Width"" type=""xs:decimal"" />
                          <xs:element name=""Height"" type=""xs:decimal"" />
                          <xs:element name=""WeightUOM"" type=""xs:string"" />
                          <xs:element name=""Weight"" type=""xs:decimal"" />
                          <xs:element name=""TrackingNumber"" type=""xs:anyType"" />
                          <xs:element name=""UCC128"" type=""xs:string"" />
                          <xs:element name=""FreightCost"" type=""xs:decimal"" />
                          <xs:element name=""PackageContents"">
                            <xs:complexType>
                              <xs:sequence>
                                <xs:element name=""PackageContent"">
                                  <xs:complexType>
                                    <xs:sequence>
                                      <xs:element name=""PackageContentID"" type=""xs:string"" />
                                      <xs:element name=""PackageID"" type=""xs:string"" />
                                      <xs:element name=""Qty"" type=""xs:decimal"" />
                                      <xs:element name=""SKU"" type=""xs:string"" />
                                      <xs:element name=""UPC"" type=""xs:string"" />
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
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Poler_945_outbound() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "WarehouseTransactions";
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
