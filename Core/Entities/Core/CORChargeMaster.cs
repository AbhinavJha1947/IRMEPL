using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Core
{
    
    public class CORChargeMaster
    {

        #region "Variables Declaration"
        private int _CHGMST_Code;

        public int CHGMST_Code
        {
            get { return _CHGMST_Code; }
            set { _CHGMST_Code = value; }
        }

        private string _CHGMST_Name;

        public string CHGMST_Name
        {
            get { return _CHGMST_Name; }
            set { _CHGMST_Name = value; }
        }
        private string _CHGMST_Description;

        public string CHGMST_Description
        {
            get { return _CHGMST_Description; }
            set { _CHGMST_Description = value; }
        }
        private int _CHGMST_ChargeType;

        public int CHGMST_ChargeType
        {
            get { return _CHGMST_ChargeType; }
            set { _CHGMST_ChargeType = value; }
        }
        private int _CHGMST_CreatedByUserID;

        public int CHGMST_CreatedByUserID
        {
            get { return _CHGMST_CreatedByUserID; }
            set { _CHGMST_CreatedByUserID = value; }
        }
        private string _CHGMST_CreatedDateTime;

        public string CHGMST_CreatedDateTime
        {
            get { return _CHGMST_CreatedDateTime; }
            set { _CHGMST_CreatedDateTime = value; }
        }
        private int _CHGMST_UpdatedByUserID;

        public int CHGMST_UpdatedByUserID
        {
            get { return _CHGMST_UpdatedByUserID; }
            set { _CHGMST_UpdatedByUserID = value; }
        }
        private string _CHGMST_UpdatedDateTime;

        public string CHGMST_UpdatedDateTime
        {
            get { return _CHGMST_UpdatedDateTime; }
            set { _CHGMST_UpdatedDateTime = value; }
        }
        private int _CHGMST_RowStatus;

        public int CHGMST_RowStatus
        {
            get { return _CHGMST_RowStatus; }
            set { _CHGMST_RowStatus = value; }
        }
        private long _CHGMST_RowVersion;

        public long CHGMST_RowVersion
        {
            get { return _CHGMST_RowVersion; }
            set { _CHGMST_RowVersion = value; }
        }
        private int _CHGMST_ControlID;

        public int CHGMST_ControlID
        {
            get { return _CHGMST_ControlID; }
            set { _CHGMST_ControlID = value; }
        }

        #endregion

        public CORChargeMaster() { }

        public CORChargeMaster(int CHGMST_Code, string CHGMST_Name, string CHGMST_Description, int CHGMST_ChargeType, int CHGMST_CreatedByUserID, string CHGMST_CreatedDateTime,
            int CHGMST_UpdatedByUserID, string CHGMST_UpdatedDateTime, int CHGMST_RowStatus, long CHGMST_RowVersion,
            int CHGMST_ControlID)
        {
            this._CHGMST_Code = CHGMST_Code;
            this._CHGMST_Name = CHGMST_Name;
            this._CHGMST_Description = CHGMST_Description;
            this._CHGMST_ChargeType = CHGMST_ChargeType;
            this._CHGMST_CreatedByUserID = CHGMST_CreatedByUserID;
            this._CHGMST_CreatedDateTime = CHGMST_CreatedDateTime;
            this._CHGMST_UpdatedByUserID = CHGMST_UpdatedByUserID;
            this._CHGMST_UpdatedDateTime = CHGMST_UpdatedDateTime;
            this._CHGMST_RowStatus = CHGMST_RowStatus;
            this._CHGMST_RowVersion = CHGMST_RowVersion;
            this._CHGMST_ControlID = CHGMST_ControlID;

        }

    }


    public class CorChargeDTLMST
    {

        #region "Variables Declaration"
        private int _CHDMST_ID;

        public int CHDMST_ID
        {
            get { return _CHDMST_ID; }
            set { _CHDMST_ID = value; }
        }

        private int _CHDMST_ChargeID;

        public int CHDMST_ChargeID
        {
            get { return _CHDMST_ChargeID; }
            set { _CHDMST_ChargeID = value; }
        }

        private int _CHDMST_TaxID;

        public int CHDMST_TaxID
        {
            get { return _CHDMST_TaxID; }
            set { _CHDMST_TaxID = value; }
        }


        #endregion

        public CorChargeDTLMST() { }

        public CorChargeDTLMST(int CHDMST_ID, int CHDMST_ChargeID, int CHDMST_TaxID)
        {
            this.CHDMST_ID = CHDMST_ID;
            this.CHDMST_ChargeID = CHDMST_ChargeID;
            this.CHDMST_TaxID = CHDMST_TaxID;

        }

    }

    public class CorChargeDTLMSTList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //Write this List class yourself.

        #region "Variables Declaration"

        private int _CHDMST_ID;
        private int _CHDMST_ChargeID;
        private int _CHDMST_TaxID;
      

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CorChargeDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CorChargeDTLMSTList(int CHDMST_ID, int CHDMST_ChargeID, int CHDMST_TaxID)
        {
            this._CHDMST_ID = CHDMST_ID;
            this._CHDMST_ChargeID = CHDMST_ChargeID;
            this._CHDMST_TaxID = CHDMST_TaxID;
            
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int CHDMST_ID
        {
            get { return _CHDMST_ID; }
            set { _CHDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int CHDMST_ChargeID
        {
            get { return _CHDMST_ChargeID; }
            set { _CHDMST_ChargeID = value; }
        }
        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int CHDMST_TaxID
        {
            get { return _CHDMST_TaxID; }
            set { _CHDMST_TaxID = value; }
        }
        

    }

    public class CORChargeMasterList
    {
        #region "Variables Declaration"
        private int _CHGMST_Code;

        public int CHGMST_Code
        {
            get { return _CHGMST_Code; }
            set { _CHGMST_Code = value; }
        }

        private string _CHGMST_Name;

        public string CHGMST_Name
        {
            get { return _CHGMST_Name; }
            set { _CHGMST_Name = value; }
        }
        private string _CHGMST_Description;

        public string CHGMST_Description
        {
            get { return _CHGMST_Description; }
            set { _CHGMST_Description = value; }
        }
        private int _CHGMST_ChargeType;

        public int CHGMST_ChargeType
        {
            get { return _CHGMST_ChargeType; }
            set { _CHGMST_ChargeType = value; }
        }

        private string _CHGMST_RowStatus;

        public string CHGMST_RowStatus
        {
            get { return _CHGMST_RowStatus; }
            set { _CHGMST_RowStatus = value; }
        }

        private int _CHGMST_ControlID;

        public int CHGMST_ControlID
        {
            get { return _CHGMST_ControlID; }
            set { _CHGMST_ControlID = value; }
        }

        private int _Count;

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        #endregion


        public CORChargeMasterList() { }

        public CORChargeMasterList(int CHGMST_Code, string CHGMST_Name, string CHGMST_Description, int CHGMST_ChargeType, string CHGMST_RowStatus, int CHGMST_ControlID, int Count)
        {

            this._CHGMST_Code = CHGMST_Code;
            this._CHGMST_Name = CHGMST_Name;
            this._CHGMST_Description = CHGMST_Description;
            this._CHGMST_ChargeType = CHGMST_ChargeType;

            this._CHGMST_RowStatus = CHGMST_RowStatus;

            this._CHGMST_ControlID = CHGMST_ControlID;
            this._Count = Count;
        }

    }

    public class CORChargeMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORChargeMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORChargeMasterMsg(int RetVal, string RetStr)
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

