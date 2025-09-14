/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.downmessage = function(element) {
//    SGLREWeb.Scripts.downmessage.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.downmessage.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.downmessage.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.downmessage.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.downmessage.registerClass('SGLREWeb.Scripts.downmessage', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();
iens6=document.all||document.getElementById
ns4=document.layers

var thename
var inwidth
var inheight
var theswitch
var theobj
var thetext
var winHeight
var winPositionFromTop
var winWidth
var startH=2
var cnt=0
var openTimer
var MSG


function ietruebody()
{
return (document.compatMode && document.compatMode!="BackCompat")? document.documentElement : document.body
}

function fireMessage(text) {
    alert(text);
	/*
		theswitch='override'
		inwidth=200
		inheight=150
		
		thetext=text
	if(iens6)
		{
		thename = "viewer"
		theobj=document.getElementById? document.getElementById(thename):document.all.thename
		winHeight=100
			if(iens6&&document.all) {
				winPositionFromTop=!window.opera? ietruebody().clientHeight : document.body.clientHeight
				winWidth=(ietruebody().clientWidth-ietruebody().rightMargin)
			}
			if(iens6&&!document.all) {
				winPositionFromTop=window.innerHeight
				winWidth=(window.innerWidth-(ietruebody().offsetLeft+30))
			}
			if(theswitch=="override") {
				winWidth=inwidth
				winHeight=inheight
			}
			winPositionFromTop = 670
		theobj.style.width=winWidth+"px"
		theobj.style.height=startH+"px"

		if(iens6&&document.all)
		{
			theobj.style.top=ietruebody().scrollTop+winPositionFromTop+"px"
			window.status=winPositionFromTop
			theobj.innerHTML = ""
			//theobj.insertAdjacentHTML("BeforeEnd","<table cellspacing=0 width="+winWidth+" height="+winHeight+" border=0><tr><td align=center style='MARGIN-LEFT:auto;MARGIN-RIGHT:auto' width=1000px valign=top><font type='ARIAL' size='2' style='FONT-WEIGHT:bold;MARGIN-LEFT:auto;COLOR:red;MARGIN-RIGHT:auto'>"+thetext+"</font></td><td style='CURSOR:hand;background-color:Black;color:Red;' valign=top align=left><a onclick=decreseit();>X</a></td></tr></table>")    
			MSG="<table cellspacing=0 width="+winWidth+" border=0><tr style='background-color:Black;color:Red'><td align=center style='MARGIN-LEFT:auto;MARGIN-RIGHT:auto' width=90% valign=top><font type='ARIAL' size='2' style='FONT-WEIGHT:bold;MARGIN-LEFT:auto;MARGIN-RIGHT:auto'>Validation Message</font></td><td style='CURSOR:hand;width=10%' valign=top align=left><a onclick=decreseit();>X</a></td></tr><tr><td colspan=2 align=center style='MARGIN-LEFT:auto;MARGIN-RIGHT:auto' valign=top><font type='ARIAL' size='2' style='FONT-WEIGHT:bold;MARGIN-LEFT:auto;COLOR:red;MARGIN-RIGHT:auto'>"+thetext+"</font></td></tr></table>"
			theobj.insertAdjacentHTML("BeforeEnd",MSG)
			//decreseit()    
		}
		if(iens6&&!document.all)
		{
			theobj.style.top=window.pageYOffset+winPositionFromTop+"px"
			theobj.innerHTML = ""
			theobj.innerHTML="<table cellspacing=0 width="+winWidth+" height="+winHeight+" border=0><tr><td style='margin-right:auto;margin-left:auto' width=100% valign=top><font type='ARIAL' size='3' style='margin-right:auto;margin-left:auto;color:RED;font-weight:Bold'>"+thetext+"</font></td></tr></table>"
		}
	}
	
	viewIt()
	
	cnt=1
	*/
	
}

function viewIt() 
{
	
	if(startH<=winHeight) 
		{
			if(iens6) 
				{
					theobj.style.visibility="visible"
						if(iens6&&document.all) 
						{
							theobj.style.top=(ietruebody().scrollTop+winPositionFromTop)-startH+"px"
						}
						if(iens6&&!document.all) 
						{
							theobj.style.top=(window.pageYOffset+winPositionFromTop)-startH+"px"
						}
					theobj.style.height=startH+"px"
					startH+=5
					openTimer=setTimeout("viewIt()",10)
					//openTimer=setTimeout("decreseit()",6000)
					openTimer=setTimeout("decreseit()",6000)
				}
		}
	else
		{
			startH=2;
		}
}
function decreseit()
{
	
	if(iens6 && cnt!=0) 
				{
				     //var startHnew=5
				      var startHnew=0
					theobj.style.visibility="visible"
						if(iens6&&document.all) 
						{
						   	theobj.style.top=(ietruebody().scrollTop+winPositionFromTop)-startHnew+"px"
						}
						if(iens6&&!document.all) 
						{
							theobj.style.top=(ietruebody().scrollTop+winPositionFromTop)-startHnew+"px"
						}
						theobj.style.height=startHnew+"px"
						//startHnew+=5
						//openTimer=setTimeout("decreseit()",8000)
					
				}
	}

    
if (iens6)
{
	document.write("<div id='viewer' style='background-color:#FFFFC0;visibility:hidden;position:absolute;right:0;margin-right:auto;margin-left:auto;width:0;height:10;z-index:5;overflow:hidden;border:2px ridge yellow'></div>")
}

