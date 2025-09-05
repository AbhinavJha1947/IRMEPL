using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
   public class OnlineRequestResponseLog
    {
        #region "Variables Declaration"

        private int _RR_ID;
        public int RR_ID
        {
            get { return _RR_ID; }
            set { _RR_ID = value; }
        }


        private string _RR_CUSTID;
        public string RR_CUSTID
        {
            get { return _RR_CUSTID; }
            set { _RR_CUSTID = value; }
        }

        private string _RR_ReceiptNo;
        public string RR_ReceiptNo
        {
            get { return _RR_ReceiptNo; }
            set { _RR_ReceiptNo = value; }
        }

        private decimal _RR_TransactionAmt;
        public decimal RR_TransactionAmt
        {
            get { return _RR_TransactionAmt; }
            set { _RR_TransactionAmt = value; }
        }

        private DateTime _RR_REQ_Date;
        public DateTime RR_REQ_Date
        {
            get { return _RR_REQ_Date; }
            set { _RR_REQ_Date = value; }
        }


        private DateTime _RR_RES_Date;
        public DateTime RR_RES_Date
        {
            get { return _RR_RES_Date; }
            set { _RR_RES_Date = value; }
        }

        private string _RR_REQ_string;
        public string RR_REQ_string
        {
            get { return _RR_REQ_string; }
            set { _RR_REQ_string = value; }
        }

        private string _RR_RES_String;
        public string RR_RES_String
        {
            get { return _RR_RES_String; }
            set { _RR_RES_String = value; }
        }

        #endregion

        public OnlineRequestResponseLog() { }

        public OnlineRequestResponseLog(int RR_ID, string RR_CUSTID, string RR_ReceiptNo, decimal RR_TransactionAmt, DateTime RR_REQ_Date, DateTime RR_RES_Date, string RR_REQ_string, string RR_RES_String)
        {
            this._RR_ID = RR_ID;
            this._RR_CUSTID = RR_CUSTID;
            this._RR_ReceiptNo = RR_ReceiptNo;
            this._RR_TransactionAmt = RR_TransactionAmt;
            this._RR_REQ_Date = RR_REQ_Date;
            this._RR_RES_Date = RR_RES_Date;
            this._RR_REQ_string = RR_REQ_string;
            this._RR_RES_String = RR_RES_String;
        }
    }

    public class OnlineRequestResponseLogMsg
    {
       
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public OnlineRequestResponseLogMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public OnlineRequestResponseLogMsg(int RetVal, string RetStr)
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

