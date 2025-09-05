//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORMeterMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORMeterMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORMeterMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _StartNo;
        private int _EndNo;
        private Int64 _METMST_MeterNo;
        private int _METMST_Alloted;
        private int _METMST_CENCode;
        private int _METMST_CreatedByUserID;
        private string _METMST_CreatedDateTime;
        private int _METMST_UpdatedByUserID;
        private string _METMST_UpdatedDateTime;
        private int _METMST_RowStatus;
        private long _METMST_RowVersion;
        private int _METMST_CONMSTCode;
        private string _METMST_Remarks;
        private string _METMST_Maker;
        private string _METMST_IssuedDateTime;
        #endregion

        /// <summary>
        /// Default constructor for CORMeterMaster class.
        /// </summary>
        public CORMeterMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORMeterMaster(Int64 METMST_MeterNo, int METMST_Alloted, int METMST_CENCode, int METMST_CreatedByUserID, string METMST_CreatedDateTime, int METMST_UpdatedByUserID, string METMST_UpdatedDateTime, int METMST_RowStatus, long METMST_RowVersion, int METMST_CONMSTCode, string METMST_Remarks)
        {

            this._METMST_MeterNo = METMST_MeterNo;
            this._METMST_Alloted = METMST_Alloted;
            this._METMST_CENCode = METMST_CENCode;
            this._METMST_CreatedByUserID = METMST_CreatedByUserID;
            this._METMST_CreatedDateTime = METMST_CreatedDateTime;
            this._METMST_UpdatedByUserID = METMST_UpdatedByUserID;
            this._METMST_UpdatedDateTime = METMST_UpdatedDateTime;
            this._METMST_RowStatus = METMST_RowStatus;
            this._METMST_RowVersion = METMST_RowVersion;
            this._METMST_CONMSTCode = METMST_CONMSTCode;
            this._METMST_Remarks = METMST_Remarks;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int64 METMST_MeterNo
        {
            get { return _METMST_MeterNo; }
            set { _METMST_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_Alloted
        {
            get { return _METMST_Alloted; }
            set { _METMST_Alloted = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_CENCode
        {
            get { return _METMST_CENCode; }
            set { _METMST_CENCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_CreatedByUserID
        {
            get { return _METMST_CreatedByUserID; }
            set { _METMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_CreatedDateTime
        {
            get { return _METMST_CreatedDateTime; }
            set { _METMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_UpdatedByUserID
        {
            get { return _METMST_UpdatedByUserID; }
            set { _METMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_UpdatedDateTime
        {
            get { return _METMST_UpdatedDateTime; }
            set { _METMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_RowStatus
        {
            get { return _METMST_RowStatus; }
            set { _METMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METMST_RowVersion
        {
            get { return _METMST_RowVersion; }
            set { _METMST_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int METMST_CONMSTCode
        {
            get { return _METMST_CONMSTCode; }
            set { _METMST_CONMSTCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_Remarks
        {
            get { return _METMST_Remarks; }
            set { _METMST_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_Maker
        {
            get { return _METMST_Maker; }
            set { _METMST_Maker = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_IssuedDateTime
        {
            get { return _METMST_IssuedDateTime; }
            set { _METMST_IssuedDateTime = value; }
        }

    }

    public class CORMeterMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private long _METMST_MeterNo;
        private string _METMST_Alloted;
        private string _CENMST_Name;
        private int _MeterCount;
        private string _CONMST_Name;
        private string _METMST_Maker;
        private string _METMST_IssuedDateTime;
        private string _METMST_Remarks;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORMeterMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORMeterMasterList(long METMST_MeterNo, string METMST_Alloted, string CENMST_Name, int MeterCount, string CONMST_Name, string METMST_Maker, string METMST_IssuedDateTime, string METMST_Remarks)
        {
            this._METMST_MeterNo = METMST_MeterNo;
            this._METMST_Alloted = METMST_Alloted;
            this._CENMST_Name = CENMST_Name;
            this._MeterCount = MeterCount;
            this._CONMST_Name = CONMST_Name;
            this._METMST_Maker = METMST_Maker;
            this._METMST_IssuedDateTime = METMST_IssuedDateTime;
            this._METMST_Remarks = METMST_Remarks;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long METMST_MeterNo
        {
            get { return _METMST_MeterNo; }
            set { _METMST_MeterNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_Alloted
        {
            get { return _METMST_Alloted; }
            set { _METMST_Alloted = value; }
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
        public string METMST_Maker
        {
            get { return _METMST_Maker; }
            set { _METMST_Maker = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string METMST_IssuedDateTime
        {
            get { return _METMST_IssuedDateTime; }
            set { _METMST_IssuedDateTime = value; }
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
        public string METMST_Remarks
        {
            get { return _METMST_Remarks; }
            set { _METMST_Remarks = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int MeterCount
        {
            get { return _MeterCount; }

        }
    }
    public class CORMeterMasterMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public CORMeterMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORMeterMasterMsg(int RetVal, string RetStr)
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
