using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Core
{
    public class CORLOCKMASTER
    {
        #region "Variables Declaration"
        private int _LCK_ID;
        private string _LCK_DATE;
        private int _LCK_CreatedByUserID;
        private string _LCK_CreatedDateTime;
        private int _LCK_UpdatedByUserID;
        private string _LCK_UpdatedDateTime;
        private long _LCK_RowVersion;
        #endregion

        public CORLOCKMASTER() { }

        public CORLOCKMASTER(int LCK_ID, string LCK_DATE, int LCK_CreatedByUserID, string LCK_CreatedDateTime, int LCK_UpdatedByUserID, string LCK_UpdatedDateTime, long LCK_RowVersion)
        {
            this._LCK_ID = LCK_ID;
            this._LCK_DATE = LCK_DATE;
            this._LCK_CreatedByUserID = LCK_CreatedByUserID;
            this._LCK_CreatedDateTime = LCK_CreatedDateTime;
            this._LCK_UpdatedByUserID = LCK_UpdatedByUserID;
            this._LCK_UpdatedDateTime = LCK_UpdatedDateTime;
            this._LCK_RowVersion = LCK_RowVersion;
        }

        public int LCK_ID
        {
            get { return _LCK_ID; }
            set { _LCK_ID = value; }
        }

        public string LCK_DATE
        {
            get { return _LCK_DATE; }
            set { _LCK_DATE = value; }
        }

        public int LCK_CreatedByUserID
        {
            get { return _LCK_CreatedByUserID; }
            set { _LCK_CreatedByUserID = value; }
        }

        public string LCK_CreatedDateTime
        {
            get { return _LCK_CreatedDateTime; }
            set { _LCK_CreatedDateTime = value; }
        }

        public int LCK_UpdatedByUserID
        {
            get { return _LCK_UpdatedByUserID; }
            set { _LCK_UpdatedByUserID = value; }
        }

        public string LCK_UpdatedDateTime
        {
            get { return _LCK_UpdatedDateTime; }
            set { _LCK_UpdatedDateTime = value; }
        }

        public long LCK_RowVersion
        {
            get { return _LCK_RowVersion; }
            set { _LCK_RowVersion = value; }
        }
    }

    public class CORLOCKMASTERLIST
    {
        #region "Variables Declaration"

        private int _LCK_ID;

        public int LCK_ID
        {
            get { return _LCK_ID; }
            set { _LCK_ID = value; }
        }

        private string _USER_Name;
        public string USER_Name
        {
            get { return _USER_Name; }
            set { USER_Name = value; }
        }
        private int _LCK_CreatedByUserID;

        public int LCK_CreatedByUserID
        {
            get { return _LCK_CreatedByUserID; }
            set { _LCK_CreatedByUserID = value; }
        }
        private DateTime _LCK_DATE;

        public DateTime LCK_DATE
        {
            get { return _LCK_DATE; }
            set { _LCK_DATE = value; }
        }

        private DateTime _LCK_CreatedDateTime;

        public DateTime LCK_CreatedDateTime
        {
            get { return _LCK_CreatedDateTime; }
            set { LCK_CreatedDateTime = value; }
        }

        //public string LCK_CreatedDateTime
        //{
        //    get { return _LCK_CreatedDateTime; }
        //    set { _LCK_CreatedDateTime = value; }
        //}

        private int _LCK_UpdatedByUserID;

        public int LCK_UpdatedByUserID
        {
            get { return _LCK_UpdatedByUserID; }
            set { _LCK_UpdatedByUserID = value; }
        }

        private string _LCK_UpdatedDateTime;

        public string LCK_UpdatedDateTime
        {
            get { return _LCK_UpdatedDateTime; }
            set { _LCK_UpdatedDateTime = value; }
        }

        private long _LCK_RowVersion;

        public long LCK_RowVersion
        {
            get { return _LCK_RowVersion; }
            set { _LCK_RowVersion = value; }
        }

        private int _LCK_Count;

        public int LCK_Count
        {
            get { return _LCK_Count; }
            set { _LCK_Count = value; }
        }
        #endregion
        
        public CORLOCKMASTERLIST(string USER_Name,DateTime LCK_DATE,DateTime LCK_CreatedDateTime,int LCK_Count)
        {
           // this._LCK_ID = LCK_ID;
            this._USER_Name = USER_Name;
           // this._LCK_CreatedByUserID = LCK_CreatedByUserID;
            this._LCK_DATE = LCK_DATE;
            this._LCK_CreatedDateTime = LCK_CreatedDateTime;
            this._LCK_Count = LCK_Count;
        }
    }

    public class CORLOCKMASTERMSG
    {
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        public CORLOCKMASTERMSG(int RetVal, string RetStr)
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

