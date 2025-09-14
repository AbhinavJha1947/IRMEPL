/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.MasterPageEvents = function(element) {
//    SGLREWeb.Scripts.MasterPageEvents.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.MasterPageEvents.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.MasterPageEvents.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.MasterPageEvents.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.MasterPageEvents.registerClass('SGLREWeb.Scripts.MasterPageEvents', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();

var lastKeyDown;
var MenuOK;
var MenuInventory;
var browser=navigator.appName;
var b_version=navigator.appVersion;
var version=parseFloat(b_version);
var tempX = 0;
var tempY = 0;
var message="";
var browserName=navigator.appName; 			
			
function StopF5andBackSpace()
{
    if (browserName=="Netscape")
    { 
        if(e.which == 116)
        {   
            e.which = 505;            
            if(e.which == 505)
            {
                return false;
            }
        }
        if ((e.which == 8))
        {   
            var str = e.srcElement.value;   
            if (str==undefined || e.srcElement.type== 'select-one' || event.srcElement.type== 'text')
            {
                return false; 
            }                   
        }
        if ((e.which == 13))
        {   
            var str = event.srcElement.value;
            
            if (e.srcElement.type== 'text' || e.srcElement.type== 'select-one')
            {
                return false; 
            }                   
        }
    }
    else
    {
        if(window.event && window.event.keyCode == 116)
        {   
            window.event.keyCode = 505;            
            if(window.event && window.event.keyCode == 505)
            {
                return false;
            }
        }
        if ((window.event.keyCode == 8))
        {   
            var str = event.srcElement.value;
            
            if (str==undefined || event.srcElement.type== 'select-one')
            {
                return false; 
            }                   
        }
        if ((window.event.keyCode == 13))
        {   
            var str = event.srcElement.value;
            
            if (str==undefined || event.srcElement.type== 'text' || event.srcElement.type== 'select-one')
            {
                return false; 
            }                   
        }
    }
}

if (browserName == "Netscape") {
    document.oncontextmenu = disableclick4FF;
    //document.onload = funLoad;
}
else 
{ 
    if (browserName=="Microsoft Internet Explorer")
    {
        document.onmousedown=disableclick;
    }
    else
    {
        alert("What ARE you browsing with here?");
    }
}

     
status="Right Click Disabled"
function disableclick(e) 
{
    if( event.button==2 )
    {
        //return true;
        alert("Sorry Right Click has been disabled for Internet Explorer!"); 
        return false;
    }
}

function disableclick4FF(e) 
{
    if(e.which==2||e.which==3)
    {
        //return true;
        alert("Sorry Right Click has been disabled!"); 
        return false;
    }
}
    
function createCookie(name,value,days) {
    if (days) {
        var date = new Date();
        date.setTime(date.getTime()+(days*24*60*60*1000));
        var expires = "; expires="+date.toGMTString();
    }
    else var expires = "";
    document.cookie = name+"="+value+expires+"; path=/";
}

function readCookie(name) {
    var nameEQ = name + "=";
    var ca = document.cookie.split(';');
    for(var i=0;i < ca.length;i++) {
        var c = ca[i];
        while (c.charAt(0)==' ') c = c.substring(1,c.length);
        if (c.indexOf(nameEQ) == 0) return c.substring(nameEQ.length,c.length);
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name,"",-1);
}
 
function funTheme(Theme)
{
    createCookie('WinXP_Blue',Theme,10)
}

			