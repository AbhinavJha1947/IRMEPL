using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BFilesCore
{
    public class CORGCVMASTER
    {
        #region "Variables Declaration"
        private int _GCV_ID;
        private string _GCV_NAME;
        private string _GCV_STARTDATE;
        private string _GCV_ENDDATE;
        private decimal _GCV_PRICE;
        private int _GCV_CENCODE;
        private int _GCV_CreatedByUserID;
        private string _GCV_CreatedDateTime;
        private int _GCV_UpdatedByUserID;
        private string _GCV_UpdatedDateTime;
        private string _GCV_RowStatus;
        private long _GCV_RowVersion;
        #endregion

        public CORGCVMASTER() { }

        public CORGCVMASTER(int GCV_ID, string GCV_NAME, string GCV_STARTDATE, string GCV_ENDDATE, decimal GCV_PRICE, int GCV_CENCODE, int GCV_CreatedByUserID, string GCV_CreatedDateTime, int GCV_UpdatedByUserID, string GCV_UpdatedDateTime, string GCV_RowStatus, long GCV_RowVersion)
        {
            this._GCV_ID = GCV_ID;
            this._GCV_NAME = GCV_NAME;
            this._GCV_STARTDATE = GCV_STARTDATE;
            this._GCV_ENDDATE = GCV_ENDDATE;
            this._GCV_PRICE = GCV_PRICE;
            this._GCV_CENCODE = GCV_CENCODE;
            this._GCV_CreatedByUserID = GCV_CreatedByUserID;
            this._GCV_CreatedDateTime = GCV_CreatedDateTime;
            this._GCV_UpdatedByUserID = GCV_UpdatedByUserID;
            this._GCV_UpdatedDateTime = GCV_UpdatedDateTime;
            this._GCV_RowStatus = GCV_RowStatus;
            this._GCV_RowVersion = GCV_RowVersion;
        }

        public int GCV_ID
        {
            get { return _GCV_ID; }
            set { _GCV_ID = value; }
        }

        public string GCV_NAME
        {
            get { return _GCV_NAME; }
            set { _GCV_NAME = value; }
        }

        public string GCV_STARTDATE
        {
            get { return _GCV_STARTDATE; }
            set { _GCV_STARTDATE = value; }
        }

        public string GCV_ENDDATE
        {
            get { return _GCV_ENDDATE; }
            set { _GCV_ENDDATE = value; }
        }

        public decimal GCV_PRICE
        {
            get { return _GCV_PRICE; }
            set { _GCV_PRICE = value; }
        }

        public int GCV_CENCODE
        {
            get { return _GCV_CENCODE; }
            set { _GCV_CENCODE = value; }
        }

        public int GCV_CreatedByUserID
        {
            get { return _GCV_CreatedByUserID; }
            set { _GCV_CreatedByUserID = value; }
        }

        public string GCV_CreatedDateTime
        {
            get { return _GCV_CreatedDateTime; }
            set { _GCV_CreatedDateTime = value; }
        }

        public int GCV_UpdatedByUserID
        {
            get { return _GCV_UpdatedByUserID; }
            set { _GCV_UpdatedByUserID = value; }
        }

        public string GCV_UpdatedDateTime
        {
            get { return _GCV_UpdatedDateTime; }
            set { _GCV_UpdatedDateTime = value; }
        }

        public string GCV_RowStatus
        {
            get { return _GCV_RowStatus; }
            set { _GCV_RowStatus = value; }
        }

        public long GCV_RowVersion
        {
            get { return _GCV_RowVersion; }
            set { _GCV_RowVersion = value; }
        }
    }

    public class CORGCVMASTERLIST
    {
        #region "Variables Declaration"

        private int _GCV_ID;

        public int GCV_ID
        {
            get { return _GCV_ID; }
            set { _GCV_ID = value; }
        }

        private string _GCV_NAME;

        public string GCV_NAME
        {
            get { return _GCV_NAME; }
            set { GCV_NAME = value; }
        }

        private string _GCV_STARTDATE;

        public string GCV_STARTDATE
        {
            get { return _GCV_STARTDATE; }
            set { _GCV_STARTDATE = value; }
        }

        private string _GCV_ENDDATE;

        public string GCV_ENDDATE
        {
            get { return _GCV_ENDDATE; }
            set { _GCV_ENDDATE = value; }
        }
        private decimal _GCV_PRICE;

        public decimal GCV_PRICE
        {
            get { return _GCV_PRICE; }
            set { _GCV_PRICE = value; }
        }

        private int _GCV_CENCODE;

        public int GCV_CENCODE
        {
            get { return _GCV_CENCODE; }
            set { _GCV_CENCODE = value; }
        }
        private string _GCV_RowStatus;

        public string GCV_RowStatus
        {
            get { return _GCV_RowStatus; }
            set { _GCV_RowStatus = value; }
        }

        private int _GCV_Count;

        public int GCV_Count
        {
            get { return _GCV_Count; }
            set { _GCV_Count = value; }
        }
        #endregion

        public CORGCVMASTERLIST(int GCV_ID, string GCV_NAME, string GCV_STARTDATE, string GCV_ENDDATE, decimal GCV_PRICE, int GCV_CENCODE, string GCV_RowStatus, int GCV_Count)
        {
            this._GCV_ID = GCV_ID;
            this._GCV_NAME = GCV_NAME;
            this._GCV_STARTDATE = GCV_STARTDATE;
            this._GCV_ENDDATE = GCV_ENDDATE;
            this._GCV_PRICE = GCV_PRICE;
            this._GCV_CENCODE = GCV_CENCODE;
            this._GCV_RowStatus = GCV_RowStatus;
            this._GCV_Count = GCV_Count;
        }
    }

    public class CORGCVMASTERMSG
    {
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        public CORGCVMASTERMSG(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}

