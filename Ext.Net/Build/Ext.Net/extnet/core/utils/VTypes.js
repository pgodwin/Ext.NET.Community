
// @source core/utils/VTypes.js

Ext.apply(Ext.form.VTypes, {
    daterange : function (val, field) {
        var date = field.parseDate(val);

        if (date) {
            if (field.startDateField && (!field.dateRangeMax || (date.getTime() != field.dateRangeMax.getTime()))) {
                var start = Ext.getCmp(field.startDateField);
                
                if (start) {
                    start.setMaxValue(date);
                    field.dateRangeMax = date;
                    start.validate();                
                }
            } else if (field.endDateField && (!field.dateRangeMin || (date.getTime() != field.dateRangeMin.getTime()))) {
                var end = Ext.getCmp(field.endDateField);
                
                if (end) {
                    end.setMinValue(date);
                    field.dateRangeMin = date;
                    end.validate();                
                }
            }
        }
        
        /*
         * Always return true since we're only using this vtype to set the
         * min/max allowed values (these are tested for after the vtype test)
         */
        return true;
    },
    
    password : function (val, field) {
        if (field.initialPassField) {
            var pwd = Ext.getCmp(field.initialPassField);
            return pwd ? (val == pwd.getValue()) : false;
        }
        
        return true;
    },

    passwordText : "Passwords do not match"
});