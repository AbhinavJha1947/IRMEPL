using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    /// <summary>
    /// Class that holds information about a 	ACCChequeDTLTRN.
    ///
    /// Enterprise Design Pattern: Domain Model, Identity Field.
    /// </summary>
    /// <remarks>
    /// This is where your business logic resides. In this example there are none.
    /// Another place for business logic and business rules is in the Service.
    /// For an example see 	ACCChequeDTLTRNService in the Service layer.
    ///
    /// The Domain Model Design Pattern states that domain objects incorporate
    /// both behavior and data. Behavior may include simple or complex business logic.
    ///
    /// The Identity Field Design Pattern saves the ID field in an object to maintain
    /// identity between an in-memory business object and that database rows.
    /// </remarks>
    
    public class ACCChequeDTLTRN
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _CHQDTL_ChequeId;
        private int _CHQDTL_ApplicationId;
        private int _CHQDTL_CorporateId;
        private int _CHQDTL_Receiptno;
        private int _CHQDTL_BankId;
        private string _CHQDTL_Remarks;
        private string _CHQDTL_ChequeNo;
        private string _CHQDTL_ChequeDate;
        private decimal _CHQDTL_ChequeAmount;
        private string _CHQDTL_RealizedDate;
        private int _CHQDTL_LotID;
        private int _CHQDTL_Status;
        private int _CHQDTL_CENCode;
        private string _CHQDTL_DishonourDate;
        private string _CHQDTL_DisReason;
        private decimal _CHQDTL_BounceCharges;
        private int _CHQDTL_CreatedByUserID;
        private string _CHQDTL_CreatedDateTime;
        private int _CHQDTL_UpdatedByUserID;
        private string _CHQDTL_UpdatedDateTime;
        private int _CHQDTL_RowStatus;
        private long _CHQDTL_RowVersion;
        private long _CHQDTL_MicrNo;
        private int _CHQDTL_SMSFlag;
        #endregion

        /// <summary>
        /// Default constructor for ACCChequeDTLTRN class.
        /// </summary>
        public ACCChequeDTLTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCChequeDTLTRN(int CHQDTL_ChequeId, int CHQDTL_ApplicationId, int CHQDTL_CorporateId, int CHQDTL_Receiptno, int CHQDTL_BankId, string CHQDTL_Remarks, string CHQDTL_ChequeNo, string CHQDTL_ChequeDate, decimal CHQDTL_ChequeAmount, string CHQDTL_RealizedDate, int CHQDTL_LotID, int CHQDTL_Status, int CHQDTL_CENCode, string CHQDTL_DishonourDate, string CHQDTL_DisReason, decimal CHQDTL_BounceCharges, int CHQDTL_CreatedByUserID, string CHQDTL_CreatedDateTime, int CHQDTL_UpdatedByUserID, string CHQDTL_UpdatedDateTime, int CHQDTL_RowStatus, long CHQDTL_RowVersion, long CHQDTL_MicrNo, int CHQDTL_SMSFlag)
        {
            this._CHQDTL_ChequeId = CHQDTL_ChequeId;
            this._CHQDTL_ApplicationId = CHQDTL_ApplicationId;
            this._CHQDTL_CorporateId = CHQDTL_CorporateId;
            this._CHQDTL_Receiptno = CHQDTL_Receiptno;
            this._CHQDTL_BankId = CHQDTL_BankId;
            this._CHQDTL_Remarks = CHQDTL_Remarks;
            this._CHQDTL_ChequeNo = CHQDTL_ChequeNo;
            this._CHQDTL_ChequeDate = CHQDTL_ChequeDate;
            this._CHQDTL_ChequeAmount = CHQDTL_ChequeAmount;
            this._CHQDTL_RealizedDate = CHQDTL_RealizedDate;
            this._CHQDTL_LotID = CHQDTL_LotID;
            this._CHQDTL_Status = CHQDTL_Status;
            this._CHQDTL_CENCode = CHQDTL_CENCode;
            this._CHQDTL_DishonourDate = CHQDTL_DishonourDate;
            this._CHQDTL_DisReason = CHQDTL_DisReason;
            this._CHQDTL_BounceCharges = CHQDTL_BounceCharges;
            this._CHQDTL_CreatedByUserID = CHQDTL_CreatedByUserID;
            this._CHQDTL_CreatedDateTime = CHQDTL_CreatedDateTime;
            this._CHQDTL_UpdatedByUserID = CHQDTL_UpdatedByUserID;
            this._CHQDTL_UpdatedDateTime = CHQDTL_UpdatedDateTime;
            this._CHQDTL_RowStatus = CHQDTL_RowStatus;
            this._CHQDTL_RowVersion = CHQDTL_RowVersion;
            this._CHQDTL_MicrNo = CHQDTL_MicrNo;
            this._CHQDTL_SMSFlag = CHQDTL_SMSFlag;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_ChequeId
        {
            get { return _CHQDTL_ChequeId; }
            set { _CHQDTL_ChequeId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_ApplicationId
        {
            get { return _CHQDTL_ApplicationId; }
            set { _CHQDTL_ApplicationId = value; }
        }

        public int CHQDTL_CorporateId
        {
            get { return _CHQDTL_CorporateId; }
            set { _CHQDTL_CorporateId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_Receiptno
        {
            get { return _CHQDTL_Receiptno; }
            set { _CHQDTL_Receiptno = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_BankId
        {
            get { return _CHQDTL_BankId; }
            set { _CHQDTL_BankId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_Remarks
        {
            get { return _CHQDTL_Remarks; }
            set { _CHQDTL_Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_ChequeNo
        {
            get { return _CHQDTL_ChequeNo; }
            set { _CHQDTL_ChequeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_ChequeDate
        {
            get { return _CHQDTL_ChequeDate; }
            set { _CHQDTL_ChequeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CHQDTL_ChequeAmount
        {
            get { return _CHQDTL_ChequeAmount; }
            set { _CHQDTL_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_RealizedDate
        {
            get { return _CHQDTL_RealizedDate; }
            set { _CHQDTL_RealizedDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_LotID
        {
            get { return _CHQDTL_LotID; }
            set { _CHQDTL_LotID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_Status
        {
            get { return _CHQDTL_Status; }
            set { _CHQDTL_Status = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_CENCode
        {
            get { return _CHQDTL_CENCode; }
            set { _CHQDTL_CENCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_DishonourDate
        {
            get { return _CHQDTL_DishonourDate; }
            set { _CHQDTL_DishonourDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_DisReason
        {
            get { return _CHQDTL_DisReason; }
            set { _CHQDTL_DisReason = value; }
        }

        public decimal CHQDTL_BounceCharges
        {
            get { return _CHQDTL_BounceCharges; }
            set { _CHQDTL_BounceCharges = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_CreatedByUserID
        {
            get { return _CHQDTL_CreatedByUserID; }
            set { _CHQDTL_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_CreatedDateTime
        {
            get { return _CHQDTL_CreatedDateTime; }
            set { _CHQDTL_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_UpdatedByUserID
        {
            get { return _CHQDTL_UpdatedByUserID; }
            set { _CHQDTL_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CHQDTL_UpdatedDateTime
        {
            get { return _CHQDTL_UpdatedDateTime; }
            set { _CHQDTL_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_RowStatus
        {
            get { return _CHQDTL_RowStatus; }
            set { _CHQDTL_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CHQDTL_RowVersion
        {
            get { return _CHQDTL_RowVersion; }
            set { _CHQDTL_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CHQDTL_MicrNo
        {
            get { return _CHQDTL_MicrNo; }
            set { _CHQDTL_MicrNo = value; }
        }

        public int CHQDTL_SMSFlag
        {
            get { return _CHQDTL_SMSFlag; }
            set { _CHQDTL_SMSFlag = value; }
        }
    }

    public class ACCChequeDTLTRNList
    {
        #region "Variables Declaration"
        private int _CHQDTL_ChequeId;
        private int _CHQDTL_ApplicationId;
        private string _Application_No;
        private string _Customer_ID;
        private string _Customer_Name;
        private string _Customer_Address;
        private string _Area;
        private int _CHQDTL_Receiptno;
        private string _Recipt_Date;
        private string _Recipt_No;
        private int _CHQDTL_BankId;
        private string _BankName;
        private string _CHQDTL_Remarks;
        private string _CHQDTL_ChequeNo;
        private string _CHQDTL_ChequeDate;
        private decimal _Amount;
        private string _CHQDTL_RealizedDate;
        private string _CHQDTL_DishonourDate;
        private string _CHQDTL_LotID;
        private string _Status;
        private string _CHQDTL_CENCode;
        private string _CHQDTL_MicrNo;
        private string _BCLTRN_DepositDate;
        private int _Count;
        #endregion

        public ACCChequeDTLTRNList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCChequeDTLTRNList(int CHQDTL_ChequeId, int CHQDTL_ApplicationId, string Application_No, string Customer_ID, string Customer_Name, string Customer_Address, string Area, int CHQDTL_Receiptno, string Recipt_Date, string Recipt_No, int CHQDTL_BankId, string BankName, string CHQDTL_Remarks, string CHQDTL_ChequeNo, string CHQDTL_ChequeDate, decimal Amount, string CHQDTL_RealizedDate, string CHQDTL_DishonourDate, string CHQDTL_LotID, string Status, string CHQDTL_CENCode, string CHQDTL_MicrNo, string BCLTRN_DepositDate, int Count)
        {
            this._CHQDTL_ChequeId = CHQDTL_ChequeId;
            this._CHQDTL_ApplicationId = CHQDTL_ApplicationId;
            this._Application_No = Application_No;
            this._Customer_ID = Customer_ID;
            this._Customer_Name = Customer_Name;
            this._Customer_Address = Customer_Address;
            this._Area = Area;
            this._CHQDTL_Receiptno = CHQDTL_Receiptno;
            this._Recipt_Date = Recipt_Date;
            this._Recipt_No = Recipt_No;
            this._CHQDTL_BankId = CHQDTL_BankId;
            this._BankName = BankName;
            this._Amount = Amount;
            this._CHQDTL_Remarks = CHQDTL_Remarks;
            this._CHQDTL_ChequeNo = CHQDTL_ChequeNo;
            this._CHQDTL_ChequeDate = CHQDTL_ChequeDate;
            this._CHQDTL_RealizedDate = CHQDTL_RealizedDate;
            this._CHQDTL_DishonourDate = CHQDTL_DishonourDate;
            this._CHQDTL_LotID = CHQDTL_LotID;
            this._Status = Status;
            this._CHQDTL_CENCode = CHQDTL_CENCode;
            this._CHQDTL_MicrNo = CHQDTL_MicrNo;
            this._BCLTRN_DepositDate = BCLTRN_DepositDate;
            this._Count = Count;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CHQDTL_ChequeId
        {
            get { return _CHQDTL_ChequeId; }
            set { _CHQDTL_ChequeId = value; }
        }

        public int CHQDTL_ApplicationId
        {
            get { return _CHQDTL_ApplicationId; }
            set { _CHQDTL_ApplicationId = value; }
        }
        public string Application_No
        {
            get { return _Application_No; }
            set { _Application_No = value; }
        }
        public string Customer_ID
        {
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }
        public string Customer_Name
        {
            get { return _Customer_Name; }
            set { _Customer_Name = value; }
        }
        public string Customer_Address
        {
            get { return _Customer_Address; }
            set { _Customer_Address = value; }
        }
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }
        public int CHQDTL_Receiptno
        {
            get { return _CHQDTL_Receiptno; }
            set { _CHQDTL_Receiptno = value; }
        }
        public string Recipt_Date
        {
            get { return _Recipt_Date; }
            set { _Recipt_Date = value; }
        }
        public string Recipt_No
        {
            get { return _Recipt_No; }
            set { _Recipt_No = value; }
        }
        public int CHQDTL_BankId
        {
            get { return _CHQDTL_BankId; }
            set { _CHQDTL_BankId = value; }
        }
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public string CHQDTL_Remarks
        {
            get { return _CHQDTL_Remarks; }
            set { _CHQDTL_Remarks = value; }
        }
        public string CHQDTL_ChequeNo
        {
            get { return _CHQDTL_ChequeNo; }
            set { _CHQDTL_ChequeNo = value; }
        }
        public string CHQDTL_ChequeDate
        {
            get { return _CHQDTL_ChequeDate; }
            set { _CHQDTL_ChequeDate = value; }
        }
        public decimal Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public string CHQDTL_RealizedDate
        {
            get { return _CHQDTL_RealizedDate; }
            set { _CHQDTL_RealizedDate = value; }
        }
        public string CHQDTL_DishonourDate
        {
            get { return _CHQDTL_DishonourDate; }
            set { _CHQDTL_DishonourDate = value; }
        }
        public string CHQDTL_LotID
        {
            get { return _CHQDTL_LotID; }
            set { _CHQDTL_LotID = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string CHQDTL_CENCode
        {
            get { return _CHQDTL_CENCode; }
            set { _CHQDTL_CENCode = value; }
        }
        public string CHQDTL_MicrNo
        {
            get { return _CHQDTL_MicrNo; }
            set { _CHQDTL_MicrNo = value; }
        }
        public string BCLTRN_DepositDate
        {
            get { return _BCLTRN_DepositDate; }
            set { _BCLTRN_DepositDate = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }

    public class ACCChequeDTLTRNDepositList
    {
        #region "Variables Declaration"
        private int _ID;
        private string _ChequeID;
        private int _AppliID;
        private int _RECHDR_ReceiptType;
        private string _ReceiptType;
        private Int64 _CHQDTL_ReceiptNo;
        private string _ReciptNo;
        private string _Recipt_Date;
        private string _Customer_ID;
        private string _Customer_Name;
        private string _Customer_Address;
        private string _Application_No;
        private string _Name;
        private string _BankID;
        private string _BankName;
        private string _ChequeNo;
        private string _ChequeDate;
        private string _Amount;
        private string _RealizedDate;
        private string _LOTID;
        private string _CHQSTATUS;
        private string _Status;
        private string _MICR_No;
        private string _BCLTRN_DepositDate;
        private string _CHQDTL_DishonourDate;
        private string _CHQDTL_DisReason;
        private string _BCHDTL_IsBounceChargeIncluded;
        private decimal _BCHDTL_BounceCharges;
        private string _BCHDTL_ChequeNo;
        private string _BCHDTL_ChequeDate;
        private decimal _BCHDTL_ChequeAmount;
        private string _ReceiptStatus;
        private int _Count;
        private string _CorporateCode;
        #endregion

        public ACCChequeDTLTRNDepositList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCChequeDTLTRNDepositList(int ID, string ChequeID, int AppliID, int RECHDR_ReceiptType, string ReceiptType, Int64 CHQDTL_ReceiptNo, string ReciptNo, string Recipt_Date, string Customer_ID, string Customer_Name, string Customer_Address, string Application_No, string Name, string BankID, string BankName, string ChequeNo, string ChequeDate, string Amount, string RealizedDate, string LOTID, string CHQSTATUS, string Status, string MICR_No, string BCLTRN_DepositDate, string CHQDTL_DishonourDate, string CHQDTL_DisReason, string BCHDTL_IsBounceChargeIncluded, decimal BCHDTL_BounceCharges, string BCHDTL_ChequeNo, string BCHDTL_ChequeDate, decimal BCHDTL_ChequeAmount,string receiptStatus, int Count, string CorporateCode)
        {
            this._ID = ID;
            this._ChequeID = ChequeID;
            this._AppliID = AppliID;

            this._RECHDR_ReceiptType = RECHDR_ReceiptType;
            this._ReceiptType = ReceiptType;
            this._CHQDTL_ReceiptNo = CHQDTL_ReceiptNo;

            this._ReciptNo = ReciptNo;
            this._Recipt_Date = Recipt_Date;
            this._Customer_ID = Customer_ID;
            this._Customer_Name = Customer_Name;
            this._Customer_Address = Customer_Address;
            this._Application_No = Application_No;
            this._Name = Name;
            this._BankID = BankID;
            this._BankName = BankName;
            this._ChequeNo = ChequeNo;
            this._ChequeDate = ChequeDate;
            this._Amount = Amount;
            this._RealizedDate = RealizedDate;
            this._LOTID = LOTID;
            this._CHQSTATUS = CHQSTATUS;
            this._Status = Status;
            this._MICR_No = MICR_No;
            this._BCLTRN_DepositDate = BCLTRN_DepositDate;
            this._CHQDTL_DishonourDate = CHQDTL_DishonourDate;
            this._CHQDTL_DisReason = CHQDTL_DisReason;
            this._BCHDTL_IsBounceChargeIncluded = BCHDTL_IsBounceChargeIncluded;
            this._BCHDTL_BounceCharges = BCHDTL_BounceCharges;
            this._BCHDTL_ChequeNo = BCHDTL_ChequeNo;
            this._BCHDTL_ChequeDate = BCHDTL_ChequeDate;
            this._BCHDTL_ChequeAmount = BCHDTL_ChequeAmount;
            this._Count = Count;
            this._CorporateCode = CorporateCode;
            this._ReceiptStatus = receiptStatus;
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        public string ChequeID
        {
            get { return _ChequeID; }
            set { _ChequeID = value; }
        }

        public int AppliID
        {
            get { return _AppliID; }
            set { _AppliID = value; }
        }

        public Int64 CHQDTL_ReceiptNo
        {
            get { return _CHQDTL_ReceiptNo; }
            set { _CHQDTL_ReceiptNo = value; }
        }

        public int RECHDR_ReceiptType
        {
            get { return _RECHDR_ReceiptType; }
            set { _RECHDR_ReceiptType = value; }
        }

        public string ReceiptType
        {
            get { return _ReceiptType; }
            set { _ReceiptType = value; }
        }

        public string ReciptNo
        {
            get { return _ReciptNo; }
            set { _ReciptNo = value; }
        }

        public string Recipt_Date
        {
            get { return _Recipt_Date; }
            set { _Recipt_Date = value; }
        }

        public string Customer_ID
        {
            get { return _Customer_ID; }
            set { _Customer_ID = value; }
        }
        public string Customer_Name
        {
            get { return _Customer_Name; }
            set { _Customer_Name = value; }
        }
        public string Customer_Address
        {
            get { return _Customer_Address; }
            set { _Customer_Address = value; }
        }


        public string Application_No
        {
            get { return _Application_No; }
            set { _Application_No = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string BankID
        {
            get { return _BankID; }
            set { _BankID = value; }
        }
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public string ChequeNo
        {
            get { return _ChequeNo; }
            set { _ChequeNo = value; }
        }
        public string ChequeDate
        {
            get { return _ChequeDate; }
            set { _ChequeDate = value; }
        }
        public string Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }
        public string RealizedDate
        {
            get { return _RealizedDate; }
            set { _RealizedDate = value; }
        }
        public string LOTID
        {
            get { return _LOTID; }
            set { _LOTID = value; }
        }
        public string CHQSTATUS
        {
            get { return _CHQSTATUS; }
            set { _CHQSTATUS = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string MICR_No
        {
            get { return _MICR_No; }
            set { _MICR_No = value; }
        }
        public string BCLTRN_DepositDate
        {
            get { return _BCLTRN_DepositDate; }
            set { _BCLTRN_DepositDate = value; }
        }
        public string CHQDTL_DishonourDate
        {
            get { return _CHQDTL_DishonourDate; }
            set { _CHQDTL_DishonourDate = value; }
        }
        public string CHQDTL_DisReason
        {
            get { return _CHQDTL_DisReason; }
            set { _CHQDTL_DisReason = value; }
        }
        public string BCHDTL_IsBounceChargeIncluded
        {
            get { return _BCHDTL_IsBounceChargeIncluded; }
            set { _BCHDTL_IsBounceChargeIncluded = value; }
        }
        public decimal BCHDTL_BounceCharges
        {
            get { return _BCHDTL_BounceCharges; }
            set { BCHDTL_BounceCharges = value; }
        }

        public string BCHDTL_ChequeNo
        {
            get { return _BCHDTL_ChequeNo; }
            set { _BCHDTL_ChequeNo = value; }
        }

        public string BCHDTL_ChequeDate
        {
            get { return _BCHDTL_ChequeDate; }
            set { _BCHDTL_ChequeDate = value; }
        }

        public decimal BCHDTL_ChequeAmount
        {
            get { return _BCHDTL_ChequeAmount; }
            set { _BCHDTL_ChequeAmount = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public string CorporateCode
        {
            get { return _CorporateCode; }
            set { _CorporateCode = value; }
        }

        public string ReceiptStatus
        {
            get { return _ReceiptStatus; }
            set { _ReceiptStatus = value; }
        }

    }

    public class ACCChequeDTLTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ACCChequeDTLTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ACCChequeDTLTRNMsg(int RetVal, string RetStr)
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
