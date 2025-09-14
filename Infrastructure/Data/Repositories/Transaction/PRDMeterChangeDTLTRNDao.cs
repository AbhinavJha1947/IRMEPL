using Application.RepositoryInterfaces.Transaction;
using Core.Entities.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories.Transaction
{
    public class PRDMeterChangeDTLTRNDao : IPRDMeterChangeDTLTRNDao
    {
        private readonly DbManager _dbManager;

        public PRDMeterChangeDTLTRNDao(DbManager dbManager)
        {
            _dbManager = dbManager;
        }
        public IList<PRDMeterChangeDTLTRNList> GetPRDMeterChangeDTLTRNs(int METCHD_METCHGID, int ApplicationID)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeDTLTRN_SelectAll ");
            sql.Append(METCHD_METCHGID + ",");
            sql.Append(ApplicationID);
            DataSet ds = _dbManager.GetDataSet(sql.ToString());
            DataTable dtList = ds.Tables[0];
            IList<PRDMeterChangeDTLTRNList> list = new List<PRDMeterChangeDTLTRNList>();
            foreach (DataRow row in dtList.Rows)
            {
                int METCHD_ID = int.Parse(row["METCHD_ID"].ToString());
                Int64 METCHD_OldMeterNo = Convert.ToInt64(row["METCHD_OldMeterNo"].ToString());
                decimal PrevReading = decimal.Parse(row["PrevReading"].ToString());
                decimal METCHD_OldMeterReading = decimal.Parse(row["METCHD_OldMeterReading"].ToString());
                string Checked = (row["Checked"].ToString() == "1") ? "checked" : "";
                list.Add(new PRDMeterChangeDTLTRNList(METCHD_ID, METCHD_OldMeterNo, PrevReading, METCHD_OldMeterReading, Checked));
            }
            return list;
        }

        public PRDMeterChangeHDRTRNMsg InsertPRDMeterChangeDTLTRN(PRDMeterChangeDTLTRN PRDMeterChangeDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("EXEC USP_PRDMeterChangeDTLTRN_Insert ");
            sql.Append(PRDMeterChangeDTLTRN.METCHD_ID + ",");
            sql.Append(PRDMeterChangeDTLTRN.METCHD_METCHGID + ",");
            sql.Append(PRDMeterChangeDTLTRN.METCHD_OldMeterNo + ",");
            sql.Append(PRDMeterChangeDTLTRN.METCHD_OldMeterReading + ",");
            sql.Append(PRDMeterChangeDTLTRN.METCHG_ApplicationId + ",");
            sql.Append("N'" + PRDMeterChangeDTLTRN.METCHG_ReplaceDate + "'");
            DataRow row = _dbManager.GetDataRow(sql.ToString(), ref objCon, ref trn);
            #region"Variables Declaration"

            int _RetVal = Convert.ToInt32(row["RetVal"]);
            string _RetStr = Convert.ToString(row["RetStr"]);
            #endregion

            return new PRDMeterChangeHDRTRNMsg(_RetVal, _RetStr);
        }
    }
}

