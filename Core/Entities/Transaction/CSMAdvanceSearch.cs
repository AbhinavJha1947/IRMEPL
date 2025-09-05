//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMAdvanceSearch.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMAdvanceSearchService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMAdvanceSearch
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _ApplicationDate;
        private string _CustomerName;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        private string _Address1;
        private string _APPMST_Phone;
        private string _APPMST_Mobile;
        private string _APPMST_BillingStatus;
        private string _OMStatus;
        private string _Area;
        #endregion

        /// <summary>
        /// Default constructor for CSMAdvanceSearch class.
        /// </summary>
        public CSMAdvanceSearch() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAdvanceSearch(int APPMST_AppID, string APPMST_AppNo, string ApplicationDate, string CustomerName, string APPMST_FName, string APPMST_MName, string APPMST_LName, string Address1, string APPMST_Phone, string APPMST_Mobile, string APPMST_BillingStatus, string OMStatus, string Area)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._ApplicationDate = ApplicationDate;
            this._CustomerName = CustomerName;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            this._Address1 = Address1;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_BillingStatus = APPMST_BillingStatus;
            this._OMStatus = OMStatus;
            this._Area = Area;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationDate
        {
            get { return _ApplicationDate; }
            set { _ApplicationDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_BillingStatus
        {
            get { return _APPMST_BillingStatus; }
            set { _APPMST_BillingStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMStatus
        {
            get { return _OMStatus; }
            set { _OMStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

    }

    public class CSMAdvanceSearchList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _APPMST_AppID;
        private string _APPMST_AppNo;
        private string _ApplicationDate;
        private string _CustomerName;
        private string _APPMST_FName;
        private string _APPMST_MName;
        private string _APPMST_LName;
        private string _Address1;
        private string _APPMST_Phone;
        private string _APPMST_Mobile;
        private string _APPMST_BillingStatus;
        private string _OMStatus;
        private string _Area;
        private string _APPMST_CustomerID;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CSMAdvanceSearch class.
        /// </summary>
        public CSMAdvanceSearchList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAdvanceSearchList(int APPMST_AppID, string APPMST_AppNo, string ApplicationDate, string CustomerName, string APPMST_FName, string APPMST_MName, string APPMST_LName, string Address1, string APPMST_Phone, string APPMST_Mobile, string APPMST_BillingStatus, string OMStatus, string Area, string CustomerID, int Count)
        {
            this._APPMST_AppID = APPMST_AppID;
            this._APPMST_AppNo = APPMST_AppNo;
            this._ApplicationDate = ApplicationDate;
            this._CustomerName = CustomerName;
            this._APPMST_FName = APPMST_FName;
            this._APPMST_MName = APPMST_MName;
            this._APPMST_LName = APPMST_LName;
            this._Address1 = Address1;
            this._APPMST_Phone = APPMST_Phone;
            this._APPMST_Mobile = APPMST_Mobile;
            this._APPMST_BillingStatus = APPMST_BillingStatus;
            this._OMStatus = OMStatus;
            this._Area = Area;
            this._APPMST_CustomerID = CustomerID;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ApplicationDate
        {
            get { return _ApplicationDate; }
            set { _ApplicationDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_FName
        {
            get { return _APPMST_FName; }
            set { _APPMST_FName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_MName
        {
            get { return _APPMST_MName; }
            set { _APPMST_MName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_LName
        {
            get { return _APPMST_LName; }
            set { _APPMST_LName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Phone
        {
            get { return _APPMST_Phone; }
            set { _APPMST_Phone = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_Mobile
        {
            get { return _APPMST_Mobile; }
            set { _APPMST_Mobile = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string APPMST_BillingStatus
        {
            get { return _APPMST_BillingStatus; }
            set { _APPMST_BillingStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string OMStatus
        {
            get { return _OMStatus; }
            set { _OMStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }


        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class CSMAdvanceSearchMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMAdvanceSearchMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMAdvanceSearchMsg(int RetVal, string RetStr)
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
