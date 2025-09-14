/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.validations = function(element) {
//    SGLREWeb.Scripts.validations.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.validations.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.validations.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.validations.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.validations.registerClass('SGLREWeb.Scripts.validations', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();

//***********************************************************************
//Project name	:	Web Application
//Module		:	General
//Description	:	Common Javascript for input validation at client side 
//			
//Developed by	:	
//Release Date	:	30-6-2004
//***********************************************************************
//.........Formatted string to check text entered by User................
var spNChar=/^[a-zA-Z0-9 ]/;
var spChar=/^[a-zA-Z ]/;
var spNums=/^[0-9]/;
var spFloat=/^[.0-9]/;
var spAlphaDec=/^[a-zA-Z.0-9]/;
var dtCh= "-";
//.........Global Wrapper function will be called from each form and each
// control validation....................................................
/*		Parameter		Desciprtion
		PassCtl		:	Control name to be validated	
		ValidType   :	Validation type e.g. "B","N","A" detail specified below
		CustomName	:	Name string to be displayed in message box
		Min			:	Minimum value
		Max			:	Maximum value
		Expression	:	Regular expression to be validated */
		
	MsgSelectDeactivateEligible = "You have not selected any record for Deactivation. \nPlease select record(s) to DEACTIVATE." ;
	MsgSelectEditEligibleOne= "You have not selected any record for Editing. \nPlease select a record to EDIT." ;
	MsgSelectEditEligibleOne1= "You have not selected any record for Viewing. \nPlease select a record to View." ;
	MsgSelectAssignEligibleOne= "You have not selected any record for Assigning Visual. \nPlease select a record to Assign Visual." ;
	MsgSelectDeleteEligible = "You have not selected any record for Deleting. \nPlease select record(s) to DELETE." ;
	MsgSelectAssignEligibleMore = "You have selected more than one record for Assigning Visual.\nPlease select only one record to Assign Visual." ;
	//MsgSelectAssignEligibleOne= "You have not selected any record for Assigning/Removing. \nPlease select a record to ASSIGN/REMOVE." ;
	//MsgSelectEditEligibleMore= "You have selected more than one record for Assigning/Removing.\nPlease select only one record to ASSIGN/REMOVE." ;
	MsgSelectEditEligibleMore= "You have selected more than one record for Editing.\nPlease select only one record to Edit." ;
	MsgSelectEditEligibleMore1= "You have selected more than one record for Viewing.\nPlease select only one record to View." ;
	MsgSendConfirm = "Are you sure you want to SEND this message?";
	MsgAssignConfirm = "Are you sure you want to Assign?";
	MsgSaveConfirm = "Are you sure you want to SAVE the record?";
	//MsgSaveConfirm1 = "Do you really want to generate the call and inward the material ?";
	MsgDeleteConfirm = "Are you sure you want to DELETE the record(s)?";
	MsgDeactivateConfirm = "Are you sure you want to DEACTIVATE the record(s)?";
	MsgContinueConfirm="Are you sure you want to Continue?";
	MsgScheduleConfirm="Are you sure you want to Schedule?";
	MsgScheduleUpdateConfirm="All previous initial inspection scheduled will be set to inactive. Are you sure you want to Continue?";
	MsgPocketPCReturn="You are about to update the Pocket PC's return. Are you sure you want to Continue?";
	MsgSelectActivateOnly="One or more selected records are already deactivated.\n Please select only active records to DEACTIATE."
	MsgSelectReturn="You have not selected any Pocket PC To Return . \nPlease select Pocket PC(s) to Return."
	MsgReturnConfirm = "Are you sure you want to Return the Pocket PC(s)?";
	
function ValidateForm(PassCtl,ValidType,CustomName,Min,Max,Expression)
{
	
	//................Standard Message Strings...........................
	//CustomName = " Field " + CustomName;
	MsgBlank ="Please enter " + CustomName;
	MsgNumber = "Please enter digits in " + CustomName + ".";
	MsgValidAlpha = "Please enter alphabetic characters in " + CustomName + ".";
	MsgValidAlphaNum="Please enter alpha-numeric characters in " + CustomName + ".";
	MsgValidAlphaDec="Please enter alphabets or Decimal characters in " + CustomName + ".";
	MsgValidFloat="Please enter valid number in " + CustomName + ".";
	
	MsgLowRange = "Please enter less then " + Max + " characters in " + CustomName + ".";
	MsgHighRange = "Please enter more then " + Min + " characters in " + CustomName + ".";
	MsgHighRanged = "Please Enter " + Min + " characters in " + CustomName + ".";
	MsgLowValue ="Please enter value less than or equal to " + Max + " in " + CustomName + ".";
	MsgHighValue = "Please enter value more than or equal to " + Min + " in " + CustomName + ".";
	MsgCustomFormat = "Please enter value in : {" + Expression + "} format." ;
	MsgDecFormat = "Please enter only Decimal values" ;
	MsgValidEmail = "Please enter valid Email in " + CustomName + ".";
	MsgDateCompare = "Date should be less than or equal to current date"
	MsgValidPhoneNoFormat="Please enter proper formats in " + CustomName + ".";
	
	if (PassCtl==null)
	{
	    return true;
	}
	
	if(PassCtl.type=="select-one")
	    {
	     MsgBlank=MsgBlank.replace("enter","Select");   
	    }
	
	//................Executes respective function accroding to ValidType............
	
	Cases =new Array;
	var types;
	types=ValidType;
	Cases=types.split(",");
	var i=0;
	for(i;i<Cases.length;i++)
	{
	    switch(Cases[i])
	    {
		    case "B": //Blank validation
			    if(Cases.length==1)
			    {
			        return	IsBlank(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			            if(!IsBlank(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			          if(!IsBlank(PassCtl)){return false;}  
			        }
			        
			    }   
			    //
			    break;
		    case "NB": // Number validation
			    //return IsNumberAllowNull(PassCtl)
			    
			    if(Cases.length==1)
			    {
			        return IsNumberAllowNull(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			             if(!IsNumberAllowNull(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			          if(!IsNumberAllowNull(PassCtl)){return false;}  
			        } 
			     }    
			    //if(!IsNumberAllowNull(PassCtl)){return false;}
			    break;
		    case "N": // Number validation
			    if(Cases.length==1)
			    {
			        return IsNumber(PassCtl,Min,Max)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			            if(!IsNumber(PassCtl,Min,Max)){return false;}else{return true;}
			        }
			        else
			        {
			          if(!IsNumber(PassCtl,Min,Max)){return false;}
			        }
			    }
			    break;	
		    case "A": // Alphabetic string validation
			    //return IsValidString(PassCtl)
			    if(Cases.length==1)
			    {
			        return IsValidString(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			            if(!IsValidString(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsValidString(PassCtl)){return false;}
			        } 
			     } 
			    // if(!IsValidString(PassCtl)){return false;}
			    break;
		    case "AB": // Alphabetic string validation
			    //return IsValidStringAllowNull(PassCtl)
			    
			    if(Cases.length==1)
			    {
			        return IsValidStringAllowNull(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsValidStringAllowNull(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsValidStringAllowNull(PassCtl)){return false;}
			        } 
			     }
			    
			    //if(!IsValidStringAllowNull(PassCtl)){return false;}
			    break;	
		    case "AN": //Alpha-Numeric string validation
			    //return IsAlphaNumeric(PassCtl)
			    
			    
			    if(Cases.length==1)
			    {
			        return IsAlphaNumeric(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsAlphaNumeric(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsAlphaNumeric(PassCtl)){return false;}
			        } 
			     }
			    //if(!IsAlphaNumeric(PassCtl)){return false;}
			    break;
			   case "AD": //Alpha-Decimal string validation
			    if(Cases.length==1)
			    {
			        return IsAlphaDecimal(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsAlphaDecimal(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsAlphaDecimal(PassCtl)){return false;}
			        } 
			     }
			    //if(!IsAlphaNumeric(PassCtl)){return false;}
			    break; 
			     
			  case "L1": 
			    //if(!IsValidLengths(PassCtl,Min,Max)){return false;}
			    if(Cases.length==1)
			    {
			        return IsValidLengths(PassCtl,Min,Max)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsValidLengths(PassCtl,Min,Max)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsValidLengths(PassCtl,Min,Max)){return false;}
			        } 
			     }
			    break;
			  
			    
		    case "L": //Length validation
			   // return IsValidLength(PassCtl,Min,Max)
			   
			   if(Cases.length==1)
			    {
			        return IsValidLength(PassCtl,Min,Max)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsValidLength(PassCtl,Min,Max)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsValidLength(PassCtl,Min,Max)){return false;}
			        } 
			     }
			     //if(!IsValidLength(PassCtl,Min,Max)){return false;}
			    break;
		    case "R": //Range validation
			    //return IsValidRange(PassCtl,Min,Max)
			    if(!IsValidRange(PassCtl,Min,Max)){return false;}
			    break;	
		    case "D": //Decimal places validation
		        
			    
			    if(Cases.length==1)
			    {
			        return IsFloat(PassCtl,Min,Max)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsFloat(PassCtl,Min,Max)){return false;}else{return true;}
			        }
			        else
			        {
			         if(!IsFloat(PassCtl,Min,Max)){return false;}
			        } 
			     }
		    //    return IsFloat(PassCtl,Min,Max)
			    //if(!IsFloat(PassCtl,Min,Max)){return false;}
			    break;
		    case "DB": //Decimal places validation
			   // return IsFloatAllowNull(PassCtl,Min,Max)
			   if(Cases.length==1)
			    {
			        return IsFloatAllowNull(PassCtl)
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			           if(!IsFloatAllowNull(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			        if(!IsFloatAllowNull(PassCtl)){return false;}
			        } 
			     }
			    //if(!IsFloatAllowNull(PassCtl)){return false;}
			    break;		
		    case "E":  //Email validation
		        if(Cases.length==1)
			    {
			        return ApplyStyle(PassCtl,IsValidEmail(PassCtl))
			    
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			            if(!ApplyStyle(PassCtl,IsValidEmail(PassCtl))){return false;}else{return true;}
			        }
			        else
			        {
			          if(!ApplyStyle(PassCtl,IsValidEmail(PassCtl))){return false;}
			        }
			        
			    } 
			    break;
		    case "FM": //Custom String validation
			    //return validateCustom(PassCtl,Expression)
			    if(!validateCustom(PassCtl,Expression)){return false;}
			    break;
		    case "DTNOW": //Date Compare
			   // return compareTodateDate(PassCtl)
			    if(!compareTodateDate(PassCtl)){return false;}
			    break;
		    case "DE": //Decimal Check
			    //return IsDec(PassCtl)
			    if(Cases.length==1)
			    {
			        return IsDec(PassCtl)
			    
			    }
			    else
			    {
			        if((i+1)==Cases.length)
			        {
			            if(!IsDec(PassCtl)){return false;}else{return true;}
			        }
			        else
			        {
			           if(!IsDec(PassCtl)){return false;}
			        }
			        
			    } 
			    //if(!IsDec(PassCtl)){return false;}
			    break;
		    }
		 }   
		
}

function validateMobNo ( mobField) 
{
    var mobNoStartWith=/^9/;
    var length=mobField.value.length;
    var str=mobField.value;
    var code=new Array(mobField.value.length);
    var flag=true;
    if (trim(str) == '')
    {
        return true;
    }
    for(var i=0;i<length;i++)
    {
       code[i]=str.charCodeAt(i);
       if(code[i]>=48 && code[i]<=57)
       {
            flag=true;
        }
        else
        {
                mobField.focus();
                mobField.select();
                flag=false;
                fireMessage("Please enter proper format");
                return false;
        } 
    }
   if(flag==true)
   {
       if(length==10)
        {
            if( !mobNoStartWith.test( mobField.value ) ) 
            {
                mobField.focus();
                mobField.select();
                fireMessage("Please Enter Mobile No. Starting with 9");
                return false;
            }
        }
        else
        {
            mobField.focus();
            mobField.select();
            fireMessage("Please Enter Mobile No. of 10 digits");
            return false;
        }
        decreseit();
        return true;
    }
}


       function IsPhoneProperFormat(field)
            {
                var checkOK = "()+-_ 0123456789";
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
                  fireMessage("Please enter valid format.");
                  return true;
                }
            }
            function IsMobileNoProperFormat(field)
            {
                var checkOK = "()+-_ 0123456789";
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
                  fireMessage("Please enter valid format.");
                  return true;
                }
            }
       function charsOnlyForFName(field)
            {
   
                var checkOK = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz";
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
               
              function numbersonlyLAB5(field,e)
			{ 
			    //alert(max);
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var code = String.fromCharCode(unicode);
			    var ashilas;
			    var anil;
			   
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                        //if not a number
                        if (unicode == 58  ||unicode==112 ||unicode==109 ||unicode==97   ||(unicode >= 48 && unicode <= 57)) //if not a number
                            {   return true; }
                            else
                            {
                            return false;
                           } 
                               
                    }
			}
            
            
            function numbersonlyLAB(field,e)
			{ 
			    //alert(max);
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var code = String.fromCharCode(unicode);
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                        //if not a number
                        if (unicode == 44 || unicode == 45 || unicode == 32 ||unicode ==43 ||unicode ==41 || unicode ==40  ||(unicode >= 48 && unicode <= 57)) //if not a number
                            {   return true; }
                            else
                            {
                            return false;
                           } 
                               
                    }
			}
			 
            function charsOnlyForFNameLab(field,e)
			{ 
			    //alert(max);
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var code = String.fromCharCode(unicode);
			    
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                         //if not a number
                        if ((unicode >= 65  && unicode <= 90)||(unicode >= 97  && unicode <= 122) || unicode == 32) //if not a number
                            { 
                              return true; 
                            }
                            else
                            {
                            return false;
                            
                            }
                      //  else
//                            {
//                               if (parseInt(document.getElementById(ctl).value + code) > parseInt('<%= MaxPage %>'))
//                                {
//                                    return false;
//                                }
//                           }                                
                    }
			}
			
			
			
			function RestrictDecimalToThreePlace(txtbox) 
                {                 
                    var str1 = txtbox.value;
                    var fullStr = "";
                    var readingArray = new Array();
                    readingArray = str1.split(".");
                    if (readingArray[1] != null) 
                    {
                        if (readingArray[1].length > 3) 
                        {
                            for (var i = 0; i < str1.length - 1; i++) 
                            {
                                fullStr = fullStr + str1.charAt(i);
                            }
                            //alert('Decimal Points are not greater then 3');
                            txtbox.value = fullStr;
                        }
                    }
                }
			
			
			
			
			
		function charsOnlyForLNameLab(field,e)
			{ 
			    //alert(max);
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var code = String.fromCharCode(unicode);
			    
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                         //if not a number
                        if ((unicode >= 65  && unicode <= 90)||(unicode >= 97  && unicode <= 122) || unicode == 32  || unicode == 46) //if not a number
                            { 
                              return true; 
                            }
                            else
                            {
                            return false;
                            
                            }
                      //  else
//                            {
//                               if (parseInt(document.getElementById(ctl).value + code) > parseInt('<%= MaxPage %>'))
//                                {
//                                    return false;
//                                }
//                           }                                
                    }
			}
       function numbersonly(ctl,e)
			{ 
			    //alert(max);
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var code = String.fromCharCode(unicode);
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                        if (unicode<48||unicode>57) //if not a number
                            {   return false; }
//                        else
//                            {
//                               if (parseInt(document.getElementById(ctl).value + code) > parseInt('<%= MaxPage %>'))
//                                {
//                                    return false;
//                                }
//                            }                                
                    }
			}
			
    

//Only Numeric Value allowed.(1234567890 and single .(decimal) only)
// Use this function at each and every place where "NumericTextBox" is used.
// If only want Numbers and not want decimal sign(.) than dont use this function. -Sehul
function numericvalueonly(ctl,e)
			{ 
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var str = ctl.value;
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                        if (unicode >= 48 && unicode <= 57) //if not a number
                            {   
	                             return true;
                            }
                        else if(unicode==46)
                            {
                            for(i=0; i < str.length;i++)
                                {
                                    var str1=str.charAt(i);
                                    if (str1 == '.')
                                        { 
                                            return false;
                                        }
                                }    
                            }
                        else
                            { return false; }
                    }
			}

   function OpenLogFile(url)
        {
        //window.showModalDialog(url, "", "dialogWidth:100px;dialogHeight:200px;");
           MPWindow = window.open(url, 'MPWindow', 'resizable=yes,toolbar=yes,scrollbars=yes,width=700,height=550,titlebar=yes,top=0,left=0');

//           SetActiveWindow(MPWindow); 
           MPWindow.top;
           MPWindow.moveTo(0, 0);
           MPWindow.focus();
        }

//Only Alphabatallowed.(ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyz .(Space)  (space))
// If only want Alphabat,decimal(.),comma(,),dash(-),slash(/) and not want any other than dont use this function. -Sehul
function alphabatonly(ctl,e)
			{ 
			    var unicode=e.charCode? e.charCode : e.keyCode
			    var str = ctl.value;
			    if (unicode!=8)
                    { //if the key isn't the backspace key (which we should allow)
                        if ((unicode >= 65 && unicode <= 90)||(unicode >= 97 && unicode <= 122)||(unicode >= 44 && unicode <= 47))
                            { return true; }
                        else
                            { return false; }
                    }
			}

			
// compare 2 dates (dd/mon/yyyy)
function CompareDate(dt1,dt2,strMsg){
	dt1=dt1.value;
	dt2=dt2.value;
	var pos1=dt1.indexOf(dtCh)
	var pos2=dt1.indexOf(dtCh,pos1+1)
	
	var Day=parseInt(dt1.substring(0,pos1))
	var Month=parseInt(convertToNumericMon(dt1.substring(pos1+1,pos2)))
	var Year=parseInt(dt1.substring(pos2+1))

	var pos1_2=dt1.indexOf(dtCh)
	var pos2_2=dt1.indexOf(dtCh,pos1_2+1)
	
	var Day_2=parseInt(dt2.substring(0,pos1_2))
	var Month_2=parseInt(convertToNumericMon(dt2.substring(pos1_2+1,pos2_2)))
	var Year_2=parseInt(dt2.substring(pos2_2+1))
	if ( Date.parse(Month+"/"+Day+"/"+Year) > Date.parse(Month_2+"/"+Day_2+"/"+Year_2) ){
		fireMessage(strMsg);
		return false;
	}
	return true;
}


function CompareDateValue(dt2,strMsg)
			{
				//dt1=dt1;
				dt2=dt2;
				var ToDay=new Date();
				var dtCh = "-";
				//var pos1=dt1.indexOf(dtCh);
				//var pos2=dt1.indexOf(dtCh,pos1+1);
					
				//var Day=dt1.substring(0,pos1);
				//var Day=parseInt(dt1.substring(0,pos1));
				//var Month=parseInt(convertToNumericMon(dt1.substring(pos1+1,pos2)));
				//var Year=parseInt(dt1.substring(pos2+1));

				var pos1_2=dt2.indexOf(dtCh);
				var pos2_2=dt2.indexOf(dtCh,pos1_2+1);
				
				//var Day_2=parseInt(dt2.substring(0,pos1_2));
				var Day_2=dt2.substring(0,pos1_2);
				var Month_2=parseInt(convertToNumericMon(dt2.substring(pos1_2+1,pos2_2)));
				var Year_2=parseInt(dt2.substring(pos2_2+1));
					
				if ( Date.parse(Month_2+"/"+Day_2+"/"+Year_2) > Date.parse((ToDay.getMonth()+1) +"/"+ToDay.getDate()+"/"+ToDay.getFullYear()) )
				{
					fireMessage(strMsg);
					return false;
				}	
				
				return true;
			}



function CompareDateWithCurrent(dt2,strMsg)
			{
				//dt1=dt1;
				dt2=dt2;
				var ToDay=new Date();
				var dtCh = "-";
				//var pos1=dt1.indexOf(dtCh);
				//var pos2=dt1.indexOf(dtCh,pos1+1);
					
				//var Day=dt1.substring(0,pos1);
				//var Day=parseInt(dt1.substring(0,pos1));
				//var Month=parseInt(convertToNumericMon(dt1.substring(pos1+1,pos2)));
				//var Year=parseInt(dt1.substring(pos2+1));

				var pos1_2=dt2.indexOf(dtCh);
				var pos2_2=dt2.indexOf(dtCh,pos1_2+1);
				
				//var Day_2=parseInt(dt2.substring(0,pos1_2));
				var Day_2=dt2.substring(0,pos1_2);
				var Month_2=parseInt(convertToNumericMon(dt2.substring(pos1_2+1,pos2_2)));
				var Year_2=parseInt(dt2.substring(pos2_2+1));
					
				if ( Date.parse(Month_2+"/"+Day_2+"/"+Year_2) > Date.parse((ToDay.getMonth()+1) +"/"+ToDay.getDate()+"/"+ToDay.getFullYear()) )
				{
					fireMessage(strMsg);
					return false;
				}	
				
				return true;
			}


//Get any two date difference //Jignashu 23-08-06
function getDayDiff(txtFromDate,txtToDate,strMsg) 
{ 
	
	var da1 = getDateNumbers(txtFromDate.value); 
	var da2 = getDateNumbers(txtToDate.value); 

	var d1  = new Date(da1[0], da1[1], da1[2]); 
	var d2  = new Date(da2[0], da2[1], da2[2]); 

	var days = Math.round((d2.getTime() - d1.getTime()) / 86400000); 
									
	if(days > 30)
	{
		fireMessage(strMsg);
		return false;
	}
	
	return true;
} 

// compare 2 dates (dd/mon/yyyy)
function CompareDateValue(dt1,dt2,strMsg){
	/*dt1=dt1;
	dt2=dt2;
	var pos1=dt1.indexOf(dtCh)
	var pos2=dt1.indexOf(dtCh,pos1+1)
	
	var Day=parseInt(dt1.substring(0,pos1))
	var Month=parseInt(convertToNumericMon(dt1.substring(pos1+1,pos2)))
	var Year=parseInt(dt1.substring(pos2+1))

	var pos1_2=dt1.indexOf(dtCh)
	var pos2_2=dt1.indexOf(dtCh,pos1_2+1)
	
	var Day_2=parseInt(dt2.substring(0,pos1_2))
	var Month_2=parseInt(convertToNumericMon(dt2.substring(pos1_2+1,pos2_2)))
	var Year_2=parseInt(dt2.substring(pos2_2+1))
		 
	if ( Date.parse(Month+"/"+Day+"/"+Year) > Date.parse(Month_2+"/"+Day_2+"/"+Year_2) ){
		fireMessage(strMsg);
		return false;
	}*/
	return true;
}



function CompareDateValueFromTO(dt1,dt2,strMsg){
	dt1=dt1;
	dt1=dt1.replace(/ /g,"-");
    dt2=dt2;
    dt2=dt2.replace(/ /g,"-");
    //var ToDay=new Date();
    var dtCh = "-";
    var dtCh1 = "-";
    //----For From Date
    var pos1_1=dt1.indexOf(dtCh1);
    var pos2_1=dt1.indexOf(dtCh1,pos1_1+1);
    var Day_1=dt1.substring(0,pos1_1);
    var Month_1=parseInt(convertToNumericMon(dt1.substring(pos1_1+1,pos2_1)));
    var Year_1=parseInt(dt1.substring(pos2_1+1))
    
    //---For To Date 
    var pos1_2=dt2.indexOf(dtCh);
    var pos2_2=dt2.indexOf(dtCh,pos1_2+1);
    var Day_2=dt2.substring(0,pos1_2);
    var Month_2=parseInt(convertToNumericMon(dt2.substring(pos1_2+1,pos2_2)));
    var Year_2=parseInt(dt2.substring(pos2_2+1));
    if ( Date.parse(Month_1+"/"+Day_1+"/"+Year_1) > Date.parse(Month_2+"/"+Day_2+"/"+Year_2) )
    {
	    fireMessage(strMsg);
	    return false;
    }	 
	
	return true;
}

//COMPARE today's DATES
//function compareTodateDate(dt1,strMsg){

//	var pos1=dt1.indexOf(dtCh)
//	var pos2=dt1.indexOf(dtCh,pos1+1)
	
//	var day=parseInt(dt1.substring(0,pos1))
//	var month=parseInt(dt1.substring(pos1+1,pos2)+%m)
//	var year=parseInt(dt1.substring(pos2+1))

//	if (Date.parse(month+"/"+day+"/"+year)>Date.parse(Date())){
//		fireMessage(strMsg);
//		Ret_val = false;
//		return Ret_val;
		//return ApplyStyle(ctl,Ret_val);
//	}
//	return true;
//}

// Blank validation
function IsBlank(ctl) 
{
	var Ret_val = true;
	if(ctl.type=="select-one")
	{
	    if (ctl.value=="-1" || ctl.selectedIndex==0 ||ctl.selectedIndex==-1)
	    {	
	      fireMessage(MsgBlank);
	      Ret_val = false;
	    }
	    else 
	    {
	        Ret_val = true;
	    }
	 }
	 else
	 {
	    if (trim(ctl.value)=="" || ctl.selectedIndex==0 )
	    {	
	      fireMessage(MsgBlank);
	      Ret_val = false;
	    }
	    else 
	    {
	        Ret_val = true;
	    }
	 
	 }   	
	return ApplyStyle(ctl,Ret_val);
}

// Number validation
function IsNumber(ctl,Minval,Maxval)
{
    
	var mname =ctl.value;
	var Ret_val = true;
	if(ctl.type=="select-one")
	{
	    if (ctl.value!="-1")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) fireMessage(MsgNumber);
    		
	    }
	 }
	 else
	 {
	     if (ctl.value!="")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) fireMessage(MsgNumber);
    		
	    }
	    else 
	    {	
	      fireMessage(MsgBlank);
	      Ret_val = false;
	    }
	 
	 } 	
	 
	 if (Ret_val)
	{
	    if (Minval!='' && (parseInt(ctl.value) < Minval))
	    {
			fireMessage (MsgHighValue);
			Ret_val= false;
	    }
		else if (Maxval!='' && (parseInt(ctl.value) > Maxval))
		{
			fireMessage(MsgLowValue);
		    Ret_val= false;
		}
	}
	
	return ApplyStyle(ctl,Ret_val);
}
/*function IsNumber_blur(ctl,Type)
{
   var mname =ctl.value;
	var Ret_val = true;
	if(ctl.type=="select-one")
	{
	    if (ctl.value!="-1")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) 
		    {
		        fireMessage('Please Enter Numeric value in '+ Type +'');
		        ctl.value="";
		    }    
    		
	    }
	 }
	 else
	 {
	     if (ctl.value!="")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) 
		    {
		        fireMessage('Please Enter Numeric value in '+ Type +'');
		        ctl.value="";
		    }
    		
	    }
	 
	 } 	
	return ApplyStyle(ctl,Ret_val);
}*/
function IsNumberWithoutMsg(ctl)
{
	var mname =ctl.value;
	var Ret_val = true;
	if(ctl.type=="select-one")
	{
	    if (ctl.value!="-1")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) return false;
    		
	    }
	    else
	    {
	        return false;
	    }
	 }
	 else
	 {
	     if (ctl.value!="")
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spNums.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
    			
		    }
		    if (!Ret_val ) return false;
    		
	    }
	    else
	    {
	        return false;
	    }
	 
	 
	 }   
	    	
	return true;
}


function IsNumberAllowNull(ctl)
{
	var mname =ctl.value;
	var Ret_val = true;
	if (Ret_val)
	{
		for(i=0; i < mname.length;i++)
		{
			var spcheck=mname.charAt(i);
			if(spNums.test(spcheck)==false)
			{
				Ret_val = false;
				break;
			}
			
		}
		if (!Ret_val ) fireMessage(MsgNumber);
		
	}	
	return ApplyStyle(ctl,Ret_val);
}

//Alphabetic characters validation
function IsValidString(ctl) 
{
	var mname =ctl.value;
	var Ret_val = true;
	if(ctl.type=="select-one")
	{
	    if (ctl.value == "-1")
	        {
	            Ret_val = false;
			    fireMessage(MsgValidAlpha);
	        }
	    if (Ret_val)
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spChar.test(spcheck)==false)
			    {
				    Ret_val = false;
				    fireMessage(MsgValidAlpha);
				    break;
			    }
		    }
	    }
	  }
	  else
	  {
	    if (ctl.value == "")
	        {
	            Ret_val = false;
			    fireMessage(MsgValidAlpha);
	        }
	    if (Ret_val)
	    {
		    for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spChar.test(spcheck)==false)
			    {
				    Ret_val = false;
				    fireMessage(MsgValidAlpha);
				    break;
			    }
		    }
	    }
	  
	  }  	
	return ApplyStyle(ctl,Ret_val);
}


//Alphabetic characters validation
function IsValidStringAllowNull(ctl) 
{
	var mname =ctl.value;
	var Ret_val = true;
	for(i=0; i < mname.length;i++)
	{
		var spcheck=mname.charAt(i);
		if(spChar.test(spcheck)==false)
		{
			Ret_val = false;
			fireMessage(MsgValidAlpha);
			break;
		}
	}
	return ApplyStyle(ctl,Ret_val);
}


//Alpha-numeric charactes validation
function IsAlphaNumeric(ctl) 
{
	mname =ctl.value;
	Ret_val = true;
	if (Ret_val)
	{
		for(i=0; i < mname.length;i++)
		{
			var spcheck=mname.charAt(i);
			if(spNChar.test(spcheck)==false)
			{
				Ret_val = false;
				break;
			}
		}
		if (!Ret_val) fireMessage(MsgValidAlphaNum);
		return ApplyStyle(ctl,Ret_val);
	}else 
	{return false;	}
	
}
function IsAlphaDecimal(ctl) 
{
	mname =ctl.value;
	Ret_val = true;
	if (Ret_val)
	{
	    if(mname!="Enter Text To Search")
	    {
	        for(i=0; i < mname.length;i++)
		    {
			    var spcheck=mname.charAt(i);
			    if(spAlphaDec.test(spcheck)==false)
			    {
				    Ret_val = false;
				    break;
			    }
		    }
		    if (!Ret_val) fireMessage(MsgValidAlphaDec);
		    return ApplyStyle(ctl,Ret_val);
		}
		else
		{
		    return true;
		}		
	}else 
	{return false;	}
	
}
//range validation
function IsValidRange(ctl,MinSize,MaxSize)
{
	fieldValue =ctl.value;
	Ret_val = IsNumber(ctl);
	if (Ret_val)
	{
		if (!( (parseFloat(fieldValue) >= MinSize) && (parseFloat(fieldValue) <= MaxSize) ))
			{
				if (parseFloat(fieldValue) < MinSize)
					fireMessage (MsgHighValue);
				else if (parseFloat(fieldValue) > MaxSize)
					fireMessage(MsgLowValue);
				Ret_val= false;
			}
	}
	return ApplyStyle(ctl,Ret_val);
}

 //String length validation
//function IsValidLength(ctl,valMin,valMax)
//{
//	mname =ctl.value;
//	Ret_val = 	IsBlank(ctl);
//	if (Ret_val)
//	{
//		if (valMin != "")
//		{
//			if( valMin >= mname.length)
//			{
//			
//				fireMessage(MsgHighRange);
//				Ret_val = false;
//			}
//		}
//		if (Ret_val)
//		{
//			if (valMax != "")
//			{	
//				if( valMax <= mname.length)
//				{
//				
//					fireMessage(MsgLowRange);
//					Ret_val = false;
//				}
//			}
//		}	
//	}			
//	return ApplyStyle(ctl,Ret_val);
//}

function IsValidLength(ctl,valMin,valMax)
{
	mname =ctl.value;
	Ret_val = 	IsBlank(ctl);
	if (Ret_val)
	{
		if (valMin != "")
		{
			if( valMin > mname.length)
			{
			
				fireMessage(MsgHighRange);
				Ret_val = false;
			}
			else if(valMin == mname.length)
			{
			    //fireMessage(MsgRangeEqual);
				Ret_val = true;
			}
			
		}
		if (Ret_val)
		{
			if (valMax != "")
			{	
				if( valMax < mname.length)
				{
				
					fireMessage(MsgLowRange);
					Ret_val = false;
				}
				else if(valMax == mname.length)
			{
			 //   fireMessage(MsgRangeEqual);
				Ret_val = true;
			}
			}
		}	
		
		
		
	}			
	return ApplyStyle(ctl,Ret_val);
}


function IsValidLengths(ctl,valMin,valMax)//for constant length
{
	var mname =ctl.value;
	Ret_val = 	IsBlank(ctl);
	if (Ret_val)
	{
		if (valMin != "")
		{
			if( parseInt(valMin) > mname.length)
			{
			
				fireMessage(MsgHighRanged);
				Ret_val = false;
			}
			
			
		}
				
		
		
	}			
	return ApplyStyle(ctl,Ret_val);
}








//Email validation
function IsValidEmail(ctl) 
{
	//IsBlank(ctl);
	
	var emailStr = ctl.value;
	
	var emailPat=/^(.+)@(.+)$/
	var specialChars="\\(\\)<>@,;:\\\\\\\"\\.\\[\\]"
	var validChars="\[^\\s" + specialChars + "\]"
	var quotedUser="(\"[^\"]*\")"
	var ipDomainPat=/^\[(\d{1,3})\.(\d{1,3})\.(\d{1,3})\.(\d{1,3})\]$/
	var atom=validChars + '+'
	var word="(" + atom + "|" + quotedUser + ")"
	var userPat=new RegExp("^" + word + "(\\." + word + ")*$")
	var domainPat=new RegExp("^" + atom + "(\\." + atom +")*$")
	var matchArray=emailStr.match(emailPat)
	if (trim(emailStr) == "") return true;
	
	if (matchArray==null) 
	{
		fireMessage(MsgValidEmail)
		ctl.focus();
		return false;
	}
	
	var user=matchArray[1]
	var domain=matchArray[2]
	
	if (user.match(userPat)==null) 
	{
    	fireMessage(MsgValidEmail)
		ctl.focus();
		return false;
	}
	
	var IPArray=domain.match(ipDomainPat)
	
	if (IPArray!=null) 
	{
		for (var i=1;i<=4;i++) 
		{
	    		if (IPArray[i]>255) 
			{
			        fireMessage(MsgValidEmail)
			        ctl.focus();
					return false;
	    		}
		}
			return true;
	}
	
	var domainArray=domain.match(domainPat)
	if (domainArray==null) 
	{
		fireMessage(MsgValidEmail)
		ctl.focus();
		return false;
	}
	
	var atomPat=new RegExp(atom,"g")
	var domArr=domain.match(atomPat)
	var len=domArr.length
	
	if (domArr[domArr.length-1].length<2 || domArr[domArr.length-1].length>3) 
	{
	   fireMessage(MsgValidEmail)
	   return false;
	}
	if (len<2) 
	{
	   fireMessage(MsgValidEmail);
	   ctl.focus();
	   return false;
	}
		return true;
}
// Decimal number to be checked
function IsFloat(Ctl,Minval,Maxval) 
{
	blnDotPresent = false;
	fieldValue = Ctl.value;
	ret = IsBlank(Ctl);
	for(i=0; i < fieldValue.length;i++)
	{
		var spcheck = fieldValue.charAt(i);
		if(spcheck == '.')
		{
			if( spFloat.test(spcheck) == false)
			{
				continue;
			}
			else
			{
				if(!blnDotPresent)
					blnDotPresent = true;
				else
				{
					ret = false;
					fireMessage (MsgCustomFormat);
					break;
				}
			}
		}
		else
			{
				if( spFloat.test(spcheck) == false)
				{
					ret = false;
					fireMessage (MsgCustomFormat);
					break;
				}
			
			}
	}
	if (ret)
	{
	    if (Minval!='' && (parseFloat(fieldValue) < Minval))
	    {
			fireMessage (MsgHighValue);
			ret= false;
	    }
		else if (Maxval!='' && (parseFloat(fieldValue) > Maxval))
		{
			fireMessage(MsgLowValue);
		    ret= false;
		}
	}
	return ApplyStyle(Ctl,ret);
}
//For Decimal
function IsDec(Ctl ) 
{
	blnDotPresent = false;
	fieldValue = Ctl.value;
	ret = true;
	
	for(i=0; i < fieldValue.length;i++)
	{
		var spcheck = fieldValue.charAt(i);
		
		if(spcheck == '.')
		{
			if( spFloat.test(spcheck) == false)
			{
			
				continue;
			}
			else
			{//alert(blnDotPresent);
				if(!blnDotPresent)
					blnDotPresent = true;
				else
				{
					ret = false;
					fireMessage (MsgDecFormat);
					break;
				}
			}
		}
		else
			{
				if( spFloat.test(spcheck) == false)
				{
					ret = false;
					fireMessage (MsgDecFormat);
					break;
				}
			
			}
	}
	return ApplyStyle(Ctl,ret);
}

// Decimal number to be checked
function IsFloatAllowNull(Ctl,Minval,Maxval ) 
{
	blnDotPresent = false
	fieldValue = Ctl.value;
	ret = true;
	if (fieldValue != "")
	{
	
		for(i=0; i < fieldValue.length;i++)
		{
			var spcheck = fieldValue.charAt(i);
			if(spcheck == '.')
			{
				if( spFloat.test(spcheck) == false)
				{
					continue;
				}
				else
				{
					if(!blnDotPresent)
						blnDotPresent = true;
					else
					{
						ret = false;
						fireMessage (MsgCustomFormat);
						break;
					}
				}
			}
			else
			{
				if( spFloat.test(spcheck) == false)
				{
					ret = false;
					fireMessage (MsgCustomFormat);
					break;
				}
			
			}
		}
		if (ret)
		{
			if (!( (parseFloat(fieldValue) >= Minval) && (parseFloat(fieldValue) <= Maxval) ))
			{
				if (parseFloat(fieldValue) < Minval)
					fireMessage (MsgHighValue);
				else if (parseFloat(fieldValue) > Maxval)
					fireMessage(MsgLowValue);
				ret= false;
			}
		}
	}	
	
	return ApplyStyle(Ctl,ret);
}

//Custom dataformat validation
function validateCustom(Obj,pattern) 
{
	if (!IsBlank(ctl))
	{
		var regex = new RegExp(pattern);
		if (!regex.test(Obj.value)) 
		{
			ApplyStyle(Obj,false);
			return false;
		}
		else 
		{
			ApplyStyle(Obj,true);
			return true;
		}
	}	
}

//To make textbox highlighted
function ApplyStyle(ctl,Return_val)
{
	if (Return_val)
	{
		//ctl.className="TextBox_Normal"; //Normal stylesheet classname
		ctl.style.backgroundColor = "#ffffff";
	}else
	{
		//ctl.className="TextBox_Selected"; //Error showing stylesheet classname
		ctl.style.visibility="visible";
		ctl.style.backgroundColor = "#d8d8d8";
		if (ctl.disabled==false)
		{	ctl.focus(); }
	}
	return Return_val;
}

function trim(inputString) {
   // Removes leading and trailing spaces from the passed string. Also removes
   // consecutive spaces and replaces it with one space. If something besides
   // a string is passed in (null, custom object, etc.) then return the input.
   if (typeof inputString != "string") { return inputString; }
   var retValue = inputString;
   var ch = retValue.substring(0, 1);
   while (ch == " ") { // Check for spaces at the beginning of the string
      retValue = retValue.substring(1, retValue.length);
      ch = retValue.substring(0, 1);
   }
   ch = retValue.substring(retValue.length-1, retValue.length);
   while (ch == " ") { // Check for spaces at the end of the string
      retValue = retValue.substring(0, retValue.length-1);
      ch = retValue.substring(retValue.length-1, retValue.length);
   }
   while (retValue.indexOf("  ") != -1) { // Note that there are two spaces in the string - look for multiple spaces within the string
      retValue = retValue.substring(0, retValue.indexOf("  ")) + retValue.substring(retValue.indexOf("  ")+1, retValue.length); // Again, there are two spaces in each of the strings
   }
   return retValue; // Return the trimmed string back to the user
} // Ends the "trim" function



///////////////////////
// Rollover effect
//////////////////////////

// Code for Mouseover effect of the Images
<!--
<!--
function MM_reloadPage(init) {  //reloads the window if Nav4 resized
  if (init==true) with (navigator) {if ((appName=="Netscape")&&(parseInt(appVersion)==4)) {
    document.MM_pgW=innerWidth; document.MM_pgH=innerHeight; onresize=MM_reloadPage; }}
  else if (innerWidth!=document.MM_pgW || innerHeight!=document.MM_pgH) location.reload();
}
MM_reloadPage(true);
// -->

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_findObj(n, d) { //v4.0
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && document.getElementById) x=document.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}


//Function for the validation of RePrint VIN
function MM_showHideLayers() { //v3.0
  var i,p,v,obj,args=MM_showHideLayers.arguments;
  for (i=0; i<(args.length-2); i+=3) if ((obj=MM_findObj(args[i]))!=null) { v=args[i+2];
    if (obj.style) { obj=obj.style; v=(v=='show')?'visible':(v='hide')?'hidden':v; }
    obj.visibility=v; }
}

		


//-->

/////////////////////////////common script for All view page 


	// Called to render rows of grid
	function ReloadColor(FormName)
	{	
		CheckedNo= 0;
		SelectColumn=0;
		currentClass="tableSelectedRow";
		var len =FormName.elements.length;
		for (i=0;i<len;i++)
		{
			if (FormName.elements(i).type=="checkbox")
			{
				SelectColumn++;
				if (FormName.elements(i).checked==true)
				{
					CheckedNo++;
					FormName.elements(i).parentElement.parentElement.style.classname="tableSelectedRow";
				}
				else
				{
					if (SelectColumn%2==0)
					{
						FormName.elements(i).parentElement.parentElement.className="tableRows"; //alter
					}else
					{
						FormName.elements(i).parentElement.parentElement.className="tableRows";
					}
				}
			}	
		}
		return CheckedNo;
	}

	function ReloadColorDeactivated(FormName)
	{	
		CheckedNo= 0;
		selectColumn = 0;
		currentClass="tableSelectedRow";
		var len =FormName.elements.length;
		for (i=0;i<len;i++)
		{
			if (FormName.elements(i).type=="checkbox")
			{
				selectColumn++;
				if (FormName.elements(i).checked==true)
					{
						CheckedNo++;
					}
					
				if (FormName.elements(i).parentElement.parentElement.className != "Deactivated" )
				{
					if (FormName.elements(i).checked==true)
					{
						FormName.elements(i).parentElement.parentElement.style.classname="tableSelectedRow";
					}else
					{
						if (selectColumn%2==0)
						{
							FormName.elements(i).parentElement.parentElement.className="tableRows"; //alter
						}else
						{
							FormName.elements(i).parentElement.parentElement.className="tableRows";
					}	}
				}
			}
		}		
		return CheckedNo;
	}
		
		
function DeactivatedCount(FormName)
	{	
		CheckedNo= 0;
		var len =FormName.elements.length;
		for (i=0;i<len;i++)
		{
			if (FormName.elements(i).parentElement.parentElement.className == "Deactivated" )		
			{
				if (FormName.elements(i).type=="checkbox")
				{
					if (FormName.elements(i).checked==true)
					{
						CheckedNo++;
					}
				}
			}	
		}
		return CheckedNo;
	}
	//Individual items' color are toggled		
	function ChangeColorDeactivated(e,FormName)
	{
		currentClass=e.parentElement.parentElement.className;
		if (currentClass != "Deactivated")
		{
			if(e.checked == true )
			{
				if (currentClass=="tableSelectedRow")
				{
					currentClass="tableRows";
				}
				else
				{
					currentClass=e.parentElement.parentElement.className;
				}
				e.parentElement.parentElement.className ="tableSelectedRow";
			}
			else
			{
				temp = e.parentElement.parentElement.className;
				e.parentElement.parentElement.className=currentClass;
				currentClass=temp;
			}
		}		 
		ReloadColorDeactivated(FormName);
	}
	function ChangeColor(e,FormName)
	{
		if(e.checked == true)
		{
			if (currentClass=="tableSelectedRow")
			{
				currentClass="tableRows";
			}
			else
			{
				currentClass=e.parentElement.parentElement.className;
			}
			e.parentElement.parentElement.className ="tableSelectedRow";
		}
		else
		{
			temp = e.parentElement.parentElement.className;
			e.parentElement.parentElement.className=currentClass;
			currentClass=temp;
			e.parentElement.parentElement.className="tableRows"; //alter
		} 
		ReloadColor(FormName);
	}
	

	// function for blinking error message.
	var x=1; 
	function countDown() 
	{
		if(x < 6){
			if (tdMsgAssist.style.visibility=="hidden"){
				tdMsgAssist.style.visibility="visible";
			}
			else {
					tdMsgAssist.style.visibility="hidden";
				}	
			x = x+1;
		}
		if (x == 6) {
			clearInterval(counter); // clearing loop
			tdMsgAssist.style.visibility="visible";
			x=1;
		}
	} 

	// when message is fired
	function fireMessage(msg){
	    msg = msg.toString().replace("\r\n", "<br>");
        msg = msg.toString().replace("\r\n1", "<br>");
        msg = msg.toString().replace("\n", "");
        tdMsgAssist.innerText=msg;	
		//tdMsgAssist.style.fontWeight="bold";
		//tdMsgAssist.style.color="red";
		counter = window.setInterval("countDown()", 1500);
	}

	function ViewPage(CallType,FormName,totalcheck)
	{
			if (CallType=='E') //Edit
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectEditEligibleOne);
					return false;
				}else
				{
					if (totalcheck == 1)
					{
						FormName.submit();
					}else
					{
						fireMessage(MsgSelectEditEligibleMore);	
						return false;
					}
				}
			}
			else if (CallType=='View') //Edit
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectEditEligibleOne1);
					return false;
				}else
				{
					if (totalcheck == 1)
					{
						FormName.submit();
					}else
					{
						fireMessage(MsgSelectEditEligibleMore1);	
						return false;
					}
				}
			}
				
			
			else if (CallType=='D') //Delete
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectDeleteEligible);	
					return false;
				}
				else
				{
					if (totalcheck >= 1)
					{
						if (confirm(MsgDeleteConfirm)) 
						{ FormName.submit();}
						else
						{ return false;}
					}
				}
			}
			else if (CallType=='V') //Assign
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectAssignEligibleOne);	
					return false;
				}
				else
				{
	
					if (totalcheck == 1)
					{
						//FormName.submit();
						 confirm(MsgContinueConfirm);
					}else
					{
						fireMessage(MsgSelectAssignEligibleMore);	
						return false;
					}
				}
			}
			else if (CallType=='A') //Deactivation
			{
				//selDeactivated = DeactivatedCount(FormName);
				if (totalcheck != 0)
				{
					if (confirm(MsgDeactivateConfirm)) 
						{ FormName.submit();}
						else
						{ return false;}
				
				}
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectDeactivateEligible);	
					return false;
				}
			
			}
			else if (CallType=='R') //Return
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectReturn);	
					return false;
				}
				else
				{
					if (totalcheck >= 1)
					{
						if (confirm(MsgReturnConfirm)) 
						{ FormName.submit();}
						else
						{ return false;}
					}
				}
			}
			else if (CallType=='S') //Assigning
			{
				if (totalcheck == 0)
				{
					fireMessage(MsgSelectAssignEligibleOne);	
					return false;
				}else
				{
					if (totalcheck == 1)
					{
						FormName.submit();
					}else
					{
						fireMessage(MsgSelectAssignEligibleMore);	
						return false;
					}
				}
			}
	}	
 
 
 
 function ValidatePhoneNumber(phoneNum) {
	var segments;		// Breaks up the phone numbers into area code, city code and number
	var i;
		
	// Check to see if they put any "( )" around the area code
	// If so we'll strip those out.
	phoneNum = phoneNum.replace("(", "");
	phoneNum = phoneNum.replace(")", "");
	
	switch (phoneNum.length) {
		case 7:																		/* The XXXXXXX case */
			//if(!isNaN(phoneNum))										// Check to see if they're real numbers
			//	return true;
			return false;
			break;
						
		case 8:																		/* The XXX-XXXX case */
			//segments = phoneNum.split("-");
			//if (segments.length == 2) {
			//	if((segments[0].length == 3) && (segments[1].length == 4)) {
			//		for (i = 0; i < 2; i++) {						// Check to see if they're real numbers
			//			if (isNaN(segments[i]))
			//				return false;
			//		}
			//		return true;
			//	}
			//}
			return false;
			break;
			
		case 10:																	/* The XXXXXXXXXX case */
			//if(!isNaN(phoneNum))										// Check to see if they're real numbers
			return false;
				//return true;
			break;
			
		case 12:																	/* The XXX-XXX-XXXX case */
			segments = phoneNum.split("-");
			if (segments.length == 3) {
				if((segments[0].length == 3) && (segments[1].length == 3) && (segments[2].length == 4)) {
					for (i = 0; i < 3; i++) {						// Check to see if they're real numbers
						if (isNaN(segments[i]))
							return false;
					}
					return true;
				}
			}
			break;
				
		default:																	/* If non of the above then fail it */
			break;
	}
	return false;
}			

	
	function Save_Confirm()
	{
		return confirm(MsgSaveConfirm );
	}
	function Save_Confirm(msg)
	{
		return confirm(msg);
	}
	function Assign_Confirm()
	{
		return confirm(MsgAssignConfirm );
	}
	function Return_Confirm()
	{
		return confirm(MsgPocketPCReturn);
	}
	function Schedule_Confirm()
	{
		return confirm(MsgScheduleConfirm);
	}
	function ScheduleUpdate_Confirm()
	{
		return confirm(MsgScheduleUpdateConfirm);
	}
	function Continue_Confirm()
	{
		return confirm(MsgContinueConfirm);
	}
	function Send_Confirm()
	{
		return confirm(MsgSendConfirm);
	}
	function Delete_Confirm()
	{	
		return confirm(MsgDeleteConfirm);
	}

//flag=true;
//function funCheckAll(){
//	for(i=0;i<=parseInt(document.forms[0].elements.length)-1;i++){
//		if (document.forms[0].elements[i].type=="checkbox"){
//			document.forms[0].elements[i].checked=flag;
//		}
//	}
//	if (flag==false){
//		flag=true;
//	}
//	else{
//		flag=false;
//	}
//}

function convertToNumericMon(strinMon)
{
  switch(strinMon)
	{	
		case  "Jan" :
		case  "jan" :
		return 1  	
		break;
	
		case  "Feb" :
		case  "feb" :
		return 2 	
		break;
		
		case  "Mar" :
		case  "mar" :
		return 3 	
		break;

		case  "Apr" :
		case  "apr" :
		return 4 	
		break;

		case  "May" :
		case  "may" :
		return 5  	
		break;

		case  "Jun" :
		case  "jun" :
		return 6 	
		break;

		case  "Jul" :
		case  "jul" :
		return 7 	
		break;

		case  "Aug" :
		case  "aug" :
		return 8 	
		break;

		case  "Sep" :
		case  "sep" :
		return 9 	
		break;

		case  "Oct" :
		case  "oct" :
		return 10  	
		break;

		case  "Nov" :
		case  "nov" :
		return 11  	
		break;

		case  "Dec" :
		case  "dec" :
		return 12  	
		break;				
	}
}

function convertToNumericMon1(strinMon)
{
  switch(strinMon)
	{	
		case  "1" :		
		return 1  	
		break;
	
		case  "2" :		
		return 2 	
		break;
		
		case  "3" :		
		return 3 	
		break;

		case  "4" :		
		return 4 	
		break;

		case  "5" :
		return 5  	
		break;

		case  "6" :		
		return 6 	
		break;

		case  "7" :
		return 7 	
		break;

		case  "8" :		
		return 8 	
		break;

		case  "9" :		
		return 9 	
		break;

		case  "10" :		
		return 10  	
		break;

		case  "11" :		
		return 11  	
		break;

		case  "12" :		
		return 12  	
		break;				
	}
}


function checkForAlphaNumericlab3()
{    
  var carCode = event.keyCode;        
  if ((carCode >= 48) && (carCode <= 57) || (carCode >= 65) && (carCode <= 90) || (carCode >= 97) && (carCode <= 122) || carCode == 8 || carCode == 9 || carCode == 13 || carCode == 27 || carCode == 32 ||  carCode == 45 || carCode == 46 || carCode==47 )
  {                  
  }
  else
  {
    event.cancelBubble = true	
    event.returnValue = false;	
    this.select;
    this.focus;  
  }
}   

function checkForAlphaNumericAndUnderScore()
{    
  var carCode = event.keyCode;        
  if ((carCode >= 48) && (carCode <= 57) || (carCode >= 65) && (carCode <= 90) || (carCode >= 97) && (carCode <= 122) || carCode == 8 || carCode == 9 || carCode == 32 || carCode == 45 || carCode == 95 || carCode==127 )
  {                  
  }
  else
  {
    event.cancelBubble = true	
    event.returnValue = false;	
    this.select;
    this.focus;  
  }
} 


function KeyPressOnDropDown(dropdownlist,caseSensitive) 
{
		// check the keypressBuffer attribute is defined on the dropdownlist
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
		return true; // give default behavior
} 


function next(){ 

// window.location="/ConnectivityScreens/ConnectivitySetup.html"; 


} 


// constants to define the title of the alert and button text. 
var 

ALERT_TITLE = "Choose Selection!"; 
var 

ALERT_BUTTON1_TEXT = "Current Page Records"; 
var 

ALERT_BUTTON2_TEXT = "All Page Records"; 
var 

BTN1_VALUE = true; 
var 

BTN2_VALUE = false; 
var 

HIDDEN_CMP_ID = "hdnExcelCmp"; 

// over-ride the alert method only if this a newer browser.

// Older browser will see standard alerts

/*if(document.getElementById) {

window.alert = function(txt) {

createCustomAlert(txt);

}

}*/


function 

createCustomAlert(txt) { 

// shortcut reference to the document object 

d = document; 


// if the modalContainer object already exists in the DOM, bail out. 

if(d.getElementById("modalContainer")) return; 


// create the modalContainer div as a child of the BODY element 

mObj = d.getElementsByTagName("body")[0].appendChild(d.createElement("div")); 

mObj.id = 

"modalContainer";

// make sure its as tall as it needs to be to overlay all the content on the page 
// mObj.style.height = document.documentElement.scrollHeight + "px";


mObj.className = "customAlert"; 


// create the DIV that will be the alert 

alertObj = mObj.appendChild(d.createElement("div")); 
alertObj.id = 

"alertBox"; 
alertObj.className = 

"customeAlertTextCont"; 

// MSIE doesnt treat position:fixed correctly, so this compensates for positioning the alert 

if(d.all && !window.opera) alertObj.style.top = "600px"; 

alertObj.style.position = "absolute";
alertObj.style.height = "150px";
alertObj.style.width = "400px";
alertObj.style.background = "#ECE9DB";

// center the alert box 

alertObj.style.left = "100px"; 

// create an H1 element as the title bar 

h1 = alertObj.appendChild(d.createElement("h1")); 
h1.appendChild(d.createTextNode(ALERT_TITLE));

h1.style.margin = "10px 0px 0px 50px"; 

// create a paragraph element to contain the txt argument 

msg = alertObj.appendChild(d.createElement("p")); 
msg.appendChild(d.createTextNode(txt));



// create an anchor element to use as the confirmation button. 

btn1 = alertObj.appendChild(d.createElement("a")); 
btn1.id = 

"btn1"; 
btn1.appendChild(d.createTextNode(ALERT_BUTTON1_TEXT));

btn1.href = 

"#"; 
btn1.className = 

"btn1"; 


// create an anchor element to use as the confirmation button. 

btn2 = alertObj.appendChild(d.createElement("a")); 
btn2.id = 

"btn2"; 
btn2.className = 

"btn2"; 
btn2.appendChild(d.createTextNode(ALERT_BUTTON2_TEXT));

btn2.href = 

"#"; 


// set up the onclick event to remove the alert when the anchor is clicked 

btn1.onclick = function() { 

removeCustomAlert(); 
document.getElementById(HIDDEN_CMP_ID).value = BTN1_VALUE; 


return true; 

} 


// set up the onclick event to remove the alert when the anchor is clicked 

btn2.onclick = function() { 

removeCustomAlert(); 
document.getElementById(HIDDEN_CMP_ID) = BTN2_VALUE;


return true; 

} 
alert(mObj.innerHTML);
//d.getElementById("testDiv").innerHTML = mObj.innerHTML;
}


// removes the custom alert from the DOM

function 
removeCustomAlert() { 
document.getElementsByTagName("body")[0].removeChild(document.getElementById("modalContainer")); 
} 

function CheckUncheckAll(chkBoxName,chkAll)
{
	if (chkAll==undefined)
	{
		chkAll='chkAll';
	}
	
	for(i=0;i<=eval('document.getElementsByName("'+chkBoxName+'")').length-1;i++)
	{
			//eval('document.getElementsByName("'+chkBoxName+'")')[i].checked = document.getElementById("chkAll").checked;
			eval('document.getElementsByName("'+chkBoxName+'")')[i].checked = eval('document.getElementById("'+chkAll+'").checked');
	}
}

function lockCol(tblID, NoOfCols) 
{
//debugger;
    if (tblID=='null') return;
    if (NoOfCols==undefined) NoOfCols=3;
	var table = document.getElementById(tblID);
	var cTR = table.getElementsByTagName('tr');  //collection of rows

	for (i = 0; i < cTR.length; i++)
    {
		var tr = cTR.item(i);
		for (j = 0; j < NoOfCols; j++)
        {
            tr.cells[j].className = 'locked';
        }
	}
}