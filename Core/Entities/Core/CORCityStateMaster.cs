using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Core
{
    public class CORCityStateMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CTSMST_Code;
        private string _CTSMST_Name;
        private int _CTSMST_Type;
        private int? _CTSMST_ParentID;
        private int _CTSMST_CreatedByUserID;
        private string _CTSMST_CreatedDateTime;
        private int _CTSMST_UpdatedByUserID;
        private string _CTSMST_UpdatedDateTime;
        private bool _CTSMST_RowStatus;
        private long _CTSMST_RowVersion;
        private decimal? _CTSMST_GCV;
        private string _CTSMST_GACode;
        #endregion

        /// <summary>
        /// Default constructor for CORBankMaster class.
        /// </summary>
        public CORCityStateMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORCityStateMaster(int CTSMST_Code, string CTSMST_Name, int CTSMST_Type, int CTSMST_ParentID, int CTSMST_CreatedByUserID, string CTSMST_CreatedDateTime, int CTSMST_UpdatedByUserID, string CTSMST_UpdatedDateTime, bool CTSMST_RowStatus, long CTSMST_RowVersion, decimal? CTSMST_GCV, string CTSMST_GACode)
        {
            this._CTSMST_Code = CTSMST_Code;
            this._CTSMST_Name = CTSMST_Name;
            this._CTSMST_Type = CTSMST_Type;
            this._CTSMST_ParentID = CTSMST_ParentID;
            this._CTSMST_CreatedByUserID = CTSMST_CreatedByUserID;
            this._CTSMST_CreatedDateTime = CTSMST_CreatedDateTime;
            this._CTSMST_UpdatedByUserID = CTSMST_UpdatedByUserID;
            this._CTSMST_UpdatedDateTime = CTSMST_UpdatedDateTime;
            this._CTSMST_RowStatus = CTSMST_RowStatus;
            this._CTSMST_RowVersion = CTSMST_RowVersion;
            this._CTSMST_GCV = CTSMST_GCV;
            this._CTSMST_GACode = CTSMST_GACode;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTSMST_Code
        {
            get { return _CTSMST_Code; }
            set { _CTSMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTSMST_GACode
        {
            get { return _CTSMST_GACode; }
            set { _CTSMST_GACode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTSMST_Name
        {
            get { return _CTSMST_Name; }
            set { _CTSMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTSMST_Type
        {
            get { return _CTSMST_Type; }
            set { _CTSMST_Type = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int? CTSMST_ParentID
        {
            get { return _CTSMST_ParentID; }
            set { _CTSMST_ParentID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CTSMST_CreatedByUserID
        {
            get { return _CTSMST_CreatedByUserID; }
            set { _CTSMST_CreatedByUserID = value; }
        }

        public string CTSMST_CreatedDateTime
        {
            get { return _CTSMST_CreatedDateTime; }
            set { _CTSMST_CreatedDateTime = value; }
        }

        public int CTSMST_UpdatedByUserID
        {
            get { return _CTSMST_UpdatedByUserID; }
            set { _CTSMST_UpdatedByUserID = value; }
        }

        public string CTSMST_UpdatedDateTime
        {
            get { return _CTSMST_UpdatedDateTime; }
            set { _CTSMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool CTSMST_RowStatus
        {
            get { return _CTSMST_RowStatus; }
            set { _CTSMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CTSMST_RowVersion
        {
            get { return _CTSMST_RowVersion; }
            set { _CTSMST_RowVersion = value; }
        }

        public decimal? CTSMST_GCV
        {
            get { return _CTSMST_GCV; }
            set { _CTSMST_GCV = value; }
        }
        
    }

    public class CORCityStateMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _CTSMST_Code;

        public int CTSMST_Code
        {
            get { return _CTSMST_Code; }
            set { _CTSMST_Code = value; }
        }

        private string _CTSMST_GACode;

        public string CTSMST_GACode
        {
            get { return _CTSMST_GACode; }
            set { _CTSMST_GACode = value; }
        }

        private string _CTSMST_Name;

        public string CTSMST_Name
        {
            get { return _CTSMST_Name; }
            set { _CTSMST_Name = value; }
        }

        private string _City_Name;

        public string City_Name
        {
            get { return _City_Name; }
            set { _City_Name = value; }
        }

        private int _CTSMST_Type;

        public int CTSMST_Type
        {
            get { return _CTSMST_Type; }
            set { _CTSMST_Type = value; }
        }
        private int _CTSMST_ParentID;

        public int CTSMST_ParentID
        {
            get { return _CTSMST_ParentID; }
            set { _CTSMST_ParentID = value; }
        }
        private int _CTSMST_CreatedByUserID;

        public int CTSMST_CreatedByUserID
        {
            get { return _CTSMST_CreatedByUserID; }
            set { _CTSMST_CreatedByUserID = value; }
        }
        private string _CTSMST_CreatedDateTime;

        public string CTSMST_CreatedDateTime
        {
            get { return _CTSMST_CreatedDateTime; }
            set { _CTSMST_CreatedDateTime = value; }
        }
        private int _CTSMST_UpdatedByUserID;

        public int CTSMST_UpdatedByUserID
        {
            get { return _CTSMST_UpdatedByUserID; }
            set { _CTSMST_UpdatedByUserID = value; }
        }
        private string _CTSMST_UpdatedDateTime;

        public string CTSMST_UpdatedDateTime
        {
            get { return _CTSMST_UpdatedDateTime; }
            set { _CTSMST_UpdatedDateTime = value; }
        }
        private string _CTSMST_RowStatus;

        public string CTSMST_RowStatus
        {
            get { return _CTSMST_RowStatus; }
            set { _CTSMST_RowStatus = value; }
        }
        private long _CTSMST_RowVersion;

        public long CTSMST_RowVersion
        {
            get { return _CTSMST_RowVersion; }
            set { _CTSMST_RowVersion = value; }
        }

        private decimal? _CTSMST_GCV;

        public decimal? CTSMST_GCV
        {
            get { return _CTSMST_GCV; }
            set { _CTSMST_GCV = value; }
        }
        private int _Count;

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORCityStateMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORCityStateMasterList(int CTSMST_Code, string CTSMST_Name, string City_Name, int CTSMST_Type, int CTSMST_ParentID, int CTSMST_CreatedByUserID, string CTSMST_CreatedDateTime, int CTSMST_UpdatedByUserID, string CTSMST_UpdatedDateTime, string CTSMST_RowStatus, long CTSMST_RowVersion, int Count, decimal? CTSMST_GCV, string CTSMST_GACode)
        {
            this._CTSMST_Code = CTSMST_Code;
            this._CTSMST_Name = CTSMST_Name;
            this._City_Name = City_Name;
            this._CTSMST_Type = CTSMST_Type;
            this._CTSMST_ParentID = CTSMST_ParentID;
            this._CTSMST_CreatedByUserID = CTSMST_CreatedByUserID;
            this._CTSMST_CreatedDateTime = CTSMST_CreatedDateTime;
            this._CTSMST_UpdatedByUserID = CTSMST_UpdatedByUserID;
            this._CTSMST_UpdatedDateTime = CTSMST_UpdatedDateTime;
            this._CTSMST_RowStatus = CTSMST_RowStatus;
            this._CTSMST_RowVersion = CTSMST_RowVersion;
            this._CTSMST_GCV = CTSMST_GCV;
            this._CTSMST_GACode = CTSMST_GACode;
            this._Count = Count;
        }

      
    }

    public class CORCityStateMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORCityStateMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORCityStateMasterMsg(int RetVal, string RetStr)
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

