using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
   public class CSTCustomerList
    {
        #region "Variable Declaration"

        private string _CustomerId;
        private string _ApplicationId;
        private string _TypeOfCust;
        private string _Address1;
        private string _Address2;
        private string _Landmark;
        private string _AreaN;
        private string _Phone;
        private string _Mobile;
        private Int64 _MeterNo;
        private decimal _PreviousReading;
        private string _CurrentReading;
        private string _ReadingDate;
        private string _CollectionDate;

        private int _Count;

        #endregion

        public CSTCustomerList()
        {
        }

        public CSTCustomerList(string CustomerId, string ApplicationId, string TypeOfCust, string Address1, string Address2, string Landmark, string AreaN, string Phone, string Mobile, decimal PreviousReading, string CurrentReading, string ReadingDate, string CollectionDate,Int64 MeterNo, int Count)
        {
            this._CustomerId = CustomerId;
            this._ApplicationId = ApplicationId;
            this._TypeOfCust = TypeOfCust;
            this._Address1 = Address1;
            this._Address2 = Address2;
            this._Landmark = Landmark;
            this._AreaN = AreaN;
            this._Phone = Phone;
            this._Mobile = Mobile;
            this._PreviousReading = PreviousReading;
            this._CurrentReading = CurrentReading;
            this._ReadingDate = ReadingDate;
            this._CollectionDate = CollectionDate;
            this._Count = Count;
            this._MeterNo = MeterNo;
        }

        public string CustomerId
        {
            get { return _CustomerId; }
            set { _CustomerId = value; }
        }
        public string ApplicationId
        {
            get { return _ApplicationId; }
            set { _ApplicationId = value; }
        }
        public string TypeOfCust
        {
            get { return _TypeOfCust; }
            set { _TypeOfCust = value; }
        }
        public string Address1
        {
            get { return _Address1; }
            set { _Address1 = value; }
        }
        public string Address2
        {
            get { return _Address2; }
            set { _Address2 = value; }
        }
        public string Landmark
        {
            get { return _Landmark; }
            set { _Landmark = value; }
        }
        public string AreaN
        {
            get { return _AreaN; }
            set { _AreaN = value; }
        }
        public string Phone
        {
            get { return _Phone; }
            set { _Phone = value; }
        }
        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }
        public decimal PreviousReading
        {
            get { return _PreviousReading; }
            set { _PreviousReading = value; }
        }
        public string CurrentReading
        {
            get { return _CurrentReading; }
            set { _CurrentReading = value; }
        }
        public string ReadingDate
        {
            get { return _ReadingDate; }
            set { _ReadingDate = value; }
        }
        public string CollectionDate
        {
            get { return _CollectionDate; }
            set { _CollectionDate = value; }
        }
        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }
        public Int64 MeterNo
        {
            get { return _MeterNo; }
            set { _MeterNo = value; }
        }
    }

   public class OMCUstomerList
   {
       #region "Variable Declaration"

       private int _ApplicationId;
       private string _ApplicationNo;
       private string _CustomerId;
       private string _CustomerName;
       private string _Address1;
       private string _Area;
       private string _Plan1;
       private string _NoticeIssued;
       private int _MeterNo;
       private int _Count;

       #endregion

       public OMCUstomerList()
       {

       }

       public OMCUstomerList(int ApplicationId, string ApplicationNo, string CustomerId, string CustomerName, string Address1, string Area, string Plan1, string NoticeIssued, int MeterNo, int Count)
       {
           this._ApplicationId = ApplicationId;
           this._ApplicationNo = ApplicationNo;
           this._CustomerId = CustomerId;
           this._CustomerName = CustomerName;
           this._Address1 = Address1;
           this._Area = Area;
           this._Plan1 = Plan1;
           this._NoticeIssued = NoticeIssued;
           this._Count = Count;
           this._MeterNo = MeterNo;
       }

       public int ApplicationId
       {
           get { return _ApplicationId; }
           set { _ApplicationId = value; }
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
       public string Address1
       {
           get { return _Address1; }
           set { _Address1 = value; }
       }
       public string Area
       {
           get { return _Area; }
           set { _Area = value; }
       }
       public string Plan1
       {
           get { return _Plan1; }
           set { _Plan1 = value; }
       }
       public string NoticeIssued
       {
           get { return _NoticeIssued; }
           set { _NoticeIssued = value; }
       }
       public int Count
       {
           get { return _Count; }
           set { _Count = value; }
       }
       public int MeterNo
       {
           get { return _MeterNo; }
           set { _MeterNo = value; }
       }
   }
}

