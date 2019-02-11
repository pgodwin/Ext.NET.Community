
// @source core/form/Checkbox.js

Ext.form.Checkbox.prototype.onRender = Ext.form.Checkbox.prototype.onRender.createSequence(function (ct, position) {
    if (!Ext.isEmpty(this.cls)) {
        this.wrap.addClass(this.cls);
    }
    
    if (!this.checked && (this.value === true || this.value === "true")) {
        this.setValue(true);
    }
    
    this.labelEl = this.wrap.child(".x-form-cb-label");
    this.applyBoxLabelCss();    
});

Ext.form.Checkbox.override({
    applyBoxLabelCss : function () {
        if (this.boxLabelCls) {
            this.setBoxLabelCls(this.boxLabelCls);
        }
        
        if (this.boxLabelStyle) {
            this.setBoxLabelStyle(this.boxLabelStyle);
        }
    },
    
    setBoxLabelStyle : function (style) {
        this.boxLabelStyle = style;

        if (this.labelEl) {
            this.labelEl.applyStyles(style);
        }
    },
    
    setBoxLabelCls : function (cls) {
        if (this.labeEl && this.boxLabelCls) {
            this.labelEl.removeClass(this.boxLabelCls);
        }
        
        this.boxLabelCls = cls;
        
        if (this.labelEl) {
            this.labelEl.addClass(this.boxLabelCls);
        }
    },
    
    setBoxLabel : function (label) {
        this.boxLabel = label;        
        
        if (this.rendered) {
            if (this.labelEl) {
                this.labelEl.update(label);
            } else {            
                this.labelEl = this.wrap.createChild({
                    tag     : "label",
                    htmlFor : this.el.id,
                    cls     : "x-form-cb-label",
                    html    : this.boxLabel
                });

                this.applyBoxLabelCss();
            }
        }
    }
});