using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class USRUserMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _USER_ID;
        private int _User_Type;
        private string _USER_BranchID;
        private string _USER_PEMPCode;
        private string _USER_FirstName;
        private string _USER_MiddleName;
        private string _USER_LastName;
        private string _USER_EmailID;
        private string _USER_LoginID;
        private string _USER_Password;
        private string _USER_PhoneNo;
        private string _USER_MobileNo;
        private int _USER_DesigID;
        private int _USER_CSMDesigID;
        private int _USER_Status;
        private int _USER_UpdatedByUserID;
        private string _USER_LastUpdateDate;
        private long _ROwVersion;

        #endregion

        /// <summary>
        /// Default constructor for USRUserMaster class.
        /// </summary>
        public USRUserMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRUserMaster(int USER_ID, int User_Type, string USER_BranchID, string USER_PEMPCode, string USER_FirstName, string USER_MiddleName, string USER_LastName, string USER_EmailID, string USER_LoginID, string USER_Password, string USER_PhoneNo, string USER_MobileNo, int USER_DesigID, int USER_CSMDesigID, int USER_Status, int USER_UpdatedByUserID, string USER_LastUpdateDate, long ROwVersion)
        {
            this._USER_ID = USER_ID;
            this._User_Type = User_Type;
            this._USER_BranchID = USER_BranchID;
            this._USER_PEMPCode = USER_PEMPCode;
            this._USER_FirstName = USER_FirstName;
            this._USER_MiddleName = USER_MiddleName;
            this._USER_LastName = USER_LastName;
            this._USER_EmailID = USER_EmailID;
            this._USER_LoginID = USER_LoginID;
            this._USER_Password = USER_Password;
            this._USER_PhoneNo = USER_PhoneNo;
            this._USER_MobileNo = USER_MobileNo;
            this._USER_DesigID = USER_DesigID;
            this._USER_CSMDesigID = USER_CSMDesigID;
            this._USER_Status = USER_Status;
            this._USER_UpdatedByUserID = USER_UpdatedByUserID;
            this._USER_LastUpdateDate = USER_LastUpdateDate;
            this._ROwVersion = ROwVersion;
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int User_Type
        {
            get { return _User_Type; }
            set { _User_Type = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_BranchID
        {
            get { return _USER_BranchID; }
            set { _USER_BranchID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_PEMPCode
        {
            get { return _USER_PEMPCode; }
            set { _USER_PEMPCode = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_FirstName
        {
            get { return _USER_FirstName; }
            set { _USER_FirstName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_MiddleName
        {
            get { return _USER_MiddleName; }
            set { _USER_MiddleName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LastName
        {
            get { return _USER_LastName; }
            set { _USER_LastName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_EmailID
        {
            get { return _USER_EmailID; }
            set { _USER_EmailID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LoginID
        {
            get { return _USER_LoginID; }
            set { _USER_LoginID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_Password
        {
            get { return _USER_Password; }
            set { _USER_Password = value; }
        }

        public string USER_PhoneNo
        {
            get { return _USER_PhoneNo; }
            set { _USER_PhoneNo = value; }
        }

        public string USER_MobileNo
        {
            get { return _USER_MobileNo; }
            set { _USER_MobileNo = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>

        public int USER_DesigID
        {
            get { return _USER_DesigID; }
            set { _USER_DesigID = value; }
        }


        public int USER_Status
        {
            get { return _USER_Status; }
            set { _USER_Status = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>


        /// <summary>
        //Write Column Description here. 
        /// </summary>

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_UpdatedByUserID
        {
            get { return _USER_UpdatedByUserID; }
            set { _USER_UpdatedByUserID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LastUpdateDate
        {
            get { return _USER_LastUpdateDate; }
            set { _USER_LastUpdateDate = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public long ROwVersion
        {
            get { return _ROwVersion; }
            set { _ROwVersion = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        /// 
        public int USER_CSMDesigID
        {
            get { return _USER_CSMDesigID; }
            set { _USER_CSMDesigID = value; }
        }
    }

    public class USRUserMasterList
    {

        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _USER_ID;
        private int _USER_Type;
        private string _strUSER_Type;
        private string _CENMST_CenterCode;
        private string _CENMST_Name;
        private string _USER_FirstName;
        private string _USER_MiddleName;
        private string _USER_LastName;
        private string _UserName;
        private string _USER_PhoneNo;
        private string _USER_MobileNo;
        private string _USER_EmailID;
        private string _USER_LoginID;
        private string _USER_Password;
        private string _USER_Status;
        private string _DESI_ID;
        private string _DESI_Name;
        private string _USER_LastUpdateDate;
        private int _USER_CSMDesigID;
        private string _CSMDESI_Name;
        private int _Usercount;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public USRUserMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Analyzer class.
        /// </summary>
        /// <param name=""></param>
        /// 

        //   public USRUserMasterforget(int USER_ID, string USER_EmailID, string USER_Password,  int Usercount)
        //{
        //    this._USER_ID = USER_ID;            
        //    this._USER_EmailID = USER_EmailID;            
        //    this._USER_Password = USER_Password;  
        //}

        public USRUserMasterList(int USER_ID, int USER_Type, string strUSER_Type, string CENMST_CenterCode, string CENMST_Name, string USER_FirstName, string USER_MiddleName, string USER_LastName, string UserName, string USER_PhoneNo, string USER_MobileNo, string USER_EmailID, string USER_LoginID, string USER_Password, string USER_Status, string DESI_ID, string DESI_Name, string USER_LastUpdateDate, string CSMDESI_Name, int Usercount)
        {

            this._USER_ID = USER_ID;
            this._USER_Type = USER_Type;
            this._strUSER_Type = strUSER_Type;
            this._CENMST_CenterCode = CENMST_CenterCode;
            this._CENMST_Name = CENMST_Name;
            this._USER_FirstName = USER_FirstName;
            this._USER_MiddleName = USER_MiddleName;
            this._USER_LastName = USER_LastName;
            this._UserName = UserName;
            this._USER_PhoneNo = USER_PhoneNo;
            this._USER_MobileNo = USER_MobileNo;
            this._USER_EmailID = USER_EmailID;
            this._USER_LoginID = USER_LoginID;
            this._USER_Password = USER_Password;
            this._USER_Status = USER_Status;
            this._DESI_ID = DESI_ID;
            this._DESI_Name = DESI_Name;
            this._CSMDESI_Name = CSMDESI_Name;
            this._USER_LastUpdateDate = USER_LastUpdateDate;
            this._Usercount = Usercount;
        }
        public int USER_CSMDesigID
        {
            get { return _USER_CSMDesigID; }
            set { _USER_CSMDesigID = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_ID
        {
            get { return _USER_ID; }
            set { _USER_ID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int USER_Type
        {
            get { return _USER_Type; }
            set { _USER_Type = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string strUSER_Type
        {
            get { return _strUSER_Type; }
            set { _strUSER_Type = value; }
        }

        public string CENMST_CenterCode
        {
            get { return _CENMST_CenterCode; }
            set { _CENMST_CenterCode = value; }
        }

        public string CENMST_Name
        {
            get { return _CENMST_Name; }
            set { _CENMST_Name = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_FirstName
        {
            get { return _USER_FirstName; }
            set { _USER_FirstName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_MiddleName
        {
            get { return _USER_MiddleName; }
            set { _USER_MiddleName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LastName
        {
            get { return _USER_LastName; }
            set { _USER_LastName = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }


        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_PhoneNo
        {
            get { return _USER_PhoneNo; }
            set { _USER_PhoneNo = value; }
        }

        public string USER_MobileNo
        {
            get { return _USER_MobileNo; }
            set { _USER_MobileNo = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_EmailID
        {
            get { return _USER_EmailID; }
            set { _USER_EmailID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LoginID
        {
            get { return _USER_LoginID; }
            set { _USER_LoginID = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_Password
        {
            get { return _USER_Password; }
            set { _USER_Password = value; }
        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_Status
        {
            get { return _USER_Status; }
            set { _USER_Status = value; }
        }
        public string USER_LastUpdateDate
        {
            get { return _USER_LastUpdateDate; }
            set { _USER_LastUpdateDate = value; }
        }

        public string DESI_ID
        {
            get { return _DESI_ID; }
            set { _DESI_ID = value; }
        }
        public string DESI_Name
        {
            get { return _DESI_Name; }
            set { _DESI_Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string CSMDESI_Name
        {
            get { return _CSMDESI_Name; }
            set { _CSMDESI_Name = value; }
        }
        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public int Usercount
        {
            get { return _Usercount; }

        }
    }
    public class USRUserMasterMsg
    {
        //Message Class.
        //--Vijay Yadav
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        /// Default constructor for USRUserMaster class.
        /// </summary>
        public USRUserMasterMsg() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public USRUserMasterMsg(int RetVal, string RetStr)
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

    public class USRUserMasterforgetMsg
    {
        //Message Class.
        //--Vijay Yadav
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"       
        private string _USER_EmailID;
        private string _USER_Password;
        private string _USER_FirstName;
        private string _USER_LastName;
        private string _USER_LoginID;
        #endregion

        /// <summary>
        /// Default constructor for USRUserMaster class.
        /// </summary>
        public USRUserMasterforgetMsg() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        /// 

        public USRUserMasterforgetMsg(string USR_EmailID, string User_Password, string User_FirstName, string User_LastName, string UserName)
        {
            this._USER_EmailID = USR_EmailID;
            this._USER_Password = User_Password;
            this._USER_FirstName = User_FirstName;
            this._USER_LastName = User_LastName;
            this._USER_LoginID = UserName;

        }

        /// <summary>
        //Write Column Description here. 
        /// </summary>
        public string USER_LoginID
        {
            get { return _USER_LoginID; }
            set { _USER_LoginID = value; }
        }

        public string USER_FirstName
        {
            get { return _USER_FirstName; }
            set { _USER_FirstName = value; }
        }
        public string USER_LastName
        {
            get { return _USER_LastName; }
            set { _USER_LastName = value; }
        }
        public string USER_EmailID
        {
            get { return _USER_EmailID; }
            set { _USER_EmailID = value; }
        }

        public string USER_Password
        {
            get { return _USER_Password; }
            set { _USER_Password = value; }
        }


        /// <summary>
        //Write Column Description here. -Vijay Yadav 
        /// </summary>


    }
}