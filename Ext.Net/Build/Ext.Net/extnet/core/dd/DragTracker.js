
// @source core/dd/DragTracker.js

Ext.net.DragTracker = function (config) {
    Ext.net.DragTracker.superclass.constructor.call(this, config);    
};

Ext.extend(Ext.net.DragTracker, Ext.dd.DragTracker, {
    proxyCls : "x-view-selector",
    
    onStart : function (xy) {
        if (!this.proxy) {
            this.proxy = this.el.createChild({ cls : this.proxyCls });
        } else {
            this.proxy.setDisplayed("block");
        }
    },

    onDrag : function (e) {
        var startXY = this.startXY,
            xy = this.getXY(),
            x = Math.min(startXY[0], xy[0]),
            y = Math.min(startXY[1], xy[1]),
            w = Math.abs(startXY[0] - xy[0]),
            h = Math.abs(startXY[1] - xy[1]);
        
        this.dragRegion.left = x;
        this.dragRegion.top = y;
        this.dragRegion.right = x + w;
        this.dragRegion.bottom = y + h;

        this.proxy.setRegion(this.dragRegion);	
    },

    onEnd : function (e) {
        if (this.proxy) {
            this.proxy.setDisplayed(false);
        }
    }
});

Ext.lib.Region.prototype.isIntersect = function (region) {
	var t = Math.max(this.top, region.top),
	    r = Math.min(this.right, region.right),
	    b = Math.min(this.bottom, region.bottom),
	    l = Math.max(this.left, region.left);

    return b >= t && r >= l;
};