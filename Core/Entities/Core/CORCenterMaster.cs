//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORCenterMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORCenterMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORCenterMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CENMST_CenterCode;
        private string _CENMST_Name;
        //private decimal? _CTSMST_GCV;
        private string _CENMST_CenterPrefix;
        private int _CENMST_State;
        private int _CENMST_City;
        private string _State;
        private string _City;
        private string _CTYMST_Name;
        private string _CENMST_Address;
        private int _CENMST_PinCode;
        private string _CENMST_Phone;
        private string _CENMST_Phone2;
        private string _CENMST_Phone3;
        private string _CENMST_Email;
        private string _CENMST_GSTNoDT;
        private string _CENMST_VATNoDT;
        private int _CENMST_CreatedByUserID;
        private string _CENMST_CreatedDateTime;
        private int _CENMST_UpdatedByUserID;
        private string _CENMST_UpdatedDateTime;

        private int _CENMST_Language;
        private string _CENMST_Latitude;
        private string _CENMST_Longitude;
        private int _CENMST_RowStatus;
        private long _CENMST_RowVersion;

        private string _CENMST_OfficeStartTime;
        private string _CENMST_OfficeEndTime;
        #endregion

        /// <summary>
        /// Default constructor for CORCenterMaster class.
        /// </summary>
        public CORCenterMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORCenterMaster(int CENMST_CenterCode, string CENMST_Name, string CENMST_CenterPrefix, int CENMST_State, int CENMST_City, string State, string City, string CTYMST_Name, string CENMST_Address, int CENMST_PinCode, string CENMST_Phone, string CENMST_Phone2, string CENMST_Phone3, string CENMST_Email, string CENMST_GSTNoDT, string CENMST_VATNoDT, int CENMST_CreatedByUserID, string CENMST_CreatedDateTime, int CENMST_UpdatedByUserID, string CENMST_UpdatedDateTime, int CENMST_Language, string CENMST_Latitude, string CENMST_Longitude, int CENMST_RowStatus, long CENMST_RowVersion, string CENMST_OfficeStartTime, string CENMST_OfficeEndTime)/*, decimal? CTSMST_GCV*/
        {
            this._CENMST_CenterCode = CENMST_CenterCode;
            this._CENMST_Name = CENMST_Name;
            this._CENMST_CenterPrefix = CENMST_CenterPrefix;
            this._CENMST_State = CENMST_State;
            this._CENMST_City = CENMST_City;
            this._State = State;
            this._City = City;
            this._CTYMST_Name = CTYMST_Name;
            this._CENMST_Address = CENMST_Address;
            this._CENMST_PinCode = CENMST_PinCode;
            this._CENMST_Phone = CENMST_Phone;
            this._CENMST_Phone2 = CENMST_Phone2;
            this._CENMST_Phone3 = CENMST_Phone3;
            this._CENMST_Email = CENMST_Email;
            this._CENMST_GSTNoDT = CENMST_GSTNoDT;
            this._CENMST_VATNoDT = CENMST_VATNoDT;
            this._CENMST_CreatedByUserID = CENMST_CreatedByUserID;
            this._CENMST_CreatedDateTime = CENMST_CreatedDateTime;
            this._CENMST_UpdatedByUserID = CENMST_UpdatedByUserID;
            this._CENMST_UpdatedDateTime = CENMST_UpdatedDateTime;
            this._CENMST_Language = CENMST_Language;
            this._CENMST_Latitude = CENMST_Latitude;
            this._CENMST_Longitude = CENMST_Longitude;
            this._CENMST_RowStatus = CENMST_RowStatus;
            this._CENMST_RowVersion = CENMST_RowVersion;
            this._CENMST_OfficeStartTime = CENMST_OfficeStartTime;
            this._CENMST_OfficeEndTime = CENMST_OfficeEndTime;
            //this._CTSMST_GCV = CTSMST_GCV;
           
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_CenterCode
        {
            get { return _CENMST_CenterCode; }
            set { _CENMST_CenterCode = value; }
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
        public string CENMST_CenterPrefix
        {
            get { return _CENMST_CenterPrefix; }
            set { _CENMST_CenterPrefix = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_State
        {
            get { return _CENMST_State; }
            set { _CENMST_State = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_City
        {
            get { return _CENMST_City; }
            set { _CENMST_City = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CTYMST_Name
        {
            get { return _CTYMST_Name; }
            set { _CTYMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Address
        {
            get { return _CENMST_Address; }
            set { _CENMST_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_PinCode
        {
            get { return _CENMST_PinCode; }
            set { _CENMST_PinCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Phone
        {
            get { return _CENMST_Phone; }
            set { _CENMST_Phone = value; }
        }
        public string CENMST_Phone2
        {
            get { return _CENMST_Phone2; }
            set { _CENMST_Phone2 = value; }
        }
        public string CENMST_Phone3
        {
            get { return _CENMST_Phone3; }
            set { _CENMST_Phone3 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Email
        {
            get { return _CENMST_Email; }
            set { _CENMST_Email = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_GSTNoDT
        {
            get { return _CENMST_GSTNoDT; }
            set { _CENMST_GSTNoDT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_VATNoDT
        {
            get { return _CENMST_VATNoDT; }
            set { _CENMST_VATNoDT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_CreatedByUserID
        {
            get { return _CENMST_CreatedByUserID; }
            set { _CENMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_CreatedDateTime
        {
            get { return _CENMST_CreatedDateTime; }
            set { _CENMST_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_UpdatedByUserID
        {
            get { return _CENMST_UpdatedByUserID; }
            set { _CENMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_UpdatedDateTime
        {
            get { return _CENMST_UpdatedDateTime; }
            set { _CENMST_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_Language
        {
            get { return _CENMST_Language; }
            set { _CENMST_Language = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Latitude
        {
            get { return _CENMST_Latitude; }
            set { _CENMST_Latitude = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Longitude
        {
            get { return _CENMST_Longitude; }
            set { _CENMST_Longitude = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_RowStatus
        {
            get { return _CENMST_RowStatus; }
            set { _CENMST_RowStatus = value; }
        }
       

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CENMST_RowVersion
        {
            get { return _CENMST_RowVersion; }
            set { _CENMST_RowVersion = value; }
        }

        public string CENMST_OfficeStartTime
        {
            get { return _CENMST_OfficeStartTime; }
            set { _CENMST_OfficeStartTime = value; }
        }

        public string CENMST_OfficeEndTime
        {
            get { return _CENMST_OfficeEndTime; }
            set { _CENMST_OfficeEndTime = value; }
        }

        //public decimal? CTSMST_GCV
        //{
        //    get { return _CTSMST_GCV; }
        //    set { _CTSMST_GCV = value; }
        //}

    }

    public class CORCenterMasterList
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CENMST_CenterCode;
        private string _CENMST_Name;
        private string _CENMST_CenterPrefix;
        private string _CENMST_Address;
        private string _StateName;
        private string _CityName;
        private string _CENMST_Phone;
        private string _CENMST_Email;
        private string _CENMST_GSTNoDT;
        private string _CENMST_VATNoDT;
        private int _CENMST_PinCode;
        private string _CENMST_Language;
        private string _CENMST_RowStatus;
        private int _centercount;
       // private decimal? _CTSMST_GCV;
        private int CENMST_CenterCode_2;
        private string CENMST_Name_2;
        private string CENMST_CenterPrefix_2;
        private string CENMST_Address_2;
        private string StateName_2;
        private string CityName_2;
        private string CENMST_Phone_2;
        private string CENMST_Email_2;
        private string CENMST_GSTNoDT_2;
        private string CENMST_VATNoDT_2;
        private int CENMST_PinCode_2;
        private string CENMST_Language_2;
        private string CENMST_RowStatus_2;
        private int centercount_2;
       

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORCenterMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORCenterMasterList(int CENMST_CenterCode, string CENMST_Name, string CENMST_CenterPrefix, string CENMST_Address, string StateName, string CityName, string CENMST_Phone, string CENMST_Email, string CENMST_GSTNoDT, string CENMST_VATNoDT, int CENMST_PinCode, string CENMST_Language, string CENMST_RowStatus, int centercount)//, decimal? CTSMST_GCV)
        {

            this._CENMST_CenterCode = CENMST_CenterCode;
            this._CENMST_Name = CENMST_Name;
            this._CENMST_CenterPrefix = CENMST_CenterPrefix;
            this._CENMST_Address = CENMST_Address;
            this._StateName = StateName;
            this._CityName = CityName;
            this._CENMST_Phone = CENMST_Phone;
            this._CENMST_Email = CENMST_Email;
            this._CENMST_GSTNoDT = CENMST_GSTNoDT;
            this._CENMST_VATNoDT = CENMST_VATNoDT;
            this._CENMST_PinCode = CENMST_PinCode;
            this._CENMST_Language = CENMST_Language;
            this._CENMST_RowStatus = CENMST_RowStatus;
            this._centercount = centercount;
            //this._CTSMST_GCV = CTSMST_GCV;



        }

        //public CORCenterMasterList(int CENMST_CenterCode_2, string CENMST_Name_2, string CENMST_CenterPrefix_2, string CENMST_Address_2, string StateName_2, string CityName_2, string CENMST_Phone_2, string CENMST_Email_2, string CENMST_GSTNoDT_2, string CENMST_VATNoDT_2, int CENMST_PinCode_2, string CENMST_Language_2, string CENMST_RowStatus_2, int centercount_2)
        //{
        //    // TODO: Complete member initialization
        //    this.CENMST_CenterCode_2 = CENMST_CenterCode_2;
        //    this.CENMST_Name_2 = CENMST_Name_2;
        //    this.CENMST_CenterPrefix_2 = CENMST_CenterPrefix_2;
        //    this.CENMST_Address_2 = CENMST_Address_2;
        //    this.StateName_2 = StateName_2;
        //    this.CityName_2 = CityName_2;
        //    this.CENMST_Phone_2 = CENMST_Phone_2;
        //    this.CENMST_Email_2 = CENMST_Email_2;
        //    this.CENMST_GSTNoDT_2 = CENMST_GSTNoDT_2;
        //    this.CENMST_VATNoDT_2 = CENMST_VATNoDT_2;
        //    this.CENMST_PinCode_2 = CENMST_PinCode_2;
        //    this.CENMST_Language_2 = CENMST_Language_2;
        //    this.CENMST_RowStatus_2 = CENMST_RowStatus_2;
        //    this.centercount_2 = centercount_2;
        //}

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_CenterCode
        {
            get { return _CENMST_CenterCode; }
            set { _CENMST_CenterCode = value; }
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
        public string CENMST_CenterPrefix
        {
            get { return _CENMST_CenterPrefix; }
            set { _CENMST_CenterPrefix = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Address
        {
            get { return _CENMST_Address; }
            set { _CENMST_Address = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CityName
        {
            get { return _CityName; }
            set { _CityName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Phone
        {
            get { return _CENMST_Phone; }
            set { _CENMST_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CENMST_PinCode
        {
            get { return _CENMST_PinCode; }
            set { _CENMST_PinCode = value; }
        }

        public string CENMST_Email
        {
            get { return _CENMST_Email; }
            set { _CENMST_Email = value; }
        }

        public string CENMST_GSTNoDT
        {
            get { return _CENMST_GSTNoDT; }
            set { _CENMST_GSTNoDT = value; }
        }

        public string CENMST_VATNoDT
        {
            get { return _CENMST_VATNoDT; }
            set { _CENMST_VATNoDT = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_Language
        {
            get { return _CENMST_Language; }
            set { _CENMST_Language = value; }
        }

        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CENMST_RowStatus
        {
            get { return _CENMST_RowStatus; }
            set { _CENMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int centercount
        {
            get { return _centercount; }

        }

        //public decimal? CTSMST_GCV
        //{
        //    get { return _CTSMST_GCV; }
        //    set { _CTSMST_GCV = value; }
        //}
    }
    public class CORCenterMasterMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public CORCenterMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORCenterMasterMsg(int RetVal, string RetStr)
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
