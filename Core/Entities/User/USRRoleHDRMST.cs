using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class USRRoleHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _ROLH_CMPMID;
        private int _ROLH_ID;
        private string _ROLH_Name;
        private int _ROLH_Status;
        private int _ROLH_UpdatedByUserID;
        private string _ROLH_LastUpdateDate;
        private long _ROLH_RowVersion;
        #endregion

        /// <summary>
        /// Default constructor for USRRoleHDRMST class.
        /// </summary>
        public USRRoleHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRRoleHDRMST(int ROLH_CMPMID, int ROLH_ID, string ROLH_Name, int ROLH_Status, int ROLH_UpdatedByUserID, string ROLH_LastUpdateDate, long ROLH_RowVersion)
        {
            this._ROLH_CMPMID = ROLH_CMPMID;
            this._ROLH_ID = ROLH_ID;
            this._ROLH_Name = ROLH_Name;
            this._ROLH_Status = ROLH_Status;
            this._ROLH_UpdatedByUserID = ROLH_UpdatedByUserID;
            this._ROLH_LastUpdateDate = ROLH_LastUpdateDate;
            this._ROLH_RowVersion = ROLH_RowVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ROLH_CMPMID
        {
            get { return _ROLH_CMPMID; }
            set { _ROLH_CMPMID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ROLH_ID
        {
            get { return _ROLH_ID; }
            set { _ROLH_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ROLH_Name
        {
            get { return _ROLH_Name; }
            set { _ROLH_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ROLH_Status
        {
            get { return _ROLH_Status; }
            set { _ROLH_Status = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int ROLH_UpdatedByUserID
        {
            get { return _ROLH_UpdatedByUserID; }
            set { _ROLH_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string ROLH_LastUpdateDate
        {
            get { return _ROLH_LastUpdateDate; }
            set { _ROLH_LastUpdateDate = value; }
        }
        public long ROLH_RowVersion
        {
            get { return _ROLH_RowVersion; }
            set { _ROLH_RowVersion = value; }
        }

    }

    public class USRRoleHDRMSTList
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _ROLH_ID;
        private string _ROLH_Name;
        private string _ROLH_Status;

        private int _rolecount;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public USRRoleHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        public USRRoleHDRMSTList(int ROLH_ID, string ROLH_Name, string ROLH_Status, int rolecount)
        {

            this._ROLH_ID = ROLH_ID;
            this._ROLH_Name = ROLH_Name;
            this._ROLH_Status = ROLH_Status;
            this._rolecount = rolecount;



        }

        /// <summary>
        //Write Column Description here. - Sehul
        /// </summary>
        public int ROLH_ID
        {
            get { return _ROLH_ID; }
            set { _ROLH_ID = value; }
        }

        /// <summary>
        //Write Column Description here. - Sehul
        /// </summary>
        public string ROLH_Name
        {
            get { return _ROLH_Name; }
            set { _ROLH_Name = value; }
        }

        /// <summary>
        //Write Column Description here. - Sehul
        /// </summary>
        public string ROLH_Status
        {
            get { return _ROLH_Status; }
            set { _ROLH_Status = value; }
        }

        /// <summary>
        //Write Column Description here. - Sehul
        /// </summary>
        public int rolecount
        {
            get { return _rolecount; }

        }


    }

    public class USRRoleHDRMSTMsg
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Overloaded default constructor for the DrugGroupMSTMsg class.
        /// </summary>
        public USRRoleHDRMSTMsg() { }

        /// <summary>
        /// Overloaded constructor for the DrugGroupMSTMsg class.
        /// </summary>
        /// <param name="RetVal">Return Value for the DrugGroupMST.</param>
        /// <param name="RetStr">Return String for the DrugGroupMST.</param>
        public USRRoleHDRMSTMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }

        /// <summary>
        /// Gets or sets Return Value.
        /// The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }

        /// <summary>
        /// Gets or sets Return String.        
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }
}
