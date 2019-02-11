Ext.ns("Ext.net", "Ext.net.DirectMethods", "Ext.ux", "Ext.ux.plugins", "Ext.ux.layout");

Ext.net.Version = "1.0.0";

(function () {
    // IE9 fixes
    var docMode = document.documentMode,
        ua = navigator.userAgent.toLowerCase(),
        check = function (r) {
            return r.test(ua);
        };
    
    Ext.isIE7 = Ext.isIE && (check(/msie 7/) || docMode === 7);
    Ext.isIE8 = Ext.isIE && ((check(/msie 8/) && docMode !== 7 && docMode !== 9) || docMode === 8);
    Ext.isIE9 = Ext.isIE && ((check(/msie 9/) && docMode !== 7 && docMode !== 8) || docMode === 9);
    Ext.isIE6 = Ext.isIE && !Ext.isIE7 && !Ext.isIE8 && !Ext.isIE9;

    if ((typeof Range !== "undefined") && !Range.prototype.createContextualFragment) {
	    Range.prototype.createContextualFragment = function (html) {
		    var frag = document.createDocumentFragment(), 
		        div = document.createElement("div");

		    frag.appendChild(div);
		    div.outerHTML = html;
		    
            return frag;
	    };
    }

    Ext.Element.addMethods({
        getAttribute : Ext.isIE && !Ext.isIE9 ?
            function (name, ns) {
                var d = this.dom,
                    type;

                if (ns) {
                    type = typeof d[ns + ":" + name];
                
                    if (type !== "undefined" && type !== "unknown") {
                        return d[ns + ":" + name] || null;
                    }
                
                    return null;
                }

                if (name === "for") {
                    name = "htmlFor";
                }
                
                return d[name] || null;
            } : function (name, ns) {

                var d = this.dom;
            
                if (ns) {
                    if (d.getAttributeNS) {
                        return d.getAttributeNS(ns, name) || d.getAttribute(ns + ":" + name);
                    } else {
                        return d.getAttribute(ns + ":" + name);
                    }
                }

                return d.getAttribute(name) || d[name] || null;
            }
    });

    Ext.removeNode = (Ext.isIE && !Ext.isIE8 && !Ext.isIE9) ? function () {
        var d;

        return function (n) {
            if (n && n.tagName !== "BODY") {
                if (Ext.enableNestedListenerRemoval === true) {
                    Ext.EventManager.purgeElement(n, true);
                } else {
                    Ext.EventManager.removeAll(n);
                }

                d = d || document.createElement("div");
                d.appendChild(n);
                d.innerHTML = "";

                delete Ext.elCache[n.id];
            }
        };
    }() : function (n) {
        if (n && n.parentNode && n.tagName !== "BODY") {
            if (Ext.enableNestedListenerRemoval === true) {
                Ext.EventManager.purgeElement(n, true);
            } else {
                Ext.EventManager.removeAll(n);
            }

            n.parentNode.removeChild(n);
            
            delete Ext.elCache[n.id];
        }
    };
    
    Ext.Resizable.Handle.override({            
        onMouseOver : function () {
            if (this.enabled) {
                this.el.addClass("x-resizable-over");
            }
            
            if (this.transparent && Ext.isIE9) {
                this.el.dom.opacity = "";
            }
        }
    });
})();