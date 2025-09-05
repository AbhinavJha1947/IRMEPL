using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    public class SearchChqueLotWise
    {
        #region "Variable Declaration"

        private string _ApplicationNo;
        private string _CustomerId;
        private string _Area;
        private string _ChequeNo;
        private string _ChequeDate;
        private decimal _ChequeAmount;
        private string _BankName;
        private string _MicrNo;
        private string _Status;
        private int _Count;

        #endregion

        public SearchChqueLotWise()
        {

        }

        public SearchChqueLotWise(string ApplicationNo, string CustomerId, string Area, string ChequeNo, string ChequeDate, decimal ChequeAmount, string BankName, string MicrNo, string Status, int Count)
        {
            this._ApplicationNo = ApplicationNo;
            this._CustomerId = CustomerId;
            this._Area = Area;
            this._ChequeNo = ChequeNo;
            this._ChequeDate = ChequeDate;
            this._ChequeAmount = ChequeAmount;
            this._BankName = BankName;
            this._MicrNo = MicrNo;
            this._Status = Status;
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
        public string Area
        {
            get { return _Area; }
            set { _Area = value; }
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
        public string MicrNo
        {
            get { return _MicrNo; }
            set { _MicrNo = value; }
        }
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

    }
}

