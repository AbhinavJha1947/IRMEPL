/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.MasterPageSplashEnd = function(element) {
//    SGLREWeb.Scripts.MasterPageSplashEnd.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.MasterPageSplashEnd.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.MasterPageSplashEnd.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.MasterPageSplashEnd.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.MasterPageSplashEnd.registerClass('SGLREWeb.Scripts.MasterPageSplashEnd', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();

if(upLevel) 
{
    var splash = document.getElementById("splashScreen");
    //var search=document.getElementById("job search")
}
else if(ns4) 
{
    var splash = document.splashScreen;
}
else if(ie4) 
{
    var splash = document.all.splashScreen;
}
hideObject(splash);

