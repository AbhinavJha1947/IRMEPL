//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORBillGeneralInfoMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see CORBillGeneralInfoMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>

    
    public class CORBillGeneralInfoMaster
    {
         /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BGIMST_ID;
        private int _BGIMST_CenterCode;
        private string _BGIMST_FromDate;
        private string _BGIMST_ToDate;
        private string _BGIMST_Information;
        private int _BGIMST_RowStatus;
        private int _BGIMST_CreatedByUserID;
        private string _BGIMST_CreatedDateTime;
        private int _BGIMST_UpdatedByUserID;
        private string _BGIMST_UpdatedDateTime;       
        private long _BGIMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORCorporateMaster class.
        /// </summary>
        public CORBillGeneralInfoMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORBillGeneralInfoMaster(int BGIMST_ID, int BGIMST_CenterCode, string BGIMST_FromDate, string BGIMST_ToDate, string BGIMST_Information, int BGIMST_RowStatus, int BGIMST_CreatedByUserID, string BGIMST_CreatedDateTime, int BGIMST_UpdatedByUserID, string BGIMST_UpdatedDateTime, long BGIMST_RowVersion)
        {
            this._BGIMST_ID = BGIMST_ID;
            this._BGIMST_CenterCode = BGIMST_CenterCode;
            this._BGIMST_FromDate = BGIMST_FromDate;
            this._BGIMST_ToDate = BGIMST_ToDate;
            this._BGIMST_Information = BGIMST_Information;
            this._BGIMST_RowStatus = BGIMST_RowStatus;
            this._BGIMST_CreatedByUserID = BGIMST_CreatedByUserID;
            this._BGIMST_CreatedDateTime = BGIMST_CreatedDateTime;
            this._BGIMST_UpdatedByUserID = BGIMST_UpdatedByUserID;
            this._BGIMST_UpdatedDateTime = BGIMST_UpdatedDateTime;
            this._BGIMST_RowVersion = BGIMST_RowVersion;
           
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_ID
        {
            get { return _BGIMST_ID; }
            set { _BGIMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_CenterCode
        {
            get { return _BGIMST_CenterCode; }
            set { _BGIMST_CenterCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_FromDate
        {
            get { return _BGIMST_FromDate; }
            set { _BGIMST_FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_ToDate
        {
            get { return _BGIMST_ToDate; }
            set { _BGIMST_ToDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_Information
        {
            get { return _BGIMST_Information; }
            set { _BGIMST_Information = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_RowStatus
        {
            get { return _BGIMST_RowStatus; }
            set { _BGIMST_RowStatus = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_CreatedByUserID
        {
            get { return _BGIMST_CreatedByUserID; }
            set { _BGIMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_CreatedDateTime
        {
            get { return _BGIMST_CreatedDateTime; }
            set { _BGIMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_UpdatedByUserID
        {
            get { return _BGIMST_UpdatedByUserID; }
            set { _BGIMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_UpdatedDateTime
        {
            get { return _BGIMST_UpdatedDateTime; }
            set { _BGIMST_UpdatedDateTime = value; }
        }

       
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long BGIMST_RowVersion
        {
            get { return _BGIMST_RowVersion; }
            set { _BGIMST_RowVersion = value; }
        }

    }

    public class CORBillGeneralInfoMasterList
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _BGIMST_ID;        
        private string _BGIMST_FromDate;
        private string _BGIMST_ToDate;
        private string _BGIMST_Information;
        private string _CENMST_Name;
        private string _BGIMST_RowStatus;
        private int _BGIMSTCount;
        #endregion

        /// <summary>
        /// Default constructor for CORAreaMaster class.
        /// </summary>
        public CORBillGeneralInfoMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORBillGeneralInfoMasterList(int BGIMST_ID, string BGIMST_FromDate, string BGIMST_ToDate, string BGIMST_Information, string CENMST_Name, string BGIMST_RowStatus, int BGIMSTCount)
        {

            this._BGIMST_ID = BGIMST_ID;           
            this._BGIMST_FromDate = BGIMST_FromDate;
            this._BGIMST_ToDate = BGIMST_ToDate;
            this._BGIMST_Information = BGIMST_Information;
            this._CENMST_Name = CENMST_Name;
            this._BGIMST_RowStatus = BGIMST_RowStatus;
            this._BGIMSTCount = BGIMSTCount;

        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int BGIMST_ID
        {
            get { return _BGIMST_ID; }
            set { _BGIMST_ID = value; }
        }

       
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_FromDate
        {
            get { return _BGIMST_FromDate; }
            set { _BGIMST_FromDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_ToDate
        {
            get { return _BGIMST_ToDate; }
            set { _BGIMST_ToDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_Information
        {
            get { return _BGIMST_Information; }
            set { _BGIMST_Information = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string BGIMST_RowStatus
        {
            get { return _BGIMST_RowStatus; }
            set { _BGIMST_RowStatus = value; }
        }
        public int BGIMSTCount
        {
            get { return _BGIMSTCount; }
            set { _BGIMSTCount = value; }
        }
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }

    public class CORBillGeneralInfoMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORBillGeneralInfoMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORBillGeneralInfoMasterMsg(int RetVal, string RetStr)
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

