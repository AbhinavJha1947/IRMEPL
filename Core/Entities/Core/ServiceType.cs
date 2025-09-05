using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a ServiceType.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see ServiceTypeService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class ServiceType
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _TYPM_ID;
        private int _TYPM_CMPMID;
        private string _TYPM_Name;
        private int _TYPM_Status;
        private int _TYPM_AUDITMID;
        private long _TYPM_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for ServiceType class.
        /// </summary>
        public ServiceType() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ServiceType(int TYPM_ID, int TYPM_CMPMID, string TYPM_Name, int TYPM_Status, int TYPM_AUDITMID, long TYPM_RowVersion)
        {
            this._TYPM_ID = TYPM_ID;
            this._TYPM_CMPMID = TYPM_CMPMID;
            this._TYPM_Name = TYPM_Name;
            this._TYPM_Status = TYPM_Status;
            this._TYPM_AUDITMID = TYPM_AUDITMID;
            this._TYPM_RowVersion = TYPM_RowVersion;

        }

        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public int TYPM_ID
        {
            get { return _TYPM_ID; }
            set { _TYPM_ID = value; }
        }

        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public int TYPM_CMPMID
        {
            get { return _TYPM_CMPMID; }
            set { _TYPM_CMPMID = value; }
        }

        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public string TYPM_Name
        {
            get { return _TYPM_Name; }
            set { _TYPM_Name = value; }
        }

        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public int TYPM_Status
        {
            get { return _TYPM_Status; }
            set { _TYPM_Status = value; }
        }


        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public int TYPM_AUDITMID
        {
            get { return _TYPM_AUDITMID; }
            set { _TYPM_AUDITMID = value; }
        }

        /// <summary>
        //Write Column Description here.  
        /// </summary>
        public long TYPM_RowVersion
        
        {
            get { return _TYPM_RowVersion; }
            set { _TYPM_RowVersion = value; }
        }

    }

    public class ServiceTypeList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.

        #region "Variable Decleration"

        private int _TYPM_ID;
        private string _TYPM_Name;
        private string _TYPM_Status;
        int _servicetypecount;

        #endregion

        public ServiceTypeList() { }

        public ServiceTypeList(int TYPM_ID, string TYPM_Name, string TYPM_Status, int servicetypecount)
        {
            this._TYPM_ID = TYPM_ID;
            this._TYPM_Name = TYPM_Name;
            this._TYPM_Status = TYPM_Status;
            this._servicetypecount = servicetypecount;

        }

        public int TYPM_ID
        {
            get { return _TYPM_ID; }
            set { _TYPM_ID = value; }

        }

        public string TYPM_Name
        {
            get { return _TYPM_Name; }
            set { _TYPM_Name = value; }
        }

        public string TYPM_Status
        {
            get { return _TYPM_Status; }
            set { _TYPM_Status = value; }

        }
        public int servicetypecount
        {
            get { return _servicetypecount; }


        }
    }

    public class ServiceTypeMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the Salutation class.
        /// </summary>
        public ServiceTypeMsg() { }

        /// <summary>
        /// Overloaded constructor for the Salutation class.
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ServiceTypeMsg(int RetVal, string RetStr)
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





