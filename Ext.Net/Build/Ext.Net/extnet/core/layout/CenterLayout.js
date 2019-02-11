
// @source core/layout/CenterLayout.js

Ext.ux.layout.CenterLayout = Ext.extend(Ext.layout.FitLayout, {
    // private
    layout : function () {
        if (Ext.isEmpty(Ext.fly("ux.center_css"))) {
            var css = ".ux-layout-center-item{margin:0 auto;text-align:left;}";
            Ext.util.CSS.createStyleSheet(css, "ux.center_css");
        }
        
        Ext.ux.layout.CenterLayout.superclass.layout.call(this);
    },
    
    setItemSize : function (item, size) {        
        this.container.addClass("ux-layout-center");        
        
        if (item && size.height > 0) {
			item.addClass("ux-layout-center-item");

            if (item.width) {
                size.width = item.width;
            }
            
            item.setSize(size);
        }
    }
});

Ext.Container.LAYOUTS["ux.center"] = Ext.ux.layout.CenterLayout;