//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORContractorMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORContractorMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORContractorMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CONMST_Code;
        private string _CONMST_Name;
        private int _CONMST_ContType;
        private int _CONMST_CenCode;
        private int _CONMST_CreatedByUserID;
        private string _CONMST_CreatedDateTime;
        private int _CONMST_UpdatedByUserID;
        private string _CONMST_UpdatedDateTime;
        private int _CONMST_RowStatus;
        private long _CONMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CORContractorMaster class.
        /// </summary>
        public CORContractorMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORContractorMaster(int CONMST_Code, string CONMST_Name, int CONMST_ContType,int CONMST_CenCode, int CONMST_CreatedByUserID, string CONMST_CreatedDateTime, int CONMST_UpdatedByUserID, string CONMST_UpdatedDateTime, int CONMST_RowStatus, long CONMST_RowVersion)
        {
            this._CONMST_Code = CONMST_Code;
            this._CONMST_Name = CONMST_Name;
            this._CONMST_ContType = CONMST_ContType;
            this._CONMST_CreatedByUserID = CONMST_CreatedByUserID;
            this._CONMST_CreatedDateTime = CONMST_CreatedDateTime;
            this._CONMST_UpdatedByUserID = CONMST_UpdatedByUserID;
            this._CONMST_UpdatedDateTime = CONMST_UpdatedDateTime;
            this._CONMST_RowStatus = CONMST_RowStatus;
            this._CONMST_RowVersion = CONMST_RowVersion;
            this._CONMST_CenCode = CONMST_CenCode;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_Code
        {
            get { return _CONMST_Code; }
            set { _CONMST_Code = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_CenCode
        {
            get { return _CONMST_CenCode; }
            set { _CONMST_CenCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_Name
        {
            get { return _CONMST_Name; }
            set { _CONMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_ContType
        {
            get { return _CONMST_ContType; }
            set { _CONMST_ContType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_CreatedByUserID
        {
            get { return _CONMST_CreatedByUserID; }
            set { _CONMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_CreatedDateTime
        {
            get { return _CONMST_CreatedDateTime; }
            set { _CONMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_UpdatedByUserID
        {
            get { return _CONMST_UpdatedByUserID; }
            set { _CONMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_UpdatedDateTime
        {
            get { return _CONMST_UpdatedDateTime; }
            set { _CONMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_RowStatus
        {
            get { return _CONMST_RowStatus; }
            set { _CONMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CONMST_RowVersion
        {
            get { return _CONMST_RowVersion; }
            set { _CONMST_RowVersion = value; }
        }

    }

    public class CORContractorMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
         #region "Variables Declaration"
        private int _CONMST_Code;
        private string _CONMST_Name;
        private string _CONMST_ContType;
        private string _CONMST_RowStatus;
        private int _CONMST_Count;
        private int _CONMST_CenCode;
        private string _CENMST_Name;
        #endregion

        /// <summary>
        /// Default constructor for CORContractorMaster class.
        /// </summary>
        public CORContractorMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORContractorMasterList(int CONMST_Code, string CONMST_Name, string CONMST_ContType, int CONMST_CenCode, string CONMST_RowStatus, string CENMST_Name, int CONMST_Count)
        {
            this._CONMST_Code = CONMST_Code;
            this._CONMST_Name = CONMST_Name;
            this._CONMST_ContType = CONMST_ContType;
            this._CONMST_RowStatus = CONMST_RowStatus;
            this._CONMST_Count = CONMST_Count;
            this._CONMST_CenCode = CONMST_CenCode;
            this._CENMST_Name = CENMST_Name;
            
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_CenCode
        {
            get { return _CONMST_CenCode; }
            set { _CONMST_CenCode = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_Code
        {
            get { return _CONMST_Code; }
            set { _CONMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_Name
        {
            get { return _CONMST_Name; }
            set { _CONMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_ContType
        {
            get { return _CONMST_ContType; }
            set { _CONMST_ContType = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CONMST_Count
        {
            get { return _CONMST_Count; }
            set { _CONMST_Count = value; }
        }
       
       
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CONMST_RowStatus
        {
            get { return _CONMST_RowStatus; }
            set { _CONMST_RowStatus = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }
        
    }
    public class CORContractorMasterMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public CORContractorMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORContractorMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        /// Gets or sets unique Salutation identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        /// Gets or sets Country Name.        
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}
