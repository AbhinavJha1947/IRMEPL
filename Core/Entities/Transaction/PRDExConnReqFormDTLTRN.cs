////Business File.
//using System; using System.Collections.Generic; using System.Linq; using System.Text; using System.Threading.Tasks;
//using System.Text;

//namespace Core.Entities.Transaction
//{
//    /// <summary>
//    /// Class that holds information about a 	PRDExConnReqFormDTLTRN.
//    ///
//    /// Enterprise Design Pattern: Domain Model, Identity Field.
//    /// </summary>
//    /// <remarks>
//    /// This is where your business logic resides. In this example there are none.
//    /// Another place for business logic and business rules is in the Service.
//    /// For an example see 	PRDExConnReqFormDTLTRNService in the Service layer.
//    ///
//    /// The Domain Model Design Pattern states that domain objects incorporate
//    /// both behavior and data. Behavior may include simple or complex business logic.
//    ///
//    /// The Identity Field Design Pattern saves the ID field in an object to maintain
//    /// identity between an in-memory business object and that database rows.
//    /// </remarks>
//    
//    public class 	PRDExConnReqFormDTLTRN
//    {
//        /// Class level Local Variables Declaration.
//        #region "Variables Declaration"
//            private int _EXCDTL_ID;
//            private decimal _EXCDTL_EConnID;
//            private int _EXCDTL_ConnType;
//            private int _EXCDTL_NoOfConnection;
//            private decimal _EXCDTL_Amount;
//        #endregion

//        /// <summary>
//        /// Default constructor for PRDExConnReqFormDTLTRN class.
//        /// </summary>
//        public PRDExConnReqFormDTLTRN() { }

//        /// <summary>
//        /// Overloaded constructor for the Branch class.
//        /// </summary>
//        public PRDExConnReqFormDTLTRN(int EXCDTL_ID,decimal EXCDTL_EConnID,int EXCDTL_ConnType,int EXCDTL_NoOfConnection,decimal EXCDTL_Amount)
//        {
//            this._EXCDTL_ID = EXCDTL_ID;
//            this._EXCDTL_EConnID = EXCDTL_EConnID;
//            this._EXCDTL_ConnType = EXCDTL_ConnType;
//            this._EXCDTL_NoOfConnection = EXCDTL_NoOfConnection;
//            this._EXCDTL_Amount = EXCDTL_Amount;
//        }

//        /// <summary>
//        //Write Column Description here. 
//        /// </summary>
//        public int EXCDTL_ID
//            {
//                 get { return _EXCDTL_ID; }
//                 set { _EXCDTL_ID = value; }
//            }

//        /// <summary>
//        //Write Column Description here. 
//        /// </summary>
//        public decimal EXCDTL_EConnID
//            {
//                 get { return _EXCDTL_EConnID; }
//                 set { _EXCDTL_EConnID = value; }
//            }

//        /// <summary>
//        //Write Column Description here. 
//        /// </summary>
//        public int EXCDTL_ConnType
//            {
//                 get { return _EXCDTL_ConnType; }
//                 set { _EXCDTL_ConnType = value; }
//            }

//        /// <summary>
//        //Write Column Description here. 
//        /// </summary>
//        public int EXCDTL_NoOfConnection
//            {
//                 get { return _EXCDTL_NoOfConnection; }
//                 set { _EXCDTL_NoOfConnection = value; }
//            }

//        /// <summary>
//        //Write Column Description here. 
//        /// </summary>
//        public decimal EXCDTL_Amount
//            {
//                 get { return _EXCDTL_Amount; }
//                 set { _EXCDTL_Amount = value; }
//            }

//    }
    


//public class PRDExConnReqFormDTLTRNMsg
//{
//    // Class level Local Variables Declaration.
//    #region "Variables Declaration"
//private int _RetVal;
//private string _RetStr;
//    #endregion

//    /// <summary>
//    //Overloaded default constructor for the Salutation class. 
//    /// </summary>
//public PRDExConnReqFormDTLTRNMsg(){ }
//    /// <summary>
//    //Overloaded constructor for the Salutation class. 
//    /// </summary>
//    /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
//    /// <param name="saltnmName">Name of the Salutation.</param>
//public PRDExConnReqFormDTLTRNMsg(int RetVal, string RetStr)
//{
//this._RetVal = RetVal;
//this._RetStr = RetStr;
//}
//    /// <summary>
//    //Gets or sets unique Salutation identifier. 
//    //The Identity Field Design Pattern. 
//    /// </summary>
//public int RetVal
//{
//get { return _RetVal; }
//set { _RetVal = value; }
//}
//    /// <summary>
//    //Gets or sets Country Name.
//    /// </summary>
//public string RetStr
//{
//get { return _RetStr; }
//set { _RetStr = value; }
//}
//}
//}







//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	PRDExConnReqFormDTLTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	PRDExConnReqFormDTLTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class PRDExConnReqFormDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _EXCDTL_ID;
        private int _EXCDTL_EConnID;
        private int _EXCDTL_ConnType;
        private int _EXCDTL_NoOfConnection;
        private decimal _EXCDTL_Amount;
        #endregion

        /// <summary>
        /// Default constructor for PRDExConnReqFormDTLTRN class.
        /// </summary>
        public PRDExConnReqFormDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDExConnReqFormDTLTRN(int EXCDTL_ID, int EXCDTL_EConnID, int EXCDTL_ConnType, int EXCDTL_NoOfConnection, decimal EXCDTL_Amount)
        {
            this._EXCDTL_ID = EXCDTL_ID;
            this._EXCDTL_EConnID = EXCDTL_EConnID;
            this._EXCDTL_ConnType = EXCDTL_ConnType;
            this._EXCDTL_NoOfConnection = EXCDTL_NoOfConnection;
            this._EXCDTL_Amount = EXCDTL_Amount;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCDTL_ID
        {
            get { return _EXCDTL_ID; }
            set { _EXCDTL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCDTL_EConnID
        {
            get { return _EXCDTL_EConnID; }
            set { _EXCDTL_EConnID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCDTL_ConnType
        {
            get { return _EXCDTL_ConnType; }
            set { _EXCDTL_ConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCDTL_NoOfConnection
        {
            get { return _EXCDTL_NoOfConnection; }
            set { _EXCDTL_NoOfConnection = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal EXCDTL_Amount
        {
            get { return _EXCDTL_Amount; }
            set { _EXCDTL_Amount = value; }
        }
    }

    public class PRDExConnReqFormDTLTRNList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }

    //public class PRDExConnReqFormDTLTRNList_CustomerData
    //{


    //    string _CD_ControlType;
    //    int _EXCDTL_NoOfConnection;



    //    /// <summary>
    //    /// Default constructor for BILMeterReadingTRN class.
    //    /// </summary>
    //    public PRDExConnReqFormDTLTRNList_CustomerData() { }

    //    /// <summary>
    //    /// Overloaded constructor for the Branch class.
    //    /// </summary>
    //    public PRDExConnReqFormDTLTRNList_CustomerData(string CD_ControlType, int EXCDTL_NoOfConnection)
    //    {

    //        this._CD_ControlType = CD_ControlType;
    //        this._EXCDTL_NoOfConnection = EXCDTL_NoOfConnection;
    //    }

    //    /// <summary>
    //    //Write Column Description here. 
    //    /// </summary>
    //    public string CD_ControlType
    //    {
    //        get { return _CD_ControlType; }
    //        set { _CD_ControlType = value; }
    //    }

    //    /// <summary>
    //    //Write Column Description here. 
    //    /// </summary>
    //    public int EXCDTL_NoOfConnection
    //    {
    //        get { return _EXCDTL_NoOfConnection; }
    //        set { _EXCDTL_NoOfConnection = value; }
    //    }

    //}


    public class PRDExConnReqFormDTLTRNList_DetailGrid
    {
        int _EXCHDR_EConnID;
        int _EXCDTL_ID;
        string _CD_ControlType;
        int _EXCDTL_NoOfConnection;
        decimal _TEDMST_Amount;
        int _TEDMST_ExtraConnTypeID;
        int _CD_ControlID;
        

        /// <summary>
        /// Default constructor for BILMeterReadingTRN class.
        /// </summary>
        public PRDExConnReqFormDTLTRNList_DetailGrid() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public PRDExConnReqFormDTLTRNList_DetailGrid(int EXCHDR_EConnID, int EXCDTL_ID, string CD_ControlType, int EXCDTL_NoOfConnection, decimal TEDMST_Amount, int TEDMST_ExtraConnTypeID, int CD_ControlID)
        {
            this._EXCHDR_EConnID = EXCHDR_EConnID;
            this._EXCDTL_ID = EXCDTL_ID;
            this._CD_ControlType = CD_ControlType;
            this._EXCDTL_NoOfConnection = EXCDTL_NoOfConnection;
            this._TEDMST_Amount = TEDMST_Amount;
            this._TEDMST_ExtraConnTypeID = TEDMST_ExtraConnTypeID;
            this._CD_ControlID= CD_ControlID;            
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCHDR_EConnID
        {
            get { return _EXCHDR_EConnID; }
            set { _EXCHDR_EConnID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int EXCDTL_ID
        {
            get { return _EXCDTL_ID; }
            set { _EXCDTL_ID = value; }
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
        public int EXCDTL_NoOfConnection
        {
            get { return _EXCDTL_NoOfConnection; }
            set { _EXCDTL_NoOfConnection = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal TEDMST_Amount
        {
            get { return _TEDMST_Amount; }
            set { _TEDMST_Amount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int TEDMST_ExtraConnTypeID
        {
            get { return _TEDMST_ExtraConnTypeID; }
            set { _TEDMST_ExtraConnTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CD_ControlID
        {
            get { return _CD_ControlID; }
            set { _CD_ControlID = value; }
        }
    }

    public class PRDExConnReqFormDTLTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public PRDExConnReqFormDTLTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public PRDExConnReqFormDTLTRNMsg(int RetVal, string RetStr)
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





