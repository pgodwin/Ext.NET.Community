﻿<%@ Page Language="C#" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body style="padding:10px;">
    <% System.Threading.Thread.Sleep(1000); %>
    
    Child page creation time:&nbsp;
    <%= DateTime.Now.ToLongTimeString() %>
</body>
</html>
