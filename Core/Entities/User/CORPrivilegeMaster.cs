using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class CORPrivilegeMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _PRVL_ID;
        private int _PRVL_ROLE_ID;
        private int _PRVL_ScreenID;
        private int _PRVL_FunctionID;
        private int _PRVL_UpdatedByUserID;
        private string _PRVL_LastUpdateDate;
        private long _PRVL_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for USRPrivilegeMaster class.
        /// </summary>
        public CORPrivilegeMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPrivilegeMaster(int PRVL_ID, int PRVL_ROLE_ID, int PRVL_ScreenID, int PRVL_FunctionID, int PRVL_UpdatedByUserID, string PRVL_LastUpdateDate, long PRVL_RowVersion)
        {
            this._PRVL_ID = PRVL_ID;
            this._PRVL_ROLE_ID = PRVL_ROLE_ID;
            this._PRVL_ScreenID = PRVL_ScreenID;
            this._PRVL_FunctionID = PRVL_FunctionID;
            this._PRVL_UpdatedByUserID = PRVL_UpdatedByUserID;
            this._PRVL_LastUpdateDate = PRVL_LastUpdateDate;
            this._PRVL_RowVersion = PRVL_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PRVL_ID
        {
            get { return _PRVL_ID; }
            set { _PRVL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PRVL_ROLE_ID
        {
            get { return _PRVL_ROLE_ID; }
            set { _PRVL_ROLE_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PRVL_ScreenID
        {
            get { return _PRVL_ScreenID; }
            set { _PRVL_ScreenID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int PRVL_FunctionID
        {
            get { return _PRVL_FunctionID; }
            set { _PRVL_FunctionID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        public int PRVL_UpdatedByUserID
        {
            get { return _PRVL_UpdatedByUserID; }
            set { _PRVL_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string PRVL_LastUpdateDate
        {
            get { return _PRVL_LastUpdateDate; }
            set { _PRVL_LastUpdateDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long PRVL_RowVersion
        {
            get { return _PRVL_RowVersion; }
            set { _PRVL_RowVersion = value; }
        }
    }

    public class CORPrivilegeMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //Write this List class yourself.

        #region "Variables Declaration"

        private int _PRVL_ID;
        private int _PRVL_ROLE_ID;
        private int _PRVL_ScreenID;
        private int _PRVL_FunctionID;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORPrivilegeMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPrivilegeMasterList(int PRVL_ID, int PRVL_ROLE_ID, int PRVL_ScreenID, int PRVL_FunctionID)
        {
            this._PRVL_ID = PRVL_ID;
            this._PRVL_ROLE_ID = PRVL_ROLE_ID;
            this._PRVL_ScreenID = PRVL_ScreenID;
            this._PRVL_FunctionID = PRVL_FunctionID;
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int PRVMST_ID
        {
            get { return _PRVL_ID; }
            set { _PRVL_ID = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int PRVL_ROLE_ID
        {
            get { return _PRVL_ROLE_ID; }
            set { _PRVL_ROLE_ID = value; }
        }
        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int PRVL_ScreenID
        {
            get { return _PRVL_ScreenID; }
            set { _PRVL_ScreenID = value; }
        }
        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int PRVL_FunctionID
        {
            get { return _PRVL_FunctionID; }
            set { _PRVL_FunctionID = value; }
        }

    }
    public class USRFunctionalityRights
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //Write this List class yourself.

        #region "Variables Declaration"

        private int _FunctionID;
        private string _FunctionName;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public USRFunctionalityRights() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRFunctionalityRights(int FunctionID, string FunctionName)
        {
            this._FunctionID = FunctionID;
            this._FunctionName = FunctionName;
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int FunctionID
        {
            get { return _FunctionID; }
            set { _FunctionID = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public string FunctionName
        {
            get { return _FunctionName; }
            set { _FunctionName = value; }
        }


    }
    public class CORPrivilegeMasterMsg
    {
        //Message Class.
        //--Vijay Yadav
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Default constructor for USRPrivilegeMaster class.
        /// </summary>
        public CORPrivilegeMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORPrivilegeMasterMsg(int RetVal, string RetStr)
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
