using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    public class OnlinePaymentDetails
    {
        #region "Variables Declaration"
        private int _OnlinePay_ID;

        public int OnlinePay_ID
        {
            get { return _OnlinePay_ID; }
            set { _OnlinePay_ID = value; }
        }
        private string _OnlinePay_ResponseRecieptNo;

        public string OnlinePay_ResponseRecieptNo
        {
            get { return _OnlinePay_ResponseRecieptNo; }
            set { _OnlinePay_ResponseRecieptNo = value; }
        }
        private string _OnlinePay_TransRefNo;

        public string OnlinePay_TransRefNo
        {
            get { return _OnlinePay_TransRefNo; }
            set { _OnlinePay_TransRefNo = value; }
        }
        private string _OnlinePay_BankRefNo;

        public string OnlinePay_BankRefNo
        {
            get { return _OnlinePay_BankRefNo; }
            set { _OnlinePay_BankRefNo = value; }
        }
        private decimal _OnlinePay_TransactionAmt;

        public decimal OnlinePay_TransactionAmt
        {
            get { return _OnlinePay_TransactionAmt; }
            set { _OnlinePay_TransactionAmt = value; }
        }
        private string _OnlinePay_BankID;

        public string OnlinePay_BankID
        {
            get { return _OnlinePay_BankID; }
            set { _OnlinePay_BankID = value; }
        }
        private string _OnlinePay_BankMarchantID;

        public string OnlinePay_BankMarchantID
        {
            get { return _OnlinePay_BankMarchantID; }
            set { _OnlinePay_BankMarchantID = value; }
        }
        private string _OnlinePay_TrnxType;

        public string OnlinePay_TrnxType
        {
            get { return _OnlinePay_TrnxType; }
            set { _OnlinePay_TrnxType = value; }
        }
        private string _OnlinePay_CurName;

        public string OnlinePay_CurName
        {
            get { return _OnlinePay_CurName; }
            set { _OnlinePay_CurName = value; }
        }
        private string _OnlinePay_ItemCode;

        public string OnlinePay_ItemCode
        {
            get { return _OnlinePay_ItemCode; }
            set { _OnlinePay_ItemCode = value; }
        }
        private string _OnlinePay_SecurityType;

        public string OnlinePay_SecurityType
        {
            get { return _OnlinePay_SecurityType; }
            set { _OnlinePay_SecurityType = value; }
        }
        private string _OnlinePay_SecurityID;

        public string OnlinePay_SecurityID
        {
            get { return _OnlinePay_SecurityID; }
            set { _OnlinePay_SecurityID = value; }
        }
        private string _OnlinePay_Password;

        public string OnlinePay_Password
        {
            get { return _OnlinePay_Password; }
            set { _OnlinePay_Password = value; }
        }
        private string _OnlinePay_TransactionDate;

        public string OnlinePay_TransactionDate
        {
            get { return _OnlinePay_TransactionDate; }
            set { _OnlinePay_TransactionDate = value; }
        }
        private string _OnlinePay_AuthStatus;

        public string OnlinePay_AuthStatus
        {
            get { return _OnlinePay_AuthStatus; }
            set { _OnlinePay_AuthStatus = value; }
        }
        private string _OnlinePay_SettlementType;

        public string OnlinePay_SettlementType
        {
            get { return _OnlinePay_SettlementType; }
            set { _OnlinePay_SettlementType = value; }
        }
        private string _OnlinePay_AddInfo1RecieptNo;

        public string OnlinePay_AddInfo1RecieptNo
        {
            get { return _OnlinePay_AddInfo1RecieptNo; }
            set { _OnlinePay_AddInfo1RecieptNo = value; }
        }
        private string _OnlinePay_AddInfo2CustName;

        public string OnlinePay_AddInfo2CustName
        {
            get { return _OnlinePay_AddInfo2CustName; }
            set { _OnlinePay_AddInfo2CustName = value; }
        }
        private string _OnlinePay_AddInfo3AppNo;

        public string OnlinePay_AddInfo3AppNo
        {
            get { return _OnlinePay_AddInfo3AppNo; }
            set { _OnlinePay_AddInfo3AppNo = value; }
        }
        private string _OnlinePay_AddInfo4CenterName;

        public string OnlinePay_AddInfo4CenterName
        {
            get { return _OnlinePay_AddInfo4CenterName; }
            set { _OnlinePay_AddInfo4CenterName = value; }
        }
        private string _OnlinePay_AddInfo5RecType;

        public string OnlinePay_AddInfo5RecType
        {
            get { return _OnlinePay_AddInfo5RecType; }
            set { _OnlinePay_AddInfo5RecType = value; }
        }
        private string _OnlinePay_AddInfo6RecNo;

        public string OnlinePay_AddInfo6RecNo
        {
            get { return _OnlinePay_AddInfo6RecNo; }
            set { _OnlinePay_AddInfo6RecNo = value; }
        }
        private string _OnlinePay_AddInfo7InvNo;

        public string OnlinePay_AddInfo7InvNo
        {
            get { return _OnlinePay_AddInfo7InvNo; }
            set { _OnlinePay_AddInfo7InvNo = value; }
        }
        private string _OnlinePay_ErrorStatus;

        public string OnlinePay_ErrorStatus
        {
            get { return _OnlinePay_ErrorStatus; }
            set { _OnlinePay_ErrorStatus = value; }
        }
        private string _OnlinePay_ErrorDescription;

        public string OnlinePay_ErrorDescription
        {
            get { return _OnlinePay_ErrorDescription; }
            set { _OnlinePay_ErrorDescription = value; }
        }
        private string _OnlinePay_Response;

        public string OnlinePay_Response
        {
            get { return _OnlinePay_Response; }
            set { _OnlinePay_Response = value; }
        }
       
        private string _OnlinePay_Request;

        public string OnlinePay_Request
        {
            get { return _OnlinePay_Request; }
            set { _OnlinePay_Request = value; }
        }
        private string _OnlinePay_FromWhichPage;

        public string OnlinePay_FromWhichPage
        {
            get { return _OnlinePay_FromWhichPage; }
            set { _OnlinePay_FromWhichPage = value; }
        }

        private string _OnlinePay_AuthStatusText;

        public string OnlinePay_AuthStatusText
        {
            get { return _OnlinePay_AuthStatusText; }
            set { _OnlinePay_AuthStatusText = value; }
        }
        #endregion
        public OnlinePaymentDetails() { }

        public OnlinePaymentDetails(int OnlinePay_ID, string OnlinePay_ResponseRecieptNo, string OnlinePay_TransRefNo, string OnlinePay_BankRefNo,
            decimal OnlinePay_TransactionAmt, string OnlinePay_BankID, string OnlinePay_BankMarchantID, string OnlinePay_TrnxType, string OnlinePay_CurName,
            string OnlinePay_ItemCode, string OnlinePay_SecurityType, string OnlinePay_SecurityID, string OnlinePay_Password, string OnlinePay_TransactionDate,
            string OnlinePay_AuthStatus, string OnlinePay_SettlementType, string OnlinePay_AddInfo1RecieptNo, string OnlinePay_AddInfo2CustName,
            string OnlinePay_AddInfo3AppNo, string OnlinePay_AddInfo4CenterName, string OnlinePay_AddInfo5RecType, string OnlinePay_AddInfo6RecNo,
            string OnlinePay_AddInfo7InvNo, string OnlinePay_ErrorStatus, string OnlinePay_ErrorDescription, string OnlinePay_Response, string OnlinePay_Request, string OnlinePay_FromWhichPage, string OnlinePay_AuthStatusText)
	{
        this._OnlinePay_ID = OnlinePay_ID;
        this._OnlinePay_ResponseRecieptNo = OnlinePay_ResponseRecieptNo;
        this._OnlinePay_TransRefNo = OnlinePay_TransRefNo;
        this._OnlinePay_BankRefNo = OnlinePay_BankRefNo;
        this._OnlinePay_TransactionAmt = OnlinePay_TransactionAmt;
        this._OnlinePay_BankID = OnlinePay_BankID;
        this._OnlinePay_BankMarchantID = OnlinePay_BankMarchantID;
        this._OnlinePay_TrnxType = OnlinePay_TrnxType;
        this._OnlinePay_CurName = OnlinePay_CurName;
        this._OnlinePay_ItemCode = OnlinePay_ItemCode;
        this._OnlinePay_SecurityType = OnlinePay_SecurityType;
        this._OnlinePay_SecurityID = OnlinePay_SecurityID;
        this._OnlinePay_Password = OnlinePay_Password;
        this._OnlinePay_TransactionDate = OnlinePay_TransactionDate;
        this._OnlinePay_AuthStatus = OnlinePay_AuthStatus;
        this._OnlinePay_SettlementType = OnlinePay_SettlementType;
        this._OnlinePay_AddInfo1RecieptNo = OnlinePay_AddInfo1RecieptNo;
        this._OnlinePay_AddInfo2CustName = OnlinePay_AddInfo2CustName;
        this._OnlinePay_AddInfo3AppNo = OnlinePay_AddInfo3AppNo;
        this._OnlinePay_AddInfo4CenterName = OnlinePay_AddInfo4CenterName;
        this._OnlinePay_AddInfo5RecType = OnlinePay_AddInfo5RecType;
        this._OnlinePay_AddInfo6RecNo = OnlinePay_AddInfo6RecNo;
        this._OnlinePay_AddInfo7InvNo = OnlinePay_AddInfo7InvNo;
        this._OnlinePay_ErrorStatus = OnlinePay_ErrorStatus;
        this._OnlinePay_ErrorDescription = OnlinePay_ErrorDescription;
        this._OnlinePay_Response = OnlinePay_Response;
        this._OnlinePay_Request = OnlinePay_Request;
        this._OnlinePay_FromWhichPage = OnlinePay_FromWhichPage;
        this._OnlinePay_AuthStatusText = OnlinePay_AuthStatusText;
	}
    }

    public class OnlinePaymentDetailsMsg
    {
        // Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public OnlinePaymentDetailsMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public OnlinePaymentDetailsMsg(int RetVal, string RetStr)
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

    
    public class OnlinePaymentDetailsList
    {
        #region "Variables Declaration"
        private string _OnlinePay_ResponseRecieptNo;

        public string OnlinePay_ResponseRecieptNo
        {
            get { return _OnlinePay_ResponseRecieptNo; }
            set { _OnlinePay_ResponseRecieptNo = value; }
        }
        private string _OnlinePay_TransRefNo;

        public string OnlinePay_TransRefNo
        {
            get { return _OnlinePay_TransRefNo; }
            set { _OnlinePay_TransRefNo = value; }
        }
        private string _OnlinePay_BankRefNo;

        public string OnlinePay_BankRefNo
        {
            get { return _OnlinePay_BankRefNo; }
            set { _OnlinePay_BankRefNo = value; }
        }
        private string _OnlinePay_TransactionAmt;

        public string OnlinePay_TransactionAmt
        {
            get { return _OnlinePay_TransactionAmt; }
            set { _OnlinePay_TransactionAmt = value; }
        }
        private string _OnlinePay_BankID;

        public string OnlinePay_BankID
        {
            get { return _OnlinePay_BankID; }
            set { _OnlinePay_BankID = value; }
        }
        private string _OnlinePay_BankMarchantID;

        public string OnlinePay_BankMarchantID
        {
            get { return _OnlinePay_BankMarchantID; }
            set { _OnlinePay_BankMarchantID = value; }
        }
        private string _OnlinePay_AddInfo1RecieptNo;

        public string OnlinePay_AddInfo1RecieptNo
        {
            get { return _OnlinePay_AddInfo1RecieptNo; }
            set { _OnlinePay_AddInfo1RecieptNo = value; }
        }
        private string _OnlinePay_AddInfo2CustName;

        public string OnlinePay_AddInfo2CustName
        {
            get { return _OnlinePay_AddInfo2CustName; }
            set { _OnlinePay_AddInfo2CustName = value; }
        }
        private string _OnlinePay_AddInfo3AppNo;

        public string OnlinePay_AddInfo3AppNo
        {
            get { return _OnlinePay_AddInfo3AppNo; }
            set { _OnlinePay_AddInfo3AppNo = value; }
        }
        private string _OnlinePay_AddInfo4CenterName;

        public string OnlinePay_AddInfo4CenterName
        {
            get { return _OnlinePay_AddInfo4CenterName; }
            set { _OnlinePay_AddInfo4CenterName = value; }
        }

        private string _OnlinePay_AddInfo5RecType;

        public string OnlinePay_AddInfo5RecType
        {
            get { return _OnlinePay_AddInfo5RecType; }
            set { _OnlinePay_AddInfo5RecType = value; }
        }
        private string _OnlinePay_AddInfo6RecNo;

        public string OnlinePay_AddInfo6RecNo
        {
            get { return _OnlinePay_AddInfo6RecNo; }
            set { _OnlinePay_AddInfo6RecNo = value; }
        }
        private string _OnlinePay_AddInfo7InvNo;

        public string OnlinePay_AddInfo7InvNo
        {
            get { return _OnlinePay_AddInfo7InvNo; }
            set { _OnlinePay_AddInfo7InvNo = value; }
        }
        private string _OnlinePay_ErrorDescription;

        public string OnlinePay_ErrorDescription
        {
            get { return _OnlinePay_ErrorDescription; }
            set { _OnlinePay_ErrorDescription = value; }
        }
        private string _OnlinePay_AuthStatusText;

        public string OnlinePay_AuthStatusText
        {
            get { return _OnlinePay_AuthStatusText; }
            set { _OnlinePay_AuthStatusText = value; }
        }
        private string _OnlinePay_TransactionDate;

        public string OnlinePay_TransactionDate
        {
            get { return _OnlinePay_TransactionDate; }
            set { _OnlinePay_TransactionDate = value; }
        }

        private int _Count;

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        #endregion


        public OnlinePaymentDetailsList() { }

        public OnlinePaymentDetailsList(string OnlinePay_ResponseRecieptNo, string OnlinePay_TransRefNo, string OnlinePay_BankRefNo, string OnlinePay_TransactionAmt,
            string OnlinePay_BankID, string OnlinePay_BankMarchantID, string OnlinePay_AddInfo1RecieptNo, string OnlinePay_AddInfo2CustName, string OnlinePay_AddInfo3AppNo,
            string OnlinePay_AddInfo4CenterName, string OnlinePay_AddInfo5RecType, string OnlinePay_AddInfo6RecNo, string OnlinePay_AddInfo7InvNo, 
            string OnlinePay_ErrorDescription, string OnlinePay_AuthStatusText, string OnlinePay_TransactionDate, int Count)
        {
            this._OnlinePay_ResponseRecieptNo = OnlinePay_ResponseRecieptNo;
            this._OnlinePay_TransRefNo = OnlinePay_TransRefNo;
            this._OnlinePay_BankRefNo = OnlinePay_BankRefNo;
            this._OnlinePay_TransactionAmt = OnlinePay_TransactionAmt;
            this._OnlinePay_BankID = OnlinePay_BankID;
            this._OnlinePay_BankMarchantID = OnlinePay_BankMarchantID;
            this._OnlinePay_AddInfo1RecieptNo = OnlinePay_AddInfo1RecieptNo;
            this._OnlinePay_AddInfo2CustName = OnlinePay_AddInfo2CustName;
            this._OnlinePay_AddInfo3AppNo = OnlinePay_AddInfo3AppNo;
            this._OnlinePay_AddInfo4CenterName = OnlinePay_AddInfo4CenterName;
            this._OnlinePay_AddInfo5RecType = OnlinePay_AddInfo5RecType;
            this._OnlinePay_AddInfo6RecNo = OnlinePay_AddInfo6RecNo;
            this._OnlinePay_AddInfo7InvNo = OnlinePay_AddInfo7InvNo;
            this._OnlinePay_ErrorDescription = OnlinePay_ErrorDescription;
            this._OnlinePay_AuthStatusText = OnlinePay_AuthStatusText;
            this._OnlinePay_TransactionDate = OnlinePay_TransactionDate;
           
            this._Count = Count;
        }
    }
}

