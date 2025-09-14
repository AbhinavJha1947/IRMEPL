/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.General = function(element) {
//    SGLREWeb.Scripts.General.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.General.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.General.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.General.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.General.registerClass('SGLREWeb.Scripts.General', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();

function decreseit()
{
	if(iens6 && cnt!=0) 
    {
        var startHnew=575
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
    }
}
function NumChk(field)
{        
    if (browserName=="Netscape")            
        var keynum = e.which; 
    else            
        var keynum = window.event.keyCode;             
    
    var str = (field.value);                                
    var splstr = (field.value).split("/");                        
    var selectedText = document.selection;
    var browserName=navigator.appName; 
    
    if(keynum!=9 && ((!(keynum >46 && keynum <58)) || (splstr.length>2 && keynum ==47)))                       
        {
        if (browserName=="Netscape")
            {e.which=0; return 0;} 
        else
            {window.event.keyCode=0; return 0;}
        }
    else if (selectedText.type == 'None')        
    {
        if((keynum >46 && keynum <58) && (str.length==8 && splstr.length==1)) 
            {                
            if (browserName=="Netscape")
                {e.which=0; return 0;} 
            else
                {window.event.keyCode=0; return 0;}
            }   
    }      
}

// Strng Function Start
function StringFormat(field)
{
    if(trim(field.value)!="")
    {
    var sr="" ;
    var cnt=0;
    var sr1;
    var pt=0;
    sr=trim(field.value);
    sr1=sr.split(' ');
    for(pt;pt<sr1.length;pt++)
    {
         txt=sr1[pt]+" ";
         txt=txt.toLowerCase();
         txtl="";
         punc=",.?!:;)'";
         punc+='"';
         while ((txt.length>0)&&(txt.indexOf(" ")>-1))
         {
            pos=txt.indexOf(" ");
            wrd=txt.substring(0,pos);
            wrdpre="";
                if (punc.indexOf(wrd.substring(0,1))>-1)
                {
                    wrdpre=wrd.substring(0,1);
                    wrd=wrd.substring(1,wrd.length);
                }
                cmp=" "+wrd+" ";
                for (var i=0;i<9;i++)
                {
                    p=wrd.indexOf(punc.substring(i,i+1));
                    if (p==wrd.length-1){
                    cmp=" "+wrd.substring(0,wrd.length-1)+" ";
                    i=9;
                 }
           }
            if (cmp.indexOf(cmp)<0)
            {
                ltr=wrd.substring(0,1);
                ltr=ltr.toUpperCase();
                wrd=ltr+wrd.substring(1,wrd.length);
            }
            txtl+=wrdpre+wrd+" "; 
            txt=txt.substring((pos+1),txt.length);
        }
        ltr=txtl.substring(0,1);
        ltr=ltr.toUpperCase();
        txtl=ltr+txtl.substring(1,txtl.length-1);
       
        if(cnt==0)
        {
            field.value=txtl;
            cnt++;
        }
        else
        {
            field.value=field.value+ ' ' +txtl;
        }   
    }
   }
}
// Strng Function End

// Numeric Value Function Start
function CurrencyFormat(field, milSep, decSep, e ,ln) 
{        
    var sep = 0;
    var key = '';
    var i = j = 0;
    var len = len2 = 0;
    var strCheck = '0123456789';
    var aux = aux2 = '';             
    if(ln<=field.value.length && ln!=0) return false;
    var whichCode = (window.Event) ? e.which : e.keyCode;        
    if (whichCode == 13) return true;  // Enter
    if (whichCode == 8) return true;  // Delete
    key = String.fromCharCode(whichCode);  // Get key value from key code
    if (strCheck.indexOf(key) == -1) return false;  // Not a valid key
    len = field.value.length;
    for(i = 0; i < len; i++)
    if ((field.value.charAt(i) != '0') && (field.value.charAt(i) != decSep)) break;
    aux = '';
    for(; i < len; i++)
    if (strCheck.indexOf(field.value.charAt(i))!=-1) aux += field.value.charAt(i);
    aux += key;
    len = aux.length;
    if (len == 0) field.value = '';
    if (len == 1) field.value = '0'+ decSep + '0' + aux;
    if (len == 2) field.value = '0'+ decSep + aux;
    if (len > 2) 
    {
        aux2 = '';
        for (j = 0, i = len - 3; i >= 0; i--) {
            if (j == 3) {
                aux2 += milSep;
                j = 0;
            }
            aux2 += aux.charAt(i);
            j++;
        }
        field.value = '';
        len2 = aux2.length;
        for (i = len2 - 1; i >= 0; i--)
        field.value += aux2.charAt(i);
        field.value += decSep + aux.substr(len - 2, len);
    }
    return false;
}
function GramFormat(field, milSep, decSep, e ,ln) 
{        
    var sep = 0;
    var key = '';
    var i = j = 0;
    var len = len2 = 0;
    var strCheck = '0123456789';
    var aux = aux2 = '';             
    if(ln<=field.value.length && ln!=0) return false;
    var whichCode = (window.Event) ? e.which : e.keyCode;        
    if (whichCode == 13) return true;  // Enter
    if (whichCode == 8) return true;  // Delete
    key = String.fromCharCode(whichCode);  // Get key value from key code
    if (strCheck.indexOf(key) == -1) return false;  // Not a valid key
    len = field.value.length;
    for(i = 0; i < len; i++)
    if ((field.value.charAt(i) != '0') && (field.value.charAt(i) != decSep)) break;
    aux = '';
    for(; i < len; i++)
    if (strCheck.indexOf(field.value.charAt(i))!=-1) aux += field.value.charAt(i);
    aux += key;
    len = aux.length;
    if (len == 0) field.value = '';
    if (len == 1) field.value = '0'+ decSep + '00' + aux;
    if (len == 2) field.value = '0'+ decSep + '0' + aux;
    if (len == 3) field.value = '0'+ decSep + aux;
    if (len > 3) 
    {
        aux2 = '';
        for (j = 0, i = len - 4; i >= 0; i--) {
            if (j == 4) {
                aux2 += milSep;
                j = 0;
            }
            aux2 += aux.charAt(i);
            j++;
        }
        field.value = '';
        len2 = aux2.length;
        for (i = len2 - 1; i >= 0; i--)
        field.value += aux2.charAt(i);
        field.value += decSep + aux.substr(len - 3, len);
    }
    return false;
}

function ChkNumber(field, e ,ln) 
{        
    var strCheck = '0123456789';
    if(ln<=field.value.length && ln!=0) return false;
    var whichCode = (window.Event) ? e.which : e.keyCode;        
    if (whichCode == 13) return true;  // Enter
    if (whichCode == 8) return true;  // Delete
    key = String.fromCharCode(whichCode);  // Get key value from key code        
    if (strCheck.indexOf(key) == -1) 
        {
            e.keyCode=0;
            return false;  // Not a valid key        
        }
}
// Numeric Value Function End

//Only characters 
function charsOnlyForFName(field)
{
    var checkOK = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
    var checkStr = field.value;
    var allValid = true;
    for (i = 0;  i < checkStr.length;  i++)
    {
        ch = checkStr.charAt(i);
            for (j = 0;  j < checkOK.length;  j++)
                if (ch == checkOK.charAt(j))
                break;
                if (j == checkOK.length)
                {
                    allValid = false;
                    break;
                }
    }
    if (!allValid)
    {
      field.select();
      field.focus();
      fireMessage("Please enter only characters.");
      return true;
    }
}

function readonlyText()
{
    return false
} 

function GetQueryString(ji) 
{
    hu = window.location.search.substring(1);
    gy = hu.split("&");
    for (i=0;i<gy.length;i++) 
    {    
        ft = gy[i].split("=");
        if (ft[0] == ji) 
        {
            return ft[1];
        }
    }
}
// Screen Lock Start
function usr_LockScreen() {
    scroll(0, 0);
    var back = document.getElementById('usr_LockBackground');
    var pane = document.getElementById('usr_LockPane');
    var text = document.getElementById('usr_LockPaneText');
    if (back)
        back.className = 'LockBackground';
    if (pane)
        pane.className = 'LockPane';
    if (text)
        text.innerHTML = "Processing Request...";
    DisableAllddl();
}

function usr_ReleaseLockScreen() {
    scroll(0, 0);
    var back = document.getElementById('usr_LockBackground');
    var pane = document.getElementById('usr_LockPane');
    var text = document.getElementById('usr_LockPaneText');
    if (back)
        back.className = 'LockOff';
    if (pane)
        pane.className = 'LockOff';
    if (text)
        text.innerHTML = "";
    EableAllddl();
}

function DisableAllddl()
{
    var Optioncontrols=document.getElementsByTagName('select');
    for(var i=0;i<Optioncontrols.length;i++)
    {
        if (Optioncontrols[i].disabled==false)
            Optioncontrols[i].title='Chg';
        Optioncontrols[i].disabled=true;
    }      
}

function EableAllddl()
{
    var Optioncontrols=document.getElementsByTagName('select');
    for(var i=0;i<Optioncontrols.length;i++)
    {
        if (Optioncontrols[i].title=='Chg')
            Optioncontrols[i].disabled=false;  
    }      
}
// Screen Lock End

// DropDown Start
function KeySortDropDownList_onkeypress(dropdownlist,caseSensitive) 
{
	if (caseSensitive=='undefined')
	{
		caseSensitive=false;
	}

	var undefined; 
	if (dropdownlist.keypressBuffer == undefined)
	{ 
		dropdownlist.keypressBuffer = ''; 
		
	} 
	// get the key that was pressed 
	var key = String.fromCharCode(window.event.keyCode); 
	dropdownlist.keypressBuffer += key;
	
			
	if (!caseSensitive) 
	{
		// convert buffer to lowercase
		dropdownlist.keypressBuffer = dropdownlist.keypressBuffer.toLowerCase();
	}
	// find if it is the start of any of the options 
	var optionsLength = dropdownlist.options.length; 
	for (var n=0; n < optionsLength; n++) 
	{ 
		var optionText = dropdownlist.options[n].text; 
		if (!caseSensitive) 
		{
			optionText = optionText.toLowerCase();
		}
		if (optionText.indexOf(dropdownlist.keypressBuffer,0) == 0) 
		{ 
			dropdownlist.selectedIndex = n; 
			return false; 
			// cancel the default behavior since 
			// we have selected our own value 
		} 
	} 
	// reset initial key to be inline with default behavior 
	dropdownlist.keypressBuffer = key; 
	return false; // give default behavior
} 

function SwpItem(dropdownlist)
{
 	if(dropdownlist.options.length>0)
    {
        for (var n=0; n < dropdownlist.options.length; n++) 
	    { 
	        var dropdowntext=dropdownlist.options[n].text ; 
		    var splstr1 = (dropdowntext).split("(");        
		    var splstr2 = (splstr1[1]).split(")");        
		    dropdownlist.options[n].text = trim(splstr2[0]) + " (" + trim(splstr1[0]) + ")" ; 
		    
	    } 	        
    }	
}

// ToolTip Functon 
function checkEvent(e) 
{
	if (!e) var e = window.event;
	if (e.target) targ = e.target;
	else if (e.srcElement) targ = e.srcElement;
	showHideToolTip(targ, e, e.type)
}
// This function shows/hides the tooltip
function showHideToolTip (theDropDown, e, eType)
{
 	if(theDropDown.selectedIndex != -1)
	{
	    var toolTipObj = new Object();
	    toolTipObj = document.getElementById("tooltip");
	    if(theDropDown.selectedIndex>0)
	    {
	        toolTipObj.innerHTML = theDropDown.options[theDropDown.selectedIndex].innerText;
	        if(eType == "mouseout")
	        {
		        toolTipObj.style.display = "none";
	        } 
	        else
	        {
		    toolTipObj.style.display = "inline";
		    toolTipObj.style.top = -2;
		    toolTipObj.style.left = 400;
		    toolTipObj.style.width = 250;
		    toolTipObj.style.height = 5;
	        }
        }
	}
	
}
//End

// This function shows/hides the tooltip
function TxtshowHideToolTip (theDropDown, e, eType)
{
	if(theDropDown.value != '' || theDropDown.value != "" || theDropDown.value != null)
	{
	    var toolTipObj = new Object();
	    toolTipObj = document.getElementById("tooltip");
	    toolTipObj.innerHTML = theDropDown.value;
	    if(eType == "mouseout")
	    {
		    toolTipObj.style.display = "none";
	    } 
	    else
	    {
		    toolTipObj.style.display = "inline";
		    toolTipObj.style.top = e.y + -75;
		    toolTipObj.style.left = e.x + 10;
	    }
	}
}
// Textbox ToolTip Functon 
function TxtcheckEvent(e) 
{
//	//debugger;
//	if (!e) var e = window.event;
//	if (e.target) targ = e.target;
//	else if (e.srcElement) targ = e.srcElement;
//	TxtshowHideToolTip(targ, e, e.type)
}
// DropDown End