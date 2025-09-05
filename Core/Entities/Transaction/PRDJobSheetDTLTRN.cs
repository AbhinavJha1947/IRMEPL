//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDJobSheetDTLTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDJobSheetDTLTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDJobSheetDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _JOBDTL_ID;
        private int _JOBDTL_JobsheetId;
        private int _JOBDTL_NoOfExtConn;
        private int _JOBDTL_MaterialID;
        private decimal _JOBDTL_PipeLength;
        private int _JOBDTL_ConnType;
        private int _JOBDTL_ExtraConnType;
        #endregion

        /// <summary>
        /// Default constructor for PRDJobSheetDTLTRN class.
        /// </summary>
        public PRDJobSheetDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDJobSheetDTLTRN(int JOBDTL_ID, int JOBDTL_JobsheetId, int JOBDTL_NoOfExtConn, int JOBDTL_MaterialID, decimal JOBDTL_PipeLength, int JOBDTL_ConnType, int JOBDTL_ExtraConnType)
        {
            this._JOBDTL_ID = JOBDTL_ID;
            this._JOBDTL_JobsheetId = JOBDTL_JobsheetId;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;
            this._JOBDTL_MaterialID = JOBDTL_MaterialID;
            this._JOBDTL_PipeLength = JOBDTL_PipeLength;
            this._JOBDTL_ConnType = JOBDTL_ConnType;
            this._JOBDTL_ExtraConnType = JOBDTL_ExtraConnType;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ID
        {
            get { return _JOBDTL_ID; }
            set { _JOBDTL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_JobsheetId
        {
            get { return _JOBDTL_JobsheetId; }
            set { _JOBDTL_JobsheetId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_MaterialID
        {
            get { return _JOBDTL_MaterialID; }
            set { _JOBDTL_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal JOBDTL_PipeLength
        {
            get { return _JOBDTL_PipeLength; }
            set { _JOBDTL_PipeLength = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ConnType
        {
            get { return _JOBDTL_ConnType; }
            set { _JOBDTL_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_ExtraConnType
        {
            get { return _JOBDTL_ExtraConnType; }
            set { _JOBDTL_ExtraConnType = value; }
        }

    }

    public class PRDJobSheetDTLTRNList
    {

        private int _JOBDTL_MaterialID;
        private string _MaterialName;
        private string _ConnectionType;
        private int _JOBDTL_ConnType;
        private decimal _JOBDTL_PipeLength;
        private string _ExtraConnType;
        private int _JOBDTL_ExtraConnType;
        private int _JOBDTL_NoOfExtConn;


        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDJobSheetDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDJobSheetDTLTRNList(int JOBDTL_MaterialID, string MaterialName, string ConnectionType, int JOBDTL_ConnType, decimal JOBDTL_PipeLength, string ExtraConnType, int JOBDTL_ExtraConnType, int JOBDTL_NoOfExtConn)
        {
            this._JOBDTL_MaterialID = JOBDTL_MaterialID;
            this._MaterialName = MaterialName;
            this._ConnectionType = ConnectionType;
            this._JOBDTL_ConnType = JOBDTL_ConnType;
            this._JOBDTL_PipeLength = JOBDTL_PipeLength;
            this._ExtraConnType = ExtraConnType;
            this._JOBDTL_ExtraConnType = JOBDTL_ExtraConnType;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public int JOBDTL_MaterialID
        {
            get { return _JOBDTL_MaterialID; }
            set { _JOBDTL_MaterialID = value; }
        }



        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }
        public string ConnectionType
        {
            get { return _ConnectionType; }
            set { _ConnectionType = value; }
        }
        public int JOBDTL_ConnType
        {
            get { return _JOBDTL_ConnType; }
            set { _JOBDTL_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal JOBDTL_PipeLength
        {
            get { return _JOBDTL_PipeLength; }
            set { _JOBDTL_PipeLength = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ExtraConnType
        {
            get { return _ExtraConnType; }
            set { _ExtraConnType = value; }
        }

        public int JOBDTL_ExtraConnType
        {
            get { return _JOBDTL_ExtraConnType; }
            set { _JOBDTL_ExtraConnType = value; }
        }

        public int JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }
    }
    public class PRDExtraConnectionReqList
    {
        private int   _EXCDTL_ID;
        private int  _EXCDTL_EConnID;
        private string _CD_ControlType;
        private int _EXCDTL_NoOfConnection;
        private decimal _EXCDTL_Amount;
        private int _count2;
  
        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDExtraConnectionReqList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDExtraConnectionReqList(int EXCDTL_ID, int EXCDTL_EConnID, string CD_ControlType, int EXCDTL_NoOfConnection, decimal EXCDTL_Amount,int count2)
        {
            this._EXCDTL_ID = EXCDTL_ID;
            this._EXCDTL_EConnID = EXCDTL_EConnID;
            this._CD_ControlType = CD_ControlType;
            this._EXCDTL_NoOfConnection = EXCDTL_NoOfConnection;
            this._EXCDTL_Amount = EXCDTL_Amount;
            this._count2 = count2; 

        }

        public int EXCDTL_ID
        {
            get { return _EXCDTL_ID; }
            set { _EXCDTL_ID = value; }
        }
        public int EXCDTL_EConnID
        {
            get { return _EXCDTL_EConnID; }
            set { _EXCDTL_EConnID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }

        public decimal EXCDTL_Amount
        {
            get { return _EXCDTL_Amount; }
            set { _EXCDTL_Amount = value; }
        }

        public int count2
        {
            get { return _count2; }

        }


    }
    public class PRDJobSheetExtraDTLTRNList
    {
        private string _ExtraConnectionType;
        private int _JOBDTL_ExtraConnType;
        private int _JOBDTL_NoOfExtConn;






        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public PRDJobSheetExtraDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public PRDJobSheetExtraDTLTRNList(string ExtraConnectionType, int JOBDTL_ExtraConnType, int JOBDTL_NoOfExtConn)
        {
            this._ExtraConnectionType = ExtraConnectionType;
            this._JOBDTL_ExtraConnType = JOBDTL_ExtraConnType;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;


        }

        public string ExtraConnectionType
        {
            get { return _ExtraConnectionType; }
            set { _ExtraConnectionType = value; }
        }
        public int JOBDTL_ExtraConnType
        {
            get { return _JOBDTL_ExtraConnType; }
            set { _JOBDTL_ExtraConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public int JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }






    }
    public class PRDJobSheetDTLTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDJobSheetDTLTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDJobSheetDTLTRNMsg(int RetVal, string RetStr)
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
    public class PRDJobSheetDTLTRNForAS
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private string _Typeofconnection;
        private string _JOBDTL_NoOfExtConn;
        private string _JOBDTL_PipeLength;
        private int _JOBDTL_JobsheetId;



        #endregion

        /// <summary>
        /// Default constructor for CORApplicationMaster class.
        /// </summary>
        public PRDJobSheetDTLTRNForAS() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDJobSheetDTLTRNForAS(string Typeofconnection, string JOBDTL_NoOfExtConn, string JOBDTL_PipeLength, int JOBDTL_JobsheetId)
        {
            this._Typeofconnection = Typeofconnection;
            this._JOBDTL_NoOfExtConn = JOBDTL_NoOfExtConn;
            this._JOBDTL_PipeLength = JOBDTL_PipeLength;
            this._JOBDTL_JobsheetId = JOBDTL_JobsheetId;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string Typeofconnection
        {
            get { return _Typeofconnection; }
            set { _Typeofconnection = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string JOBDTL_NoOfExtConn
        {
            get { return _JOBDTL_NoOfExtConn; }
            set { _JOBDTL_NoOfExtConn = value; }
        }
        public string JOBDTL_PipeLength
        {
            get { return _JOBDTL_PipeLength; }
            set { _JOBDTL_PipeLength = value; }
        }
        
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int JOBDTL_JobsheetId
        {
            get { return _JOBDTL_JobsheetId; }
            set { _JOBDTL_JobsheetId = value; }
        }

    }

}
