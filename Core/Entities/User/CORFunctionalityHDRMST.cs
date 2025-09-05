using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.User
{
    public class CORFunctionalityHDRMST
    {
        /// Class level Local Variables Declaration.
        #region "Variables Declaration"
        private int _FunctionID;
        private string _FunctionName;
        private int _FunctionDispalySeq;
        private int _FunctionStatus;
        #endregion

        /// <summary>
        /// Default constructor for CORFunctionalityHDRMST class.
        /// </summary>
        public CORFunctionalityHDRMST() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORFunctionalityHDRMST(int FunctionID, string FunctionName, int FunctionDispalySeq, int FunctionStatus)
        {
            this._FunctionID = FunctionID;
            this._FunctionName = FunctionName;
            this._FunctionDispalySeq = FunctionDispalySeq;
            this._FunctionStatus = FunctionStatus;
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int FunctionID
        {
            get { return _FunctionID; }
            set { _FunctionID = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public string FunctionName
        {
            get { return _FunctionName; }
            set { _FunctionName = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int FunctionDispalySeq
        {
            get { return _FunctionDispalySeq; }
            set { _FunctionDispalySeq = value; }
        }

        /// <summary>
        //Write Column Description here. - Vijay
        /// </summary>
        public int FunctionStatus
        {
            get { return _FunctionStatus; }
            set { _FunctionStatus = value; }
        }

    }


    public class CORFunctionalityHDRMSTList
    {
        //Write this List class yourself.
        //This List Class can not be generate using this utility.
        //Write this List class yourself.

        #region "Variables Declaration"

        private int _FunctionID;
        private string _FunctionName;
        private string _Status;


        #endregion

        /// <summary>
        /// Default constructor for branchmst class.
        /// </summary>
        public CORFunctionalityHDRMSTList() { }

        /// <summary>
        /// Overloaded constructor for the Branch class.
        /// </summary>
        public CORFunctionalityHDRMSTList(int FunctionID, string FunctionName, string Status)
        {
            this._FunctionID = FunctionID;
            this._FunctionName = FunctionName;
            this._Status = Status;

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
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }
    }

}
