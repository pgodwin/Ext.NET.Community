
// @source core/tree/TreeNode.js

Ext.override(Ext.tree.TreeNode, {
    removeChildren : function () {
        while (this.childNodes.length > 0) {
            this.removeChild(this.childNodes[0]);
        }
    },
    
    clone : function (newId) {
        var atts = this.attributes;
        
        atts.id = (newId !== false) ? Ext.id() : this.id;
        
        var clonedNode = new Ext.tree.TreeNode(Ext.apply({}, atts));
        clonedNode.text = this.text;

        for (var i = 0; i < this.childNodes.length; i++) {
            clonedNode.appendChild(this.childNodes[i].clone(newId));
        }
        
        return clonedNode;
    },
    
    // remove when the following topic will be marked as FIXED
    // http://www.extjs.com/forum/showthread.php?t=91506
    afterAdd : function (node, exists) {
        if (this.childrenRendered) {
            node.render();
        } else if (exists) {
            node.renderIndent(true, true);
        }
    }
});