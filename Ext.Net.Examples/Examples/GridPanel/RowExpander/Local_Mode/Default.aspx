<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        this.Store1.DataSource = new object[]
            {
                new object[] { "3m Co", 71.72, 0.02, 0.03, "9/1 12:00am", "Manufacturing" },
                new object[] { "Alcoa Inc", 29.01, 0.42, 1.47, "9/1 12:00am", "Manufacturing" },
                new object[] { "Altria Group Inc", 83.81, 0.28, 0.34, "9/1 12:00am", "Manufacturing" },
                new object[] { "American Express Company", 52.55, 0.01, 0.02, "9/1 12:00am", "Finance" },
                new object[] { "American International Group, Inc.", 64.13, 0.31, 0.49, "9/1 12:00am", "Services" },
                new object[] { "AT&T Inc.", 31.61, -0.48, -1.54, "9/1 12:00am", "Services" },
                new object[] { "Boeing Co.", 75.43, 0.53, 0.71, "9/1 12:00am", "Manufacturing" },
                new object[] { "Caterpillar Inc.", 67.27, 0.92, 1.39, "9/1 12:00am", "Services" },
                new object[] { "Citigroup, Inc.", 49.37, 0.02, 0.04, "9/1 12:00am", "Finance" },
                new object[] { "E.I. du Pont de Nemours and Company", 40.48, 0.51, 1.28, "9/1 12:00am", "Manufacturing" },
                new object[] { "Exxon Mobil Corp", 68.1, -0.43, -0.64, "9/1 12:00am", "Manufacturing" },
                new object[] { "General Electric Company", 34.14, -0.08, -0.23, "9/1 12:00am", "Manufacturing" },
                new object[] { "General Motors Corporation", 30.27, 1.09, 3.74, "9/1 12:00am", "Automotive" },
                new object[] { "Hewlett-Packard Co.", 36.53, -0.03, -0.08, "9/1 12:00am", "Computer" },
                new object[] { "Honeywell Intl Inc", 38.77, 0.05, 0.13, "9/1 12:00am", "Manufacturing" },
                new object[] { "Intel Corporation", 19.88, 0.31, 1.58, "9/1 12:00am", "Computer" },
                new object[] { "International Business Machines", 81.41, 0.44, 0.54, "9/1 12:00am", "Computer" },
                new object[] { "Johnson & Johnson", 64.72, 0.06, 0.09, "9/1 12:00am", "Medical" },
                new object[] { "JP Morgan & Chase & Co", 45.73, 0.07, 0.15, "9/1 12:00am", "Finance" },
                new object[] { "McDonald\"s Corporation", 36.76, 0.86, 2.40, "9/1 12:00am", "Food" },
                new object[] { "Merck & Co., Inc.", 40.96, 0.41, 1.01, "9/1 12:00am", "Medical" },
                new object[] { "Microsoft Corporation", 25.84, 0.14, 0.54, "9/1 12:00am", "Computer" },
                new object[] { "Pfizer Inc", 27.96, 0.4, 1.45, "9/1 12:00am", "Medical" },
                new object[] { "The Coca-Cola Company", 45.07, 0.26, 0.58, "9/1 12:00am", "Food" },
                new object[] { "The Home Depot, Inc.", 34.64, 0.35, 1.02, "9/1 12:00am", "Retail" },
                new object[] { "The Procter & Gamble Company", 61.91, 0.01, 0.02, "9/1 12:00am", "Manufacturing" },
                new object[] { "United Technologies Corporation", 63.26, 0.55, 0.88, "9/1 12:00am", "Computer" },
                new object[] { "Verizon Communications", 35.57, 0.39, 1.11, "9/1 12:00am", "Services" },
                new object[] { "Wal-Mart Stores, Inc.", 45.45, 0.73, 1.63, "9/1 12:00am", "Retail" }
            };

        this.Store1.DataBind();

        const string desc = "this.desc_data = \"Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Sed metus nibh, sodales a, porta at, " +
                            "vulputate eget, dui. Pellentesque ut nisl. Maecenas tortor turpis, interdum non, sodales non, " +
                            "iaculis ac, lacus. Vestibulum auctor, tortor quis iaculis malesuada, libero lectus bibendum purus, " +
                            "sit amet tincidunt quam turpis vel lacus. In pellentesque nisl non sem. Suspendisse nunc sem, " +
                            "pretium eget, cursus a, fringilla vel, urna.<br/><br/>Aliquam commodo ullamcorper erat. " +
                            "Nullam vel justo in neque porttitor laoreet. Aenean lacus dui, consequat eu, adipiscing eget, " +
                            "nonummy non, nisi. Morbi nunc est, dignissim non, ornare sed, luctus eu, massa. Vivamus eget quam. " +
                            "Vivamus tincidunt diam nec urna. Curabitur velit.\";";

        string dataID = string.Concat(this.Store1.ClientID, ".proxy.data");
        string push = string.Format(@"for (var i = 0; i < {0}.length; i++) {{{0}[i].push(desc_data);}}", dataID);

        this.ResourceManager1.RegisterClientScriptBlock("desc_data", desc);
        this.ResourceManager1.RegisterOnReadyScript(push);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>GridPanel with RowExpander Plugin - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />

    <script type="text/javascript">
        var template = '<span style="color:{0};">{1}</span>';

        var change = function (value) {
            return String.format(template, (value > 0) ? "green" : "red", value);
        }

        var pctChange = function (value) {
            return String.format(template, (value > 0) ? "green" : "red", value + "%");
        }
    </script>
</head>
<body scroll="no">
    <form runat="server">
        <ext:ResourceManager ID="ResourceManager1" runat="server" />
        
        <h1>GridPanel with RowExpander Plugin</h1>
        
        <ext:Store ID="Store1" runat="server" IgnoreExtraFields="false">
            <Reader>
                <ext:ArrayReader>
                    <Fields>
                        <ext:RecordField Name="company" />
                        <ext:RecordField Name="price" Type="Float" />
                        <ext:RecordField Name="change" Type="Float" />
                        <ext:RecordField Name="pctChange" Type="Float" />
                        <ext:RecordField Name="lastChange" Type="Date" DateFormat="M/d hh:mmtt" />
                        <ext:RecordField Name="industry" />
                        <ext:RecordField Name="desc" />
                    </Fields>
                </ext:ArrayReader>
            </Reader>
        </ext:Store>
        
        <ext:GridPanel 
            ID="GridPanel1" 
            runat="server" 
            StoreID="Store1" 
            TrackMouseOver="true"
            Title="RowExpander" 
            Collapsible="true" 
            AnimCollapse="true"
            Icon="Table" 
            Width="600" 
            Height="600">
            <ColumnModel runat="server">
                <Columns>
                    <ext:Column Header="Company" Width="40" DataIndex="company" />
                    <ext:Column Header="Price" Width="20" DataIndex="price">
                        <Renderer Format="UsMoney" />
                    </ext:Column>
                    <ext:Column Header="Change" Width="20" DataIndex="change">
                        <Renderer Fn="change" />
                    </ext:Column>
                    <ext:Column Header="Change" Width="20" DataIndex="pctChange">
                        <Renderer Fn="pctChange" />
                    </ext:Column>
                    <ext:DateColumn Header="Last Updated" Width="20" DataIndex="lastChange" />
                </Columns>
            </ColumnModel>
            <View>
                <ext:GridView ID="GridView1" runat="server" ForceFit="true" />
            </View>
            <SelectionModel>
                <ext:RowSelectionModel ID="RowSelectionModel1" runat="server" />
            </SelectionModel>
            <Plugins>
                <ext:RowExpander ID="RowExpander1" runat="server">
                    <Listeners>
                        <BeforeCollapse Handler="Ext.Msg.notify('Row collapsing', 'Row � ' + rowIndex);" />
                        <BeforeExpand Handler="Ext.Msg.notify('Row expanding', 'Row � ' + rowIndex);" />
                        <Collapse Handler="Ext.Msg.notify('Row collapsed', 'Row � ' + rowIndex);" />
                        <Expand Handler="Ext.Msg.notify('Row expanded', 'Row � ' + rowIndex);" />
                    </Listeners>
                    <Template ID="Template1" runat="server">
                        <Html>
							<p><b>Company:</b> {company}</p><br/>
							<p><b>Summary:</b> {desc}</p>
						</Html>
                    </Template>
                </ext:RowExpander>
            </Plugins>
        </ext:GridPanel>
    </form>
</body>
</html>
