using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    
    public class ACCCreditNoteTRN
    {
        #region "Variables Declaration"
        private decimal _CRNT_CreditNoteNo;
        private string _CRNT_CreditNoteRefNo;
        private string _CRNT_Date;
        private int _CRNT_CorporateID;
        private decimal _CRNT_ApplicationID;
        private int _CRNT_CreditNoteType;
        private Int32 _CRNT_PayMode;
        private string _CRNT_ChequeNo;
        private string _CRNT_ChequeDate;
        private decimal _CRNT_ChequeAmount;
        private int _CRNT_CreatedByUserID;
        private string _CRNT_CreatedDateTime;
        private int _CRNT_UpdatedByUserID;
        private string _CRNT_UpdatedDateTime;
        private int _CRNT_RowStatus;
        private long _CRNT_RowVersion;
        private int _Bankid;
        private int _centercode;
        private Int64 _CHQDTL_MicrNo;
        private int _CRNT_SMSFlag;
        private string _CRNT_Remark;
        private int _CRNT_PayStatus;
        #endregion


        public ACCCreditNoteTRN() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public ACCCreditNoteTRN(decimal CRNT_CreditNoteNo, string CRNT_CreditNoteRefNo, string CRNT_Date, int CRNT_CorporateID, decimal CRNT_ApplicationID, int CRNT_CreditNoteType, decimal CRNT_ChequeAmount, int CRNT_CreatedByUserID, string CRNT_CreatedDateTime, int CRNT_UpdatedByUserID, string CRNT_UpdatedDateTime, int CRNT_RowStatus, long CRNT_RowVersion, int centercode, int CRNT_SMSFlag, string CRNT_Remark)
        {
            this._CRNT_CreditNoteNo = CRNT_CreditNoteNo;
            this._CRNT_CreditNoteRefNo = CRNT_CreditNoteRefNo;
            this._CRNT_Date = CRNT_Date;
            this._CRNT_CorporateID = CRNT_CorporateID;
            this._CRNT_ApplicationID = CRNT_ApplicationID;
            this._CRNT_CreditNoteType = CRNT_CreditNoteType;

            
            this._CRNT_ChequeAmount = CRNT_ChequeAmount;
            this._CRNT_CreatedByUserID = CRNT_CreatedByUserID;
            this._CRNT_CreatedDateTime = CRNT_CreatedDateTime;
            this._CRNT_UpdatedByUserID = CRNT_UpdatedByUserID;
            this._CRNT_UpdatedDateTime = CRNT_UpdatedDateTime;
            this._CRNT_RowStatus = CRNT_RowStatus;
            this._CRNT_RowVersion = CRNT_RowVersion;
            
            this._centercode = centercode;
            
            this._CRNT_SMSFlag = CRNT_SMSFlag;
            this._CRNT_Remark = CRNT_Remark;
            
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Bankid
        {
            get { return _Bankid; }
            set { _Bankid = value; }
        }
        public int centercode
        {
            get { return _centercode; }
            set { _centercode = value; }
        }
        

        public decimal CRNT_CreditNoteNo
        {
            get { return _CRNT_CreditNoteNo; }
            set { _CRNT_CreditNoteNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CRNT_CreditNoteRefNo
        {
            get { return _CRNT_CreditNoteRefNo; }
            set { _CRNT_CreditNoteRefNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CRNT_Date
        {
            get { return _CRNT_Date; }
            set { _CRNT_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_CorporateID
        {
            get { return _CRNT_CorporateID; }
            set { _CRNT_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CRNT_ApplicationID
        {
            get { return _CRNT_ApplicationID; }
            set { _CRNT_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_CreditNoteType
        {
            get { return _CRNT_CreditNoteType; }
            set { _CRNT_CreditNoteType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
      

        /// <summary>
        //Write Column Description here. 
        /// </summary>
       

        /// <summary>
        //Write Column Description here. 
        /// </summary>
      

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal CRNT_ChequeAmount
        {
            get { return _CRNT_ChequeAmount; }
            set { _CRNT_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_CreatedByUserID
        {
            get { return _CRNT_CreatedByUserID; }
            set { _CRNT_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CRNT_CreatedDateTime
        {
            get { return _CRNT_CreatedDateTime; }
            set { _CRNT_CreatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_UpdatedByUserID
        {
            get { return _CRNT_UpdatedByUserID; }
            set { _CRNT_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CRNT_UpdatedDateTime
        {
            get { return _CRNT_UpdatedDateTime; }
            set { _CRNT_UpdatedDateTime = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_RowStatus
        {
            get { return _CRNT_RowStatus; }
            set { _CRNT_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long CRNT_RowVersion
        {
            get { return _CRNT_RowVersion; }
            set { _CRNT_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int CRNT_SMSFlag
        {
            get { return _CRNT_SMSFlag; }
            set { _CRNT_SMSFlag = value; }
        }
        public string CRNT_Remark
        {
            get { return _CRNT_Remark; }
            set { _CRNT_Remark = value; }
        }

    }

    public class ACCCreditNoteTRNList
    {
        #region "Variables Declaration"
        private decimal _CRNT_CreditNoteNo;
        private string _CRNT_CreditNoteRefNo;
        private string _CRNT_Date;
        private string _CRNT_CreditNoteType;
        private decimal _CRNT_ChequeAmount;
        private string _Appno;
        private string _APPMST_CustomerID;
        private string _Name;
        private string _Area;
        private decimal _CRNT_Chequebalance;
        private string _CRNT_RowStatus;
        private int _CRNT_CreditNoteId;
        private int _Count;
        #endregion
        public ACCCreditNoteTRNList() { }

        public ACCCreditNoteTRNList(decimal CRNT_CreditNoteNo, string CRNT_CreditNoteRefNo, string CRNT_Date, string CRNT_CreditNoteType, decimal CRNT_ChequeAmount, decimal CRNT_Chequebalance, string appno, string APPMST_CustomerID, string name, string area, string CRNT_RowStatus, int Count)
        {
            this._CRNT_CreditNoteNo = CRNT_CreditNoteNo;
            this._CRNT_CreditNoteRefNo = CRNT_CreditNoteRefNo;
            this._CRNT_Date = CRNT_Date;
            this._CRNT_CreditNoteType = CRNT_CreditNoteType;
            this._CRNT_ChequeAmount = CRNT_ChequeAmount;
            this._CRNT_Chequebalance = CRNT_Chequebalance;
            this._Appno = appno;
            this._APPMST_CustomerID = APPMST_CustomerID;
            this._Name = name;
            this._Area = area;
            this._CRNT_Chequebalance = CRNT_Chequebalance;
            this._CRNT_RowStatus = CRNT_RowStatus;
            this._Count = Count;
        }

        public decimal CRNT_CreditNoteNo
        {
            get { return _CRNT_CreditNoteNo; }
            set { _CRNT_CreditNoteNo = value; }
        }
        public string CRNT_CreditNoteRefNo
        {
            get { return _CRNT_CreditNoteRefNo; }
            set { _CRNT_CreditNoteRefNo = value; }
        }
        public string CRNT_Date
        {
            get { return _CRNT_Date; }
            set { _CRNT_Date = value; }
        }
        public string CRNT_CreditNoteType
        {
            get { return _CRNT_CreditNoteType; }
            set { _CRNT_CreditNoteType = value; }
        }
        public decimal CRNT_ChequeAmount
        {
            get { return _CRNT_ChequeAmount; }
            set { _CRNT_ChequeAmount = value; }
        }

        public decimal CRNT_Chequebalance
        {
            get { return _CRNT_Chequebalance; }
            set { _CRNT_Chequebalance = value; }
        }
        public string Appno
        {
            get { return _Appno; }
            set { _Appno = value; }
        }
        public string APPMST_CustomerID
        {
            get { return _APPMST_CustomerID; }
            set { _APPMST_CustomerID = value; }
        }

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
        }

        

        public string CRNT_RowStatus
        {
            get { return _CRNT_RowStatus; }
            set { _CRNT_RowStatus = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
       
      
    }


    public class ACCCreditNoteTRNMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ACCCreditNoteTRNMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ACCCreditNoteTRNMsg(int RetVal, string RetStr)
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

