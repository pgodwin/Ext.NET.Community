<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>HBoxLayout - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        html, body {
            font: normal 12px verdana;
            margin: 0;
            padding: 0;
            border: 0 none;
            background-color: #dfe8f6 !important;
        }
    </style>
    
    <script type="text/javascript">
        var replace = function (panel) {
            var btns = Ext.getCmp("btns");

            Ext.get("hiddenArea").appendChild(btns.remove(0, false).getEl());
            btns.add(panel);

            btns.doLayout();
        }
    </script>
</head>
<body>
    <ext:ResourceManager ID="ASP" runat="server" />
    
    <ext:Viewport runat="server">
        <Items>
            <ext:BorderLayout runat="server">
                <North 
                    Split="true" 
                    MinHeight="40" 
                    MaxHeight="85" 
                    Margins-Top="5" 
                    Margins-Left="5" 
                    Margins-Right="5" 
                    Margins-Bottom="0">
                    <ext:Panel ID="btns" runat="server" BaseCls="x-plain" Height="50" Layout="Fit">
                        <Items>
                            <ext:Panel ID="Panel1" runat="server" BaseCls="x-plain">
                                <Content>
                                    <p style="padding:10px;color:#556677;">Select a configuration below:</p>
                                </Content>
                            </ext:Panel>
                        </Items>
                    </ext:Panel>
                </North>
                <Center Margins-Top="0" Margins-Left="5" Margins-Right="5" Margins-Bottom="5">
                    <ext:Panel runat="server" Layout="Anchor">
                        <Items>
                            <ext:Panel runat="server" BaseCls="x-plain" AnchorHorizontal="100%">
                                <Defaults>
                                    <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
                                    <ext:Parameter Name="pressed" Value="false" Mode="Raw" />
                                    <ext:Parameter Name="toggleGroup" Value="btns" Mode="Value" />
                                    <ext:Parameter Name="allowDepress" Value="false" Mode="Raw" />
                                </Defaults>
                                <Items>
                                    <ext:HBoxLayout runat="server" Padding="10">
                                        <BoxItems>
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Spaced">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlSpaced});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Align: top">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlAlignTop});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Align: middle">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlAlignMiddle});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Align: stretch">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlAlignStretch});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Align: stretchmax">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlAlignStretchMax});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                        </BoxItems>
                                    </ext:HBoxLayout>
                                </Items>
                            </ext:Panel>
                            <ext:Panel runat="server" BaseCls="x-plain" AnchorHorizontal="100%">
                                <Defaults>
                                    <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
                                    <ext:Parameter Name="pressed" Value="false" Mode="Raw" />
                                    <ext:Parameter Name="toggleGroup" Value="btns" Mode="Value" />
                                    <ext:Parameter Name="allowDepress" Value="false" Mode="Raw" />
                                </Defaults>
                                <Items>
                                    <ext:HBoxLayout runat="server" Padding="0 10 10">
                                        <BoxItems>
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Flex: All even">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlFlexEven});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Flex: Ratio">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlFlexRatio});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Pack: start">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlPackStart});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Pack: center">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlPackCenter});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                            
                                            <ext:BoxItem>
                                                <ext:Button runat="server" Text="Pack: end">
                                                    <Listeners>
                                                        <Click Handler="replace(#{PnlPackEnd});" />
                                                    </Listeners>
                                                </ext:Button>
                                            </ext:BoxItem>
                                        </BoxItems>
                                    </ext:HBoxLayout>
                                </Items>
                            </ext:Panel>
                        </Items>
                    </ext:Panel>
                </Center>
            </ext:BorderLayout>
        </Items>
    </ext:Viewport>
    
    <div id="hiddenArea" class="x-hidden">
        <ext:Panel ID="PnlSpaced" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Top">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem Flex="1">
                            <ext:Panel runat="server" BaseCls="x-plain" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>                    
                        
                        <ext:BoxItem Margins="0">
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignTop" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Top">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>                    
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignMiddle" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>       
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignStretch" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Stretch">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignStretchMax" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="StretchMax">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1 - height 30px" Height="30" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlFlexEven" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle">
                    <BoxItems>
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem Flex="1" Margins="0">
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlFlexRatio" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle">
                    <BoxItems>
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem Flex="1">
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem Flex="3" Margins="0">
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackStart" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle" Pack="Start">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackCenter" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle" Pack="Center">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackEnd" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:HBoxLayout runat="server" Padding="5" Align="Middle" Pack="End">
                    <BoxItems>
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 1" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 2" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>  
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:HBoxLayout>
            </Items>
        </ext:Panel>
    </div>
</body>
</html>
