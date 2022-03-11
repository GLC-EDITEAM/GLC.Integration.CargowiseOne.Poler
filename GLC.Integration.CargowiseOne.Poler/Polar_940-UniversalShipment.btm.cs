namespace GLC.Integration.CargowiseOne.Poler {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseOne.Poler._940_polar_input_schema", typeof(global::GLC.Integration.CargowiseOne.Poler._940_polar_input_schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    public sealed class _940_UniversalShipment : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var userCSharp"" version=""1.0"" xmlns:ns0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/WarehouseTransactionsInbound"" />
  </xsl:template>
  <xsl:template match=""/WarehouseTransactionsInbound"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;GDS&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;US&quot;)"" />
    <!--<xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCGDSTRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;GLCGDSLAX&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;GLC&quot;)"" />
    <!--<xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;TRN&quot;)"" />-->
    <!--PROD Value-->
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;GDS&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;WarehouseOrder&quot;)"" />
    <ns0:UniversalShipment>
      <ns0:Shipment>
        <ns0:DataContext>
          <ns0:Company>
            <ns0:Code>
              <xsl:value-of select=""$var:v1"" />
            </ns0:Code>
            <ns0:Country>
              <ns0:Code>
                <xsl:value-of select=""$var:v2"" />
              </ns0:Code>
            </ns0:Country>
          </ns0:Company>
          <ns0:DataProvider>
            <xsl:value-of select=""$var:v3"" />
          </ns0:DataProvider>
          <ns0:EnterpriseID>
            <xsl:value-of select=""$var:v4"" />
          </ns0:EnterpriseID>
          <ns0:ServerID>
            <xsl:value-of select=""$var:v5"" />
          </ns0:ServerID>
          <ns0:DataTargetCollection>
            <ns0:DataTarget>
              <ns0:Type>
                <xsl:value-of select=""$var:v6"" />
              </ns0:Type>
            </ns0:DataTarget>
          </ns0:DataTargetCollection>
        </ns0:DataContext>

       
       
          <ns0:LocalProcessing>                     
              <ns0:DeliveryRequiredBy>
                <xsl:value-of select=""userCSharp:DateimeConversion(WarehouseTransaction/TransInfo/ExpectedDate/text())"" />
              </ns0:DeliveryRequiredBy>          
          </ns0:LocalProcessing>
        
        <xsl:variable name=""varEarliestShipDate"" select=""WarehouseTransaction/TransInfo/EarliestShipDate/text()""/>
        
        <ns0:Order>
          <ns0:OrderNumber>
            <xsl:value-of select=""WarehouseTransaction/TransInfo/ReferenceNum/text()"" />
          </ns0:OrderNumber>
          <ns0:ClientReference>
            <xsl:value-of select=""WarehouseTransaction/TransInfo/PONum/text()"" />
          </ns0:ClientReference>
         
          <!--<ns0:TotalUnits>
            <xsl:value-of select=""concat($cntW01,'.00')""/>
          </ns0:TotalUnits>-->
          
          <xsl:variable name=""var:v8"" select=""userCSharp:StringConcat(&quot;ORD&quot;)"" />
          <ns0:Type>
            <ns0:Code>ORD</ns0:Code>
            <ns0:Description>ORDER</ns0:Description>
          </ns0:Type>
          <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;FNT&quot;)"" />
          <ns0:Warehouse>
            <ns0:Code>
              <xsl:value-of select=""$var:v9"" />
            </ns0:Code>
      </ns0:Warehouse>
          <ns0:OrderLineCollection>
            <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;Complete&quot;)"" />
            <xsl:attribute name=""Content"">
              <xsl:value-of select=""$var:v10"" />
            </xsl:attribute>
            <xsl:for-each select=""//OrderItems"">
              <xsl:variable name=""var:v7"" select=""position()"" />                             
                <xsl:for-each select=""OrderItem"">                  
                  <ns0:OrderLine>
                    <ns0:LineNumber>
                      <xsl:value-of select=""$var:v7"" />
                    </ns0:LineNumber>
                    <ns0:OrderedQty>
                      <xsl:value-of select=""OrderQty/text()"" />
                    </ns0:OrderedQty>                   
                    <ns0:OrderedQtyUnit>
                      <ns0:Code>
                         <xsl:text>UNT</xsl:text>                        
                      </ns0:Code>
                    </ns0:OrderedQtyUnit>
                    <ns0:Product>
                        <ns0:Code>
                          <xsl:value-of select=""SKU/text()"" />
                        </ns0:Code>
                    </ns0:Product>
                    <ns0:CustomizedFieldCollection>
                      
                      <ns0:CustomizedField>
                        <ns0:Key>UPCCODE</ns0:Key>
                        <ns0:DataType>String</ns0:DataType>
                        <ns0:Value>
                          <xsl:value-of select=""UPC/text()"" />
                        </ns0:Value>
                      </ns0:CustomizedField>
                    </ns0:CustomizedFieldCollection>
                  </ns0:OrderLine>
                </xsl:for-each>
              </xsl:for-each>
            
          </ns0:OrderLineCollection>
        </ns0:Order>

        <CustomizedFieldCollection>
         
              <CustomizedField>
                <DataType>String</DataType>
                <Key>StartDate</Key>
                <Value>
                  <xsl:value-of select=""$varEarliestShipDate"" />
                </Value>
              </CustomizedField>
          
          <CustomizedField>
                <DataType>String</DataType>
                <Key>PolerOrderType</Key>
                <Value>
                  <xsl:value-of select=""WarehouseTransaction/TransInfo/OrderType/text()"" />
                </Value>
              </CustomizedField>
           <CustomizedField>
                <DataType>String</DataType>
                <Key>SCACCode</Key>
                <Value>
                  <xsl:value-of select=""WarehouseTransaction/ShippingInstructions/SCACCode/text()"" />
                </Value>
              </CustomizedField>
           <CustomizedField>
                <DataType>String</DataType>
                <Key>Mode</Key>
                <Value>
                  <xsl:value-of select=""WarehouseTransaction/ShippingInstructions/Mode/text()"" />
                </Value>
              </CustomizedField>
           <CustomizedField>
                <DataType>String</DataType>
                <Key>BillingCode</Key>
                <Value>
                  <xsl:value-of select=""WarehouseTransaction/ShippingInstructions/BillingCode/text()"" />
                </Value>
              </CustomizedField>
            

        </CustomizedFieldCollection>

     <ns0:OrganizationAddressCollection>
          
              <ns0:OrganizationAddress>
                <ns0:AddressType>ConsignorDocumentaryAddress</ns0:AddressType>
                <ns0:OrganizationCode>PACEVEUS</ns0:OrganizationCode>
              </ns0:OrganizationAddress>           
              <ns0:OrganizationAddress>
                <ns0:AddressType>ConsigneeAddress</ns0:AddressType>
                <ns0:Address1>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/Address1/text()"" />
                </ns0:Address1>
                <ns0:Address2>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/Address2/text()"" />
                </ns0:Address2>
                <ns0:AddressOverride>true</ns0:AddressOverride>
                <ns0:City>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/City/text()"" />
                </ns0:City>
                <ns0:State>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/State/text()""/>
                </ns0:State>
                <xsl:variable name=""comp_name"" select=""concat(WarehouseTransaction/ShipTo/Name/text(),'_',WarehouseTransaction/ShipTo/Name/text())""/>
                <ns0:CompanyName>
                  <xsl:value-of select=""$comp_name"" />
                </ns0:CompanyName>
                <ns0:Country>
                  <ns0:Code>                    
                      <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/CountryCode/text()"" />                   
                  </ns0:Code>
                </ns0:Country>
                <ns0:Postcode>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Address/Zip/text()"" />
                </ns0:Postcode>
                 <ns0:Contact>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/PhoneNumber1/text()"" />
                </ns0:Contact>
                 <ns0:Email>
                  <xsl:value-of select=""WarehouseTransaction/ShipTo/Email/text()"" />
                </ns0:Email>
              </ns0:OrganizationAddress> 
       <ns0:OrganizationAddress>
            <ns0:AddressType>TransportCompanyDocumentaryAddress</ns0:AddressType>
           
              <ns0:OrganizationCode>
                <xsl:value-of select=""WarehouseTransaction/ShippingInstructions/Carrier/text()"" />
              </ns0:OrganizationCode>            
          </ns0:OrganizationAddress>
        </ns0:OrganizationAddressCollection>
      </ns0:Shipment>
    </ns0:UniversalShipment>

  </xsl:template>
<msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
  public string StringConcat(string param0) { return param0; }
public string DateimeConversion(string strin) 
{ 
DateTime strdatetime = new DateTime(); 
strdatetime = DateTime.Parse(strin); 
strin = strdatetime.ToString(""yyyy-MM-ddTHH:mm:ss""); 
return strin; }

public bool LogicalEq(string val1, string val2) { bool ret = false; double d1 = 0; double d2 = 0; if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2)) { ret = d1 == d2; } else { ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0; } return ret; }

public bool IsNumeric(string val) { if (val == null) { return false; } double d = 0; return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d); }
public bool IsNumeric(string val, ref double d) { if (val == null) { return false; } return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d); }
  ]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseOne.Poler._940_polar_input_schema";
        
        private const global::GLC.Integration.CargowiseOne.Poler._940_polar_input_schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"GLC.Integration.CargowiseOne.Poler._940_polar_input_schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _TrgSchemas;
            }
        }
    }
}
