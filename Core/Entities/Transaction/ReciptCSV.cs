using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    
    class ReciptCSV
    {
        #region "Variables Declaration"
        private decimal _RECHDR_ReceiptNo;
        private string _RECHDR_Date;
        private int _RECHDR_CorporateID;
        private decimal _RECHDR_ApplicationID;
        private int _RECHDR_ReceiptType;
        private Int32 _RECHDR_PayMode;
        private string _RECHDR_ChequeNo;
        private string _RECHDR_ChequeDate;
        private decimal _RECHDR_ChequeAmount;
        private int _RECHDR_CreatedByUserID;
        private int _Bankid;
        private int _centercode;
        private Int64 _CHQDTL_MicrNo;
        private decimal _RECDTL_ReceiptNo;
        private int _RECDTL_HeadId;
        private decimal _RECDTL_Amount;


        #endregion

        public ReciptCSV() { }

        public ReciptCSV(decimal RECHDR_ReceiptNo, string RECHDR_Date, int RECHDR_CorporateID, decimal RECHDR_ApplicationID, int RECHDR_ReceiptType, Int32 RECHDR_PayMode, string RECHDR_ChequeNo, string RECHDR_ChequeDate, decimal RECHDR_ChequeAmount, int RECHDR_CreatedByUserID, int Bankid, int centercode, Int64 CHQDTL_MicrNo, decimal RECDTL_ReceiptNo, int RECDTL_HeadId, decimal RECDTL_Amount)
        {
            this._RECHDR_ReceiptNo = RECHDR_ReceiptNo;
            this._RECHDR_Date = RECHDR_Date;
            this._RECHDR_CorporateID = RECHDR_CorporateID;
            this._RECHDR_ApplicationID = RECHDR_ApplicationID;
            this._RECHDR_ReceiptType = RECHDR_ReceiptType;
            this._RECHDR_PayMode = RECHDR_PayMode;
            this._RECHDR_ChequeNo = RECHDR_ChequeNo;
            this._RECHDR_ChequeDate = RECHDR_ChequeDate;
            this._RECHDR_ChequeAmount = RECHDR_ChequeAmount;
            this._RECHDR_CreatedByUserID = RECHDR_CreatedByUserID;
            this._Bankid = Bankid;
            this._centercode = centercode;
            this._CHQDTL_MicrNo = CHQDTL_MicrNo;
            this._RECDTL_ReceiptNo = RECDTL_ReceiptNo;
            this._RECDTL_HeadId = RECDTL_HeadId;
            this._RECDTL_Amount = RECDTL_Amount;
        }
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
        public Int64 CHQDTL_MicrNo
        {
            get { return _CHQDTL_MicrNo; }
            set { _CHQDTL_MicrNo = value; }
        }

        public decimal RECHDR_ReceiptNo
        {
            get { return _RECHDR_ReceiptNo; }
            set { _RECHDR_ReceiptNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_Date
        {
            get { return _RECHDR_Date; }
            set { _RECHDR_Date = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_CorporateID
        {
            get { return _RECHDR_CorporateID; }
            set { _RECHDR_CorporateID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECHDR_ApplicationID
        {
            get { return _RECHDR_ApplicationID; }
            set { _RECHDR_ApplicationID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_ReceiptType
        {
            get { return _RECHDR_ReceiptType; }
            set { _RECHDR_ReceiptType = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public Int32 RECHDR_PayMode
        {
            get { return _RECHDR_PayMode; }
            set { _RECHDR_PayMode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_ChequeNo
        {
            get { return _RECHDR_ChequeNo; }
            set { _RECHDR_ChequeNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string RECHDR_ChequeDate
        {
            get { return _RECHDR_ChequeDate; }
            set { _RECHDR_ChequeDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECHDR_ChequeAmount
        {
            get { return _RECHDR_ChequeAmount; }
            set { _RECHDR_ChequeAmount = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECHDR_CreatedByUserID
        {
            get { return _RECHDR_CreatedByUserID; }
            set { _RECHDR_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECDTL_ReceiptNo
        {
            get { return _RECDTL_ReceiptNo; }
            set { _RECDTL_ReceiptNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int RECDTL_HeadId
        {
            get { return _RECDTL_HeadId; }
            set { _RECDTL_HeadId = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public decimal RECDTL_Amount
        {
            get { return _RECDTL_Amount; }
            set { _RECDTL_Amount = value; }
        }
    }

    public class ReciptCSVMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public ReciptCSVMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public ReciptCSVMsg(int RetVal, string RetStr)
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

