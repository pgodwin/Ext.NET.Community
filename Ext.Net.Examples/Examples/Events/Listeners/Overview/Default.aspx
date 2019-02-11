<%@ Page Language="C#" %>

<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<script runat="server">
    protected void Page_Load(object sender, EventArgs e)
    {
        // Define a generic JavaScript function to use later
        string fn = "Ext.Msg.alert('Confirm', String.format('You Clicked {0}', el.id));";

        // 2. Click Listener from Code-Behind
        this.Button2.Listeners.Click.Handler = fn;

        // 3. Click Listener using .On() method
        this.Button3.On("click", "function(el) {" + fn + "}");

        // 4. Click Listener using .AddListener() method
        this.Button4.AddListener("click", "function(el) {" + fn + "}");

        // 11. Click Listener which only fires once (set from code-behind)
        this.Button11.Listeners.Click.Handler = fn;
        this.Button11.Listeners.Click.Single = true;

        // 12. Click Listener which only fires after 1.5 seconds (set from code-behind)
        this.Button12.Listeners.Click.Fn = "myCustomFn";
        this.Button12.Listeners.Click.Delay = 1500;
    }
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Click Listener to Button - Ext.NET Examples</title>
    
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        .example { 
            padding: 30px; 
        }
    </style>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server">
            <Listeners>
                <DocumentReady Handler="this.Button5.on('click', function (el) { Ext.Msg.alert('Confirm', String.format('You Clicked {0}', el.id)); });" />
            </Listeners>
        </ext:ResourceManager>
        
        <script type="text/javascript">
            var myCustomFn = function (el) {
                Ext.Msg.alert('Confirm', String.format('You Clicked {0}', el.id));
            };
        </script>
    
        <h1>Add Click Listener to Button (or any Ext.Net/Ext Control)</h1>
        
        <p>A "Listener" is a client-side event Handler. The event handler will call a client-side JavaScript function if the Listener has been configured.</p>

        <h2>1. Click Listener (set in markup)</h2>
        
            <ext:Button ID="Button1" runat="server" Text="Button #1">
                <Listeners>
                    <Click Handler="Ext.Msg.alert('Confirm', 'You Clicked Button1');" />
                </Listeners>
            </ext:Button>
        
        
       <h2>2. Click Listener from Code-Behind</h2>
        
            <ext:Button ID="Button2" runat="server" Text="Button #2" />
        
        
        <h2>3. Click Listener using .On() method</h2>
        
            <ext:Button ID="Button3" runat="server" Text="Button #3" />
        
        
       <h2>4. Click Listener using .AddListener() method</h2>
        
            <ext:Button ID="Button4" runat="server" Text="Button #4" />
        
        
         <h2>5. Click Listener using inline JavaScript</h2>
        
            <ext:Button ID="Button5" runat="server" Text="Button #5" />
        
        
        <h2>6. Click Listener added from Click Listener of another Control</h2>
        
            <ext:Button ID="btnAddClick" runat="server" Text="Add Click Listener to Button #6">
                <Listeners>
                    <Click Handler="Button6.on('click', function () {Ext.Msg.alert('Confirm', 'You Clicked the Button6')});" />
                </Listeners>
            </ext:Button>
            <br />
            <ext:Button ID="Button6" runat="server" Text="Button #6" />
        
            
        <h2>7. Click Listener calling custom JavaScript function by name (set "Handler" Property)</h2>
        
            <ext:Button ID="Button7" runat="server" Text="Button #7">
                <Listeners>
                    <Click Handler="={myCustomFn}" />
                </Listeners>
            </ext:Button>
        

        <h2>8. Click Listener calling custom JavaScript function by name (set "Fn" Property)</h2>
        
            <ext:Button ID="Button8" runat="server" Text="Button #8">
                <Listeners>
                    <Click Fn="myCustomFn" />
                </Listeners>
            </ext:Button>
        
        
        <h2>9. Click Listener which only fires once (set in markup)</h2>
        
            <ext:Button ID="Button9" runat="server" Text="Button #9">
                <Listeners>
                    <Click Fn="myCustomFn" Single="true" />
                </Listeners>
            </ext:Button>
        

        <h2>10. Click Listener which only fires after 1.5 seconds (set in markup)</h2>
        
            <ext:Button ID="Button10" runat="server" Text="Button #10">
                <Listeners>
                    <Click Fn="myCustomFn" Delay="1500" />
                </Listeners>
            </ext:Button>
        
            
        <h2>11. Click Listener which only fires once (set from code-behind)</h2>
        
            <ext:Button ID="Button11" runat="server" Text="Button #11" />
        

        <h2>12. Click Listener which only fires after 1.5 seconds (set from code-behind)</h2>
        
            <ext:Button ID="Button12" runat="server" Text="Button #12" />
        
    </form>
</body>
</html>