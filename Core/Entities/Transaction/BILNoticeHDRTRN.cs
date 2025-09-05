//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	BILNoticeHDRTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	BILNoticeHDRTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class BILNoticeHDRTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _NOTHDR_NoticeNo;
        private string _NOTHDR_NoticeRefNo;
        private string _NOTHDR_NoticeDate;
        private decimal _NOTHDR_ApplicationId;
        private string _NOTHDR_CustomerId;
        private string _NOTHDR_Name;
        private string _NOTHDR_Address;
        private string _NOTHDR_Area;
        private decimal _NOTHDR_TotalOsAmt;
        private int _NOTHDR_PaidBefore;
        private int _NOTHDR_CreatedByUserID;
        private string _NOTHDR_CreatedDateTime;
        private int _NOTHDR_UpdatedByUserID;
        private string _NOTHDR_UpdatedDateTime;
        private int _NOTHDR_RowStatus;
        private long _NOTHDR_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for BILNoticeHDRTRN class.
        /// </summary>
        public BILNoticeHDRTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILNoticeHDRTRN(decimal NOTHDR_NoticeNo, string NOTHDR_NoticeRefNo, string NOTHDR_NoticeDate, decimal NOTHDR_ApplicationId, string NOTHDR_CustomerId, string NOTHDR_Name, string NOTHDR_Address, string NOTHDR_Area, decimal NOTHDR_TotalOsAmt, int NOTHDR_PaidBefore, int NOTHDR_CreatedByUserID, string NOTHDR_CreatedDateTime, int NOTHDR_UpdatedByUserID, string NOTHDR_UpdatedDateTime, int NOTHDR_RowStatus, long NOTHDR_RowVersion)
        {
            this._NOTHDR_NoticeNo = NOTHDR_NoticeNo;
            this._NOTHDR_NoticeRefNo = NOTHDR_NoticeRefNo;
            this._NOTHDR_NoticeDate = NOTHDR_NoticeDate;
            this._NOTHDR_ApplicationId = NOTHDR_ApplicationId;
            this._NOTHDR_CustomerId = NOTHDR_CustomerId;
            this._NOTHDR_Name = NOTHDR_Name;
            this._NOTHDR_Address = NOTHDR_Address;
            this._NOTHDR_Area = NOTHDR_Area;
            this._NOTHDR_TotalOsAmt = NOTHDR_TotalOsAmt;
            this._NOTHDR_PaidBefore = NOTHDR_PaidBefore;
            this._NOTHDR_CreatedByUserID = NOTHDR_CreatedByUserID;
            this._NOTHDR_CreatedDateTime = NOTHDR_CreatedDateTime;
            this._NOTHDR_UpdatedByUserID = NOTHDR_UpdatedByUserID;
            this._NOTHDR_UpdatedDateTime = NOTHDR_UpdatedDateTime;
            this._NOTHDR_RowStatus = NOTHDR_RowStatus;
            this._NOTHDR_RowVersion = NOTHDR_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_NoticeNo
        {
            get { return _NOTHDR_NoticeNo; }
            set { _NOTHDR_NoticeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_NoticeRefNo
        {
            get { return _NOTHDR_NoticeRefNo; }
            set { _NOTHDR_NoticeRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_NoticeDate
        {
            get { return _NOTHDR_NoticeDate; }
            set { _NOTHDR_NoticeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_ApplicationId
        {
            get { return _NOTHDR_ApplicationId; }
            set { _NOTHDR_ApplicationId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_CustomerId
        {
            get { return _NOTHDR_CustomerId; }
            set { _NOTHDR_CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Name
        {
            get { return _NOTHDR_Name; }
            set { _NOTHDR_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Address
        {
            get { return _NOTHDR_Address; }
            set { _NOTHDR_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Area
        {
            get { return _NOTHDR_Area; }
            set { _NOTHDR_Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_TotalOsAmt
        {
            get { return _NOTHDR_TotalOsAmt; }
            set { _NOTHDR_TotalOsAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NOTHDR_PaidBefore
        {
            get { return _NOTHDR_PaidBefore; }
            set { _NOTHDR_PaidBefore = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NOTHDR_CreatedByUserID
        {
            get { return _NOTHDR_CreatedByUserID; }
            set { _NOTHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_CreatedDateTime
        {
            get { return _NOTHDR_CreatedDateTime; }
            set { _NOTHDR_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NOTHDR_UpdatedByUserID
        {
            get { return _NOTHDR_UpdatedByUserID; }
            set { _NOTHDR_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_UpdatedDateTime
        {
            get { return _NOTHDR_UpdatedDateTime; }
            set { _NOTHDR_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int NOTHDR_RowStatus
        {
            get { return _NOTHDR_RowStatus; }
            set { _NOTHDR_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long NOTHDR_RowVersion
        {
            get { return _NOTHDR_RowVersion; }
            set { _NOTHDR_RowVersion = value; }
        }

    }

    public class BILNoticeHDRTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _NOTHDR_NoticeNo;
        private string _NOTHDR_NoticeRefNo;
        private string _NOTHDR_NoticeDate;
        private string _NOTHDR_CustomerId;
        private string _NOTHDR_Name;
        private string _NOTHDR_Address;
        private string _NOTHDR_Area;
        private decimal _NOTHDR_TotalOsAmt;
        private int _Count;
        private int _NOTHDR_PaidBefore;
        private int _NOTHDR_NoticeOn;
        private decimal _NOTHDR_DebitNoteAmt;
        #endregion

        public BILNoticeHDRTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public BILNoticeHDRTRNList(decimal NOTHDR_DebitNoteAmt,decimal NOTHDR_NoticeNo, string NOTHDR_NoticeRefNo, string NOTHDR_NoticeDate, string NOTHDR_CustomerId, string NOTHDR_Name, string NOTHDR_Address, string NOTHDR_Area, decimal NOTHDR_TotalOsAmt,int Count,int NOTHDR_PaidBefore,int NOTHDR_NoticeOn)
        {
            this._NOTHDR_NoticeNo = NOTHDR_NoticeNo;
            this._NOTHDR_NoticeRefNo = NOTHDR_NoticeRefNo;
            this._NOTHDR_NoticeDate = NOTHDR_NoticeDate;
            this._NOTHDR_CustomerId = NOTHDR_CustomerId;
            this._NOTHDR_Name = NOTHDR_Name;
            this._NOTHDR_Address = NOTHDR_Address;
            this._NOTHDR_Area = NOTHDR_Area;
            this._NOTHDR_TotalOsAmt = NOTHDR_TotalOsAmt;
            this._Count = Count;
            this._NOTHDR_PaidBefore = NOTHDR_PaidBefore;
            this._NOTHDR_NoticeOn = NOTHDR_NoticeOn;
            this._NOTHDR_DebitNoteAmt = NOTHDR_DebitNoteAmt;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_DebitNoteAmt
        {
            get { return _NOTHDR_DebitNoteAmt; }
            set { _NOTHDR_DebitNoteAmt = value; }
        }
      
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_NoticeNo
        {
            get { return _NOTHDR_NoticeNo; }
            set { _NOTHDR_NoticeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_NoticeRefNo
        {
            get { return _NOTHDR_NoticeRefNo; }
            set { _NOTHDR_NoticeRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_NoticeDate
        {
            get { return _NOTHDR_NoticeDate; }
            set { _NOTHDR_NoticeDate = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_CustomerId
        {
            get { return _NOTHDR_CustomerId; }
            set { _NOTHDR_CustomerId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Name
        {
            get { return _NOTHDR_Name; }
            set { _NOTHDR_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Address
        {
            get { return _NOTHDR_Address; }
            set { _NOTHDR_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string NOTHDR_Area
        {
            get { return _NOTHDR_Area; }
            set { _NOTHDR_Area = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal NOTHDR_TotalOsAmt
        {
            get { return _NOTHDR_TotalOsAmt; }
            set { _NOTHDR_TotalOsAmt = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public int NOTHDR_PaidBefore
        {
            get { return _NOTHDR_PaidBefore; }
            set { _NOTHDR_PaidBefore = value; }
        }
        public int NOTHDR_NoticeOn
        {
            get { return _NOTHDR_NoticeOn; }
            set { _NOTHDR_NoticeOn = value; }
        }
    }


    public class BILNoticeHDRTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public BILNoticeHDRTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public BILNoticeHDRTRNMsg(int RetVal, string RetStr)
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
