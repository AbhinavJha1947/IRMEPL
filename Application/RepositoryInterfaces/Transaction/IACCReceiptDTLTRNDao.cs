using Core.Entities.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces.Transaction
{
    public interface IACCReceiptDTLTRNDao
    {
        public IList<ACCReceiptDTLTRNList> GetACCReceiptDTLTRNs(decimal RECDTL_ReceiptNo, int receipttype, decimal Applicationid, int corporate);

        public ACCReceiptDTLTRN GetACCReceiptDTLTRN(decimal ACCReceiptDTLTRNid, ref SqlConnection objCon, ref SqlTransaction trn);
        public ACCReceiptHDRTRNMsg InsertACCReceiptDTLTRN(ACCReceiptDTLTRN ACCReceiptDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn);

        public ACCReceiptHDRTRNMsg InsertACCReceiptDTLTRN_ForCSVUpload(ACCReceiptDTLTRN ACCReceiptDTLTRN, ref SqlConnection objCon, ref SqlTransaction trn);

    }
}
