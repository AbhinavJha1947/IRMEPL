using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a Control_Detail.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see Control_DetailService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class ControlDetailMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _CD_ControlID;
        private int _CD_CHMID;
        private string _CD_ControlType;
        private string _CD_ControlSeq;
        private int _CD_ControlStatus;

        #endregion

        /// <summary>
        /// Default constructor for Control_Detail class.
        /// </summary>
        public ControlDetailMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ControlDetailMaster(int CD_ControlID, int CD_CHMID, string CD_ControlType, string CD_ControlSeq, int CD_ControlStatus)
        {
            this._CD_ControlID = CD_ControlID;
            this._CD_CHMID = CD_CHMID;
            this._CD_ControlType = CD_ControlType;
            this._CD_ControlSeq = CD_ControlSeq;
            this._CD_ControlStatus = CD_ControlStatus;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_CHMID
        {
            get { return _CD_CHMID; }
            set { _CD_CHMID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CD_ControlSeq
        {
            get { return _CD_ControlSeq; }
            set { _CD_ControlSeq = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlStatus
        {
            get { return _CD_ControlStatus; }
            set { _CD_ControlStatus = value; }
        }
    }

    public class ControlDetailMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _CD_ControlID;
        private int _CD_CHMID;
        private string _CD_ControlType;
        private string _CHM_Type;
        private string _CD_ControlStatus;
        private string _CD_ControlSeq;
        private int _Controlcount;

        #endregion

        /// <summary>
        /// Default constructor for CtlDetail class.
        /// </summary>
        public ControlDetailMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>

        public ControlDetailMasterList(int CD_ControlID, int CD_CHMID, string CD_ControlType, string CHM_Type, string CD_ControlSeq, string CD_ControlCode, int Controlcount)
        {
            this._CD_ControlID = CD_ControlID;
            this._CD_CHMID = CD_CHMID;
            this._CD_ControlType = CD_ControlType;
            this._CHM_Type = CHM_Type;
            this._CD_ControlStatus = CD_ControlStatus;
            this._CD_ControlSeq = CD_ControlSeq;
            this._Controlcount = Controlcount;
        }

        /// <summary>
        /// Gets or sets unique Control Detail identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }

        /// <summary>
        /// Gets or sets unique Control Detail identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int CD_CHMID
        {
            get { return _CD_CHMID; }
            set { _CD_CHMID = value; }
        }

        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }

        /// <summary>
        /// Gets or sets unique Control Detail identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int Controlcount
        {
            get { return _Controlcount; }
            set { _Controlcount = value; }
        }

        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        public string CD_ControlStatus
        {
            get { return _CD_ControlStatus; }
            set { _CD_ControlStatus = value; }
        }

        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        public string CHM_Type
        {
            get { return _CHM_Type; }
            set { _CHM_Type = value; }
        }
        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        public string CD_ControlCode
        {
            get { return _CD_ControlSeq; }
            set { _CD_ControlSeq = value; }
        }
    }

    public class ControlDetailMasterMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _RetVal;
        private string _RetStr;

        #endregion

        /// <summary>
        /// Overloaded default constructor for the DrugGroupMSTMsg class.
        /// </summary>
        public ControlDetailMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the DrugGroupMSTMsg class.
        /// </summary>
        /// <param name="RetVal">Return Value for the DrugGroupMST.</param>
        /// <param name="RetStr">Return String for the DrugGroupMST.</param>
        public ControlDetailMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        /// Gets or sets Return Value.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        /// Gets or sets Return String.        
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }

    public class ControlHeaderMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _CD_CHMID;
        private string _CD_ControlType;

        #endregion

        /// <summary>
        /// Default constructor for CtlDetail class.
        /// </summary>
        public ControlHeaderMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>

        public ControlHeaderMasterList(int CD_CHMID, string CD_ControlType)
        {
            this._CD_CHMID = CD_CHMID;
            this._CD_ControlType = CD_ControlType;
        }

        /// <summary>
        /// Gets or sets unique Control Detail identifier.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int CD_CHMID
        {
            get { return _CD_CHMID; }
            set { _CD_CHMID = value; }
        }

        /// <summary>
        /// Gets or sets the Control Type Name.
        /// </summary>
        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
    }
}
