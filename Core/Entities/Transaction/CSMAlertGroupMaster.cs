//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMAlertGroupMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMAlertGroupMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMAlertGroupMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _AGMMST_AlertGroupId;
        private int _AGMMST_AlertNameId;
        private int _AGMMST_CallType;
        private Int16 _AGMMST_ViaEmail;
        private Int16 _AGMMST_ViaSMS;
        private int _AGMMST_CenterId;
        private int _AGMMST_UserId;
        private string _AGMMST_DateTime;
        private long _AGMMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CSMAlertGroupMaster class.
        /// </summary>
        public CSMAlertGroupMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAlertGroupMaster(int AGMMST_AlertGroupId, int AGMMST_AlertNameId, int AGMMST_CallType, Int16 AGMMST_ViaEmail, Int16 AGMMST_ViaSMS, int AGMMST_CenterId, int AGMMST_UserId, string AGMMST_DateTime, long AGMMST_RowVersion)
        {
            this._AGMMST_AlertGroupId = AGMMST_AlertGroupId;
            this._AGMMST_AlertNameId = AGMMST_AlertNameId;
            this._AGMMST_CallType = AGMMST_CallType;
            this._AGMMST_ViaEmail = AGMMST_ViaEmail;
            this._AGMMST_ViaSMS = AGMMST_ViaSMS;
            this._AGMMST_CenterId = AGMMST_CenterId;
            this._AGMMST_UserId = AGMMST_UserId;
            this._AGMMST_DateTime = AGMMST_DateTime;
            this._AGMMST_RowVersion = AGMMST_RowVersion;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_AlertGroupId
        {
            get { return _AGMMST_AlertGroupId; }
            set { _AGMMST_AlertGroupId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_AlertNameId
        {
            get { return _AGMMST_AlertNameId; }
            set { _AGMMST_AlertNameId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_CallType
        {
            get { return _AGMMST_CallType; }
            set { _AGMMST_CallType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int16 AGMMST_ViaEmail
        {
            get { return _AGMMST_ViaEmail; }
            set { _AGMMST_ViaEmail = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int16 AGMMST_ViaSMS
        {
            get { return _AGMMST_ViaSMS; }
            set { _AGMMST_ViaSMS = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_CenterId
        {
            get { return _AGMMST_CenterId; }
            set { _AGMMST_CenterId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_UserId
        {
            get { return _AGMMST_UserId; }
            set { _AGMMST_UserId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AGMMST_DateTime
        {
            get { return _AGMMST_DateTime; }
            set { _AGMMST_DateTime = value; }
        }
        public long AGMMST_RowVersion
        {
            get { return _AGMMST_RowVersion; }
            set { _AGMMST_RowVersion = value; }
        }

    }

    public class CSMAlertGroupMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS

         /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _AGMMST_AlertGroupId;
        private string  _AGMMST_AlertNameId;
        private string  _AGMMST_CallType;
        private string  _AGMMST_ViaEmail;
        private string  _AGMMST_ViaSMS;
        private string  _AGMMST_CenterId;
        private int _Count;
        
        #endregion

        /// <summary>
        /// Default constructor for CSMAlertGroupMaster class.
        /// </summary>
        public CSMAlertGroupMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAlertGroupMasterList(int AGMMST_AlertGroupId, string AGMMST_AlertNameId, string AGMMST_CallType, string AGMMST_ViaEmail, string AGMMST_ViaSMS, string AGMMST_CenterId, int Count)
        {
            this._AGMMST_AlertGroupId = AGMMST_AlertGroupId;
            this._AGMMST_AlertNameId = AGMMST_AlertNameId;
            this._AGMMST_CallType = AGMMST_CallType;
            this._AGMMST_ViaEmail = AGMMST_ViaEmail;
            this._AGMMST_ViaSMS = AGMMST_ViaSMS;
            this._AGMMST_CenterId = AGMMST_CenterId;
            this._Count = Count;
           
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGMMST_AlertGroupId
        {
            get { return _AGMMST_AlertGroupId; }
            set { _AGMMST_AlertGroupId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string AGMMST_AlertNameId
        {
            get { return _AGMMST_AlertNameId; }
            set { _AGMMST_AlertNameId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string  AGMMST_CallType
        {
            get { return _AGMMST_CallType; }
            set { _AGMMST_CallType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string  AGMMST_ViaEmail
        {
            get { return _AGMMST_ViaEmail; }
            set { _AGMMST_ViaEmail = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string  AGMMST_ViaSMS
        {
            get { return _AGMMST_ViaSMS; }
            set { _AGMMST_ViaSMS = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string  AGMMST_CenterId
        {
            get { return _AGMMST_CenterId; }
            set { _AGMMST_CenterId = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
       
        
    }


    public class CSMAlertGroupMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMAlertGroupMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMAlertGroupMasterMsg(int RetVal, string RetStr)
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
