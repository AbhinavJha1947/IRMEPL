//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORSendSMSHistory.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORSendSMSHistoryService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORSendSMSHistory
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _sms_id;
        private string _CustomerId;
        private string _mobileno;
        private string _message;
        private int _SendStatus;
        private string _Remarks;
        private string _ErrorDescription;
        private int _CreatedBy;
        private string _CreatedDate;
        private string _sentdate;
        #endregion

        /// <summary>
        /// Default constructor for CORSendSMSHistory class.
        /// </summary>
        public CORSendSMSHistory() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORSendSMSHistory(int sms_id, string CustomerId, string mobileno, string message, int SendStatus, string Remarks, string ErrorDescription, string sentdate, int CreatedBy, string CreatedDate)
        {
            this._sms_id = sms_id;
            this._CustomerId = CustomerId;
            this._mobileno = mobileno;
            this._Remarks = Remarks;
            this._ErrorDescription = ErrorDescription;
            this._message = message;
            this._SendStatus = SendStatus;
            this._CreatedBy = CreatedBy;
            this._CreatedDate = CreatedDate;
            this._sentdate = sentdate;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int sms_id
        {
            get { return _sms_id; }
            set { _sms_id = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string mobileno
        {
            get { return _mobileno; }
            set { _mobileno = value; }
        }

        public string sentdate
        {
            get { return _sentdate; }
            set { _sentdate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        public string ErrorDescription
        {
            get { return _ErrorDescription; }
            set { _ErrorDescription = value; }
        }

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        public int SendStatus
        {
            get { return _SendStatus; }
            set { _SendStatus = value; }
        }     

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }

    }

    public class CORSendSMSHistoryList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _sms_id;
        private string _CustomerId;
        private string _mobileno;
        private string _message;
        private string _enterdate;
        private string _sentdate;
        private string _SendStatus;
        private int _SendSMSCounter;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORSendSMSHistoryList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORSendSMSHistoryList(int sms_id, string CustomerId, string mobileno, string message, string enterdate, string sentdate, string SendStatus, int SendSMSCounter)
        {
            this._sms_id = sms_id;
            this._CustomerId = CustomerId;
            this._mobileno = mobileno;
            this._message = message;
            this._enterdate = enterdate;
            this._sentdate = sentdate;
            this._SendStatus = SendStatus;
            this._SendSMSCounter = SendSMSCounter;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int sms_id
        {
            get { return _sms_id; }
            set { _sms_id = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string mobileno
        {
            get { return _mobileno; }
            set { _mobileno = value; }
        }

        public string message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string enterdate
        {
            get { return _enterdate; }
            set { _enterdate = value; }
        }

        public string sentdate
        {
            get { return _sentdate; }
            set { _sentdate = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SendStatus
        {
            get { return _SendStatus; }
            set { _SendStatus = value; }
        }

        public int SendSMSCounter
        {
            get { return _SendSMSCounter; }

        }
    }


    public class CORSendSMSHistoryMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORSendSMSHistoryMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORSendSMSHistoryMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }
        /// <summary>
        //Gets or sets unique Salutation identifier. 
        //The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}
