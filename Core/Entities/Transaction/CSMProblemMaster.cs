//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	CSMProblemMaster.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CSMProblemMasterService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CSMProblemMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PROMST_ProblemId;
        private string _PROMST_Description;
        private int _PROMST_ProblemType;
        private int _PROMST_Priority;
        private int _PROMST_ClosedBefore;
        private int _PROMST_UserId;
        private long _PROMST_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CSMProblemMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMProblemMaster(int PROMST_ProblemId, string PROMST_Description, int PROMST_ProblemType, int PROMST_Priority, int PROMST_ClosedBefore, int PROMST_UserId, long PROMST_RowVersion)
        {
            this._PROMST_ProblemId = PROMST_ProblemId;
            this._PROMST_Description = PROMST_Description;
            this._PROMST_ProblemType = PROMST_ProblemType;
            this._PROMST_Priority = PROMST_Priority;
            this._PROMST_ClosedBefore = PROMST_ClosedBefore;
            this._PROMST_UserId = PROMST_UserId;
            this._PROMST_RowVersion = PROMST_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_ProblemId
        {
            get { return _PROMST_ProblemId; }
            set { _PROMST_ProblemId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PROMST_Description
        {
            get { return _PROMST_Description; }
            set { _PROMST_Description = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_ProblemType
        {
            get { return _PROMST_ProblemType; }
            set { _PROMST_ProblemType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_Priority
        {
            get { return _PROMST_Priority; }
            set { _PROMST_Priority = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_ClosedBefore
        {
            get { return _PROMST_ClosedBefore; }
            set { _PROMST_ClosedBefore = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_UserId
        {
            get { return _PROMST_UserId; }
            set { _PROMST_UserId = value; }
        }
        public long PROMST_RowVersion
        {
            get { return _PROMST_RowVersion; }
            set { _PROMST_RowVersion = value; }
        } 
        

    }

    public class CSMProblemMasterList
    {
         /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PROMST_ProblemId;
        private string _PROMST_Description;
        private string _ProblemType;
        private string _Priority;
        private string _ClosedBefore;
        private int _Count;
        #endregion

        /// <summary>
        /// Default constructor for CSMProblemMaster class.
        /// </summary>
        public CSMProblemMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CSMProblemMasterList(int PROMST_ProblemId, string PROMST_Description, string ProblemType, string Priority, string ClosedBefore, int Count)
        {
            this._PROMST_ProblemId = PROMST_ProblemId;
            this._PROMST_Description = PROMST_Description;
            this._ProblemType = ProblemType;
            this._Priority = Priority;
            this._ClosedBefore = ClosedBefore;
            this._Count = Count;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PROMST_ProblemId
        {
            get { return _PROMST_ProblemId; }
            set { _PROMST_ProblemId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PROMST_Description
        {
            get { return _PROMST_Description; }
            set { _PROMST_Description = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ProblemType
        {
            get { return _ProblemType; }
            set { _ProblemType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Priority
        {
            get { return _Priority; }
            set { _Priority = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ClosedBefore
        {
            get { return _ClosedBefore; }
            set { _ClosedBefore = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }


    public class CSMProblemMasterMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CSMProblemMasterMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CSMProblemMasterMsg(int RetVal, string RetStr)
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
