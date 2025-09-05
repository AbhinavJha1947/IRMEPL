//Business File.
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Core
{
    /// <summary>
    /// Class that holds information about a 	CORPlanHDRMST.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	CORPlanHDRMSTService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class CORPlanHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PLAMST_Code;
        private string _PLAMST_StartDate;
        private string _PLAMST_PlanName;
        private int _PLAMST_PlanType;
        private int _PLAMST_PropertyTypeID;
        private decimal _PLAMST_PlanAmt;
        private decimal _PLAMST_WOAmt;
        private decimal _PLAMST_CommClearAmt;
        private int _PLAMST_CreatedByUserID;
        private int _PLAMST_UpdatedByUserID;
        private int _PLAMST_RowStatus;
        private long _PLAMST_RowVersion;
        private int _PLAMST_MobileAppStatus;
        #endregion

        /// <summary>
        /// Default constructor for CORPlanHDRMST class.
        /// </summary>
        public CORPlanHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPlanHDRMST(int PLAMST_Code, string PLAMST_StartDate, string PLAMST_PlanName, int PLAMST_PlanType, int PLAMST_PropertyTypeID, decimal PLAMST_PlanAmt, decimal PLAMST_WOAmt, decimal PLAMST_CommClearAmt, int PLAMST_CreatedByUserID, int PLAMST_UpdatedByUserID, int PLAMST_RowStatus, long PLAMST_RowVersion, int PLAMST_MobileAppStatus)
        {
            this._PLAMST_Code = PLAMST_Code;
            this._PLAMST_StartDate = PLAMST_StartDate;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._PLAMST_PlanType = PLAMST_PlanType;
            this._PLAMST_PropertyTypeID = PLAMST_PropertyTypeID;
            this._PLAMST_PlanAmt = PLAMST_PlanAmt;
            this._PLAMST_WOAmt = PLAMST_WOAmt;
            this._PLAMST_CommClearAmt = PLAMST_CommClearAmt;
            this._PLAMST_CreatedByUserID = PLAMST_CreatedByUserID;
            this._PLAMST_UpdatedByUserID = PLAMST_UpdatedByUserID;
            this._PLAMST_RowStatus = PLAMST_RowStatus;
            this._PLAMST_RowVersion = PLAMST_RowVersion;
            this._PLAMST_MobileAppStatus = PLAMST_MobileAppStatus;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_Code
        {
            get { return _PLAMST_Code; }
            set { _PLAMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_StartDate
        {
            get { return _PLAMST_StartDate; }
            set { _PLAMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_PlanType
        {
            get { return _PLAMST_PlanType; }
            set { _PLAMST_PlanType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_PropertyTypeID
        {
            get { return _PLAMST_PropertyTypeID; }
            set { _PLAMST_PropertyTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_PlanAmt
        {
            get { return _PLAMST_PlanAmt; }
            set { _PLAMST_PlanAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_WOAmt
        {
            get { return _PLAMST_WOAmt; }
            set { _PLAMST_WOAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_CommClearAmt
        {
            get { return _PLAMST_CommClearAmt; }
            set { _PLAMST_CommClearAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_CreatedByUserID
        {
            get { return _PLAMST_CreatedByUserID; }
            set { _PLAMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_UpdatedByUserID
        {
            get { return _PLAMST_UpdatedByUserID; }
            set { _PLAMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_RowStatus
        {
            get { return _PLAMST_RowStatus; }
            set { _PLAMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long PLAMST_RowVersion
        {
            get { return _PLAMST_RowVersion; }
            set { _PLAMST_RowVersion = value; }
        }

        public int PLAMST_MobileAppStatus
        {
            get { return _PLAMST_MobileAppStatus; }
            set { _PLAMST_MobileAppStatus = value; }
        }

    }

    public class CORPlanHDRMSTList
    {
        #region "Variables Declaration"
        private int _PLAMST_Code;
        private string _PLAMST_StartDate;
        private string _PLAMST_PlanName;
        private string _PlanType;
        private string _PropertyType;
        private decimal _PLAMST_WOAmt;
        private decimal _PLAMST_CommClearAmt;
        private decimal _PLAMST_PlanAmt;
        private string _PLAMST_RowStatus;
        private int _Count;
        private string _PLAMST_MobileAppStatus;
        #endregion
        public CORPlanHDRMSTList() { }
        public CORPlanHDRMSTList(int PLAMST_Code, string PLAMST_StartDate, string PLAMST_PlanName, string PlanType, string PropertyType, decimal PLAMST_WOAmt, decimal PLAMST_CommClearAmt, decimal PLAMST_PlanAmt, string PLAMST_RowStatus, int Count, string PLAMST_MobileAppStatus)
        {
            this._PLAMST_Code = PLAMST_Code;
            this._PLAMST_StartDate = PLAMST_StartDate;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._PlanType = PlanType;
            this._PropertyType = PropertyType;
            this._PLAMST_WOAmt = PLAMST_WOAmt;
            this._PLAMST_CommClearAmt = PLAMST_CommClearAmt;
            this._PLAMST_PlanAmt = PLAMST_PlanAmt;
            this._PLAMST_RowStatus = PLAMST_RowStatus;
            this._Count = Count;
            this._PLAMST_MobileAppStatus = PLAMST_MobileAppStatus;

        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PLAMST_Code
        {
            get { return _PLAMST_Code; }
            set { _PLAMST_Code = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_StartDate
        {
            get { return _PLAMST_StartDate; }
            set { _PLAMST_StartDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PlanType
        {
            get { return _PlanType; }
            set { _PlanType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PropertyType
        {
            get { return _PropertyType; }
            set { _PropertyType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_WOAmt
        {
            get { return _PLAMST_WOAmt; }
            set { _PLAMST_WOAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_CommClearAmt
        {
            get { return _PLAMST_CommClearAmt; }
            set { _PLAMST_CommClearAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PLAMST_PlanAmt
        {
            get { return _PLAMST_PlanAmt; }
            set { _PLAMST_PlanAmt = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PLAMST_RowStatus
        {
            get { return _PLAMST_RowStatus; }
            set { _PLAMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public string PLAMST_MobileAppStatus
        {
            get { return _PLAMST_MobileAppStatus; }
            set { _PLAMST_MobileAppStatus = value; }
        }

        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //--VBS
    }


    public class CORPlanHDRMSTMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORPlanHDRMSTMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORPlanHDRMSTMsg(int RetVal, string RetStr)
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

    
    public class CORPlanDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PDLMST_ID;
        private int _PDLMST_PlanID;
        private int _PDLMST_HeadID;
        private decimal _PDLMST_Amount;
        private bool _PDLMST_Refundable;
        private int _PDLMST_NoofEMI;
        private int _PDLMST_Collect;
        #endregion

        /// <summary>
        /// Default constructor for CORPlanDTLMST class.
        /// </summary>
        public CORPlanDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPlanDTLMST(int PDLMST_ID, int PDLMST_PlanID, int PDLMST_HeadID, decimal PDLMST_Amount, bool PDLMST_Refundable, int PDLMST_NoofEMI, int PDLMST_Collect)
        {
            this._PDLMST_ID = PDLMST_ID;
            this._PDLMST_PlanID = PDLMST_PlanID;
            this._PDLMST_HeadID = PDLMST_HeadID;
            this._PDLMST_Amount = PDLMST_Amount;
            this._PDLMST_Refundable = PDLMST_Refundable;
            this._PDLMST_NoofEMI = PDLMST_NoofEMI;
            this._PDLMST_Collect = PDLMST_Collect;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_ID
        {
            get { return _PDLMST_ID; }
            set { _PDLMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_PlanID
        {
            get { return _PDLMST_PlanID; }
            set { _PDLMST_PlanID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_HeadID
        {
            get { return _PDLMST_HeadID; }
            set { _PDLMST_HeadID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PDLMST_Amount
        {
            get { return _PDLMST_Amount; }
            set { _PDLMST_Amount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool PDLMST_Refundable
        {
            get { return _PDLMST_Refundable; }
            set { _PDLMST_Refundable = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_NoofEMI
        {
            get { return _PDLMST_NoofEMI; }
            set { _PDLMST_NoofEMI = value; }
        }
        public int PDLMST_Collect
        {
            get { return _PDLMST_Collect; }
            set { _PDLMST_Collect = value; }
        }

    }

    public class CORPlanDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PDLMST_HeadID;
        private string _HeadName;
        private int _PDLMST_NoofEMI;
        private bool _PDLMST_Refundable;
        private decimal _PDLMST_Amount;
        private int _PDLMST_Collect;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORPlanDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORPlanDTLMSTList(int PDLMST_HeadID, string HeadName, decimal PDLMST_Amount, bool PDLMST_Refundable, int PDLMST_NoofEMI, int PDLMST_Collect)
        {
            this._PDLMST_HeadID = PDLMST_HeadID;
            this._HeadName = HeadName;
            this._PDLMST_Amount = PDLMST_Amount;
            this._PDLMST_Refundable = PDLMST_Refundable;
            this._PDLMST_NoofEMI = PDLMST_NoofEMI;
            this._PDLMST_Collect = PDLMST_Collect;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_HeadID
        {
            get { return _PDLMST_HeadID; }
            set { _PDLMST_HeadID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string HeadName
        {
            get { return _HeadName; }
            set { _HeadName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PDLMST_NoofEMI
        {
            get { return _PDLMST_NoofEMI; }
            set { _PDLMST_NoofEMI = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool PDLMST_Refundable
        {
            get { return _PDLMST_Refundable; }
            set { _PDLMST_Refundable = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PDLMST_Amount
        {
            get { return _PDLMST_Amount; }
            set { _PDLMST_Amount = value; }
        }

        public int PDLMST_Collect
        {
            get { return _PDLMST_Collect; }
            set { _PDLMST_Collect = value; }
        }
    }

    
    public class CORPlanMATDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PMDMST_ID;
        private int _PMDMST_PlanID;
        private int _PMDMST_MaterialID;
        private decimal _PMDMST_PipeLengthFree;
        private int _PMDMST_PropertyTypeID;
        private int _PMDMST_PipeConnType;
        private int _PMDMST_ExtraConnType;
        #endregion

        /// <summary>
        /// Default constructor for CORPlanMATDTLMST class.
        /// </summary>
        public CORPlanMATDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPlanMATDTLMST(int PMDMST_ID, int PMDMST_PlanID, int PMDMST_MaterialID, decimal PMDMST_PipeLengthFree, int PMDMST_PropertyTypeID, int PMDMST_PipeConnType, int PMDMST_ExtraConnType)
        {
            this._PMDMST_ID = PMDMST_ID;
            this._PMDMST_PlanID = PMDMST_PlanID;
            this._PMDMST_MaterialID = PMDMST_MaterialID;
            this._PMDMST_PipeLengthFree = PMDMST_PipeLengthFree;
            this._PMDMST_PropertyTypeID = PMDMST_PropertyTypeID;
            this._PMDMST_PipeConnType = PMDMST_PipeConnType;
            this._PMDMST_ExtraConnType = PMDMST_ExtraConnType;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_ID
        {
            get { return _PMDMST_ID; }
            set { _PMDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_PlanID
        {
            get { return _PMDMST_PlanID; }
            set { _PMDMST_PlanID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_MaterialID
        {
            get { return _PMDMST_MaterialID; }
            set { _PMDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PMDMST_PipeLengthFree
        {
            get { return _PMDMST_PipeLengthFree; }
            set { _PMDMST_PipeLengthFree = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_PropertyTypeID
        {
            get { return _PMDMST_PropertyTypeID; }
            set { _PMDMST_PropertyTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_PipeConnType
        {
            get { return _PMDMST_PipeConnType; }
            set { _PMDMST_PipeConnType = value; }
        }

        public int PMDMST_ExtraConnType
        {
            get { return _PMDMST_ExtraConnType; }
            set { _PMDMST_ExtraConnType = value; }
        }
    }

    public class CORPlanMATDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PMDMST_MaterialID;
        private string _MaterialName;
        private decimal _PMDMST_PipeLengthFree;
        private int _PMDMST_PipeConnType;
        private string _PipeConnType;
        private int _PMDMST_PropertyTypeID;
        private string _PropertyType;
        private string _ExtraConnType;
        private int _PMDMST_ExtraConnType;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORPlanMATDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORPlanMATDTLMSTList(int PMDMST_MaterialID, string MaterialName, decimal PMDMST_PipeLengthFree, int PMDMST_PipeConnType, string PipeConnType, int PMDMST_ExtraConnType, string ExtraConnType, int PMDMST_PropertyTypeID, string PropertyType)
        {
            this._PMDMST_MaterialID = PMDMST_MaterialID;
            this._MaterialName = MaterialName;
            this._PMDMST_PipeLengthFree = PMDMST_PipeLengthFree;
            this._PMDMST_PipeConnType = PMDMST_PipeConnType;
            this._PipeConnType = PipeConnType;
            this._PMDMST_ExtraConnType = PMDMST_ExtraConnType;
            this._ExtraConnType = ExtraConnType;
            this._PMDMST_PropertyTypeID = PMDMST_PropertyTypeID;
            this._PropertyType = PropertyType;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_MaterialID
        {
            get { return _PMDMST_MaterialID; }
            set { _PMDMST_MaterialID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string MaterialName
        {
            get { return _MaterialName; }
            set { _MaterialName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal PMDMST_PipeLengthFree
        {
            get { return _PMDMST_PipeLengthFree; }
            set { _PMDMST_PipeLengthFree = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_PipeConnType
        {
            get { return _PMDMST_PipeConnType; }
            set { _PMDMST_PipeConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PipeConnType
        {
            get { return _PipeConnType; }
            set { _PipeConnType = value; }
        }

        public int PMDMST_ExtraConnType
        {
            get { return _PMDMST_ExtraConnType; }
            set { _PMDMST_ExtraConnType = value; }
        }

        public string ExtraConnType
        {
            get { return _ExtraConnType; }
            set { _ExtraConnType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PMDMST_PropertyTypeID
        {
            get { return _PMDMST_PropertyTypeID; }
            set { _PMDMST_PropertyTypeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PropertyType
        {
            get { return _PropertyType; }
            set { _PropertyType = value; }
        }
    }

    
    public class CORPlanSchemeDTLMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PSDMST_ID;
        private int _PSDMST_PlanID;
        private int _PSDMST_SchemeID;
        #endregion

        /// <summary>
        /// Default constructor for CORPlanSchemeDTLMST class.
        /// </summary>
        public CORPlanSchemeDTLMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPlanSchemeDTLMST(int PSDMST_ID, int PSDMST_PlanID, int PSDMST_SchemeID)
        {
            this._PSDMST_ID = PSDMST_ID;
            this._PSDMST_PlanID = PSDMST_PlanID;
            this._PSDMST_SchemeID = PSDMST_SchemeID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PSDMST_ID
        {
            get { return _PSDMST_ID; }
            set { _PSDMST_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PSDMST_PlanID
        {
            get { return _PSDMST_PlanID; }
            set { _PSDMST_PlanID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PSDMST_SchemeID
        {
            get { return _PSDMST_SchemeID; }
            set { _PSDMST_SchemeID = value; }
        }

    }

    public class CORPlanSchemeDTLMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PSDMST_SchemeID;
        private string _SCHMST_Name;
        private bool _Checked;
        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORPlanSchemeDTLMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public CORPlanSchemeDTLMSTList(int PSDMST_SchemeID, string SCHMST_Name, bool Checked)
        {
            this._PSDMST_SchemeID = PSDMST_SchemeID;
            this._SCHMST_Name = SCHMST_Name;
            this._Checked = Checked;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PSDMST_SchemeID
        {
            get { return _PSDMST_SchemeID; }
            set { _PSDMST_SchemeID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string SCHMST_Name
        {
            get { return _SCHMST_Name; }
            set { _SCHMST_Name = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public bool Checked
        {
            get { return _Checked; }
            set { _Checked = value; }
        }
    }

    public class CORCenterPlanMapping
    {
        #region "Variables Declaration"
        private int _CPM_CenterCode;
        private int _CPM_PlanCode;
        private int _CPM_CreatedByUserID;
        private int _CPM_UpdatedByUserID;
        private int _CPM_RowStatus;
        private long _CPM_RowVersion;
        #endregion
       
        #region "Property Declaration"
        public int CPM_CenterCode
        {
            get { return _CPM_CenterCode; }
            set { _CPM_CenterCode = value; }
        }
        public int CPM_PlanCode
        {
            get { return _CPM_PlanCode; }
            set { _CPM_PlanCode = value; }
        }
        public int CPM_CreatedByUserID
        {
            get { return _CPM_CreatedByUserID; }
            set { _CPM_CreatedByUserID = value; }
        }
        public int CPM_UpdatedByUserID
        {
            get { return _CPM_UpdatedByUserID; }
            set { _CPM_UpdatedByUserID = value; }
        }
        public int CPM_RowStatus
        {
            get { return _CPM_RowStatus; }
            set { _CPM_RowStatus = value; }
        }
        public long CPM_RowVersion
        {
            get { return _CPM_RowVersion; }
            set { _CPM_RowVersion = value; }
        }
        #endregion

        #region "Constructor"
        public CORCenterPlanMapping() { }
        public CORCenterPlanMapping(int CPM_CenterCode, int CPM_PlanCode, int CPM_CreatedByUserID, int CPM_UpdatedByUserID, int CPM_RowStatus, int CPM_RowVersion)
        {
            this._CPM_CenterCode = CPM_CenterCode;
            this._CPM_PlanCode = CPM_PlanCode;
            this._CPM_CreatedByUserID = CPM_CreatedByUserID;
            this._CPM_UpdatedByUserID = CPM_UpdatedByUserID;
            this._CPM_RowStatus = CPM_RowStatus;
            this._CPM_RowVersion = CPM_RowVersion;
        }

        #endregion


    }

    public class CORCenterPlanMappingList
    {
        #region "Variables Declaration"
        private int _CPM_ID;
        private int _CPM_CenterCode;
        private int _CPM_PlanCode;
        private string _CENMST_Name;
        private string _PLAMST_PlanName;
        private int _CPM_RowStatus;
        private int _Count;

        #endregion

        #region "Property Declaration"
        public int CPM_ID
        {
            get { return _CPM_ID; }
            set { _CPM_ID = value; }
        }
        public int CPM_CenterCode
        {
            get { return _CPM_CenterCode; }
            set { _CPM_CenterCode = value; }
        }

        public int CPM_PlanCode
        {
            get { return _CPM_PlanCode; }
            set { _CPM_PlanCode = value; }
        }
        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }

        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }
        public int CPM_RowStatus
        {
            get { return _CPM_RowStatus; }
            set { _CPM_RowStatus = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        #endregion

        #region "Constructor"
        public CORCenterPlanMappingList() { }
        public CORCenterPlanMappingList(int CPM_ID,int CPM_CenterCode, int CPM_PlanCode, string CENMST_Name, string PLAMST_PlanName, int CPM_RowStatus, int Count)
        {
            this._CPM_ID = CPM_ID;
            this._CPM_CenterCode = CPM_CenterCode;
            this._CPM_PlanCode = CPM_PlanCode;
            this._CENMST_Name = CENMST_Name;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._CPM_RowStatus = CPM_RowStatus;
            this._Count = Count;
        }
        #endregion


    }





}
