<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
    
     <script type="text/javascript">
        var addTab = function (tabPanel, id, url) {
            var tab = tabPanel.getComponent(id);

            if (!tab) {
                tab = tabPanel.add({ 
                    id       : id, 
                    title    : url, 
                    closable : true,                    
                    autoLoad : {
                        showMask : true,
                        url      : url,
                        mode     : "iframe",
                        maskMsg  : "Loading " + url + "..."
                    }                    
                });

                tab.on("activate", function () {
                    var item = MenuPanel1.menu.items.get(id + "_item");
                    
                    if (item) {
                        MenuPanel1.setSelection(item);
                    }
                }, this);
            }
            
            tabPanel.setActiveTab(tab);
        }
    </script>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server" />
        
        <ext:Window runat="server" Width="700" Height="500" Icon="Link" Title="Adding tab">
            <Items>
                <ext:BorderLayout runat="server">
                    <West>
                        <ext:MenuPanel ID="MenuPanel1" runat="server" Width="200">
                            <Menu runat="server">
                                <Items>
                                    <ext:MenuItem ID="idClt_item" runat="server" Text="Ext.Net">
                                        <Listeners>
                                            <Click Handler="addTab(#{TabPanel1}, 'idClt', 'http://www.ext.net');" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    
                                    <ext:MenuSeparator />
                                    
                                    <ext:MenuItem ID="idGgl_item" runat="server" Text="Google">
                                        <Listeners>
                                            <Click Handler="addTab(#{TabPanel1}, 'idGgl', 'http://www.google.com');" />
                                        </Listeners>
                                    </ext:MenuItem>
                                    
                                    <ext:MenuSeparator />
                                    
                                    <ext:MenuItem ID="idExt_item" runat="server" Text="ExtJS">
                                        <Listeners>
                                            <Click Handler="addTab(#{TabPanel1}, 'idExt', 'http://www.extjs.com');" />
                                        </Listeners>
                                    </ext:MenuItem>
                                </Items>
                            </Menu>
                        </ext:MenuPanel>
                    </West>
                    <Center>
                        <ext:TabPanel ID="TabPanel1" runat="server" />                               
                    </Center>
                </ext:BorderLayout>
            </Items>
        </ext:Window>
    </form>
</body>
</html>
