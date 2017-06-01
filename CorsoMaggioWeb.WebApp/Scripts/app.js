"use strict";
(function (global, $) {


    var App = {

        initMethods: [],

        registerInit: function(initializer){
            App.initMethods.push(initializer);
        },

        init: function(){
            App.ajax.init();

            $.each(App.initMethods, function (initializer) {
                initializer();
            });
        },
        utils: {
            ns: function (namespace, newObject) {
                var segments = namespace.split('.');
                var current = window;
                for (var i = 0; i < segments.length - 1; i++) {
                    if (!current[segments[i]])
                        current[segments[i]] = {};
                    
                    current = current[segments[i]];

                }

                if (newObject)
                    current[segments[segments.length - 1]] = newObject;
                else
                    if (!current[segments[segments.length - 1]])
                        current[segments[segments.length - 1]] = {};
                
            }
            
        }
    };


    App.ajax = {
        init: function () {

        }
    };


    /*
    var App2 = function(){
        var self = this;
        self.utils = {
            ns: App.utils.ns
        };
    }

    var app2 = new App2();
    
    app2.utils.ns('sefin.app2', app2);
    */

    App.utils.ns('sefin.app', App);
    App.utils.ns('sefin.corso');

    $(App.init);


     // su file del componente
     //sefin.app.registerInit(sefin.component.popovercontratto.init);
    
})(window,jQuery);

