
// @source core/menu/Menu.js

Ext.override(Ext.menu.Menu, {
    enableScrolling : false,
    
    lastTargetIn : function (cmp) {
        return Ext.fly(cmp.getEl ? cmp.getEl() : cmp).contains(this.trg);
    },
    
    render : function (ct, position) {        
        if (!ct && this.floating && this.renderToForm === true) {
            ct = Ext.net.ResourceMgr.getAspForm() || Ext.getBody();
        }
        
        Ext.menu.Menu.superclass.render.call(this, ct, position);
    }
});