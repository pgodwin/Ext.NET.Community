<%@ Page Language="C#" %>

<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>
    
<script runat="server">
    protected void CheckField(object sender, RemoteValidationEventArgs e)
    {
        TextField field = (TextField)sender;
        
        if (field.Text == "Valid")
        {
            e.Success = true;
        }
        else
        {
            e.Success = false;
            e.ErrorMessage = "'Valid' is valid value only";
        }

        System.Threading.Thread.Sleep(1000);          
    }
</script>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Remote Validation - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
       
        <ext:FormPanel 
            runat="server" 
            Title="Remote Validation Form" 
            Padding="5"
            Frame="true"
            LabelWidth="250"
            MonitorValid="true"
            Width="500"             
            DefaultAnchor="-20"
            Height="200">
            <Items>
                <ext:TextField runat="server" FieldLabel="No validation" />
                <ext:TextField runat="server" FieldLabel="Client only validation" AllowBlank="false" />
                <ext:TextField runat="server" FieldLabel="Server only validation" IsRemoteValidation="true">
                    <RemoteValidation OnValidation="CheckField" />
                </ext:TextField>
                
                <ext:TextField runat="server" FieldLabel="Client and server validation" IsRemoteValidation="true" AllowBlank="false">
                    <RemoteValidation OnValidation="CheckField" />                    
                </ext:TextField>
                
                <ext:TextField runat="server" FieldLabel="Client and server validation (web service)" IsRemoteValidation="true" AllowBlank="false">
                    <RemoteValidation Url="ValidationService.asmx/CheckField" Json="true" />                    
                </ext:TextField>
            </Items>
            <Buttons>
                <ext:Button ID="Button1" runat="server" Text="Submit" FormBind="true" />
            </Buttons>
            <Listeners>
                <ClientValidation Handler="#{Button1}.setDisabled(!valid);" />
            </Listeners>
       </ext:FormPanel>
    </form>    
</body>
</html>
