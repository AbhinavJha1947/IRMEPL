using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Core
{
    public class CORDOCUploadDownload
    {
        #region "Variables Declaration"

        private int _DOC_ID;
        public int DOC_ID
        {
            get { return _DOC_ID; }
            set { _DOC_ID = value; }
        }

        private string _AppNo;
        public string AppNo
        {
            get { return _AppNo; }
            set { _AppNo = value; }
        }

        private string _DOC_Filename;
        public string DOC_Filename
        {
            get { return _DOC_Filename; }
            set { _DOC_Filename = value; }
        }

        private int _DOC_CreatedByUserID;
        public int DOC_CreatedByUserID
        {
            get { return _DOC_CreatedByUserID; }
            set { _DOC_CreatedByUserID = value; }
        }

        private int _DOC_OWflag;
        public int DOC_OWflag
        {
            get { return _DOC_OWflag; }
            set { _DOC_OWflag = value; }
        }

        private int _DOC_RowStatus;
        public int DOC_RowStatus
        {
            get { return _DOC_RowStatus; }
            set { _DOC_RowStatus = value; }
        }


        #endregion

        public CORDOCUploadDownload() { }

        public CORDOCUploadDownload(int DOC_ID, string AppNo, string DOC_Filename, int DOC_CreatedByUserID, int DOC_OWflag, int DOC_RowStatus)
        {
            this._DOC_ID = DOC_ID;
            this._AppNo = AppNo;
            this._DOC_Filename = DOC_Filename;
            this._DOC_CreatedByUserID = DOC_CreatedByUserID;
            this._DOC_OWflag = DOC_OWflag;
            this._DOC_RowStatus = DOC_RowStatus;
        }


    }

    public class CORDOCUploadDownloadLogMsg
    {

        #region "Variables Declaration"
        private int _RetVal;
        private string _RetStr;
        #endregion

        /// <summary>
        //Overloaded default constructor for the Salutation class. 
        /// </summary>
        public CORDOCUploadDownloadLogMsg() { }
        /// <summary>
        //Overloaded constructor for the Salutation class. 
        /// </summary>
        /// <param name="saltnmId">Unique Identifier for the Salutation.</param>
        /// <param name="saltnmName">Name of the Salutation.</param>
        public CORDOCUploadDownloadLogMsg(int RetVal, string RetStr)
        {
            this._RetVal = RetVal;
            this._RetStr = RetStr;
        }
        /// <summary>
        //Gets or sets unique Salutation identifier. 
        //The Identity Field Design Pattern. 
        /// </summary>
        public int RetVal
        {
            get { return _RetVal; }
            set { _RetVal = value; }
        }
        /// <summary>
        //Gets or sets Country Name.
        /// </summary>
        public string RetStr
        {
            get { return _RetStr; }
            set { _RetStr = value; }
        }
    }


}

