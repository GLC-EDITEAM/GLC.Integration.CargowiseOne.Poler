namespace GLC.Integration.CargowiseOne.Poler {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment", typeof(global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GLC.Integration.CargowiseOne.Poler.Poler_945_outbound", typeof(global::GLC.Integration.CargowiseOne.Poler.Poler_945_outbound))]
    public sealed class TransformPolershipmntto945xml : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://www.cargowise.com/Schemas/Universal/2011/11"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:UniversalShipment"" />
  </xsl:template>
  <xsl:template match=""/s0:UniversalShipment"">
    <WarehouseTransactions>      
        <WarehouseTransaction>          
            <WarehouseTransactionID>
              <xsl:value-of select=""s0:Shipment/s0:Order/s0:ClientReference/text()"" />
            </WarehouseTransactionID>
          
          <TransInfo>
            <ReferenceNum>
              <xsl:value-of select=""s0:Shipment/s0:Order/s0:OrderNumber/text()"" />
            </ReferenceNum>
          </TransInfo>

          <xsl:variable name=""varSCACode"">
            <xsl:for-each select=""//s0:CustomizedFieldCollection"">
              <xsl:for-each select=""s0:CustomizedField"">
                <xsl:if test=""s0:Key/text()='SCACCode'"">
                  <xsl:value-of select=""s0:Value/text()""/>
                </xsl:if>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:variable>

          <xsl:variable name=""vartransorgcode"">
            <xsl:for-each select=""//s0:OrganizationAddressCollection"">
              <xsl:for-each select=""//s0:OrganizationAddress"">
                <xsl:if test=""s0:AddressType/text()='TransportCompanyDocumentaryAddress'"">
                  <xsl:value-of select=""s0:OrganizationCode/text()""/>
                </xsl:if>
              </xsl:for-each>
            </xsl:for-each>
          </xsl:variable>
          
          <ShippingInstructions>
            <SCACCode>
              <xsl:value-of select=""$varSCACode""/>
            </SCACCode>
            <Carrier>
              <xsl:value-of select=""$vartransorgcode""/>
            </Carrier>
            
          </ShippingInstructions>

          <TrackingInfo>
            <TrackingNumber>
              <xsl:value-of select=""s0:Shipment/s0:Order/s0:TransportReference/text()"" />
            </TrackingNumber>
            <xsl:for-each select=""s0:Shipment/s0:MilestoneCollection/s0:Milestone"">
              <xsl:if test=""s0:EventCode/text()='FIN'"">
                <PickupDate>
                  <xsl:value-of select=""userCSharp:Getdateformat(s0:ActualDate/text())"" />
                </PickupDate>
              </xsl:if>
            </xsl:for-each>
          </TrackingInfo>
          <ShipmentInfo>
           <FreightCost>0.00</FreightCost>
          </ShipmentInfo>
          <xsl:variable name=""varguid"" select=""userCSharp:getGuid()""/>
          <Packages>
            <Package>
              <PackageID>
                <xsl:value-of select=""$varguid"" />
              </PackageID>
              <WarehouseTransactionID>
                <xsl:value-of select=""s0:Shipment/s0:Order/s0:ClientReference/text()"" />
              </WarehouseTransactionID>
              <Length>10</Length>
              <Width>10</Width>
              <Height>10</Height>
              <WeightUOM>LB</WeightUOM>
              <Weight>0.3</Weight>
              <TrackingNumber>
                <xsl:value-of select=""s0:Shipment/s0:Order/s0:TransportReference/text()"" />
              </TrackingNumber>


              <PackageContents>
                <xsl:for-each select=""s0:Shipment/s0:Order/s0:OrderLineCollection/s0:OrderLine"">
                  <xsl:variable name=""varUPCCODE"">
                    <xsl:for-each select=""s0:CustomizedFieldCollection/s0:CustomizedField"">
                      <xsl:if test=""s0:Key='UPCCODE'"">
                        <xsl:value-of select=""s0:Value/text()""/>
                      </xsl:if>
                    </xsl:for-each>
                  </xsl:variable>
                  <PackageContent>
                    <PackageContentID>
                      <xsl:value-of select=""s0:Product/s0:Code/text()""/>
                    </PackageContentID>
                    <PackageID>
                      <xsl:value-of select=""$varguid"" />
                    </PackageID>
                    <Qty>
                      <xsl:value-of select=""s0:QuantityMet/text()""/>
                    </Qty>
                    <SKU>
                        <xsl:value-of select=""s0:Product/s0:Code/text()""/>
                    </SKU>
                    <UPC>
                      <xsl:value-of select=""$varUPCCODE""/>
                  </UPC>
                  </PackageContent>
                </xsl:for-each>
              </PackageContents>
            </Package>
          </Packages>
          
        </WarehouseTransaction>
      
    </WarehouseTransactions>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp"">
    <![CDATA[
    
    public string getGuid()
    {
    Guid g = Guid.NewGuid();
    return g.ToString();
    }
    
    public int lxcnt=0;
    
    public int getcnt()
    {
      lxcnt=lxcnt+1;
      return lxcnt;
    }
    
    public int getdifford (int a, int b)
    {
    int c= a-b;
    return c;
    }
    
    public void resetcnt()
    {
      lxcnt=0;
      }
    public double getcbconversion(int a)
    {
    double b=0;
      b=a*2.2;
      b=Math.Round(b,2);
      return b;
      }
    
    public int getdiff(int a1,int a2)
    {
         int a11=a1-a2;
         return a11;
    }
    
    public string replacefunc(string strin)
    {
    strin=strin.Replace("".000"","""");
    return strin;
    }    
    public string Getdateformat(string strin)
    {
           DateTime dt2 = new DateTime();
            dt2 = Convert.ToDateTime(strin);
            strin = dt2.ToString(""yyyyMMdd"");
            return strin;
    }
    
    public string Gettimeformat(string strin)
    {
      DateTime dt3=new DateTime();
      dt3 =Convert.ToDateTime(strin);
      strin=dt3.ToString(""HHmmss"");
      return strin;
      }   
    
     
    public string getadddate(string strin)
    {
          DateTime dt2 = new DateTime();
            dt2 = Convert.ToDateTime(strin);
            dt2 = dt2.AddDays(2);
            strin = dt2.ToString(""yyyyMMdd"");
            return strin;
            }
    
public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringConcat(string param0)
{
   return param0;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]>
  </msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
        
        private const global::GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GLC.Integration.CargowiseOne.Poler.Poler_945_outbound";
        
        private const global::GLC.Integration.CargowiseOne.Poler.Poler_945_outbound _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GLC.Integration.CargowiseoneInboundCommon.Schemas.UniversalShipment";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GLC.Integration.CargowiseOne.Poler.Poler_945_outbound";
                return _TrgSchemas;
            }
        }
    }
}
