<%@ Page Language="C#" %>

<%@ Import Namespace="System.Threading" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
    
<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            this.ResourceManager1.RegisterIcon(Icon.Information);
        }
    }

    public static string stub = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.";
    
    protected void Option1_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            Html = stub
        });
    }

    protected void Option2_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.TopRight, 
                TargetAnchor = AnchorPoint.TopRight,
                OffsetX = -20,
                OffsetY = 20
            },
            ShowFx = new SlideIn { Anchor = AnchorPoint.TopRight, Options = new FxConfig { Easing = Easing.BounceOut } },
            HideFx = new Ghost{Anchor = AnchorPoint.TopRight},
            Html = stub
        });
    }

    protected void Option3_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.TopLeft,
                TargetAnchor = AnchorPoint.TopLeft,
                OffsetX = 20,
                OffsetY = 20
            },
            ShowFx = new Frame { Color = "C3DAF9", Count = 1, Options = new FxConfig { Duration = 2 } },
            HideFx = new SwitchOff(),
            Html = stub
        });
    }

    protected void Option4_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            HideDelay = 1000,
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.BottomLeft,
                TargetAnchor = AnchorPoint.BottomLeft,
                OffsetX = 20,
                OffsetY = -20
            },
            ShowFx = new FadeIn { Options = new FxConfig { Duration = 2 } },
            HideFx = new FadeOut { Options = new FadeOutConfig { Duration = 2, EndOpacity = 0.25f } },
            Html = stub
        });
    }

    protected void Option10_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            Height = 150,
            Width = 300,
            BodyStyle = "padding:10px",
            Html = stub,
            ShowFx = new SlideIn { Anchor = AnchorPoint.Right },
            HideFx = new SlideOut { Anchor = AnchorPoint.Right }
        });
    }

    protected void Option11_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            AutoHide = false,
            Html = stub
        });
    }

    protected void Option12_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            HideDelay = 2000,
            Html = stub
        });
    }

    protected void Option13_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            PinEvent = "mouseover",
            Html = stub
        });
    }

    protected void Option14_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            CloseVisible = true,
            Html = stub
        });
    }

    protected void Option15_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            Width = 500,
            Height = 400,
            AutoHide = false,
            AutoLoad = new LoadConfig("http://www.google.com",LoadMode.IFrame),
            Html = stub
        });
    }

    protected void Option16_Click(object sender, DirectEventArgs e)
    {
        WindowListeners listeners = new WindowListeners();
        
        listeners.BeforeShow.Handler = string.Concat(BarLabel.ClientID, ".setText(new Date().format('g:i:s A'));");
        
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            Icon = Icon.Information,
            Height = 150,
            AutoHide = false,
            CloseVisible = true,
            ContentEl = "customEl",
            Listeners = listeners
        });
    }

    protected void Option5_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.TopLeft,
                TargetAnchor = AnchorPoint.BottomRight,
                OffsetX = 10,
                OffsetY = 10,
                El = Window1.ClientID
            },
            ShowFx = new SlideIn { Anchor = AnchorPoint.Top },
            HideFx = new Ghost { Anchor = AnchorPoint.Top },
            Html = stub
        });
    }

    protected void Option6_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            BringToFront = true,
            AlignCfg = new NotificationAlignConfig
            {
                OffsetX = -10,
                OffsetY = -10,
                El = Window1.ClientID
            },
            Html = stub
        });
    }

    protected void Option7_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.Bottom,
                TargetAnchor = AnchorPoint.Top,
                OffsetX = 0,
                OffsetY = -2,
                El = Window1.ClientID
            },
            Width = 300,
            Html = stub
        });
    }

    protected void Option8_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.Top,
                TargetAnchor = AnchorPoint.Bottom,
                OffsetX = 0,
                OffsetY = 2,
                El = Window1.ClientID
            },
            ShowFx = new SlideIn{Anchor = AnchorPoint.Top},
            HideFx = new Ghost{Anchor = AnchorPoint.Top},
            Width = 300,
            Html = stub
        });
    }

    protected void Option9_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            AlignCfg = new NotificationAlignConfig
            {
                ElementAnchor = AnchorPoint.Left,
                TargetAnchor = AnchorPoint.Right,
                OffsetX = 2,
                OffsetY = 0,
                El = Window1.ClientID
            },
            ShowFx = new SlideIn { Anchor = AnchorPoint.Left },
            HideFx = new Ghost { Anchor = AnchorPoint.Left },
            Height = 350,
            Html = stub
        });
    }

    protected void Option17_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            ShowPin = true,
            Html = stub
        });
    }

    protected void Option18_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            ShowPin = true,
            Pinned = true,
            Html = stub
        });
    }

    protected void Option19_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            Title = "Title",
            ShowPin = true,
            Tools = new ToolsCollection{new Tool{Type = ToolType.Help, Handler = X.MessageBox.Alert("Help","Help button clicked").ToScript()}},
            Html = stub
        });
    }

    protected void Option20_Click(object sender, DirectEventArgs e)
    {
        Notification.Show(new NotificationConfig
        {
            PinEvent = "none",
            Html = stub
        });
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary of Notification options - Ext.NET Examples</title>  
    <style type="text/css">
        .menu-label {
            border-bottom: dotted 1px;
            margin-left:25px;
        }
    </style> 
</head>
<body>
    <ext:ResourceManager ID="ResourceManager1" runat="server" DirectEventUrl="default.aspx" />
    
    <ext:Window ID="Window1" runat="server" Title="Notifications" Width="300" Height="350" Layout="Accordion">
        <Items>
            <ext:MenuPanel runat="server" Title="Basic Align" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Bottom Right">
                            <DirectEvents>
                                <Click OnEvent="Option1_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Top Right">
                            <DirectEvents>
                                <Click OnEvent="Option2_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Top Left">
                            <DirectEvents>
                                <Click OnEvent="Option3_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Bottom Left">
                            <DirectEvents>
                                <Click OnEvent="Option4_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Custom Align" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Bottom Right Outside Window">
                            <DirectEvents>
                                <Click OnEvent="Option5_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Bottom Right Inside Window">
                            <DirectEvents>
                                <Click OnEvent="Option6_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Above Top Edge">
                            <DirectEvents>
                                <Click OnEvent="Option7_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Below Bottom Edge">
                            <DirectEvents>
                                <Click OnEvent="Option8_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem ID="MenuItem1" runat="server" Text="Show Right">
                            <DirectEvents>
                                <Click OnEvent="Option9_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="ShowMode" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuTextItem runat="server" Text="Click Several Times" Cls="menu-label" />
                        <ext:MenuItem runat="server" Text="Show Bottom Right">
                            <DirectEvents>
                                <Click OnEvent="Option10_Click" />
                            </DirectEvents>
                        </ext:MenuItem>                                
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Hide Functionality" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Auto Hiding">
                            <DirectEvents>
                                <Click OnEvent="Option11_Click" />
                            </DirectEvents>
                        </ext:MenuItem>    
                        
                        <ext:MenuItem runat="server" Text="2 Second Delay">
                            <DirectEvents>
                                <Click OnEvent="Option12_Click" />
                            </DirectEvents>
                        </ext:MenuItem>                                                            
                        
                        <ext:MenuItem runat="server" Text="Mouseover Stop Hiding">
                            <DirectEvents>
                                <Click OnEvent="Option13_Click" />
                            </DirectEvents>
                        </ext:MenuItem>   
                        
                        <ext:MenuItem runat="server" Text="Close All Other Notifications">
                            <DirectEvents>
                                <Click OnEvent="Option14_Click" />
                            </DirectEvents>
                        </ext:MenuItem>   
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Content Functionality" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show with AutoLoad">
                            <DirectEvents>
                                <Click OnEvent="Option15_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show with Content Element">
                            <DirectEvents>
                                <Click OnEvent="Option16_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Tools" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Pin Tool Button">
                            <DirectEvents>
                                <Click OnEvent="Option17_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Pinned Pin Tool Button">
                            <DirectEvents>
                                <Click OnEvent="Option18_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Custom Tool Button">
                            <DirectEvents>
                                <Click OnEvent="Option19_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Other" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="No Title">
                            <DirectEvents>
                                <Click OnEvent="Option20_Click" />
                            </DirectEvents>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
        </Items>
        <Plugins>
            <ext:KeepActive runat="server" />
        </Plugins>
    </ext:Window>
    
    <div id="customEl" class="x-hidden">
        <ext:Panel 
            ID="CustomEl1" 
            runat="server" 
            Border="false" 
            Padding="2" 
            AutoDataBind="true" 
            Height="113" 
            Width="180">
            <Content>
                <%# stub %>
            </Content>
            <BottomBar>
                <ext:Toolbar runat="server">
                    <Items>
                        <ext:ToolbarTextItem ID="BarLabel" runat="server" />
                        <ext:ToolbarFill runat="server" />
                        <ext:Button runat="server" Icon="Add" />
                        <ext:Button runat="server" Icon="Email" />
                    </Items>
                </ext:Toolbar>
            </BottomBar>
        </ext:Panel>
    </div>
</body>
</html>