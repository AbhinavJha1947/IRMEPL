using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class BILAMCCSVDataDao : IBILAMCCSVDataDao
    {
        private readonly DbManager _dbManager;

        public BILAMCCSVDataDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<BILAMCCSVDataList> GetBILAMCCSVDatas()
        {
            string sortExpression = "AMCCSV_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetBILAMCCSVDatas(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<BILAMCCSVDataList> GetBILAMCCSVDatas(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILAMCCSVData_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'AMCCSV_ID',");
            }
            else
            {
                sql.Append("'" + sortExpression + "',");
            }
            //String Building for Sorintg Type
            if (String.IsNullOrEmpty(sortType) == true)
            {
                sql.Append("'ASC',");
            }
            else
            {
                sql.Append("'" + sortType + "',");
            }
            //String Building for Page Index
            sql.Append(pageIndex + ",");
            sql.Append(pageSize + ",'");
            sql.Append(criteria + "'");
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<BILAMCCSVDataList> list = new List<BILAMCCSVDataList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public BILAMCCSVData GetBILAMCCSVData(int BILAMCCSVDataid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILAMCCSVData_Select " + BILAMCCSVDataid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int AMCCSV_ID = Convert.ToInt32(row["AMCCSV_ID"]);
            int AMCCSV_CenCode = Convert.ToInt32(row["AMCCSV_CenCode"]);
            string AMCCSV_ApplicationNo = row["AMCCSV_ApplicationNo"].ToString();
            string AMCCSV_Date = Convert.ToString(row["AMCCSV_Date"]);
            int AMCCSV_MeterNo = Convert.ToInt32(row["AMCCSV_MeterNo"]);
            string AMCCSV_Regulator = Convert.ToString(row["AMCCSV_Regulator"]);
            decimal AMCCSV_Pressure = Convert.ToDecimal(row["AMCCSV_Pressure"]);
            int AMCCSV_ExtraKitchen = Convert.ToInt32(row["AMCCSV_ExtraKitchen"]);
            int AMCCSV_ExtraBathroom = Convert.ToInt32(row["AMCCSV_ExtraBathroom"]);
            int AMCCSV_Leakage = Convert.ToInt32(row["AMCCSV_Leakage"]);
            int AMCCSV_SingleVentilation = Convert.ToInt32(row["AMCCSV_SingleVentilation"]);
            string AMCCSV_HouseClosed = Convert.ToString(row["AMCCSV_HouseClosed"]);
            string AMCCSV_DCForceDC = Convert.ToString(row["AMCCSV_DCForceDC"]);
            string AMCCSV_DMLT = Convert.ToString(row["AMCCSV_DMLT"]);
            string AMCCSV_PHC = Convert.ToString(row["AMCCSV_PHC"]);
            string AMCCSV_UnSafeConn = Convert.ToString(row["AMCCSV_UnSafeConn"]);
            int AMCCSV_MeterStop = Convert.ToInt32(row["AMCCSV_MeterStop"]);
            int AMCCSV_ChangeRubTube = Convert.ToInt32(row["AMCCSV_ChangeRubTube"]);
            int AMCCSV_ChangeNeoRubCap = Convert.ToInt32(row["AMCCSV_ChangeNeoRubCap"]);
            int AMCCSV_ChangeRubTubeClamp = Convert.ToInt32(row["AMCCSV_ChangeRubTubeClamp"]);
            int AMCCSV_ChangeMainISOValve = Convert.ToInt32(row["AMCCSV_ChangeMainISOValve"]);
            int AMCCSV_ChangeAdapter = Convert.ToInt32(row["AMCCSV_ChangeAdapter"]);
            int AMCCSV_ChangeTF = Convert.ToInt32(row["AMCCSV_ChangeTF"]);
            int AMCCSV_ChangeGIElbow = Convert.ToInt32(row["AMCCSV_ChangeGIElbow"]);
            int AMCCSV_ChangeHexNipple = Convert.ToInt32(row["AMCCSV_ChangeHexNipple"]);
            int AMCCSV_ChangeGIClamp = Convert.ToInt32(row["AMCCSV_ChangeGIClamp"]);
            int AMCCSV_ChangeORingAdapter = Convert.ToInt32(row["AMCCSV_ChangeORingAdapter"]);
            int AMCCSV_ChangeORingUnion = Convert.ToInt32(row["AMCCSV_ChangeORingUnion"]);
            int AMCCSV_ChangeScrew = Convert.ToInt32(row["AMCCSV_ChangeScrew"]);
            int AMCCSV_ChangeRollPlug = Convert.ToInt32(row["AMCCSV_ChangeRollPlug"]);
            int AMCCSV_ChangeRCCGuardNail = Convert.ToInt32(row["AMCCSV_ChangeRCCGuardNail"]);
            int AMCCSV_ChangeGIUnion = Convert.ToInt32(row["AMCCSV_ChangeGIUnion"]);
            int AMCCSV_ChangePECoupler = Convert.ToInt32(row["AMCCSV_ChangePECoupler"]);
            int AMCCSV_LeakageInMainISOValve = Convert.ToInt32(row["AMCCSV_LeakageInMainISOValve"]);
            int AMCCSV_LeakageInRegOrRegAdapter = Convert.ToInt32(row["AMCCSV_LeakageInRegOrRegAdapter"]);
            int AMCCSV_LeakageInUnion = Convert.ToInt32(row["AMCCSV_LeakageInUnion"]);
            int AMCCSV_LeakageInMeterOrMeterAdapter = Convert.ToInt32(row["AMCCSV_LeakageInMeterOrMeterAdapter"]);
            int AMCCSV_LeakageInTF = Convert.ToInt32(row["AMCCSV_LeakageInTF"]);
            int AMCCSV_LeakageInGIFitting = Convert.ToInt32(row["AMCCSV_LeakageInGIFitting"]);
            int AMCCSV_LeakageInRubTube = Convert.ToInt32(row["AMCCSV_LeakageInRubTube"]);
            string AMCCSV_Remarks = Convert.ToString(row["AMCCSV_Remarks"]);
            int AMCCSV_CreatedByUserID = Convert.ToInt32(row["AMCCSV_CreatedByUserID"]);
            #endregion

            return new
            BILAMCCSVData(AMCCSV_ID, AMCCSV_CenCode, AMCCSV_ApplicationNo, AMCCSV_Date, AMCCSV_MeterNo, AMCCSV_Regulator, AMCCSV_Pressure, AMCCSV_ExtraKitchen, AMCCSV_ExtraBathroom, AMCCSV_Leakage, AMCCSV_SingleVentilation, AMCCSV_HouseClosed, AMCCSV_DCForceDC, AMCCSV_DMLT, AMCCSV_PHC, AMCCSV_UnSafeConn, AMCCSV_MeterStop, AMCCSV_ChangeRubTube, AMCCSV_ChangeNeoRubCap, AMCCSV_ChangeRubTubeClamp, AMCCSV_ChangeMainISOValve, AMCCSV_ChangeAdapter, AMCCSV_ChangeTF, AMCCSV_ChangeGIElbow, AMCCSV_ChangeHexNipple, AMCCSV_ChangeGIClamp, AMCCSV_ChangeORingAdapter, AMCCSV_ChangeORingUnion, AMCCSV_ChangeScrew, AMCCSV_ChangeRollPlug, AMCCSV_ChangeRCCGuardNail, AMCCSV_ChangeGIUnion, AMCCSV_ChangePECoupler, AMCCSV_LeakageInMainISOValve, AMCCSV_LeakageInRegOrRegAdapter, AMCCSV_LeakageInUnion, AMCCSV_LeakageInMeterOrMeterAdapter, AMCCSV_LeakageInTF, AMCCSV_LeakageInGIFitting, AMCCSV_LeakageInRubTube, AMCCSV_Remarks, AMCCSV_CreatedByUserID);
        }

        public BILAMCCSVDataMsg InsertBILAMCCSVData(BILAMCCSVData BILAMCCSVData, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILAMCCSVData_Insert ");
            sql.Append(BILAMCCSVData.AMCCSV_CenCode + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_ApplicationNo + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Date + "',");
            sql.Append(BILAMCCSVData.AMCCSV_MeterNo + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Regulator + "',");
            sql.Append(BILAMCCSVData.AMCCSV_Pressure + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ExtraKitchen + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ExtraBathroom + ",");
            sql.Append(BILAMCCSVData.AMCCSV_Leakage + ",");
            sql.Append(BILAMCCSVData.AMCCSV_SingleVentilation + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_HouseClosed + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_DCForceDC + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_DMLT + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_PHC + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_UnSafeConn + "',");
            sql.Append(BILAMCCSVData.AMCCSV_MeterStop + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRubTube + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeNeoRubCap + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRubTubeClamp + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeMainISOValve + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeTF + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIElbow + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeHexNipple + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIClamp + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeORingAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeORingUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeScrew + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRollPlug + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRCCGuardNail + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangePECoupler + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInMainISOValve + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInRegOrRegAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInMeterOrMeterAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInTF + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInGIFitting + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInRubTube + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Remarks.Replace("'", "''") + "',");
            sql.Append(BILAMCCSVData.AMCCSV_CreatedByUserID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new BILAMCCSVDataMsg(_RetVal, _RetStr);
        }

        public BILAMCCSVDataMsg UpdateBILAMCCSVData(BILAMCCSVData BILAMCCSVData, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILAMCCSVData_Update ");
            sql.Append(BILAMCCSVData.AMCCSV_ID + ",");
            sql.Append(BILAMCCSVData.AMCCSV_CenCode + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_ApplicationNo + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Date + "',");
            sql.Append(BILAMCCSVData.AMCCSV_MeterNo + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Regulator.Replace("'", "''") + "',");
            sql.Append(BILAMCCSVData.AMCCSV_Pressure + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ExtraKitchen + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ExtraBathroom + ",");
            sql.Append(BILAMCCSVData.AMCCSV_Leakage + ",");
            sql.Append(BILAMCCSVData.AMCCSV_SingleVentilation + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_HouseClosed.Replace("'", "''") + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_DCForceDC.Replace("'", "''") + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_DMLT.Replace("'", "''") + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_PHC.Replace("'", "''") + "',");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_UnSafeConn.Replace("'", "''") + "',");
            sql.Append(BILAMCCSVData.AMCCSV_MeterStop + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRubTube + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeNeoRubCap + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRubTubeClamp + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeMainISOValve + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeTF + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIElbow + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeHexNipple + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIClamp + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeORingAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeORingUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeScrew + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRollPlug + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeRCCGuardNail + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangeGIUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_ChangePECoupler + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInMainISOValve + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInRegOrRegAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInUnion + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInMeterOrMeterAdapter + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInTF + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInGIFitting + ",");
            sql.Append(BILAMCCSVData.AMCCSV_LeakageInRubTube + ",");
            sql.Append("N'" + BILAMCCSVData.AMCCSV_Remarks.Replace("'", "''") + "',");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new BILAMCCSVDataMsg(_RetVal, _RetStr);
        }

        public BILAMCCSVDataMsg DeleteBILAMCCSVData(int BILAMCCSVDataID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_BILAMCCSVData_Delete " + BILAMCCSVDataID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new BILAMCCSVDataMsg(_RetVal, _RetStr);
        }
    }
}

