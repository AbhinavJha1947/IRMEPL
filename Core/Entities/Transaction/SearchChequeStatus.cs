using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    public class SearchChequeStatus
    {
        #region "Variable Declaration"

        private string _ApplicationNo;
        private string _CustomerId;
        private string _CustomerName;
        private string _ReceiptNo;
        private string _ReceiptDate;
        private string _ChequeNo;
        private string _ChequeDate;
        private decimal _ChequeAmount;
        private string _BankName;
        private string _RealizedDate;
        private string _DishonourDate;
        private string _LotNo;
        private string _DepositDate;
        private string _ControlType;
        private int _Count;

        #endregion

        public SearchChequeStatus()
        {

        }

        public SearchChequeStatus(string ApplicationNo, string CustomerId, string CustomerName, string ReceiptNo, string ReceiptDate, string ChequeNo, string ChequeDate, decimal ChequeAmount, string BankName, string RealizedDate, string DishonourDate, string LotNo, string DepositDate, string ControlType, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerId = CustomerId;
            this._CustomerName = CustomerName;
            this._ReceiptNo = ReceiptNo;
            this._ReceiptDate = ReceiptDate;
            this._ChequeNo = ChequeNo;
            this._ChequeDate = ChequeDate;
            this._ChequeAmount = ChequeAmount;
            this._BankName = BankName;
            this._RealizedDate = RealizedDate;
            this._DishonourDate = DishonourDate;
            this._LotNo = LotNo;
            this._DepositDate = DepositDate;
            this._ControlType = ControlType;
            this._Count = Count;
        }

        public string ApplicationNo
        {
            get { return _ApplicationNo; }
            set { _ApplicationNo = value; }
        }
        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        public string CustomerName
        {
            get { return _CustomerName; }
            set { _CustomerName = value; }
        }
        public string ReceiptNo
        {
            get { return _ReceiptNo; }
            set { _ReceiptNo = value; }
        }
        public string ReceiptDate
        {
            get { return _ReceiptDate; }
            set { _ReceiptDate = value; }
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
        public decimal ChequeAmount
        {
            get { return _ChequeAmount; }
            set { _ChequeAmount = value; }
        }
        public string BankName
        {
            get { return _BankName; }
            set { _BankName = value; }
        }
        public string RealizedDate
        {
            get { return _RealizedDate; }
            set { _RealizedDate = value; }
        }
        public string DishonourDate
        {
            get { return _DishonourDate; }
            set { _DishonourDate = value; }
        }
        public string LotNo
        {
            get { return _LotNo; }
            set { _LotNo = value; }
        }
        public string DepositDate
        {
            get { return _DepositDate; }
            set { _DepositDate = value; }
        }
        public string ControlType
        {
            get { return _ControlType; }
            set { _ControlType = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
    }
}

