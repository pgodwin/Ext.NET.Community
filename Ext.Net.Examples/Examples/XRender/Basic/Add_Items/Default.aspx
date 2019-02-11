<%@ Page Language="C#" %>

<%@ Import Namespace="Panel=Ext.Net.Panel" %>
<%@ Import Namespace="Ext.Net.Utilities" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<script runat="server">
    protected void Button1_Click(object sender, DirectEventArgs e)
    {
        var index = this.GetIndex();

        /*     TabPanel    */

        new Panel
        {
            ID = "Tab" + index,
            Title = "Tab " + index,
            Html = "Tab {0} : ({1})".FormatWith(index, DateTime.Now.ToLongTimeString()),
            Padding = 5,
            Border = false
        }.Render(this.TabPanel1, RenderMode.AddTo);
        
        this.TabPanel1.SetActiveTab("Tab" + index);
        
        /*     Accordion    */

        var p = new Panel
        {
            ID = "Panel" + index,
            Title = "Panel " + index,
            Html = "Panel {0} : ({1})".FormatWith(index, DateTime.Now.ToLongTimeString()),
            Padding = 5,
            Border = false
        };
        
        p.Expand();
        
        // You can call .Render and pass RenderMode.AddTo as the second param, or
        // p.Render(this.Panel1, RenderMode.AddTo);
        
        // call .AddTo Method which performs the same action as above line.
        p.AddTo(this.Panel1);
    }

    private int GetIndex()
    {
        var index = Convert.ToInt32(this.Hidden1.Text) + 1;
        
        this.Hidden1.Text = index.ToString();

        return index;
    }
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamically add a new Panel to a Parent Items Collection - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <h1>Dynamically add a new Panel to a Parent Items Collection</h1>
        
        <ext:Button runat="server" Text="Add Item" Icon="Add" OnDirectClick="Button1_Click" />
        
        <ext:Hidden ID="Hidden1" runat="server" Text="1" />
        
        <h2>Add a Tab Item</h2>
        
        <ext:TabPanel 
            ID="TabPanel1" 
            runat="server" 
            Height="185" 
            Width="350"
            EnableTabScroll="true">
            <Items>
                <ext:Panel runat="server" Title="Tab 1" Html="Tab 1" Padding="5" />
            </Items>
        </ext:TabPanel>
        
        <h2>Add an Accordion Item</h2>
        
        <ext:Panel 
            ID="Panel1" 
            runat="server" 
            Title="Accordion" 
            Height="185"
            Width="350"
            Layout="Accordion"
            AutoScroll="true">
            <Items>
                <ext:Panel runat="server" Title="Panel 1" Html="Panel 1" Padding="5" Border="false" />
            </Items>
        </ext:Panel>
    </form>
</body>
</html>