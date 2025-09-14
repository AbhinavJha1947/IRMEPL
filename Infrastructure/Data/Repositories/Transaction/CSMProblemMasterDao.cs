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
    public class CSMProblemMasterDao : ICSMProblemMasterDao
    {
        private readonly DbManager _dbManager;

        public CSMProblemMasterDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<CSMProblemMasterList> GetCSMProblemMasters()
        {
            string sortExpression = "PROMST_ProblemId";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetCSMProblemMasters(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<CSMProblemMasterList> GetCSMProblemMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMProblemMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'PROMST_ProblemId',");
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
            IList<CSMProblemMasterList> list = new List<CSMProblemMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int PROMST_ProblemId = int.Parse(row["PROMST_ProblemId"].ToString());
                string PROMST_Description = row["PROMST_Description"].ToString();
                string ProblemType = row["ProblemType"].ToString();
                string Priority = row["Priority"].ToString();
                string ClosedBefore = row["ClosedBefore"].ToString();
                list.Add(new CSMProblemMasterList(PROMST_ProblemId, PROMST_Description, ProblemType, Priority, ClosedBefore, Count));
            }
            return list;
        }

        public CSMProblemMaster GetCSMProblemMaster(int CSMProblemMasterid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMProblemMaster_Select " + CSMProblemMasterid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int PROMST_ProblemId = Convert.ToInt32(row["PROMST_ProblemId"]);
            string PROMST_Description = Convert.ToString(row["PROMST_Description"]);
            int PROMST_ProblemType = Convert.ToInt32(row["PROMST_ProblemType"]);
            int PROMST_Priority = Convert.ToInt32(row["PROMST_Priority"]);
            int PROMST_ClosedBefore = Convert.ToInt32(row["PROMST_ClosedBefore"]);
            int PROMST_UserId = Convert.ToInt32(row["PROMST_UserId"]);
            long PROMST_RowVersion = (long)row["PROMST_RowVersion"];
            #endregion

            return new
            CSMProblemMaster(PROMST_ProblemId, PROMST_Description, PROMST_ProblemType, PROMST_Priority, PROMST_ClosedBefore, PROMST_UserId, PROMST_RowVersion);
        }

        public CSMProblemMasterMsg InsertCSMProblemMaster(CSMProblemMaster CSMProblemMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMProblemMaster_Insert ");
            sql.Append("N'" + CSMProblemMaster.PROMST_Description + "',");
            sql.Append(CSMProblemMaster.PROMST_ProblemType + ",");
            sql.Append(CSMProblemMaster.PROMST_Priority + ",");
            sql.Append(CSMProblemMaster.PROMST_ClosedBefore + ",");
            sql.Append(CSMProblemMaster.PROMST_UserId);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMProblemMasterMsg(_RetVal, _RetStr);
        }

        public CSMProblemMasterMsg UpdateCSMProblemMaster(CSMProblemMaster CSMProblemMaster, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMProblemMaster_Update ");
            sql.Append(CSMProblemMaster.PROMST_ProblemId + ",");
            sql.Append("N'" + CSMProblemMaster.PROMST_Description + "',");
            sql.Append(CSMProblemMaster.PROMST_ProblemType + ",");
            sql.Append(CSMProblemMaster.PROMST_Priority + ",");
            sql.Append(CSMProblemMaster.PROMST_ClosedBefore + ",");
            sql.Append(CSMProblemMaster.PROMST_UserId + ",");
            sql.Append(CSMProblemMaster.PROMST_RowVersion);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMProblemMasterMsg(_RetVal, _RetStr);
        }

        public CSMEscalationMatrixMsg UpdateCSMEscalationMatrix(CSMEscalationMatrix CSMEscalationMatrix, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMEscalationMatrixMaster_Update ");
            sql.Append(CSMEscalationMatrix.EM_ID + ",");
            sql.Append("N'" + CSMEscalationMatrix.EM_ComplainCategory + "',");
            sql.Append(CSMEscalationMatrix.EM_ComplianType + ",");
            sql.Append(CSMEscalationMatrix.EM_Level + ",");
            sql.Append(CSMEscalationMatrix.EM_SLA + ",");
            sql.Append(CSMEscalationMatrix.EM_AssignUser + ",");
            //sql.Append(CSMEscalationMatrix.EM_UpdatedByID + ",");
            sql.Append(CSMEscalationMatrix.EM_RowStatus);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMEscalationMatrixMsg(_RetVal, _RetStr);
        }


        public CSMProblemMasterMsg DeleteCSMProblemMaster(int CSMProblemMasterID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMProblemMaster_Delete " + CSMProblemMasterID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMProblemMasterMsg(_RetVal, _RetStr);
        }


        public CSMEscalationMatrixMsg InsertCSMEscalationMatrix(CSMEscalationMatrix CSMEscalationMatrix, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMEscalationMatrixMaster_Insert ");
            sql.Append(CSMEscalationMatrix.EM_ComplainCategory + ",");
            sql.Append(CSMEscalationMatrix.EM_ComplianType + ",");
            sql.Append(CSMEscalationMatrix.EM_Level + ",");
            sql.Append(CSMEscalationMatrix.EM_SLA + ",");
            sql.Append(CSMEscalationMatrix.EM_AssignUser + ",");
            sql.Append(CSMEscalationMatrix.EM_CreatedByID);

            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new CSMEscalationMatrixMsg(_RetVal, _RetStr);
        }

        public IList<CSMEscalationMatrixList> GetCSMEscalationMatrixs(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMEscalationMatrixMaster_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'EM_ComplainCategory',");
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
            IList<CSMEscalationMatrixList> list = new List<CSMEscalationMatrixList>();
            foreach (DataRow row in dtList.Rows)
            {
                int EM_ID = int.Parse(row["EM_ID"].ToString());
                string EM_ComplainCategory = row["EM_ComplainCategory"].ToString();
                string EM_ComplianType = row["EM_ComplianType"].ToString();
                string EM_Level = row["EM_Level"].ToString();
                string EM_SLA = row["EM_SLA"].ToString();
                string EM_AssignUser = row["EM_AssignUser"].ToString();
                string EM_RowStatus = row["EM_RowStatus"].ToString();
                string EM_CreatedDate = row["EM_CreatedDate"].ToString();
                list.Add(new CSMEscalationMatrixList(EM_ID, EM_ComplainCategory, EM_ComplianType, EM_Level, EM_SLA, EM_AssignUser, EM_RowStatus, EM_CreatedDate, Count));
            }
            return list;
        }

        public CSMEscalationMatrix GetCSMEscalationMatrix(int CSMEscalationMatrixid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMEscalationMatrixMaster_Select " + CSMEscalationMatrixid);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"
            int EM_ID = Convert.ToInt32(row["EM_ID"]);
            int EM_ComplainCategory = Convert.ToInt32(row["EM_ComplainCategory"]);
            int EM_ComplianType = Convert.ToInt32(row["EM_ComplianType"]);
            int EM_Level = Convert.ToInt32(row["EM_Level"]);
            int EM_SLA = Convert.ToInt32(row["EM_SLA"]);
            int EM_AssignUser = Convert.ToInt32(row["EM_AssignUser"]);
            //long EM_RowStatus = (long)row["EM_RowVersion"];
            int EM_RowStatus = Convert.ToInt32(row["EM_RowStatus"]);
            int EM_CreatedByID = Convert.ToInt32(row["EM_CreatedByID"]);
            string EM_CreatedDate = Convert.ToString(row["EM_CreatedDate"]);
            #endregion

            return new
            CSMEscalationMatrix(EM_ID, EM_ComplainCategory, EM_ComplianType, EM_Level, EM_SLA, EM_AssignUser, EM_RowStatus, EM_CreatedByID, EM_CreatedDate);
        }


        public CSMEscalationMatrixMsg DeleteCSMEscalationMatrix(int EM_ID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_CSMEscalationMatrixMaster_Delete " + EM_ID);
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new CSMEscalationMatrixMsg(_RetVal, _RetStr);
        }

        public IList<CSMSlaMasterList> GetSlaMasters(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("USP_CSMSlaMaster_SelectAll ");

            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'CSMSLA_Id',");
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

            //String Building for Page Size
            sql.Append(pageSize + ",'");

            //String Building for For Count.
            sql.Append(criteria + "'");

            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            DataTable dtRowCount = ds.Tables[1];
            int Controlcount = int.Parse(dtRowCount.Rows[0][0].ToString());

            IList<CSMSlaMasterList> list = new List<CSMSlaMasterList>();
            foreach (DataRow row in dtList.Rows)
            {
                int CSMSLA_Id = int.Parse(row["CSMSLA_Id"].ToString());
                int CSMSLA_Value = int.Parse(row["CSMSLA_Value"].ToString());
                string CSMSLA_Type = row["CSMSLA_Type"].ToString();

                //decimal ITMRTD_Rate =decimal.Parse(row["ITMRTD_Rate"].ToString());

                list.Add(new CSMSlaMasterList(CSMSLA_Id, CSMSLA_Value, CSMSLA_Type, Controlcount));
            }
            return list;
        }

    }
}
