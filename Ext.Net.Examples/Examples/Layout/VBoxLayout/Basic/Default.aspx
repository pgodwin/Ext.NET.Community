<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>VBoxLayout - Ext.NET Examples</title>
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
    <ext:ResourceManager ID="ResourceManager1" runat="server" />
    
    <ext:Viewport runat="server">
        <Items>
            <ext:BorderLayout runat="server">
                <West 
                    Split="true" 
                    MinWidth="100" 
                    MaxWidth="250" 
                    Margins-Top="5" 
                    Margins-Left="5" 
                    Margins-Right="0" 
                    Margins-Bottom="5">
                    <ext:Panel ID="btns" runat="server" BaseCls="x-plain" Width="150" Layout="Fit">
                        <Items>
                            <ext:Panel ID="Panel1" runat="server" BaseCls="x-plain">
                                <Content>
                                    <p style="padding:10px;color:#556677;font-size:11px;">Select a configuration to the right &raquo;</p>
                                </Content>
                            </ext:Panel>
                        </Items>
                    </ext:Panel>
                </West>
                <Center Margins-Top="5" Margins-Left="0" Margins-Right="5" Margins-Bottom="5">
                    <ext:Panel runat="server">
                        <Items>
                            <ext:VBoxLayout runat="server" Align="Stretch">
                                <BoxItems>
                                    <ext:BoxItem>
                                        <ext:Panel runat="server" BaseCls="x-plain" Height="40">
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
                                                            <ext:Button runat="server" Text="Multi-Spaced">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlMultiSpaced});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Align: Top">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlAlignTop});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Align: Middle">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlAlignMiddle});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Align: Stretch">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlAlignStretch});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Align: StretchMax">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlAlignStretchMax});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                    </BoxItems>
                                                </ext:HBoxLayout>
                                            </Items>
                                        </ext:Panel>
                                    </ext:BoxItem>
                                    
                                    <ext:BoxItem>
                                        <ext:Panel runat="server" BaseCls="x-plain" Height="40">
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
                                                            <ext:Button runat="server" Text="Flex + Stretch">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlFlexStretch});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Pack: Start">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlPackStart});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Pack: Center">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlPackCenter});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                        
                                                        <ext:BoxItem>
                                                            <ext:Button runat="server" Text="Pack: End">
                                                                <Listeners>
                                                                    <Click Handler="replace(#{PnlPackEnd});" />
                                                                </Listeners>
                                                            </ext:Button>
                                                        </ext:BoxItem>
                                                    </BoxItems>
                                                </ext:HBoxLayout>
                                            </Items>
                                        </ext:Panel>
                                    </ext:BoxItem>
                                </BoxItems>
                            </ext:VBoxLayout>
                        </Items>
                    </ext:Panel>
                </Center>
            </ext:BorderLayout>
        </Items>
    </ext:Viewport>
    
    <div id="hiddenArea" class="x-hidden">
        <ext:Panel ID="PnlSpaced" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Left">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlMultiSpaced" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Left">
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
                        
                        <ext:BoxItem Flex="1">
                            <ext:Panel runat="server" BaseCls="x-plain" />
                        </ext:BoxItem>
                        
                        <ext:BoxItem>
                            <ext:Button runat="server" Text="Button 3" />
                        </ext:BoxItem>        
                        
                        <ext:BoxItem Flex="1">
                            <ext:Panel runat="server" BaseCls="x-plain" />
                        </ext:BoxItem>            
                        
                        <ext:BoxItem Margins="0">
                            <ext:Button runat="server" Text="Button 4" />
                        </ext:BoxItem>
                    </BoxItems>
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignTop" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Left">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignMiddle" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignStretch" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Stretch">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlAlignStretchMax" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 5 0 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="StretchMax">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlFlexEven" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlFlexRatio" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlFlexStretch" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Stretch">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackStart" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center" Pack="Start">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackCenter" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center" Pack="Center">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
        
        <ext:Panel ID="PnlPackEnd" runat="server">
            <Defaults>
                <ext:Parameter Name="margins" Value="0 0 5 0" Mode="Value" />
            </Defaults>
            <Items>
                <ext:VBoxLayout runat="server" Padding="5" Align="Center" Pack="End">
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
                </ext:VBoxLayout>
            </Items>
        </ext:Panel>
    </div>
</body>
</html>
