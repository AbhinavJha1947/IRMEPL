/// <reference name="MicrosoftAjax.js"/>

//Type.registerNamespace("SGLREWeb.Scripts");

//SGLREWeb.Scripts.DateCurStringValidation = function(element) {
//    SGLREWeb.Scripts.DateCurStringValidation.initializeBase(this, [element]);
//}

//SGLREWeb.Scripts.DateCurStringValidation.prototype = {
//    initialize: function() {
//        SGLREWeb.Scripts.DateCurStringValidation.callBaseMethod(this, 'initialize');
//        
//        // Add custom initialization here
//    },
//    dispose: function() {        
//        //Add custom dispose actions here
//        SGLREWeb.Scripts.DateCurStringValidation.callBaseMethod(this, 'dispose');
//    }
//}
//SGLREWeb.Scripts.DateCurStringValidation.registerClass('SGLREWeb.Scripts.DateCurStringValidation', Sys.UI.Control);

//if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();
// JScript File

// Date Function Start
var monthname = new Array("Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec");
var monthvalue = new Array("01","02","03","04","05","06","07","08","09","10","11","12");
var dayvalue = new Array("01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31");
function arrayIndexOf(array, value)
{
    var found = false;
    var index = 0;
    while(!found && index < array.length)
    {
        if(array[index]==value)
            found = true;
    else
        index++;
}
return (found)?index:-1;
}

function LostFocus(field,IsChkDateCrteria,BtnStr)
{
   var checkstr = "0123456789";
   var DateField = field;
   var Datevalue = "";
   var DateTemp = "";
   var seperator = "/";
   var day;
   var month;
   var year;
   var leap = 0;
   var err = 0;
   var i;
   err = 0;
   
   var attributeNode = document.createAttribute ('maxlength');
   attributeNode.value = '11';
   field.setAttributeNode (attributeNode);
   DateValue = field.value;  //DateField.value;       
   /* Delete all chars except 0..9 */
   if(DateValue !="")
   {
       for (i = 0; i < DateValue.length; i++) 
       {
          if (checkstr.indexOf(DateValue.substr(i,1)) >= 0) 
          {
             DateTemp = DateTemp + DateValue.substr(i,1);
          }
       }
       DateValue = DateTemp;           
       if (DateValue!="") 
       {
           /* Always change date to 8 digits - string*/
           /* if year is entered as 2-digit / always assume 20xx */
           if (DateValue.length == 6) {
              DateValue = DateValue.substr(0,4) + '20' + DateValue.substr(4,2); }
           if (DateValue.length != 8) {
              err = 19;}
           /* year is wrong if year = 0000 */
           year = DateValue.substr(4,4);
           if (year == 0) {
              err = 20;
           }
           /* Validation of month*/
           month = DateValue.substr(2,2);
           if ((month < 1) || (month > 12)) {
              err = 21;
           }
           /* Validation of day*/
           day = DateValue.substr(0,2);
           if (day < 1) {
             err = 22;
           }
           /* Validation leap-year / february / day */
           if ((year % 4 == 0) || (year % 100 == 0) || (year % 400 == 0)) {
              leap = 1;
           }
           if ((month == 2) && (leap == 1) && (day > 29)) {
              err = 23;
           }
           if ((month == 2) && (leap != 1) && (day > 28)) {
              err = 24;
           }
           /* Validation of other months */
           if ((day > 31) && ((month == "01") || (month == "03") || (month == "05") || (month == "07") || (month == "08") || (month == "10") || (month == "12"))) {
              err = 25;
           }
           if ((day > 30) && ((month == "04") || (month == "06") || (month == "09") || (month == "11"))) {
              err = 26;
           }
           /* if 00 ist entered, no error, deleting the entry */
           if ((day == 0) && (month == 0) && (year == 00)) {
              err = 0; day = ""; month = ""; year = ""; seperator = "";
           }
           /* if no error, write the completed date to Input-Field (e.g. 13.12.2001) */
           if (err == 0) {
              //DateField.value = day + seperator + monthname[month-1] + seperator + year;
              seperator = "-";                   
              field.value = day + seperator + monthname[month-1] + seperator + year;              
              decreseit();
              
              if (IsChkDateCrteria == 'T')
              {
                  var ActMth = document.getElementById('ctl00_ddlAct_Month');
                  var flg=1;  
                  var ChkVal=year + month + day;                
                  if(ActMth.options.length>0)
                    {
                        for (var n=0; n < ActMth.options.length; n++) 
                        { 
                            var dropdowntext=ActMth.options[n].text ; 
                            var splstr = (dropdowntext).split("-");
                            if (splstr.length==1)
                            {
                                if (parseInt(ChkVal)<parseInt(splstr[0]))
                                {
                                    field.select();
                                    field.focus();
                                    fireMessage("Date should be grater than last transction date!");
                                    return false;                                                                              
                                }
                                else
                                {
                                    if (document.getElementById('ctl00_ContentPlaceHolder1_' + BtnStr)!= null)
                                        document.getElementById('ctl00_ContentPlaceHolder1_' + BtnStr).disabled=false; 
                                    field.style.backgroundColor = 'white';
                                }
                            } 
                            else
                            {
                                if (parseInt(ChkVal)>=parseInt(splstr[0]) && parseInt(ChkVal)<=parseInt(splstr[1]))
                                {
                                    flg=0;
                                    if (document.getElementById('ctl00_ContentPlaceHolder1_' + BtnStr)!= null)
                                        document.getElementById('ctl00_ContentPlaceHolder1_' + BtnStr).disabled=false; 
                                    field.style.backgroundColor = 'white';
                                    return true;
                                }
                            }
                        } 	        
                    }
                    if (flg==1)
                    {
                        field.select();
                        field.focus();
                        fireMessage("Enter Date between active month criteria!");
                        return true;
                    }                                   
                }
           }
           /* Error-message if err != 0 */               
           else {
              //alert("Date is incorrect!");
              field.select();
              field.focus();
              fireMessage("Date is incorrect!");
              field.value='';
              return true;
           }  
       }      
       else {field.value='';}            
   }       
   field.style.backgroundColor = 'white';                 
}
    
function LostFocusCompare(field,ChkBlk,ChkPar,cmpDate,StrMsg)  
{       
   var checkstr = "0123456789";
   var DateField = field;
   var Datevalue = "";
   var DateTemp = "";
   var seperator = "/";
   var day;
   var month;
   var year;
   var leap = 0;
   var err = 0;
   var i;
   err = 0;
   
   var attributeNode = document.createAttribute ('maxlength');
   attributeNode.value = '11';
   field.setAttributeNode (attributeNode);
    
   DateValue = field.value;  //DateField.value;       
   /* Delete all chars except 0..9 */       
   if(DateValue !="")
   {
       for (i = 0; i < DateValue.length; i++) 
       {
          if (checkstr.indexOf(DateValue.substr(i,1)) >= 0) 
          {
             DateTemp = DateTemp + DateValue.substr(i,1);
          }
       }
       DateValue = DateTemp;           
       if (DateValue!="") 
       {
           /* Always change date to 8 digits - string*/
           /* if year is entered as 2-digit / always assume 20xx */
           if (DateValue.length == 6) {
              DateValue = DateValue.substr(0,4) + '20' + DateValue.substr(4,2); }
           if (DateValue.length != 8) {
              err = 19;}
           /* year is wrong if year = 0000 */
           year = DateValue.substr(4,4);
           if (year == 0) {
              err = 20;
           }
           /* Validation of month*/
           month = DateValue.substr(2,2);
           if ((month < 1) || (month > 12)) {
              err = 21;
           }
           /* Validation of day*/
           day = DateValue.substr(0,2);
           if (day < 1) {
             err = 22;
           }
           /* Validation leap-year / february / day */
           if ((year % 4 == 0) || (year % 100 == 0) || (year % 400 == 0)) {
              leap = 1;
           }
           if ((month == 2) && (leap == 1) && (day > 29)) {
              err = 23;
           }
           if ((month == 2) && (leap != 1) && (day > 28)) {
              err = 24;
           }
           /* Validation of other months */
           if ((day > 31) && ((month == "01") || (month == "03") || (month == "05") || (month == "07") || (month == "08") || (month == "10") || (month == "12"))) {
              err = 25;
           }
           if ((day > 30) && ((month == "04") || (month == "06") || (month == "09") || (month == "11"))) {
              err = 26;
           }
           /* if 00 ist entered, no error, deleting the entry */
           if ((day == 0) && (month == 0) && (year == 00)) {
              err = 0; day = ""; month = ""; year = ""; seperator = "";
           }
           /* if no error, write the completed date to Input-Field (e.g. 13.12.2001) */
           if (err == 0) {
              //DateField.value = day + seperator + monthname[month-1] + seperator + year;
              
              //Compare start   
                 var Str='';                  
                 if (ChkPar!='')
                 {
                     
                     if (ChkPar=='C'&& Date.parse(month+"/"+day+"/"+year)!=Date.parse(Date()))
                        {
                            if (StrMsg!='')
                                Str = StrMsg;
                            else
                                Str ="Date Can not Future or Past!";
                        } 
                     else if (ChkPar=='P'&& Date.parse(month+"/"+day+"/"+year)>Date.parse(Date()))                         
                        { 
                            if (StrMsg!='')
                                Str = StrMsg;
                            else
                                Str ="Date Can not Future!";
                        } 
                     if (ChkPar=='N'&& Date.parse(month+"/"+day+"/"+year)<Date.parse(Date()))
                        { 
                            //fireMessage("Date Can not Past!");field.select();field.focus();
                            if (StrMsg!='')
                                Str = StrMsg;
                            else
                                Str ="Date Can not Past!";
                        }             
                     if (ChkPar=='CP' && cmpDate!='')                         
                     {                              
                        //compare two date
                        var DateValue1 =document.getElementById('ctl00_ContentPlaceHolder1_' + cmpDate).value;                           
                        if (DateValue1!='')
                        {
                            if (ChkPar=='CP'&& Date.parse(month+"/"+day+"/"+year)!=Date.parse(monthvalue[(arrayIndexOf(monthname,DateValue1.substr(3,3)))]+"/"+DateValue1.substr(0,2)+"/"+DateValue1.substr(7,4)))
                                {                                 
                                    if (StrMsg!='') Str = StrMsg;
                                    else
                                    Str = document.getElementById('ctl00_ContentPlaceHolder1_' + cmpDate).value + " is not matching " + field.value;
                                }                 
                        }
                     }
                     if (Str!='')
                        {fireMessage(Str);field.select();field.focus();}
                 }
              //Compare end
              
              seperator = "-";                   
              field.value = day + seperator + monthname[month-1] + seperator + year;              
              decreseit();
           }
           /* Error-message if err != 0 */               
           else {
              //alert("Date is incorrect!");
              field.select();
              field.focus();
              fireMessage("Date is incorrect!");
              return true;
           }  
       }      
       else 
       {
            field.value='';                
       }            
   }       
   else
   {
        if(ChkBlk=='B')
            {
                field.select();
                field.focus();
                fireMessage("Date Can not Blank!");                  
            }
   }
   field.style.backgroundColor = 'white';                 
}

function SetFocus(field,IsSystemDateRequire)
{  
    IsSystemDateRequire = typeof(IsSystemDateRequire) != 'undefined' ? IsSystemDateRequire : true;
    var DateValue = "";
    var DateTemp = "";
    var seperator = "/";
    var err = 0;
    var i = -1;
    err = 0; 
    
    var attributeNode = document.createAttribute ('maxlength');
    //attributeNode.value = '10';
    attributeNode.value = '11';
    field.setAttributeNode (attributeNode);
         
    DateValue = field.value;  
    if (DateValue!="")
    {        
        i=(arrayIndexOf(monthname,DateValue.substr(3,3)));
        if (i!=-1)
        {
            year = DateValue.substr(7,4);
            month = monthvalue[i];   
            day = DateValue.substr(0,2);            
        }
        else
        { return 0;}            
        field.value = day + seperator + month + seperator + year;
    }
    else
    {
        if (IsSystemDateRequire == true)
        {
        var CurrDate = new Date();                    
        var curr_date = CurrDate.getDate();           
        var curr_month = CurrDate.getMonth();
        var curr_year = CurrDate.getFullYear();        
        field.value = dayvalue[curr_date-1] + seperator + monthvalue[curr_month] + seperator + curr_year;
        }
        else
        {
        field.value = "";
        }
    }
    field.style.backgroundColor = 'FEFFC4';   
    field.select();
}
    
function SetFocus4(field)
{  

    var DateValue = "";
    var DateTemp = "";
    var seperator = "/";
    var err = 0;
    var i = -1;
    err = 0; 
    
    var attributeNode = document.createAttribute ('maxlength');
    //attributeNode.value = '10';
    attributeNode.value = '11';
    field.setAttributeNode (attributeNode);
         
    DateValue = field.value;  
    if (DateValue!="")
    {        
        i=(arrayIndexOf(monthname,DateValue.substr(3,3)));
        if (i!=-1)
        {
            year = DateValue.substr(7,4);        
            month = monthvalue[i];   
            day = DateValue.substr(0,2);            
        }
        else
        { return 0;}            
        field.value = day + seperator + month + seperator + year;
    }
    else
    {
        var CurrDate = new Date();                    
        var curr_date = CurrDate.getDate();
        curr_date = curr_date + 4;
        var curr_month = CurrDate.getMonth();
        var curr_year = CurrDate.getFullYear();        
        field.value = dayvalue[curr_date-1] + seperator + monthvalue[curr_month] + seperator + curr_year;
    }
    field.style.backgroundColor = 'FEFFC4';   
    field.select();
}   
// Date Function End