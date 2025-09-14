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
    
    
    function LostFoc(field)
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
               if(year>'2078')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               if(year<'1900')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               /* if no error, write the completed date to Input-Field (e.g. 13.12.2001) */
               if (err == 0) {
                  //DateField.value = day + seperator + monthname[month-1] + seperator + year;
                  seperator = "/";                   
                  field.value = day + seperator + month + seperator + year;
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
           else {field.value='';}            
       }       
       field.style.backgroundColor = 'white';                    
    }
    
    function LostFocus1(field)
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
           else {field.value='';}            
       } 
       if (DateValue=="")
       {
       
       field.value="Enter Text To Search"
       field.style.ForeColor;
    
       }          
       field.style.backgroundColor = 'white';                 
    }



    function LostFocu(field)
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
               if(year>'2078')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               if(year<'1900')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               /* if no error, write the completed date to Input-Field (e.g. 13.12.2001) */
               if (err == 0) {
                  //DateField.value = day + seperator + monthname[month-1] + seperator + year;
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
           else {field.value='';}            
       }    
            field.style.backgroundColor = 'FEFFC4';   
        //field.select();
       //field.style.backgroundColor = 'white';                 
    }





    function LostFocus(field)
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
               if(year>'2078')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               if(year<'1900')
               {
                  field.select();
                  field.focus();
                  fireMessage("year is not accepted");
                  return true;
               }
               /* if no error, write the completed date to Input-Field (e.g. 13.12.2001) */
               if (err == 0) {
                  //DateField.value = day + seperator + monthname[month-1] + seperator + year;
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
           else {field.value='';}            
       }    
            //field.style.backgroundColor = 'FEFFC4';   
        //field.select();
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








	
	 function SetFocus1(field)
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
        if (DateValue!="Enter Text To Search")
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
            var curr_month = CurrDate.getMonth();
            var curr_year = CurrDate.getFullYear();        
            field.value = dayvalue[curr_date-1] + seperator + monthvalue[curr_month] + seperator + curr_year;
        }
        field.style.backgroundColor = 'FEFFC4';   
        field.select();
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
// Date Function End

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
// Numeric Value Function End

//
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
///Only characters 
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
        text.innerHTML = 'Processing Request...'
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
