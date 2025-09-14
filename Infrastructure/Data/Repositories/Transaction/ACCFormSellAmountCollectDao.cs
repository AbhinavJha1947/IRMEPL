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
    public class ACCFormSellAmountCollectDao : IACCFormSellAmountCollectDao
    {
        private readonly DbManager _dbManager;

        public ACCFormSellAmountCollectDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<ACCFormSellAmountCollectList> GetACCFormSellAmountCollects()
        {
            string sortExpression = "FSAC_Srno";
            string sortType = "ASC";
            int pageIndex = 0;
            int pageSize = -1;
            string criteria = "";
            return GetACCFormSellAmountCollects(sortExpression, sortType, pageIndex, pageSize, criteria);
        }

        public IList<ACCFormSellAmountCollectList> GetACCFormSellAmountCollects(string sortExpression, string sortType, int pageIndex, int pageSize, string criteria)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCFormSellAmountCollect_SelectAll ");
            //String Building for Order by Column.
            if (String.IsNullOrEmpty(sortExpression) == true)
            {
                sql.Append("'FSAC_Srno',");
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
            IList<ACCFormSellAmountCollectList> list = new List<ACCFormSellAmountCollectList>();
            foreach (DataRow row in dtList.Rows)
            {
                int FSAC_Srno = int.Parse(row["FSAC_Srno"].ToString());
                string FSAC_Date = row["FSAC_Date"].ToString();
                int FSAC_NoofForm = int.Parse(row["FSAC_NoofForm"].ToString());
                decimal FSAC_Amount = decimal.Parse(row["FSAC_Amount"].ToString());

                list.Add(new ACCFormSellAmountCollectList(FSAC_Srno, FSAC_Date, FSAC_NoofForm, FSAC_Amount, Count));
                //***Please write field names which you wants to display in grid.***
            }
            return list;
        }

        public ACCFormSellAmountCollect GetACCFormSellAmountCollect(int ACCFormSellAmountCollectid, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCFormSellAmountCollect_Select " + ACCFormSellAmountCollectid);
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"
            int FSAC_Srno = Convert.ToInt32(row["FSAC_Srno"]);
            string FSAC_Date = Convert.ToString(row["FSAC_Date"]);
            int FSAC_NoofForm = Convert.ToInt32(row["FSAC_NoofForm"]);
            decimal FSAC_Amount = Convert.ToDecimal(row["FSAC_Amount"]);
            int FSAC_CenCode = Convert.ToInt32(row["FSAC_CenCode"]);
            int FSAC_Createdby = Convert.ToInt32(row["FSAC_Createdby"]);
            string FSAC_CreatedDate = Convert.ToString(row["FSAC_CreatedDate"]);
            int FSAC_Updatedby = Convert.ToInt32(row["FSAC_Updatedby"]);
            string FSAC_UpdatedDate = Convert.ToString(row["FSAC_UpdatedDate"]);

            #endregion

            return new
            ACCFormSellAmountCollect(FSAC_Srno, FSAC_Date, FSAC_NoofForm, FSAC_Amount, FSAC_CenCode, FSAC_Createdby, FSAC_CreatedDate, FSAC_Updatedby, FSAC_UpdatedDate);
        }

        public ACCFormSellAmountCollectMsg InsertACCFormSellAmountCollect(ACCFormSellAmountCollect ACCFormSellAmountCollect, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCFormSellAmountCollect_Insert ");
            sql.Append("N'" + ACCFormSellAmountCollect.FSAC_Date + "',");
            sql.Append(ACCFormSellAmountCollect.FSAC_NoofForm + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_Amount + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_CenCode + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_Createdby + ",");
            sql.Append("N'" + ACCFormSellAmountCollect.FSAC_CreatedDate + "',");
            sql.Append(ACCFormSellAmountCollect.FSAC_Updatedby + ",");
            sql.Append("N'" + ACCFormSellAmountCollect.FSAC_UpdatedDate + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new ACCFormSellAmountCollectMsg(_RetVal, _RetStr);
        }

        public ACCFormSellAmountCollectMsg UpdateACCFormSellAmountCollect(ACCFormSellAmountCollect ACCFormSellAmountCollect, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCFormSellAmountCollect_Update ");
            sql.Append(ACCFormSellAmountCollect.FSAC_Srno + ",");
            sql.Append("N'" + ACCFormSellAmountCollect.FSAC_Date + "',");
            sql.Append(ACCFormSellAmountCollect.FSAC_NoofForm + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_Amount + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_CenCode + ",");
            sql.Append(ACCFormSellAmountCollect.FSAC_Createdby + ",");
            //sql.Append("N'"+ACCFormSellAmountCollect.FSAC_CreatedDate+"',");
            sql.Append(ACCFormSellAmountCollect.FSAC_Updatedby);
            //sql.Append("N'"+ACCFormSellAmountCollect.FSAC_UpdatedDate+"'");
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCFormSellAmountCollectMsg(_RetVal, _RetStr);
        }

        public ACCFormSellAmountCollectMsg DeleteACCFormSellAmountCollect(int ACCFormSellAmountCollectID, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_ACCFormSellAmountCollect_Delete " + ACCFormSellAmountCollectID);
            DataRow row = _dbManager.GetDataRow(sql.ToString());

            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);

            #endregion

            return new ACCFormSellAmountCollectMsg(_RetVal, _RetStr);
        }
    }
}
