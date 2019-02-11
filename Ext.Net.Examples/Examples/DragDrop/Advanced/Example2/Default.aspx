<%@ Page Language="C#" %>
<%@ Register assembly="Ext.Net" namespace="Ext.Net" tagprefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Drag&amp;Drop - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
    
    <style type="text/css">
        body {
            font-size: 11px;
            font-family: arial;
        }
        .dd-ct {
            position:absolute;
            border: 1px solid silver;
            width: 180px;
            height: 180px;
            top: 40px;
            background-color: #ffffc0;
        }
        #dd1-ct {
            left: 64px;
        }
        #dd2-ct {
            left: 256px;
        }
        .dd-item {
            height: 14px;
            border: 1px solid #a0a0a0;
            background-color: #c4d0ff;
            vertical-align: middle;
            cursor: move;
            padding: 2px;
            z-index: 1000;
            margin: 2px;
        }
        .dd-ct .dd-item {
            margin: 2px;
        }
        .dd-proxy {
            opacity: 0.4;
            -moz-opacity: 0.4;
            filter: alpha(opacity=40);
        }
        .dd-over {
            background-color: #ffff60;
        }
    </style>
    
    <ext:ResourcePlaceHolder runat="server" Mode="ScriptFiles" />
    
    <script type="text/javascript">
        function getDragData(e) {
            if (!this.ddel) {
                 this.ddel = document.createElement('div');
            }
            
            var target = Ext.get(e.getTarget());
            if (target.hasClass('dd-ct')) {
                return false;
            }
            return {ddel:this.ddel, item:target};
        }
    
        function onInitDrag(e) {
            this.ddel.innerHTML = this.dragData.item.dom.innerHTML;
            this.ddel.className = this.dragData.item.dom.className;
            this.ddel.style.width = this.dragData.item.getWidth() + "px";
            this.proxy.update(this.ddel);
        }
        
        function getRepairXY(e, data) {
            data.item.highlight('#e8edff');
            return data.item.getXY();
        }
        
        function notifyDrop(dd, e, data) {
            this.el.removeClass(this.overClass);
            this.el.appendChild(data.item);
            return true;
        }
    </script>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <a href="http://www.extjs.com/learn/Tutorial:Advanced_Custom_Drag_and_Drop_Part_2">Tutorial:Advanced Custom Drag and Drop Part 2</a>
        
        <ext:DragZone runat="server" Target="dd1-ct" Group="group" Scroll="false">
            <GetDragData Fn="getDragData" />
            <OnInitDrag Fn="onInitDrag" />
            <GetRepairXY Fn="getRepairXY" />
        </ext:DragZone>
        
        <ext:DragZone runat="server" Target="dd2-ct" Group="group" Scroll="false">
            <GetDragData Fn="getDragData" />
            <OnInitDrag Fn="onInitDrag" />
            <GetRepairXY Fn="getRepairXY" />
        </ext:DragZone>
        
        <ext:DropTarget runat="server" Target="dd1-ct" Group="group" OverClass="dd-over">
            <NotifyDrop Fn="notifyDrop" />
        </ext:DropTarget>
        
        <ext:DropTarget runat="server" Target="dd2-ct" Group="group" OverClass="dd-over">
            <NotifyDrop Fn="notifyDrop" />
        </ext:DropTarget>
        
        <div class="dd-ct" id="dd1-ct">
            <div class="dd-item" id="dd1-item1">Item 1.1</div>
            <div class="dd-item" id="dd1-item2">Item 1.2</div>
            <div class="dd-item" id="dd1-item3">Item 1.3</div>
        </div>
        <div class="dd-ct" id="dd2-ct">
            <div class="dd-item" id="dd2-item1">Item 2.1</div>
            <div class="dd-item" id="dd2-item2">Item 2.2</div>
            <div class="dd-item" id="dd2-item3">Item 2.3</div>
        </div>
        
    </form>    
</body>
</html>
