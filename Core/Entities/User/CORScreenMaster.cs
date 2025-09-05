using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class CORScreenMaster
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _ScreenId;
        private int _ScreenModuleID;
        private string _FormName;
        private string _FormTitle;
        private int _ScreenMenuSeq;
        private int _Status;
        private string _Remarks;
        private int _LangId;
        #endregion

        /// <summary>
        /// Default constructor for CORScreenMaster class.
        /// </summary>
        public CORScreenMaster() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORScreenMaster(int ScreenId, int ScreenModuleID, string FormName, string FormTitle, int ScreenMenuSeq, int Status, string Remarks, int LangId)
        {
            this._ScreenId = ScreenId;
            this._ScreenModuleID = ScreenModuleID;
            this._FormName = FormName;
            this._FormTitle = FormTitle;
            this._ScreenMenuSeq = ScreenMenuSeq;
            this._Status = Status;
            this._Remarks = Remarks;
            this._LangId = LangId;
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ScreenId
        {
            get { return _ScreenId; }
            set { _ScreenId = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ScreenModuleID
        {
            get { return _ScreenModuleID; }
            set { _ScreenModuleID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string FormTitle
        {
            get { return _FormTitle; }
            set { _FormTitle = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int ScreenMenuSeq
        {
            get { return _ScreenMenuSeq; }
            set { _ScreenMenuSeq = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string Remarks
        {
            get { return _Remarks; }
            set { _Remarks = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int LangId
        {
            get { return _LangId; }
            set { _LangId = value; }
        }

    }


    public class CORScreenMasterList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //Write this List class yourself.

        #region "Variables Declaration"

        private int _ScreenId;
        private string _ModuleName;
        private int _ScreenModuleID;
        private string _FormName;
        private int _ScreenParentID;
        private string _SubModule;
        private string _FormTitle;

        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORScreenMasterList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORScreenMasterList(int ScreenId, string ModuleName, int ScreenModuleID, string FormName, int ScreenParentID, string SubModule, string FormTitle)
        {
            this._ScreenId = ScreenId;
            this._ModuleName = ModuleName;
            this._ScreenModuleID = ScreenModuleID;
            this._FormName = FormName;
            this._ScreenParentID = ScreenParentID;
            this._SubModule = SubModule;
            this._FormTitle = FormTitle;
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public int ScreenId
        {
            get { return _ScreenId; }
            set { _ScreenId = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>

        /// 
        public int ScreenModuleID
        {
            get { return _ScreenModuleID; }
            set { _ScreenModuleID = value; }
        }

        public string FormName
        {
            get { return _FormName; }
            set { _FormName = value; }
        }

        public int ScreenParentID
        {
            get { return _ScreenParentID; }
            set { _ScreenParentID = value; }
        }

        public string SubModule
        {
            get { return _SubModule; }
            set { _SubModule = value; }
        }

        /// <summary>
        //Write Column Description here. - 
        /// </summary>
        public string FormTitle
        {
            get { return _FormTitle; }
            set { _FormTitle = value; }
        }


    }

}
