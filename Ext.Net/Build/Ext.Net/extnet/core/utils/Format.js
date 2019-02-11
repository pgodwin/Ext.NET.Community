
// @source core/utils/Format.js

Ext.util.Format.usMoneyTemp = Ext.util.Format.usMoney;

Ext.util.Format.usMoney = function (v) {
    return Ext.util.Format.usMoneyTemp(String(v).replace(/[^0-9.\-]/g, ""));
};