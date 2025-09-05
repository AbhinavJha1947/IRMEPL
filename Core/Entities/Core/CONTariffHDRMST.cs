//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CONTariffHDRMST.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CONTariffHDRMSTService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CONTariffHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CTAMST_TariffID;
        private string _CTAMST_StartDate;
        private int _CTAMST_ContractorID;
        private int _CTAMST_CreatedByUserID;
        private string _CTAMST_CreatedDateTime;
        private int _CTAMST_UpdatedByUserID;
        private string _CTAMST_UpdatedDateTime;
        private int _CTAMST_RowStatus;
        private long _CTAMST_RowVersion;
        private int _CTAMST_OldID;
        #endregion

        /// <summary>
        /// Default constructor for CONTariffHDRMST class.
        /// </summary>
        public CONTariffHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CONTariffHDRMST(int CTAMST_TariffID, string CTAMST_StartDate, int CTAMST_ContractorID, int CTAMST_CreatedByUserID, string CTAMST_CreatedDateTime, int CTAMST_UpdatedByUserID, string CTAMST_UpdatedDateTime, int CTAMST_RowStatus)
        {
            this._CTAMST_TariffID = CTAMST_TariffID;
            this._CTAMST_StartDate = CTAMST_StartDate;
            this._CTAMST_ContractorID = CTAMST_ContractorID;
            this._CTAMST_CreatedByUserID = CTAMST_CreatedByUserID;
            this._CTAMST_CreatedDateTime = CTAMST_CreatedDateTime;
            this._CTAMST_UpdatedByUserID = CTAMST_UpdatedByUserID;
            this._CTAMST_UpdatedDateTime = CTAMST_UpdatedDateTime;
            this._CTAMST_RowStatus = CTAMST_RowStatus;
            
           
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_TariffID
        {
            get { return _CTAMST_TariffID; }
            set { _CTAMST_TariffID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTAMST_StartDate
        {
            get { return _CTAMST_StartDate; }
            set { _CTAMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_ContractorID
        {
            get { return _CTAMST_ContractorID; }
            set { _CTAMST_ContractorID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_CreatedByUserID
        {
            get { return _CTAMST_CreatedByUserID; }
            set { _CTAMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTAMST_CreatedDateTime
        {
            get { return _CTAMST_CreatedDateTime; }
            set { _CTAMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_UpdatedByUserID
        {
            get { return _CTAMST_UpdatedByUserID; }
            set { _CTAMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTAMST_UpdatedDateTime
        {
            get { return _CTAMST_UpdatedDateTime; }
            set { _CTAMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_RowStatus
        {
            get { return _CTAMST_RowStatus; }
            set { _CTAMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CTAMST_RowVersion
        {
            get { return _CTAMST_RowVersion; }
            set { _CTAMST_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_OldID
        {
            get { return _CTAMST_OldID; }
            set { _CTAMST_OldID = value; }
        }

    }

    public class CONTariffHDRMSTList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CTAMST_TariffID;
        private int _CTAMST_ContractorID;
        private string _CTAMST_StartDate;
        private string _CONMST_Name;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CONTariffHDRMST class.
        /// </summary>
        public CONTariffHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CONTariffHDRMSTList(int CTAMST_TariffID,int CTAMST_ContractorID,string CTAMST_StartDate, string CONMST_Name,int Count)
        {
            this._CTAMST_TariffID = CTAMST_TariffID;
            this._CTAMST_ContractorID = CTAMST_ContractorID;
            this._CTAMST_StartDate = CTAMST_StartDate;
            this._CONMST_Name = CONMST_Name;
            this._Count = Count;
        }

        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTAMST_StartDate
        {
            get { return _CTAMST_StartDate; }
            set { _CTAMST_StartDate = value; }
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
        public int CTAMST_TariffID
        {
            get { return _CTAMST_TariffID; }
            set { _CTAMST_TariffID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTAMST_ContractorID
        {
            get { return _CTAMST_ContractorID; }
            set { _CTAMST_ContractorID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }


    public class CONTariffHDRMSTMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CONTariffHDRMSTMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CONTariffHDRMSTMsg(int RetVal, string RetStr)
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
