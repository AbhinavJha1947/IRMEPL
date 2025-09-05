using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class USRUserRoleMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _USRROL_ID;
        private int _USRROL_UserID;
        private int _USRROL_RoleID;
        private int _USRROL_CreatedByUserID;
        private string _USRROL_CreatedDate;
        private int _USRROL_UpdatedByUserID;
        private string _USRROL_LastUpdateDate;
        private long _USRROL_RowVersion;
        private int _USRROL_AUDITMID;
        #endregion

        /// <summary>
        /// Default constructor for USRUserRoleMaster class.
        /// </summary>
        public USRUserRoleMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRUserRoleMaster(int USRROL_ID, int USRROL_UserID, int USRROL_RoleID, int USRROL_CreatedByUserID, string USRROL_CreatedDate, int USRROL_UpdatedByUserID, string USRROL_LastUpdateDate, long USRROL_RowVersion, int USRROL_AUDITMID)
        {
            this._USRROL_ID = USRROL_ID;
            this._USRROL_UserID = USRROL_UserID;
            this._USRROL_RoleID = USRROL_RoleID;
            this._USRROL_CreatedByUserID = USRROL_CreatedByUserID;
            this._USRROL_CreatedDate = USRROL_CreatedDate;
            this._USRROL_UpdatedByUserID = USRROL_UpdatedByUserID;
            this._USRROL_LastUpdateDate = USRROL_LastUpdateDate;
            this._USRROL_RowVersion = USRROL_RowVersion;
            this._USRROL_AUDITMID = USRROL_AUDITMID;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_ID
        {
            get { return _USRROL_ID; }
            set { _USRROL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_UserID
        {
            get { return _USRROL_UserID; }
            set { _USRROL_UserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_RoleID
        {
            get { return _USRROL_RoleID; }
            set { _USRROL_RoleID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_CreatedByUserID
        {
            get { return _USRROL_CreatedByUserID; }
            set { _USRROL_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USRROL_CreatedDate
        {
            get { return _USRROL_CreatedDate; }
            set { _USRROL_CreatedDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_UpdatedByUserID
        {
            get { return _USRROL_UpdatedByUserID; }
            set { _USRROL_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USRROL_LastUpdateDate
        {
            get { return _USRROL_LastUpdateDate; }
            set { _USRROL_LastUpdateDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long USRROL_RowVersion
        {
            get { return _USRROL_RowVersion; }
            set { _USRROL_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USRROL_AUDITMID
        {
            get { return _USRROL_AUDITMID; }
            set { _USRROL_AUDITMID = value; }
        }

    }

    //public class 	USRUserRoleMasterList
    //{
    ///// Class level Local Variables Declaration.
    //        #region "Variables Declaration"

    //    private int _ROLH_ID;
    //    private string _ROLH_Name;
    //    private string _ROLH_Status;

    //        #endregion

    //        /// <summary>
    //        /// Default constructor for UserRoleMst class.
    //        /// </summary>
    //        public USRUserRoleMasterList() { }

    //        /// <summary>
    //        /// Overloaded constructor for the Role class.
    //        /// </summary>
    //        public USRUserRoleMasterList(int ROLH_ID, string ROLH_Name, string ROLH_Status)
    //        {
    //            this._ROLH_ID = ROLH_ID;
    //            this._ROLH_Name = ROLH_Name;
    //            this._ROLH_Status = ROLH_Status;
    //        }

    //        /// <summary>
    //        /// </summary>
    //        public int ROLH_ID
    //        {
    //            get { return _ROLH_ID; }
    //            set { _ROLH_ID = value; }
    //        }

    //        /// <summary>
    //        /// </summary>
    //        public string ROLH_Name
    //        {
    //            get { return _ROLH_Name; }
    //            set { _ROLH_Name = value; }
    //        }

    //        /// <summary>
    //        /// </summary>
    //        public string ROLH_Status
    //        {
    //            get { return _ROLH_Status; }
    //            set { _ROLH_Status = value; }
    //        }
    //}

    public class USRUserRoleMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"

        private int _USRROL_ID;
        private int _USRROL_UserID;
        private int _USRROL_RoleID;

        #endregion

        /// <summary>
        /// Default constructor for UserRoleMst class.
        /// </summary>
        public USRUserRoleMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Role class.
        /// </summary>
        public USRUserRoleMasterList(int USRROL_ID, int USRROL_UserID, int USRROL_RoleID)
        {
            this._USRROL_ID = USRROL_ID;
            this._USRROL_UserID = USRROL_UserID;
            this._USRROL_RoleID = USRROL_RoleID;
        }

        /// <summary>
        /// </summary>
        public int USRROL_ID
        {
            get { return _USRROL_ID; }
            set { _USRROL_ID = value; }
        }

        /// <summary>
        /// </summary>
        public int USRROL_UserID
        {
            get { return _USRROL_UserID; }
            set { _USRROL_UserID = value; }
        }

        /// <summary>
        /// </summary>
        public int USRROL_RoleID
        {
            get { return _USRROL_RoleID; }
            set { _USRROL_RoleID = value; }
        }
    }
    public class USRUserRoleMasterMsg
    {
        //Message Class.
        //--Vijay Yadav
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Default constructor for USRUserRoleMaster class.
        /// </summary>
        public USRUserRoleMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRUserRoleMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        //Write Column Description here. -Vijay Yadav 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        //Write Column Description here. -Vijay Yadav 
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }

    }
}
