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
    public class PRDExConnReqFormDTLTRNDao : IPRDExConnReqFormDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDExConnReqFormDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDExConnReqFormDTLTRNList> GetPRDExConnReqFormDTLTRNs()
        {
            string sortExpression = "EXCDTL_ID";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetPRDExConnReqFormDTLTRNs(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<PRDExConnReqFormDTLTRNList> GetPRDExConnReqFormDTLTRNs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRN_SelectAll ");
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
            int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDExConnReqFormDTLTRNList> list = new List<PRDExConnReqFormDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public PRDExConnReqFormDTLTRN GetPRDExConnReqFormDTLTRN(int PRDExConnReqFormDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRN_Select " + PRDExConnReqFormDTLTRNid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int EXCDTL_ID = Convert.ToInt32(row["EXCDTL_ID"].ToString());
            int EXCDTL_EConnID = Convert.ToInt32(row["EXCDTL_EConnID"].ToString());
            int EXCDTL_ConnType = Convert.ToInt32(row["EXCDTL_ConnType"].ToString());
            int EXCDTL_NoOfConnection = Convert.ToInt32(row["EXCDTL_NoOfConnection"].ToString());
            decimal EXCDTL_Amount = Convert.ToDecimal(row["TEDMST_Amount"].ToString());

            #endregion

            return new
            PRDExConnReqFormDTLTRN(EXCDTL_ID, EXCDTL_EConnID, EXCDTL_ConnType, EXCDTL_NoOfConnection, EXCDTL_Amount);
        }


        public IList<PRDExConnReqFormDTLTRNList_DetailGrid> GetPRDExConnReqFormDTLTRNList_DetailGrid(string TARMST_StartDate, int TARMST_TariffFor, int TPDMST_PlanID, int CenterCode, int ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRNList_DetailGrid '" + TARMST_StartDate + "'" + ',' + TARMST_TariffFor + ',' + TPDMST_PlanID + ',' + CenterCode + ',' + ApplicationID);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDExConnReqFormDTLTRNList_DetailGrid> list = new List<PRDExConnReqFormDTLTRNList_DetailGrid>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"
                int EXCHDR_EConnID = Convert.ToInt32(row["EXCHDR_EConnID"].ToString());
                int EXCDTL_ID = Convert.ToInt32(row["EXCDTL_ID"].ToString());
                string CD_ControlType = row["CD_ControlType"].ToString();
                int EXCDTL_NoOfConnection = Convert.ToInt32(row["EXCDTL_NoOfConnection"].ToString());
                decimal TEDMST_Amount = Convert.ToDecimal(row["TEDMST_Amount"]);
                int TEDMST_ExtraConnTypeID = Convert.ToInt32(row["TEDMST_ExtraConnTypeID"].ToString());
                int CD_ControlID = Convert.ToInt32(row["CD_ControlID"].ToString());

                list.Add(new PRDExConnReqFormDTLTRNList_DetailGrid(EXCHDR_EConnID, EXCDTL_ID, CD_ControlType, EXCDTL_NoOfConnection, TEDMST_Amount, TEDMST_ExtraConnTypeID, CD_ControlID));
            }
            #endregion
            return list;
        }


        //public IList<PRDExConnReqFormDTLTRNList_DetailGrid> GetPRDExConnReqFormDTLTRNList_CustomerDataGrid(int ApplicationId,int CenterCode)
        //{
        //    StringBuilder sql = new StringBuilder();
        //    sql.Append("EXEC USP_ExtraConncetionBindData " + ApplicationId + ',' + CenterCode);
        //    //DataRow row = _dbManager.GetDataRow(sql.ToString());

        //    DataSet ds = _dbManager.GetDataSet(sql.ToString());
        //    DataTable dtList = ds.Tables[0];
        //    //DataTable dtRowCount = ds.Tables[1];
        //    //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
        //    IList<PRDExConnReqFormDTLTRNList_DetailGrid> list = new List<PRDExConnReqFormDTLTRNList_DetailGrid>();
        //    foreach (DataRow row in dtList.Rows)
        //    {
        //        #region"Variables Declaration"
        //        int EXCHDR_EConnID = Convert.ToInt32(row["EXCHDR_EConnID"].ToString());
        //        int EXCDTL_ID = Convert.ToInt32(row["EXCDTL_ID"].ToString());
        //        string CD_ControlType = row["CD_ControlType"].ToString();
        //        int EXCDTL_NoOfConnection = Convert.ToInt32(row["EXCDTL_NoOfConnection"].ToString());
        //        decimal TEDMST_Amount = Convert.ToDecimal(row["EXCDTL_Amount"]);
        //        int TEDMST_ExtraConnTypeID = Convert.ToInt32(row["TEDMST_ExtraConnTypeID"].ToString());
        //        int CD_ControlID = Convert.ToInt32(row["CD_ControlID"].ToString()); 

        //        list.Add(new PRDExConnReqFormDTLTRNList_DetailGrid(EXCHDR_EConnID, EXCDTL_ID, CD_ControlType, EXCDTL_NoOfConnection, TEDMST_Amount, TEDMST_ExtraConnTypeID, CD_ControlID));
        //    }
        //        #endregion
        //    return list;
        //}


        public IList<PRDExConnReqFormDTLTRNList_DetailGrid> GetPRDExConnReqFormDTLTRNList_DetailGrid(int EXCHDR_ConnID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRNList_DetailGridEditTime " + EXCHDR_ConnID);
            //DataRow row = _dbManager.GetDataRow(sql.ToString());

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            //DataTable dtRowCount = ds.Tables[1];
            //int Count = int.Parse(dtRowCount.Rows[0][0].ToString());
            IList<PRDExConnReqFormDTLTRNList_DetailGrid> list = new List<PRDExConnReqFormDTLTRNList_DetailGrid>();
            foreach (DataRow row in dtList.Rows)
            {
                #region"Variables Declaration"

                int EXCHDR_EConnID = Convert.ToInt32(row["EXCHDR_EConnID"].ToString());
                int EXCDTL_ID = Convert.ToInt32(row["EXCDTL_ID"].ToString());
                string CD_ControlType = row["CD_ControlType"].ToString();
                int EXCDTL_NoOfConnection = Convert.ToInt32(row["EXCDTL_NoOfConnection"].ToString());
                decimal TEDMST_Amount = Convert.ToDecimal(row["TEDMST_Amount"]);
                int TEDMST_ExtraConnTypeID = Convert.ToInt32(row["TEDMST_ExtraConnTypeID"].ToString());
                int CD_ControlID = Convert.ToInt32(row["CD_ControlID"].ToString());

                list.Add(new PRDExConnReqFormDTLTRNList_DetailGrid(EXCHDR_EConnID, EXCDTL_ID, CD_ControlType, EXCDTL_NoOfConnection, TEDMST_Amount, TEDMST_ExtraConnTypeID, CD_ControlID));
            }
            #endregion
            return list;
        }
        public PRDExConnReqFormDTLTRNMsg InsertPRDExConnReqFormDTLTRN(PRDExConnReqFormDTLTRN PRDExConnReqFormDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRN_Insert ");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_EConnID + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_ConnType + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_NoOfConnection + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_Amount);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDExConnReqFormDTLTRNMsg(_RetVal, _RetStr);
        }

        public PRDExConnReqFormDTLTRNMsg UpdatePRDExConnReqFormDTLTRN(PRDExConnReqFormDTLTRN PRDExConnReqFormDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRN_Update ");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_ID + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_EConnID + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_ConnType + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_NoOfConnection + ",");
            sql.Append(PRDExConnReqFormDTLTRN.EXCDTL_Amount);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormDTLTRNMsg(_RetVal, _RetStr);
        }

        public PRDExConnReqFormDTLTRNMsg DeletePRDExConnReqFormDTLTRN(int PRDExConnReqFormDTLTRNID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDExConnReqFormDTLTRN_Delete " + PRDExConnReqFormDTLTRNID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new PRDExConnReqFormDTLTRNMsg(_RetVal, _RetStr);
        }

    }
}
