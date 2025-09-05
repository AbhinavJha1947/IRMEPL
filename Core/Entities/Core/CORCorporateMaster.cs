//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORCorporateMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORCorporateMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORCorporateMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CORMST_CorporateID;
        private string _CORMST_CorRefCode;
        private string _CORMST_CorName;
        private string _CORMST_CorAddress;
        private int _CORMST_CenCode;
        private int _CORMST_Planid;
        private int _CORMST_CreatedByUserID;
        private string _CORMST_CreatedDateTime;
        private int _CORMST_UpdatedByUserID;
        private string _CORMST_UpdatedDateTime;
        private int _CORMST_RowStatus;
        private long _CORMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORCorporateMaster class.
        /// </summary>
        public CORCorporateMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORCorporateMaster(int CORMST_CorporateID, string CORMST_CorRefCode, string CORMST_CorName, string CORMST_CorAddress, int CORMST_CenCode, int CORMST_Planid, int CORMST_CreatedByUserID, string CORMST_CreatedDateTime, int CORMST_UpdatedByUserID, string CORMST_UpdatedDateTime, int CORMST_RowStatus, long CORMST_RowVersion)
        {
            this._CORMST_CorporateID = CORMST_CorporateID;
            this._CORMST_CorRefCode = CORMST_CorRefCode;
            this._CORMST_CorName = CORMST_CorName;
            this._CORMST_CorAddress = CORMST_CorAddress;
            this._CORMST_CenCode = CORMST_CenCode;
            this._CORMST_CreatedByUserID = CORMST_CreatedByUserID;
            this._CORMST_CreatedDateTime = CORMST_CreatedDateTime;
            this._CORMST_UpdatedByUserID = CORMST_UpdatedByUserID;
            this._CORMST_UpdatedDateTime = CORMST_UpdatedDateTime;
            this._CORMST_RowStatus = CORMST_RowStatus;
            this._CORMST_RowVersion = CORMST_RowVersion;
            this._CORMST_Planid = CORMST_Planid;
            this._CORMST_RowStatus = CORMST_RowStatus;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_CorporateID
        {
            get { return _CORMST_CorporateID; }
            set { _CORMST_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorRefCode
        {
            get { return _CORMST_CorRefCode; }
            set { _CORMST_CorRefCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorName
        {
            get { return _CORMST_CorName; }
            set { _CORMST_CorName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorAddress
        {
            get { return _CORMST_CorAddress; }
            set { _CORMST_CorAddress = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_CenCode
        {
            get { return _CORMST_CenCode; }
            set { _CORMST_CenCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_Planid
        {
            get { return _CORMST_Planid; }
            set { _CORMST_Planid = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_CreatedByUserID
        {
            get { return _CORMST_CreatedByUserID; }
            set { _CORMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CreatedDateTime
        {
            get { return _CORMST_CreatedDateTime; }
            set { _CORMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_UpdatedByUserID
        {
            get { return _CORMST_UpdatedByUserID; }
            set { _CORMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_UpdatedDateTime
        {
            get { return _CORMST_UpdatedDateTime; }
            set { _CORMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_RowStatus
        {
            get { return _CORMST_RowStatus; }
            set { _CORMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CORMST_RowVersion
        {
            get { return _CORMST_RowVersion; }
            set { _CORMST_RowVersion = value; }
        }

    }

    public class CORCorporateMasterList
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CORMST_CorporateID;
        private string _CORMST_CorRefCode;
        private string _CORMST_CorName;
        private string _CORMST_CorAddress;
        private int _CORMST_PlanID;
        private string _PLAMST_PlanName;
        private string _CenterName;
        private string _CORMST_RowStatus;
        private int _CorporateCount;
        #endregion

        /// <summary>
        /// Default constructor for CORAreaMaster class.
        /// </summary>
        public CORCorporateMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORCorporateMasterList(int CORMST_CorporateID, string CORMST_CorRefCode, string CORMST_CorName, string CORMST_CorAddress, int CORMST_PlanID, string PLAMST_PlanName, string CenterName, string CORMST_RowStatus, int CorporateCount)
        {

            this._CORMST_CorporateID = CORMST_CorporateID;
            this._CORMST_CorRefCode = CORMST_CorRefCode;
            this._CORMST_CorName = CORMST_CorName;
            this._CORMST_CorAddress = CORMST_CorAddress;
            this._CORMST_PlanID = CORMST_PlanID;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._CenterName = CenterName;
            this._CORMST_RowStatus = CORMST_RowStatus;
            this._CorporateCount = CorporateCount;

        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_CorporateID
        {
            get { return _CORMST_CorporateID; }
            set { _CORMST_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorRefCode
        {
            get { return _CORMST_CorRefCode; }
            set { _CORMST_CorRefCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorName
        {
            get { return _CORMST_CorName; }
            set { _CORMST_CorName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_CorAddress
        {
            get { return _CORMST_CorAddress; }
            set { _CORMST_CorAddress = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CORMST_PlanID
        {
            get { return _CORMST_PlanID; }
            set { _CORMST_PlanID = value; }
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CenterName
        {
            get { return _CenterName; }
            set { _CenterName = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CORMST_RowStatus
        {
            get { return _CORMST_RowStatus; }
            set { _CORMST_RowStatus = value; }
        }
        public int CorporateCount
        {
            get { return _CorporateCount; }
            set { _CorporateCount = value; }
        }
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }


    public class CORCorporateMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORCorporateMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORCorporateMasterMsg(int RetVal, string RetStr)
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
