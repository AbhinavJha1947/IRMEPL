/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.MasterPageSplashStart = function(element) {
//    SGLREWeb.Scripts.MasterPageSplashStart.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.MasterPageSplashStart.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.MasterPageSplashStart.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.MasterPageSplashStart.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.MasterPageSplashStart.registerClass('SGLREWeb.Scripts.MasterPageSplashStart', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();

if(document.getElementById) {
	var upLevel = true;
	}
else if(document.layers) {
	var ns4 = true;
	}
else if(document.all) {
	var ie4 = true;
	}
function showObject(obj) 
{
}

function hideObject(obj) 
{
    if (ns4) {
	obj.visibility = "hide";
	}
    if (ie4 || upLevel) {
	obj.style.visibility = "hidden";
	}
}