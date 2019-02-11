<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<script runat="server">
    private object[] TestData
    {
        get
        {
            DateTime now = DateTime.Now;

            return new object[]
            {
                new object[] { "3m Co", 71.72, 0.02, 0.03, now },
                new object[] { "Alcoa Inc", 29.01, 0.42, 1.47, now },
                new object[] { "Altria Group Inc", 83.81, 0.28, 0.34, now },
                new object[] { "American Express Company", 52.55, 0.01, 0.02, now },
                new object[] { "American International Group, Inc.", 64.13, 0.31, 0.49, now },
                new object[] { "AT&T Inc.", 31.61, -0.48, -1.54, now },
                new object[] { "Boeing Co.", 75.43, 0.53, 0.71, now },
                new object[] { "Caterpillar Inc.", 67.27, 0.92, 1.39, now },
                new object[] { "Citigroup, Inc.", 49.37, 0.02, 0.04, now },
                new object[] { "E.I. du Pont de Nemours and Company", 40.48, 0.51, 1.28, now },
                new object[] { "Exxon Mobil Corp", 68.1, -0.43, -0.64, now },
                new object[] { "General Electric Company", 34.14, -0.08, -0.23, now },
                new object[] { "General Motors Corporation", 30.27, 1.09, 3.74, now },
                new object[] { "Hewlett-Packard Co.", 36.53, -0.03, -0.08, now },
                new object[] { "Honeywell Intl Inc", 38.77, 0.05, 0.13, now },
                new object[] { "Intel Corporation", 19.88, 0.31, 1.58, now },
                new object[] { "International Business Machines", 81.41, 0.44, 0.54, now },
                new object[] { "Johnson & Johnson", 64.72, 0.06, 0.09, now },
                new object[] { "JP Morgan & Chase & Co", 45.73, 0.07, 0.15, now },
                new object[] { "McDonald\"s Corporation", 36.76, 0.86, 2.40, now },
                new object[] { "Merck & Co., Inc.", 40.96, 0.41, 1.01, now },
                new object[] { "Microsoft Corporation", 25.84, 0.14, 0.54, now },
                new object[] { "Pfizer Inc", 27.96, 0.4, 1.45, now },
                new object[] { "The Coca-Cola Company", 45.07, 0.26, 0.58, now },
                new object[] { "The Home Depot, Inc.", 34.64, 0.35, 1.02, now },
                new object[] { "The Procter & Gamble Company", 61.91, 0.01, 0.02, now },
                new object[] { "United Technologies Corporation", 63.26, 0.55, 0.88, now },
                new object[] { "Verizon Communications", 35.57, 0.39, 1.11, now },
                new object[] { "Wal-Mart Stores, Inc.", 45.45, 0.73, 1.63, now }
            };
        }
    }
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!X.IsAjaxRequest)
        {
            this.Store1.DataSource = this.TestData;
            this.Store1.DataBind(); 
        }
    }

    protected void MyData_Refresh(object sender, StoreRefreshDataEventArgs e)
    {
        this.Store1.DataSource = this.TestData;
        this.Store1.DataBind(); 
    }
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drag and Drop from GridPanel to TreePanel - Ext.NET Examples</title>
    
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
         var beforenodedrop = function (e) { 
            if (Ext.isArray(e.data.selections)) {
                e.cancel = false;
                e.dropNode = [];
                var rec;
                
                for (var i = 0; i < e.data.selections.length; i++) {
                    rec = e.data.selections[i];
                    
                    e.dropNode.push(this.loader.createNode({
                        text   : rec.get("company"),
                        leaf   : true,
                        price  : rec.get("price"),
                        change : rec.get("change"),
                        qtip   : rec.get("lastChange")
                    }));
                }
                
                return true;
            }
        }   
    </script>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <ext:Store ID="Store1" runat="server" OnRefreshData="MyData_Refresh">
            <Reader>
                <ext:ArrayReader>
                    <Fields>
                        <ext:RecordField Name="company" />
                        <ext:RecordField Name="price" Type="Float" />
                        <ext:RecordField Name="change" Type="Float" />
                        <ext:RecordField Name="pctChange" Type="Float" />
                        <ext:RecordField Name="lastChange" Type="Date" DateFormat="yyyy-MM-ddTHH:mm:ss" />
                    </Fields>
                </ext:ArrayReader>
            </Reader>
        </ext:Store>
        
        <ext:Panel runat="server" Width="700" Height="400">
            <Items>
                <ext:BorderLayout runat="server">
                    <Center MarginsSummary="5 0 5 5">
                        <ext:GridPanel 
                            runat="server" 
                            StoreID="Store1" 
                            StripeRows="true"
                            Title="Grid" 
                            EnableDragDrop="true"
                            DDGroup="grid2tree"
                            AutoExpandColumn="Company">
                            <ColumnModel runat="server">
                                <Columns>
                                    <ext:Column 
                                        ColumnID="Company" 
                                        Header="Company" 
                                        Width="160" 
                                        Sortable="true" 
                                        DataIndex="company" 
                                        />
                                    <ext:Column 
                                        Header="Price" 
                                        Width="75" 
                                        Sortable="true" 
                                        DataIndex="price">
                                        <Renderer Format="UsMoney" />
                                    </ext:Column>
                                </Columns>
                            </ColumnModel>
                            <SelectionModel>
                                <ext:RowSelectionModel runat="server" />
                            </SelectionModel>
                            <LoadMask ShowMask="true" />
                            <BottomBar>
                                <ext:PagingToolbar runat="server" PageSize="10" StoreID="Store1" />
                            </BottomBar>
                        </ext:GridPanel>
                    </Center>
                    
                    <East Split="true" MarginsSummary="5 5 5 0">
                        <ext:TreePanel 
                            runat="server" 
                            EnableDD="true" 
                            DDGroup="grid2tree"
                            Width="300"
                            Title="tree"
                            AutoScroll="true"
                            Collapsible="true">
                            <Root>
                                <ext:TreeNode Text="Root" Expanded="true">
                                    <Nodes>
                                        <ext:TreeNode Text="Folder 1" Qtip="Rows dropped here will be appended to the folder">
                                            <Nodes>
                                                <ext:TreeNode Text="Subleaf 1" Qtip="Subleaf 1 Quick Tip" Leaf="true" />
                                            </Nodes>
                                        </ext:TreeNode>
                                        
                                        <ext:TreeNode Text="Folder 2" Qtip="Rows dropped here will be appended to the folder">
                                            <Nodes>
                                                <ext:TreeNode Text="Subleaf 2" Qtip="Subleaf 2 Quick Tip" Leaf="true" />
                                            </Nodes>
                                        </ext:TreeNode>
                                        
                                        <ext:TreeNode Text="Leaf 1" Qtip="Leaf 1 Quick Tip" Leaf="true" />
                                    </Nodes>
                                </ext:TreeNode>
                            </Root>
                            <Listeners>
                                <BeforeNodeDrop Fn="beforenodedrop" />
                            </Listeners>
                        </ext:TreePanel>
                    </East>
                </ext:BorderLayout>
            </Items>
        </ext:Panel> 
    </form>
</body>
</html>
