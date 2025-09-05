//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORSendEmailHistory.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORSendEmailHistoryService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORSendEmailHistory
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _Id;
        private string _CustomerId;
        private string _ToEmailAddress;
        private string _CCEmailAddress;
        private string _EmailSubject;
        private string _EmailBody;
        private int _SendStatus;
        private int _NoOfAttachment;
        private string _AttachmentPath;
        private int _CreatedBy;
        private string _CreatedDate;
        private int _IsAttachReq;
        #endregion

        /// <summary>
        /// Default constructor for CORSendEmailHistory class.
        /// </summary>
        public CORSendEmailHistory() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORSendEmailHistory(int Id, string CustomerId, string ToEmailAddress, string CCEmailAddress, string EmailSubject, string EmailBody, int SendStatus, int NoOfAttachment, string AttachmentPath, int CreatedBy, string CreatedDate, int IsAttachReq)
        {
            this._Id = Id;
            this._CustomerId = CustomerId;
            this._ToEmailAddress = ToEmailAddress;
            this._CCEmailAddress = CCEmailAddress;
            this._EmailSubject = EmailSubject;
            this._EmailBody = EmailBody;
            this._NoOfAttachment = NoOfAttachment;
            this._AttachmentPath = AttachmentPath;
            this._SendStatus = SendStatus;
            this._CreatedBy = CreatedBy;
            this._CreatedDate = CreatedDate;
            this._IsAttachReq = IsAttachReq;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        public string ToEmailAddress
        {
            get { return _ToEmailAddress; }
            set { _ToEmailAddress = value; }
        }

        public string CCEmailAddress
        {
            get { return _CCEmailAddress; }
            set { _CCEmailAddress = value; }
        }      

        public string EmailSubject
        {
            get { return _EmailSubject; }
            set { _EmailSubject = value; }
        }

        public string EmailBody
        {
            get { return _EmailBody; }
            set { _EmailBody = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NoOfAttachment
        {
            get { return _NoOfAttachment; }
            set { _NoOfAttachment = value; }
        }

        public string AttachmentPath
        {
            get { return _AttachmentPath; }
            set { _AttachmentPath = value; }
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

        public int IsAttachReq
        {
            get { return _IsAttachReq; }
            set { _IsAttachReq = value; }
        }


    }

    public class CORSendEmailHistoryList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _Id;
        private string _CustomerId;
        private string _ToEmailAddress;
        private string _CCEmailAddress;
        private string _EmailSubject;
        private string _EmailBody;
        private string _SendStatus;
        private int _NoOfAttachment;
        private string _AttachmentPath;
        private int _CreatedBy;
        private string _CreatedDate;
        private int _SendEmailCounter;
        private int _IsAttachReq;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORSendEmailHistoryList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORSendEmailHistoryList(int Id, string CustomerId, string ToEmailAddress, string CCEmailAddress, string EmailSubject, string EmailBody, int NoOfAttachment, string AttachmentPath, string SendStatus, int CreatedBy, string CreatedDate, int SendEmailCounter, int IsAttachReq)
        {
            this._Id = Id;
            this._CustomerId = CustomerId;
            this._ToEmailAddress = ToEmailAddress;
            this._CCEmailAddress = CCEmailAddress;
            this._EmailSubject = EmailSubject;
            this._EmailBody = EmailBody;
            this._NoOfAttachment = NoOfAttachment;
            this._AttachmentPath = AttachmentPath;
            this._SendStatus = SendStatus;
            this._CreatedBy = CreatedBy;
            this._CreatedDate = CreatedDate;
            this._SendEmailCounter = SendEmailCounter;
            this._IsAttachReq = IsAttachReq;
        }

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
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
        public string ToEmailAddress
        {
            get { return _ToEmailAddress; }
            set { _ToEmailAddress = value; }
        }

        public string CCEmailAddress
        {
            get { return _CCEmailAddress; }
            set { _CCEmailAddress = value; }
        }

        public string EmailSubject
        {
            get { return _EmailSubject; }
            set { _EmailSubject = value; }
        }

        public string EmailBody
        {
            get { return _EmailBody; }
            set { _EmailBody = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NoOfAttachment
        {
            get { return _NoOfAttachment; }
            set { _NoOfAttachment = value; }
        }

        public string AttachmentPath
        {
            get { return _AttachmentPath; }
            set { _AttachmentPath = value; }
        }



        public string SendStatus
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

        public int IsAttachReq
        {
            get { return _IsAttachReq; }
            set { _IsAttachReq = value; }
        }

        public int SendEmailCounter
        {
            get { return _SendEmailCounter; }

        }
    }


    public class CORSendEmailHistoryMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORSendEmailHistoryMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORSendEmailHistoryMsg(int RetVal, string RetStr)
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
