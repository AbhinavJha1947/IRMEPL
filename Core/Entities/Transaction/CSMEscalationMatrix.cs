using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Transaction
{
    
    public class CSMEscalationMatrix
    {
        #region "Variables Declaration"
        private int _EM_ID;
        private int _EM_ComplainCategory;
        private int _EM_ComplianType;
        private int _EM_Level;
        private int _EM_SLA;
        private int _EM_AssignUser;
        private int _EM_RowStatus;
        private int _EM_CreatedByID;
        private string _EM_CreatedDate;
        #endregion


        public CSMEscalationMatrix() { }

        public CSMEscalationMatrix(int EM_ID, int EM_ComplainCategory, int EM_ComplianType, int EM_Level, int EM_SLA, int EM_AssignUser, int EM_RowStatus, int EM_CreatedByID, string EM_CreatedDate)
        {
            this._EM_ID = EM_ID;
            this._EM_ComplainCategory = EM_ComplainCategory;
            this._EM_ComplianType = EM_ComplianType;
            this._EM_Level = EM_Level;
            this._EM_SLA = EM_SLA;
            this._EM_AssignUser = EM_AssignUser;
            this._EM_RowStatus = EM_RowStatus;
            this._EM_CreatedByID = EM_CreatedByID;
            this._EM_CreatedDate = EM_CreatedDate;

        }

        #region "property Declaration"

        public int EM_ID
        {
            get { return _EM_ID; }
            set { _EM_ID = value; }
        }

        public int EM_ComplainCategory
        {
            get { return _EM_ComplainCategory; }
            set { _EM_ComplainCategory = value; }
        }

        public int EM_ComplianType
        {
            get { return _EM_ComplianType; }
            set { _EM_ComplianType = value; }
        }
        public int EM_Level
        {
            get { return _EM_Level; }
            set { _EM_Level = value; }
        }

        public int EM_SLA
        {
            get { return _EM_SLA; }
            set { _EM_SLA = value; }
        }
        public int EM_AssignUser
        {
            get { return _EM_AssignUser; }
            set { _EM_AssignUser = value; }
        }

        public int EM_RowStatus
        {
            get { return _EM_RowStatus; }
            set { _EM_RowStatus = value; }
        }

        public int EM_CreatedByID
        {
            get { return _EM_CreatedByID; }
            set { _EM_CreatedByID = value; }
        }


        public string EM_CreatedDate
        {
            get { return _EM_CreatedDate; }
            set { _EM_CreatedDate = value; }
        }

        #endregion




    }

    public class CSMEscalationMatrixList
    {
        #region "Variables Declaration"
        private int _EM_ID;
        private string _EM_ComplainCategory;
        private string _EM_ComplianType;
        private string _EM_Level;
        private string _EM_SLA;
        private string _EM_AssignUser;
        private string _EM_RowStatus;
        private string _EM_CreatedDate;
        private int _Count;

        #endregion

        public CSMEscalationMatrixList() { }

        public CSMEscalationMatrixList(int EM_ID, string EM_ComplainCategory, string EM_ComplianType, string EM_Level, string EM_SLA, string EM_AssignUser, string EM_RowStatus, string EM_CreatedDate,int count)
        {
            this._EM_ID = EM_ID;
            this._EM_ComplainCategory = EM_ComplainCategory;
            this._EM_ComplianType = EM_ComplianType;
            this._EM_Level = EM_Level;
            this._EM_SLA = EM_SLA;
            this._EM_AssignUser = EM_AssignUser;
            this._EM_RowStatus = EM_RowStatus;
            this._EM_CreatedDate = EM_CreatedDate;
            this._Count = count;
            

        }

        #region "property Declaration"

        public int EM_ID
        {
            get { return _EM_ID; }
            set { _EM_ID = value; }
        }

        public string EM_ComplainCategory
        {
            get { return _EM_ComplainCategory; }
            set { _EM_ComplainCategory = value; }
        }

        public string EM_ComplianType
        {
            get { return _EM_ComplianType; }
            set { _EM_ComplianType = value; }
        }
        public string EM_Level
        {
            get { return _EM_Level; }
            set { _EM_Level = value; }
        }

        public string EM_SLA
        {
            get { return _EM_SLA; }
            set { _EM_SLA = value; }
        }
        public string EM_AssignUser
        {
            get { return _EM_AssignUser; }
            set { _EM_AssignUser = value; }
        }

        public string EM_RowStatus
        {
            get { return _EM_RowStatus; }
            set { _EM_RowStatus = value; }
        }

        public string EM_CreatedDate
        {
            get { return _EM_CreatedDate; }
            set { _EM_CreatedDate = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }

        #endregion

    }

    public class CSMEscalationMatrixMsg
    {

        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion


        public CSMEscalationMatrixMsg() { }

        public CSMEscalationMatrixMsg(int RetVal, string RetStr)
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

    public class CSMSlaMasterList
    {
        #region "Variables Declaration"
        private int _CSMSLA_Id;
        private int _CSMSLA_Value;
        private string _CSMSLA_Type;
        private int _Count;
        #endregion

        public CSMSlaMasterList() { }

        public CSMSlaMasterList(int CSMSLA_Id, int CSMSLA_Value, string CSMSLA_Type,int Count)
        {
            this._CSMSLA_Id = CSMSLA_Id;
            this._CSMSLA_Value = CSMSLA_Value;
            this._CSMSLA_Type = CSMSLA_Type;
            this._Count = Count;
        }

        public int CSMSLA_Id
        {
            get { return _CSMSLA_Id; }
            set { _CSMSLA_Id = value; }
        }

        public int CSMSLA_Value
        {
            get { return _CSMSLA_Value; }
            set { _CSMSLA_Value = value; }
        }

        public string CSMSLA_Type
        {
            get { return _CSMSLA_Type; }
            set { _CSMSLA_Type = value; }
        }

        public int Count
        {
            get { return _Count; }
            set { _Count = value; }
        }



    }

}

