//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDOMNoticeGeneration.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDOMNoticeGenerationService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDOMNoticeGeneration
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _OMNTRN_ID;
        private string _OMNTRN_NoticeNo;
        private string _OMNTRN_Date;
        private int _OMNTRn_AppID;
        private string _OMNTRN_CustomerID;
        private int _OMNTRN_Createdby;
        private string _OMNTRN_CreatedDate;
        #endregion

        /// <summary>
        /// Default constructor for PRDOMNoticeGeneration class.
        /// </summary>
        public PRDOMNoticeGeneration() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDOMNoticeGeneration(int OMNTRN_ID, string OMNTRN_NoticeNo, string OMNTRN_Date, int OMNTRn_AppID, string OMNTRN_CustomerID, int OMNTRN_Createdby, string OMNTRN_CreatedDate)
        {
            this._OMNTRN_ID = OMNTRN_ID;
            this._OMNTRN_NoticeNo = OMNTRN_NoticeNo;
            this._OMNTRN_Date = OMNTRN_Date;
            this._OMNTRn_AppID = OMNTRn_AppID;
            this._OMNTRN_CustomerID = OMNTRN_CustomerID;
            this._OMNTRN_Createdby = OMNTRN_Createdby;
            this._OMNTRN_CreatedDate = OMNTRN_CreatedDate;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OMNTRN_ID
        {
            get { return _OMNTRN_ID; }
            set { _OMNTRN_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMNTRN_NoticeNo
        {
            get { return _OMNTRN_NoticeNo; }
            set { _OMNTRN_NoticeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMNTRN_Date
        {
            get { return _OMNTRN_Date; }
            set { _OMNTRN_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OMNTRn_AppID
        {
            get { return _OMNTRn_AppID; }
            set { _OMNTRn_AppID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMNTRN_CustomerID
        {
            get { return _OMNTRN_CustomerID; }
            set { _OMNTRN_CustomerID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int OMNTRN_Createdby
        {
            get { return _OMNTRN_Createdby; }
            set { _OMNTRN_Createdby = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMNTRN_CreatedDate
        {
            get { return _OMNTRN_CreatedDate; }
            set { _OMNTRN_CreatedDate = value; }
        }

    }

    public class PRDOMNoticeGenerationList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _OMNTRN_ID;
        private string _OMNTRN_NoticeNo;
        private string _OMNTRN_Date;
        //private int _OMNTRn_AppID;
        private string _OMNTRN_CustomerID;
        //private int _OMNTRN_Createdby;
        //private string _OMNTRN_CreatedDate;
        private string _Name;
        private string _Address;
        private string _Area;
        private int _Count;
        #endregion

        public PRDOMNoticeGenerationList()
        {

        }
        public PRDOMNoticeGenerationList(int OMNTRN_ID, string NoticeNo, string NoticeDate, string CustomerId, string Name, string Address1, string Area, int Count)
        {
            this._OMNTRN_ID = OMNTRN_ID;
            this._OMNTRN_NoticeNo = NoticeNo;
            this._OMNTRN_Date = NoticeDate;
            this._OMNTRN_CustomerID = CustomerId;
            this._Name = Name;
            this._Address = Address1;
            this._Area = Area;
            this._Count = Count;
        }

        public int OMNTRN_ID
        {
            get { return _OMNTRN_ID; }
            set { _OMNTRN_ID = value; }
        }
        public string NoticeNo
        {
            get { return _OMNTRN_NoticeNo; }
            set { _OMNTRN_NoticeNo = value; }
        }
        public string NoticeDate
        {
            get { return _OMNTRN_Date; }
            set { _OMNTRN_Date = value; }
        }
        public string CustomerId
        {
            get { return _OMNTRN_CustomerID; }
            set { _OMNTRN_CustomerID = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Address1
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }


    }


    public class PRDOMNoticeGenerationMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDOMNoticeGenerationMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDOMNoticeGenerationMsg(int RetVal, string RetStr)
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

