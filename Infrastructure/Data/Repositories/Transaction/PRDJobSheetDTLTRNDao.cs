using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class PRDJobSheetDTLTRNDao : IPRDJobSheetDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDJobSheetDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDJobSheetDTLTRNList> GetPRDJobSheetDTLTRNs(int JOBDTL_JobsheetId)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetDTLTRN_SelectAll " + JOBDTL_JobsheetId);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            IList<PRDJobSheetDTLTRNList> list = new List<PRDJobSheetDTLTRNList>();

            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {
                    int JOBDTL_MaterialID = int.Parse(row["JOBDTL_MaterialID"].ToString());
                    string MaterialName = row["MaterialName"].ToString();
                    string ConnectionType = row["ConnectionType"].ToString();
                    int JOBDTL_ConnType = int.Parse(row["JOBDTL_ConnType"].ToString());
                    decimal JOBDTL_PipeLength = decimal.Parse(row["JOBDTL_PipeLength"].ToString());
                    string ExtraConnType = row["ExtraConnType"].ToString();
                    int JOBDTL_ExtraConnType = int.Parse(row["JOBDTL_ExtraConnType"].ToString());
                    int JOBDTL_NoOfExtConn = int.Parse(row["JOBDTL_NoOfExtConn"].ToString());

                    list.Add(new PRDJobSheetDTLTRNList(JOBDTL_MaterialID, MaterialName, ConnectionType, JOBDTL_ConnType, JOBDTL_PipeLength, ExtraConnType, JOBDTL_ExtraConnType, JOBDTL_NoOfExtConn));
                }
            }
            return list;
        }
        public IList<PRDExtraConnectionReqList> GetPrdAppworkordersEdit()
        {
            string sortExpression = "EXCDTL_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRExtraConnectionReqDTLTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDExtraConnectionReqList> GetPRExtraConnectionReqDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_PRDExtraConnectionRequestForJobsheet_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'EXCDTL_ID',");
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
            int count2 = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDExtraConnectionReqList> list = new List<PRDExtraConnectionReqList>();
            foreach (DataRow row in dtList.Rows)
            {

                int EXCDTL_ID = int.Parse(row["EXCDTL_ID"].ToString());
                int EXCDTL_EConnID = int.Parse(row["EXCDTL_EConnID"].ToString());
                string CD_ControlType = row["CD_ControlType"].ToString();
                int EXCDTL_NoOfConnection = int.Parse(row["EXCDTL_NoOfConnection"].ToString());
                decimal EXCDTL_Amount = decimal.Parse(row["EXCDTL_Amount"].ToString());


                list.Add(new PRDExtraConnectionReqList(EXCDTL_ID, EXCDTL_EConnID, CD_ControlType, EXCDTL_NoOfConnection, EXCDTL_Amount, count2));
            }
            return list;
        }
        public IList<PRDJobSheetExtraDTLTRNList> GetPRDJobSheetExtraDTLTRNs(int JOBDTL_JobsheetId, int WorkOrderType)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetDTLTRNforExtraConnection_SelectAll " + JOBDTL_JobsheetId + "," + WorkOrderType);
            //String Building for Order by Column.

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            IList<PRDJobSheetExtraDTLTRNList> list = new List<PRDJobSheetExtraDTLTRNList>();

            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {
                    string ExtraConnectionType = row["ExtraConnectionType"].ToString();
                    int JOBDTL_ExtraConnType = int.Parse(row["JOBDTL_ExtraConnType"].ToString());
                    int JOBDTL_NoOfExtConn = int.Parse(row["JOBDTL_NoOfExtConn"].ToString());

                    list.Add(new PRDJobSheetExtraDTLTRNList(ExtraConnectionType, JOBDTL_ExtraConnType, JOBDTL_NoOfExtConn));

                }
            }
            return list;
        }
        public PRDJobSheetDTLTRN GetPRDJobSheetDTLTRN(int PRDJobSheetDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetDTLTRN_Select " + PRDJobSheetDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int JOBDTL_ID = Convert.ToInt32(row["JOBDTL_ID"]);
            int JOBDTL_JobsheetId = Convert.ToInt32(row["JOBDTL_JobsheetId"]);
            int JOBDTL_NoOfExtConn = Convert.ToInt32(row["JOBDTL_NoOfExtConn"]);
            int JOBDTL_MaterialID = Convert.ToInt32(row["JOBDTL_MaterialID"]);
            decimal JOBDTL_PipeLength = Convert.ToDecimal(row["JOBDTL_PipeLength"]);
            int JOBDTL_ConnType = Convert.ToInt32(row["JOBDTL_ConnType"]);
            int JOBDTL_ExtraConnType = Convert.ToInt32(row["JOBDTL_ExtraConnType"]);

            #endregion

            return new
            PRDJobSheetDTLTRN(JOBDTL_ID, JOBDTL_JobsheetId, JOBDTL_NoOfExtConn, JOBDTL_MaterialID, JOBDTL_PipeLength, JOBDTL_ConnType, JOBDTL_ExtraConnType);
        }

        public PRDJobSheetDTLTRNMsg InsertPRDJobSheetDTLTRN(PRDJobSheetDTLTRN PRDJobSheetDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDJobSheetDTLTRN_Insert ");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_JobsheetId + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_NoOfExtConn + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_MaterialID + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_PipeLength + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ConnType + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ExtraConnType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDJobSheetDTLTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetDTLTRNMsg UpdatePRDJobSheetDTLTRN(PRDJobSheetDTLTRN PRDJobSheetDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_PRDJobSheetDTLTRN_Update ");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_JobsheetId + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_NoOfExtConn + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_MaterialID + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ConnType + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ExtraConnType + ",");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new PRDJobSheetDTLTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetDTLTRNMsg DeletePRDJobSheetDTLTRN(int PRDJobSheetDTLTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC Transaction_PRDJobSheetDTLTRN_Delete " + PRDJobSheetDTLTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetVal"]);

            #endregion

            return new PRDJobSheetDTLTRNMsg(_RetVal, _RetStr);
        }

        public PRDJobSheetDTLTRNMsg InsertPRDJobSheetDTLTRN_ForCSVUpload(PRDJobSheetDTLTRN PRDJobSheetDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC [USP_PRDJobSheetDTLTRN_Insert_ForCSVUpload] ");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_JobsheetId + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_NoOfExtConn + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_MaterialID + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_PipeLength + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ConnType + ",");
            sql.Append(PRDJobSheetDTLTRN.JOBDTL_ExtraConnType);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDJobSheetDTLTRNMsg(_RetVal, _RetStr);
        }
        public IList<PRDJobSheetDTLTRNForAS> GetPRDJobSheetDTLTRNForAS(decimal CORApplicationMasterid)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC usp_JobDetailForAdvSearch " + CORApplicationMasterid);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            IList<PRDJobSheetDTLTRNForAS> list = new List<PRDJobSheetDTLTRNForAS>();
            if (ds.Tables.Count > 0)
            {
                DataTable dtList = ds.Tables[0];
                foreach (DataRow row in dtList.Rows)
                {
                    string Typeofconnection = Convert.ToString(row["Typeofconnection"]);
                    string JOBDTL_NoOfExtConn = Convert.ToString(row["JOBDTL_ExtraConnType"]);
                    string JOBDTL_PipeLength = Convert.ToString(row["JOBDTL_PipeLength"]);
                    int JOBDTL_JobsheetId = Convert.ToInt32(row["JOBDTL_JobsheetId"]);
                    list.Add(new PRDJobSheetDTLTRNForAS(Typeofconnection, JOBDTL_NoOfExtConn, JOBDTL_PipeLength, JOBDTL_JobsheetId));

                }
            }
            return list;



        }

    }
}
