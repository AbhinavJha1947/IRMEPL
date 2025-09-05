using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class USRRoleMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _ROLMST_RoleID;
        private string _ROLMST_RoleName;
        private string _ROLMST_RoleDescription;
        private int _ROLMST_RowStatus;
        private int _ROLMST_CreatedByUserID;
        private string _ROLMST_CreatedDate;
        private int _ROLMST_UpdatedByUserID;
        private string _ROLMST_LastUpdateDate;
        private long _ROLMST_RowVersion;
        private int _ROLMST_AUDITMID;
        #endregion

        /// <summary>
        /// Default constructor for USRRoleMaster class.
        /// </summary>
        public USRRoleMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRRoleMaster(int ROLMST_RoleID, string ROLMST_RoleName, string ROLMST_RoleDescription, int ROLMST_RowStatus, int ROLMST_CreatedByUserID, string ROLMST_CreatedDate, int ROLMST_UpdatedByUserID, string ROLMST_LastUpdateDate, long ROLMST_RowVersion, int ROLMST_AUDITMID)
        {
            this._ROLMST_RoleID = ROLMST_RoleID;
            this._ROLMST_RoleName = ROLMST_RoleName;
            this._ROLMST_RoleDescription = ROLMST_RoleDescription;
            this._ROLMST_RowStatus = ROLMST_RowStatus;
            this._ROLMST_CreatedByUserID = ROLMST_CreatedByUserID;
            this._ROLMST_CreatedDate = ROLMST_CreatedDate;
            this._ROLMST_UpdatedByUserID = ROLMST_UpdatedByUserID;
            this._ROLMST_LastUpdateDate = ROLMST_LastUpdateDate;
            this._ROLMST_RowVersion = ROLMST_RowVersion;
            this._ROLMST_AUDITMID = ROLMST_AUDITMID;
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_RoleID
        {
            get { return _ROLMST_RoleID; }
            set { _ROLMST_RoleID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_RoleName
        {
            get { return _ROLMST_RoleName; }
            set { _ROLMST_RoleName = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_RoleDescription
        {
            get { return _ROLMST_RoleDescription; }
            set { _ROLMST_RoleDescription = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_RowStatus
        {
            get { return _ROLMST_RowStatus; }
            set { _ROLMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_CreatedByUserID
        {
            get { return _ROLMST_CreatedByUserID; }
            set { _ROLMST_CreatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_CreatedDate
        {
            get { return _ROLMST_CreatedDate; }
            set { _ROLMST_CreatedDate = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_UpdatedByUserID
        {
            get { return _ROLMST_UpdatedByUserID; }
            set { _ROLMST_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_LastUpdateDate
        {
            get { return _ROLMST_LastUpdateDate; }
            set { _ROLMST_LastUpdateDate = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public long ROLMST_RowVersion
        {
            get { return _ROLMST_RowVersion; }
            set { _ROLMST_RowVersion = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_AUDITMID
        {
            get { return _ROLMST_AUDITMID; }
            set { _ROLMST_AUDITMID = value; }
        }

    }

    public class USRRoleMasterList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _ROLMST_RoleID;
        private string _ROLMST_RoleName;
        private string _ROLMST_RoleDescription;
        private string _ROLMST_RowStatus;
        private int _rolecount;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public USRRoleMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public USRRoleMasterList(int ROLMST_RoleID, string ROLMST_RoleName, string ROLMST_RoleDescription, string ROLMST_RowStatus, int rolecount)
        {

            this._ROLMST_RoleID = ROLMST_RoleID;
            this._ROLMST_RoleName = ROLMST_RoleName;
            this._ROLMST_RoleDescription = ROLMST_RoleDescription;
            this.ROLMST_RowStatus = ROLMST_RowStatus;
            this._rolecount = rolecount;



        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ROLMST_RoleID
        {
            get { return _ROLMST_RoleID; }
            set { _ROLMST_RoleID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_RoleName
        {
            get { return _ROLMST_RoleName; }
            set { _ROLMST_RoleName = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_RoleDescription
        {
            get { return _ROLMST_RoleDescription; }
            set { _ROLMST_RoleDescription = value; }
        }
        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string ROLMST_RowStatus
        {
            get { return _ROLMST_RowStatus; }
            set { _ROLMST_RowStatus = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int rolecount
        {
            get { return _rolecount; }

        }

    }
    public class USRRoleMasterMsg
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Default constructor for USRRoleMaster class.
        /// </summary>
        public USRRoleMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the  class.
        /// </summary>
        public USRRoleMasterMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }

    }
}