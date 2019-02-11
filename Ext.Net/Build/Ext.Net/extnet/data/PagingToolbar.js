
// @source data/PagingToolbar.js

Ext.PagingToolbar.prototype.onRender = Ext.PagingToolbar.prototype.onRender.createSequence(function (el) {
    if (this.pageIndex) {
        if (this.store.getCount() === 0) {
            this.store.on("load", function () {
                this.changePage(this.pageIndex);
            }, this, { single : true });
        } else {
            this.changePage(this.pageIndex);
        }
    }
    
    this.on("change", function (el, data) {
        this.getActivePageField().setValue(data.activePage);
    }, this);
    
    this.getActivePageField().render(this.el.parent() || this.el);
    
    if (this.store.proxy.isMemoryProxy) {
        this.refresh.setHandler(function () {                    
            if (this.store.proxy.refreshData) {
                this.store.proxy.refreshData(null, this.store);
            }
            
            if (this.store.proxy.isUrl) {
                item.initialConfig.handler();
            }
        }, this);         
    }
    
    if (this.hideRefresh) {
        this.refresh.hide();
    }
});

Ext.PagingToolbar.override({
    hideRefresh: false,
    
    getActivePageField : function () {
        if (!this.activePageField) {
            this.activePageField = new Ext.form.Hidden({ 
                id   : this.id + "_ActivePage", 
                name : this.id + "_ActivePage" 
            });
        }
        
        return this.activePageField;
    }    
});