<%@ Page Language="C#" %>

<%@ Register Assembly="Ext.Net" Namespace="Ext.Net" TagPrefix="ext" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DropDownField ValueText Mode - Ext.NET Examples</title>
    <link href="../../../../resources/css/examples.css" rel="stylesheet" type="text/css" />
    
    <script runat="server">
        protected void SetValueClick(object sender, DirectEventArgs e)
        {
            Field1.SetValue("N11,N12", "[Go jogging,Take a nap]");
        }
    </script>
    
    <script type="text/javascript">
            var getValues = function (tree) {
                var msg = [], 
                    selNodes = tree.getChecked();
                 
                Ext.each(selNodes, function (node) {
                    msg.push(node.id);
                });
                
                return msg.join(",");
            };
            
            var getText = function (tree) {
                var msg = [], 
                    selNodes = tree.getChecked();
                msg.push("[");   
                 
                Ext.each(selNodes, function (node) {
                    if (msg.length > 1) {
                        msg.push(",");
                    }
                    
                    msg.push(node.text);
                });
                
                msg.push("]");
                
                return msg.join("");
            };
            
            var syncValue = function(value){
                var tree = this.component;
                if (tree.rendered){
                   var ids = value.split(",");
                   tree.setChecked({ids: ids, silent: true});
                   
                   tree.getSelectionModel().clearSelections();
                   Ext.each(ids, function(id){
                       var node = tree.getNodeById(id);      
                       if (node) {
                         node.ensureVisible(function () {
                            tree.getSelectionModel().select(tree.getNodeById(this.id), null, true);
                         }, node);
                       }
                   }, this);
                   
                   
                }
            }
        </script>
</head>
<body>
    <form runat="server">
        <ext:ResourceManager runat="server" />
        
        <h1>DropDownField ValueText Mode</h1>
        
        <ext:DropDownField ID="Field1" runat="server" 
			    
			    UnderlyingValue="N22,N23"
			    Text="[Milk,Cereal]"
			    
			    Editable="false" 
			    Width="300" 
			    TriggerIcon="SimpleArrowDown" 
			    Mode="ValueText">
                <Component>
                    <ext:TreePanel 
                        runat="server" 
                        Title="My Task List"
                        Icon="Accept"
                        Height="300"
                        Shadow="None"
                        UseArrows="true"
                        AutoScroll="true"
                        Animate="true"
                        EnableDD="true"
                        ContainerScroll="true"
                        RootVisible="false">
                        <Root>
                            <ext:TreeNode>
                                <Nodes>
                                    <ext:TreeNode Text="To Do" Icon="Folder">
                                        <Nodes>
                                            <ext:TreeNode NodeID="N11" Text="Go jogging" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N12" Text="Take a nap" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N13" Text="Clean house" Leaf="true" Checked="False" />
                                        </Nodes>
                                    </ext:TreeNode>
                                    
                                    <ext:TreeNode Text="Grocery List" Icon="Folder">
                                        <Nodes>
                                            <ext:TreeNode NodeID="N21" Text="Bananas" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N22" Text="Milk" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N23" Text="Cereal" Leaf="true" Checked="False" />
                                            
                                            <ext:TreeNode Text="Energy foods" Icon="Folder">
                                                <Nodes>
                                                    <ext:TreeNode NodeID="N241" Text="Coffee" Leaf="true" Checked="False" />
                                                    <ext:TreeNode NodeID="N242" Text="Red Bull" Leaf="true" Checked="False" />
                                                </Nodes>
                                            </ext:TreeNode>
                                        </Nodes>
                                    </ext:TreeNode>
                                    
                                    <ext:TreeNode Text="Kitchen Remodel" Icon="Folder">
                                        <Nodes>
                                            <ext:TreeNode NodeID="N31" Text="Finish the budget" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N32" Text="Call contractors" Leaf="true" Checked="False" />
                                            <ext:TreeNode NodeID="N33" Text="Choose design" Leaf="true" Checked="False" />
                                        </Nodes>
                                    </ext:TreeNode>
                                </Nodes>
                            </ext:TreeNode>
                        </Root>
                        
                        <Buttons>
                            <ext:Button runat="server" Text="Close">
                                <Listeners>
                                    <Click Handler="#{Field1}.collapse();" />
                                </Listeners>
                            </ext:Button>
                        </Buttons>
                        
                        <Listeners>
                            <CheckChange Handler="this.dropDownField.setValue(getValues(this), getText(this), false);" />
                        </Listeners>
                        
                        <SelectionModel>
                            <ext:MultiSelectionModel runat="server" />
                        </SelectionModel>      
                     </ext:TreePanel>
                </Component>
                <Listeners>
                    <Expand Handler="this.component.getRootNode().expand(true);" Single="true" Delay="20" />
                </Listeners>
                <SyncValue Fn="syncValue" />
            </ext:DropDownField>
        
            <ext:Container ID="Ct1" runat="server" Layout="HBox">
                <Items>
                    <ext:Button runat="server" Text="Show Value">
                        <Listeners>
                            <Click Handler="alert(Field1.getValue());" />
                        </Listeners>
                    </ext:Button>
                    
                    <ext:Button runat="server" Text="Show Text">
                        <Listeners>
                            <Click Handler="alert(Field1.getText());" />
                        </Listeners>
                    </ext:Button>
                    
                    <ext:Button runat="server" Text="Set Value">
                        <DirectEvents>
                            <Click OnEvent="SetValueClick" />
                        </DirectEvents>
                    </ext:Button>
                </Items>
                <Listeners>
                    <AfterRender Handler="this.doLayout();" />
                </Listeners>
            </ext:Container>
   </form>
</body>
</html>
