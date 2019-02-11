
// @source data/HttpProxy.js

Ext.data.HttpProxy.prototype.doRequest = Ext.data.HttpProxy.prototype.doRequest.createInterceptor(function (action, rs, params, reader, callback, scope, arg) {
    if (this.conn.json) {
        this.conn.jsonData = params;
    }
});