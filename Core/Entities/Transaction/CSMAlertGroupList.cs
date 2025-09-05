//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMAlertGroupList.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMAlertGroupListService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMAlertGroupList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private decimal _AGLDTL_AlertListId;
        private int _AGLDTL_AlertGroupId;
        private int _AGLDTL_AlertUserId;
        #endregion

        /// <summary>
        /// Default constructor for CSMAlertGroupList class.
        /// </summary>
        public CSMAlertGroupList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAlertGroupList(decimal AGLDTL_AlertListId, int AGLDTL_AlertGroupId, int AGLDTL_AlertUserId)
        {
            this._AGLDTL_AlertListId = AGLDTL_AlertListId;
            this._AGLDTL_AlertGroupId = AGLDTL_AlertGroupId;
            this._AGLDTL_AlertUserId = AGLDTL_AlertUserId;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal AGLDTL_AlertListId
        {
            get { return _AGLDTL_AlertListId; }
            set { _AGLDTL_AlertListId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGLDTL_AlertGroupId
        {
            get { return _AGLDTL_AlertGroupId; }
            set { _AGLDTL_AlertGroupId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGLDTL_AlertUserId
        {
            get { return _AGLDTL_AlertUserId; }
            set { _AGLDTL_AlertUserId = value; }
        }

    }

    public class CSMAlertGroupListList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
        #region "Variables Declaration"
        private int _AGLDTL_AlertListId;
        private int _AGLDTL_AlertGroupId;
        private int _AGLDTL_AlertUserId;
        private int _Count;
        #endregion
        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMAlertGroupListList(int AGLDTL_AlertListId, int AGLDTL_AlertGroupId, int AGLDTL_AlertUserId,int Count)
        {
            this._AGLDTL_AlertListId = AGLDTL_AlertListId;
            this._AGLDTL_AlertGroupId = AGLDTL_AlertGroupId;
            this._AGLDTL_AlertUserId = AGLDTL_AlertUserId;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGLDTL_AlertListId
        {
            get { return _AGLDTL_AlertListId; }
            set { _AGLDTL_AlertListId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGLDTL_AlertGroupId
        {
            get { return _AGLDTL_AlertGroupId; }
            set { _AGLDTL_AlertGroupId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int AGLDTL_AlertUserId
        {
            get { return _AGLDTL_AlertUserId; }
            set { _AGLDTL_AlertUserId = value; }
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
    public class CSMAlertGroupListMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMAlertGroupListMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMAlertGroupListMsg(int RetVal, string RetStr)
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
