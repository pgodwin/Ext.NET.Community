
// @source core/DatePicker.js

Ext.DatePicker.prototype.initComponent = Ext.DatePicker.prototype.initComponent.createSequence(function () {
    var fn = function () { 
        this.getInputField().setValue(this.getValue().dateFormat("Y-m-d\\Th:i:s")); 
    };
    
    this.on("render", fn, this);
    this.on("select", fn, this);
});

Ext.DatePicker.prototype.onRender = Ext.DatePicker.prototype.onRender.createSequence(function (el) {
    this.getInputField().render(this.el.parent() || this.el);    
    this.initValue();    
    this.setReadOnly(this.readOnly);
});

Ext.DatePicker.prototype.update = Ext.DatePicker.prototype.update.createSequence(function (date, forceRefresh) {
    if (date.getTime() != (this.value ? this.value.clearTime(true) : new Date().clearTime()).getTime()) {
        this.cells.removeClass("x-date-selected");    
    }
});

Ext.DatePicker.override({
    readOnly       : false,
    hideWithLabel  : true,
    isFormField    : true,
    
    getName        : Ext.form.Field.prototype.getName,
    initValue      : Ext.form.Field.prototype.initValue,
    isDirty        : Ext.form.Field.prototype.isDirty,
    reset          : Ext.form.Field.prototype.reset,
    isValid        : Ext.form.Field.prototype.isValid,
    validate       : Ext.form.Field.prototype.validate,
    processValue   : Ext.form.Field.prototype.processValue,
    validateValue  : Ext.form.Field.prototype.validateValue,
    clearInvalid   : Ext.emptyFn,
    markInvalid    : Ext.emptyFn,
    getRawValue    : Ext.form.Field.prototype.getValue,
    setRawValue    : Ext.form.Field.prototype.setValue,    
    getReadOnly    : Ext.form.Field.prototype.getReadOnly,
    adjustWidth    : Ext.form.Field.prototype.adjustWidth,
    hideNote       : Ext.form.Field.prototype.hideNote,
    showNote       : Ext.form.Field.prototype.showNote,
    hideFieldLabel : Ext.form.Field.prototype.hideFieldLabel,
    showFieldLabel : Ext.form.Field.prototype.showFieldLabel,
    initNote       : Ext.form.Field.prototype.initNote,
    
    getInputField : function () {
        if (!this.inputField) {
            this.inputField = new Ext.form.Hidden({ 
                id   : this.id + "_Input", 
                name : this.id + "_Input" 
            });
        }
        
        return this.inputField;
    },
    
    setReadOnly : function (readOnly) {
        if (this.rendered) {
            this.el.dom.readOnly = readOnly;
        }
        
        this.readOnly = readOnly;
        this.doDisabled(readOnly);
    }
});