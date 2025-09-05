using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Entities.Transaction
{
    public class ApplicationDetails
    {
        #region "Variables Declaration"
        protected string _BCCMST_ShortName;
        protected string _BCCMST_StartDate;
        protected string _BCCMST_EndDate;
        protected string _METTRN_MeterNo;
        protected string _METTRN_ReadingDate;
        protected string _METTRN_CurrentReading;
        protected string _APPMST_AppNo;
        protected int _APPMST_AppID;
        protected string _PLAMST_PlanName;
        protected string _CD_ControlType;
        protected string _Name;
        protected string _Address;
        #endregion

        public ApplicationDetails() { }
        public ApplicationDetails(string BCCMST_ShortName, string BCCMST_StartDate, string BCCMST_EndDate, string METTRN_MeterNo, string METTRN_ReadingDate, string      METTRN_CurrentReading, string APPMST_AppNo, int APPMST_AppID, string PLAMST_PlanName, string CD_ControlType, string Name, string Address)
        {

            this._BCCMST_ShortName = BCCMST_ShortName;
            this._BCCMST_StartDate = BCCMST_StartDate;
            this._BCCMST_EndDate = BCCMST_EndDate;
            this._METTRN_MeterNo = METTRN_MeterNo;
            this._METTRN_ReadingDate = METTRN_ReadingDate;
            this._METTRN_CurrentReading = METTRN_CurrentReading;
            this._APPMST_AppNo = APPMST_AppNo;
            this._APPMST_AppID = APPMST_AppID;
            this._PLAMST_PlanName = PLAMST_PlanName;
            this._CD_ControlType = CD_ControlType;
            this._Name = Name;
            this._Address = Address;
           
        }


        public string BCCMST_ShortName
        {
            get { return _BCCMST_ShortName; }
            set { _BCCMST_ShortName = value; }
        }

        public string BCCMST_StartDate
        {
            get { return _BCCMST_StartDate; }
            set { _BCCMST_StartDate = value; }
        }
        public string BCCMST_EndDate
        {
            get { return _BCCMST_EndDate; }
            set { _BCCMST_EndDate = value; }
        }
        public string METTRN_MeterNo
        {
            get { return _METTRN_MeterNo; }
            set { _METTRN_MeterNo = value; }
        }
        public string METTRN_ReadingDate
        {
            get { return _METTRN_ReadingDate; }
            set { _METTRN_ReadingDate = value; }
        }
        public string METTRN_CurrentReading
        {
            get { return _METTRN_CurrentReading; }
            set { _METTRN_CurrentReading = value; }
        }
        public string APPMST_AppNo
        {
            get { return _APPMST_AppNo; }
            set { _APPMST_AppNo = value; }
        }

        public int APPMST_AppID
        {
            get { return _APPMST_AppID; }
            set { _APPMST_AppID = value; }
        }
        public string PLAMST_PlanName
        {
            get { return _PLAMST_PlanName; }
            set { _PLAMST_PlanName = value; }
        }

        public string CD_ControlType
        {
            get { return _CD_ControlType; }
            set { _CD_ControlType = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
    }
}

