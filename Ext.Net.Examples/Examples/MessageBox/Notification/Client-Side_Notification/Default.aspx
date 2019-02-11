<%@ Page Language="C#" %>

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
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Summary of Client-Side Notification Options - Ext.NET Examples</title>  
    <style type="text/css">
        .menu-label {
            border-bottom: dotted 1px;
            margin-left:25px;
        }
    </style> 
    
    <script type="text/javascript">
        var stub = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit, sed diam nonummy nibh euismod tincidunt ut laoreet dolore magna aliquam erat volutpat.";
    </script>
</head>
<body scroll="no">
    <ext:ResourceManager ID="ResourceManager1" runat="server" />
    
    <ext:Window ID="Window1" runat="server" Title="Notifications" Width="300" Height="350" Layout="Accordion">
        <Items>
            <ext:MenuPanel runat="server" Title="Basic Align" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Bottom Right">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls  : 'icon-information',
                                        pinEvent : 'click',
                                        html     : stub,
                                        title    : 'Title'
                                     });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Top Right">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx     : {
                                            fxName : 'ghost', 
                                            args   : [ 'tr', {} ]
                                        },
                                        showFx     : {
                                            fxName : 'slideIn', 
                                            args   : [ 
                                            'tr', { 
                                                easing   : 'bounceOut',
                                                duration : 1.0
                                                }
                                            ]},                                    
                                        alignToCfg : {
                                            offset   : [ -20, 20 ],
                                            position : 'tr-tr'
                                        },
                                        html  : stub,
                                        title : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Top Left">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx    : { 
                                            fxName : 'switchOff', 
                                            args   : [ {} ]
                                        },
                                        showFx : {
                                            args : [ 
                                                'C3DAF9', 
                                                1,
                                                {
                                                    duration : 2.0
                                                }
                                            ],
                                            fxName : 'frame'
                                        },
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 20, 20 ],
                                            position : 'tl-tl'
                                        },
                                        html   : stub,
                                        title  : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Bottom Left">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx     : {
                                            args   : 
                                            [ 
                                                { 
                                                    duration   : 2.0,
                                                    endOpacity : 0.25
                                                }
                                            ],
                                            fxName : 'fadeOut'
                                        },
                                        showFx     : {
                                            args   : [ { duration : 2.0 } ],
                                            fxName : 'fadeIn'
                                        },
                                        hideDelay  : 1000,
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 20, -20 ],
                                            position : 'bl-bl'
                                        },
                                        html       : stub,
                                        title      : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Custom Align" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Bottom Right Outside Window">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx     : {
                                            args   : [ 't', {} ],
                                            fxName : 'ghost'
                                        },
                                        showFx     : {
                                            args   : [ 't', {} ],
                                            fxName : 'slideIn'
                                        },
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 10, 10 ],
                                            position : 'tl-br',
                                            el       : Ext.net.getEl('Window1')
                                        },
                                        html       : stub,
                                        title      : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Bottom Right Inside Window">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        bringToFront : true,
                                        pinEvent     : 'click',
                                        alignToCfg   : {
                                            offset   : [ -10, -10 ],
                                            position : 'br-br',
                                            el       : Ext.net.getEl('Window1')
                                        },
                                        html         : stub,
                                        title        : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Above Top Edge">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 0, -2 ],
                                            position : 'b-t',
                                            el       : Ext.net.getEl('Window1')
                                        },
                                        width      : 300,                                    
                                        html       : stub,
                                        title      : 'Title'
                                   });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Below Bottom Edge">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx   : { 
                                            args   : [ 't', {} ],
                                            fxName : 'ghost'
                                        },
                                        showFx     : {
                                            args   : [ 't', {} ],
                                            fxName : 'slideIn'
                                        },
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 0, 2 ],
                                            position : 't-b',
                                            el       : Ext.net.getEl('Window1')
                                        },
                                        width      : 300,
                                        html       : stub,
                                        title      : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem ID="MenuItem1" runat="server" Text="Show Right">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        hideFx   : {
                                            args   : [ 'l', {} ],
                                            fxName : 'ghost'
                                        },
                                        showFx     : { 
                                            args   : [ 'l', {} ],
                                            fxName : 'slideIn'
                                        },
                                        pinEvent   : 'click',
                                        alignToCfg : {
                                            offset   : [ 2, 0 ],
                                            position : 'l-r',
                                            el       : Ext.net.getEl('Window1')
                                        },
                                        height     : 350,
                                        html       : stub,
                                        title      : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="ShowMode" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuTextItem runat="server" Text="Click Several Times" Cls="menu-label" />
                        <ext:MenuItem runat="server" Text="Show Bottom Right">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls : 'icon-information',
                                        hideFx  : {
                                            args   : [ 'r', {} ],
                                            fxName : 'slideOut'
                                        },
                                        showFx  : {
                                            args   : [ 'r', {} ],
                                            fxName : 'slideIn'
                                        },
                                        pinEvent  : 'click',
                                        bodyStyle : 'padding:10px',
                                        shadow    : false,
                                        height    : 150,
                                        width     : 300,
                                        html      : stub,
                                        title     : 'Title'
                                   });" />
                            </Listeners>
                        </ext:MenuItem>                                
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Hide Functionality" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Without Auto Hiding">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls  : 'icon-information',
                                        autoHide : false,
                                        html     : stub,
                                        title    : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>    
                        
                        <ext:MenuItem runat="server" Text="2 Second Delay">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls   : 'icon-information',
                                        hideDelay : 2000,
                                        pinEvent  : 'click',
                                        html      : stub,
                                        title     : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>                                                            
                        
                        <ext:MenuItem runat="server" Text="Mouseover Stop Hiding">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls   : 'icon-information',
                                        pinEvent  : 'mouseover',
                                        html      : stub,
                                        title     : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>   
                        
                        <ext:MenuItem runat="server" Text="Close All Other Notifications">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        iconCls      : 'icon-information',
                                        closeVisible : true,
                                        html         : stub,
                                        title        : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>   
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Content Functionality" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show with AutoLoad">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        autoLoad : {
                                            scripts : true,
                                            mode    : 'iframe',
                                            url     : 'http://www.google.com'
                                        },
                                        iconCls  : 'icon-information',
                                        autoHide : false,
                                        height   : 400,
                                        width    : 500,
                                        html     : stub,
                                        title    : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show with Content Element">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        listeners    : {
                                            beforeshow : {
                                                fn : function (el) { 
                                                    BarLabel.setText(new Date().format('g:i:s A'));
                                                }
                                            }
                                        },
                                        iconCls      : 'icon-information',
                                        closeVisible : true,
                                        autoHide     : false,
                                        height       : 150,
                                        contentEl    : 'customEl',
                                        title        : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Tools" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="Show Pin Tool Button">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        showPin  : true,
                                        pinEvent : 'click',
                                        shadow   : false,
                                        html     : stub,
                                        title    : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Pinned Pin Tool Button">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        pinned   : true,
                                        showPin  : true,
                                        pinEvent : 'click',
                                        html     : stub,
                                        title    : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                        
                        <ext:MenuItem runat="server" Text="Show Custom Tool Button">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        showPin : true,
                                        tools   : [
                                            {
                                                handler : function (event,toolEl,panel) {
                                                    Ext.Msg.show({
                                                        msg     : 'Help button clicked',
                                                        buttons : Ext.Msg.OK,
                                                        title   : 'Help'
                                                    });
                                                },
                                                id : 'help'
                                            }
                                        ],
                                        pinEvent : 'click',
                                        html     : stub,
                                        title    : 'Title'
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
            
            <ext:MenuPanel runat="server" Title="Other" SaveSelection="false">
                <Menu runat="server">
                    <Items>
                        <ext:MenuItem runat="server" Text="No Title">
                            <Listeners>
                                <Click Handler="
                                    Ext.net.Notification.show({
                                        pinEvent : 'none',
                                        html     : stub,
                                        title    : ''
                                    });" />
                            </Listeners>
                        </ext:MenuItem>
                    </Items>
                </Menu>
            </ext:MenuPanel>
        </Items>
        <Plugins>
            <ext:KeepActive runat="server" />
        </Plugins>
    </ext:Window>
    
    <div id="customEl" class="x-hide-offsets">
        <ext:Panel ID="CustomEl1" runat="server" Border="false" Padding="2" Html="={stub}" Height="113" Width="180">
            <BottomBar>
                <ext:Toolbar ID="Toolb1" runat="server">
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