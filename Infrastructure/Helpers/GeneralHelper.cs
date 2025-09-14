using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;

namespace Infrastructure.Helpers
{
    public class GeneralHelper
    {
        private readonly string _connectionString;
        private readonly ILogger<ClsTransaction> _logger;
        private readonly IConfiguration _configuration;
        public string strReceiptObj = "No Need To save as Receipt Amount is ZERO";
        public string strStudentSave = "Student Record Saved;Serial No: ";
        public string strBalance = "Old Balance Of Last Academic Year";
        public string strRegIncorrect = "Incorrect Reg No/Serial No,PLEASE CHECK";
        public string strNotAdmitted = "Student Not Granted Admission";
        public string strRegGenerated = "Registration Numbers Generated Successfully";
        public string strEffectiveDate = "Record(s) Cannot be Edited as Effective Date Already Passed";
        public string strException = "There is some system problem.";
        public string strRecordExist = "Record already exist.";
        public string strRecordUpdated = "Record Updated successfully.";
        public string strRecordAdded = "Record Added successfully.";
        public string strRecordDeleted = "Record Deleted successfully.";
        public string strSelect = "Student Not Admitted ,No Need To Save";
        public string strRecordUsed = "Record can not be deleted as dependent record(s) exists/ deleted.";
        public string strEXEERROR = "Please select valid file type.";
        public string strHttpEx = "Please check your internet connection.";
        public string strMailSent = "Message(s) sent successfully.";
        public string strRecNoFound = "Record Not Found.";

        public string SiteTitle { get; set; }
        public string JobsheetImagePath_LocalPC { get; set; }
        public string MsgBlank { get; set; }
        public string MsgNumber { get; set; }
        public string MsgValidAlpha { get; set; }
        public string MsgValidAlphaNum { get; set; }
        public string MsgValidFloat { get; set; }
        public string MsgLowValue { get; set; }
        public string MsgHighValue { get; set; }
        public string MsgCustomFormat { get; set; }
        public string MsgDecFormat { get; set; }
        public string MsgValidEmail { get; set; }
        public string MsgDateCompare { get; set; }
        public string rptUser { get; set; }
        public string rptPwd { get; set; }
        public string rptDSN { get; set; }
        public string rptDB { get; set; }
        public string rptVerifyDatabase { get; set; }
        public string FileLoad { get; set; }
        public string AppDBOnSameServer { get; set; }
        public string FileUploadSharedFolderName { get; set; }
        public string RptLocation = "','','location=0,alwaysRaised=1,maximize=1, toolbar=0,titlebar=0,statusbar=0, directories=0, status=yes, menubar=0, scrollbars=1,resizable=0, height=680,width=1015, left=0, top=0'";

        private readonly Random objRandom = new Random(((int)((DateTime.Now.Ticks % int.MaxValue))));
        public static GeneralHelper objGeneral;
        public GeneralHelper()
        {
        }
        public GeneralHelper(IConfiguration configuration, ILogger<ClsTransaction> logger)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public GeneralHelper(string connectionString)
        {
            _connectionString = connectionString;
        }

        public static GeneralHelper CheckInstance()
        {
            try
            {
                if (objGeneral == null)
                {
                    objGeneral = new GeneralHelper();
                }
                return objGeneral;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CheckNullText(object value)
        {
            try
            {
                if (value == DBNull.Value || Convert.ToString(value) == "")
                {
                    return null;
                }
                else
                {
                    return Convert.ToString(value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CheckActiveInactive(object value)
        {
            try
            {
                if (string.IsNullOrEmpty(Convert.ToString(value)) || Convert.ToString(value).ToLower() == "inactive")
                {
                    return "<i class='inactive-dot fa fa-circle'></i> Inactive";
                }
                else
                {
                    return "<i class='active-dot fa fa-circle'></i> Active";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CheckBrowser(string userAgent)
        {
            try
            {
                if (userAgent.Contains("Trident") || userAgent.Contains("MSIE"))
                    return "IE";
                if (userAgent.Contains("Edg"))
                    return "Edge";
                if (userAgent.Contains("Chrome"))
                    return "Chrome";
                if (userAgent.Contains("Firefox"))
                    return "Firefox";
                if (userAgent.Contains("Safari"))
                    return "Safari";

                return "Unknown";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void FindControlRecursive1()
        {
            try
            {
                // Method body removed as it was WebForms specific
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetStyle(string userAgent)
        {
            try
            {
                if (CheckBrowser(userAgent) == "IE")
                {
                    return "height:17px";
                }
                else
                {
                    return "height:0px";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetReturnStringFromProc(string commandText)
        {
            try
            {
                string iresult;
                using var cmd = new SqlCommand();
                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                iresult = Convert.ToString(cmd.ExecuteScalar());
                return iresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string File_Uploadnew(Stream fileStream, string fileName, string strDPath)
        {
            if (fileStream == null || fileStream.Length == 0)
                return "No file selected";

            string strFileName;
            string strActualPath;
            string ext;

            ext = Path.GetExtension(fileName).ToUpper().Substring(1);

            if (ext != "DOC" && ext != "JPG" && ext != "GIF" && ext != "PPS" && ext != "PDF" &&
                ext != "PEG" && ext != "TXT" && ext != "XLS" && ext != "RAR" && ext != "MSI" &&
                ext != "EXE" && ext != "HTM" && ext != "PPT" && ext != "ZIP" && ext != "CSV" && ext != "DOCX" && ext != "XLSX")
            {
                return "EXTERROR";
            }

            strFileName = Path.GetFileName(fileName);
            strFileName = strFileName.Replace(" ", "_");
            strActualPath = Path.Combine(strDPath, strFileName);

            try
            {
                if (File.Exists(strActualPath))
                {
                    strFileName = $"({DateTime.Now.ToString("dd-MMM-yyyy,hh:mm:ss").Replace(":", "")}){strFileName}";
                    strActualPath = Path.Combine(strDPath, strFileName);
                }

                Directory.CreateDirectory(strDPath);
                using (var stream = new FileStream(strActualPath, FileMode.Create))
                {
                    fileStream.CopyTo(stream);
                }
                return strFileName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string GetReturnStringFromProcWithTran(string commandText, SqlConnection con, SqlTransaction s)
        {
            try
            {
                string iresult;
                using var cmd = new SqlCommand();
                cmd.Transaction = s;
                cmd.CommandText = commandText;
                cmd.Connection = con;
                iresult = Convert.ToString(cmd.ExecuteScalar());
                return iresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExecProc(string commandText)
        {
            try
            {
                using var cmd = new SqlCommand();
                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string CheckNull(object value)
        {
            try
            {
                if (value == DBNull.Value || Convert.ToString(value) == "")
                {
                    return "&nbsp;";
                }
                else
                {
                    return Convert.ToString(value);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool ConvertStringToBool(object value)
        {
            try
            {
                if (Convert.ToString(value).ToLower() == "true")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Connection()
        {
            // Method kept for compatibility
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public DataSet GetReturnDatasetFromProc(string commandText)
        {
            try
            {
                using var cmd = new SqlCommand();
                using var objDtAdap = new SqlDataAdapter(cmd);
                var objDtSet = new DataSet();

                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                objDtAdap.Fill(objDtSet);
                return objDtSet;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable GetReturnDataTableFromProc(string commandText)
        {
            try
            {
                using var cmd = new SqlCommand();
                using var objDtAdap = new SqlDataAdapter(cmd);
                var objDt = new DataTable();

                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                objDtAdap.Fill(objDt);
                return objDt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public long GetReturnFromProc(string commandText)
        {
            try
            {
                long iresult;
                using var cmd = new SqlCommand();
                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                iresult = Convert.ToInt64(cmd.ExecuteScalar());
                return iresult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool GetReturnStatusFromProc(string commandText)
        {
            try
            {
                using var cmd = new SqlCommand();
                using var objDtAdap = new SqlDataAdapter(cmd);
                var objDtSet = new DataSet();

                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

                objDtAdap.Fill(objDtSet);
                foreach (DataTable DT in objDtSet.Tables)
                {
                    if (DT.Columns[0].ColumnName == "STATUS")
                        if (DT.Rows[0]["STATUS"].ToString() == "T")
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SqlDataReader GetReaderFromProc(string commandText)
        {
            try
            {
                var cmd = new SqlCommand();
                cmd.CommandText = commandText;
                cmd.Connection = GetConnection();
                cmd.Connection.Open();
                var result = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Note: WebForms binding methods removed as they are not applicable in MVC
        // Replace with data retrieval methods and bind in controllers/views

        public void GetPriviledge(int userId, string pageName, object sessionProvider)
        {
            try
            {
                // This method would need to be adapted based on your session management strategy in MVC
                // Example implementation - you'll need to modify based on your session handling
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunShowException(string strEx)
        {
            return strEx.Replace("'", "`").Replace(Environment.NewLine, " ");
        }

        public string FunEdit(List<Dictionary<string, object>> dataItems, string codeField, bool blnIsVarchar = false)
        {
            try
            {
                string strcode = "";

                foreach (var item in dataItems)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        if (blnIsVarchar)
                        {
                            strcode += "'" + item[codeField].ToString() + "',";
                        }
                        else
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                    return "0";

                return strcode.Substring(0, strcode.Length - 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunEditForMultiItem(List<Dictionary<string, object>> dataItems, string codeField, bool blnIsVarchar)
        {
            try
            {
                string strcode = "";

                foreach (var item in dataItems)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        if (blnIsVarchar)
                        {
                            strcode += "'" + item[codeField].ToString() + "',";
                        }
                        else
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                    return "";

                return strcode.Substring(0, strcode.Length - 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Dictionary<string, object> GetClearedFormData(Dictionary<string, object> formData, string omitField = "")
        {
            try
            {
                var clearedData = new Dictionary<string, object>();

                foreach (var item in formData)
                {
                    if (omitField.ToUpper() != item.Key.ToUpper())
                    {
                        // Set default values based on expected type
                        if (item.Value is string)
                            clearedData[item.Key] = "";
                        else if (item.Value is bool)
                            clearedData[item.Key] = false;
                        else if (item.Value is int || item.Value is decimal)
                            clearedData[item.Key] = 0;
                        else
                            clearedData[item.Key] = null;
                    }
                    else
                    {
                        clearedData[item.Key] = item.Value;
                    }
                }

                return clearedData;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Utility method to populate object from form data
        public void FillObjectFromData<T>(T targetObject, Dictionary<string, object> formData) where T : class
        {
            try
            {
                var properties = typeof(T).GetProperties();

                foreach (var property in properties)
                {
                    if (formData.ContainsKey(property.Name) && property.CanWrite)
                    {
                        var value = formData[property.Name];
                        if (value != null && value != DBNull.Value)
                        {
                            property.SetValue(targetObject, Convert.ChangeType(value, property.PropertyType));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        // Export methods refactored for ASP.NET Core MVC
        public byte[] ExportToExcel(string fileName, string commandText)
        {
            try
            {
                var dataset = GetReturnDatasetFromProc(commandText);
                var dataView = dataset.Tables[0].DefaultView;

                string exportContent = ConvertDataViewToString(dataView, "", "\t");
                var encoding = new System.Text.UnicodeEncoding();
                return encoding.GetBytes(exportContent);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] ExportToExcelFromDataTable(string fileName, DataTable dataTable)
        {
            try
            {
                fileName += " " + DateTime.Now.ToString("ddMMMyyyyhhmmss");

                var htmlBuilder = new StringBuilder();
                htmlBuilder.Append("<!DOCTYPE HTML PUBLIC \"-//W3C//DTD HTML 4.0 Transitional//EN\">");
                htmlBuilder.Append("<font style='font-size:10.0pt; font-family:Calibri;'>");
                htmlBuilder.Append("<BR><BR><BR>");
                htmlBuilder.Append("<Table border='1' bgColor='#ffffff' borderColor='#000000' cellSpacing='0' cellPadding='0' style='font-size:10.0pt; font-family:Calibri; background:white;'>");
                htmlBuilder.Append("<TR>");

                // Add headers
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    htmlBuilder.Append("<Td><B>");
                    htmlBuilder.Append(dataTable.Columns[j].ColumnName);
                    htmlBuilder.Append("</B></Td>");
                }
                htmlBuilder.Append("</TR>");

                // Add data rows
                foreach (DataRow row in dataTable.Rows)
                {
                    htmlBuilder.Append("<TR>");
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        htmlBuilder.Append("<Td>");
                        htmlBuilder.Append(row[i].ToString());
                        htmlBuilder.Append("</Td>");
                    }
                    htmlBuilder.Append("</TR>");
                }
                htmlBuilder.Append("</Table>");
                htmlBuilder.Append("</font>");

                return System.Text.Encoding.GetEncoding("windows-1250").GetBytes(htmlBuilder.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public byte[] ExportToExcelNew(string fileName, string commandText)
        {
            try
            {
                fileName += " " + DateTime.Now.ToString("ddMMMyyyyhhmmss");
                var dataset = GetReturnDatasetFromProc(commandText);
                var dataTable = dataset.Tables[0];

                return ExportToExcelFromDataTable(fileName, dataTable);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ConvertDataViewToString(DataView srcDataView, string delimiter, string separator)
        {
            var resultBuilder = new StringBuilder();

            // Add headers
            foreach (DataColumn col in srcDataView.Table.Columns)
            {
                if (!string.IsNullOrEmpty(delimiter))
                    resultBuilder.Append(delimiter);

                resultBuilder.Append(col.ColumnName);

                if (!string.IsNullOrEmpty(delimiter))
                    resultBuilder.Append(delimiter);

                resultBuilder.Append(separator);
            }

            if (resultBuilder.Length > separator.Length)
                resultBuilder.Length = resultBuilder.Length - separator.Length;

            resultBuilder.Append(Environment.NewLine);

            // Add data rows
            foreach (DataRowView row in srcDataView)
            {
                foreach (DataColumn col in srcDataView.Table.Columns)
                {
                    if (!string.IsNullOrEmpty(delimiter))
                        resultBuilder.Append(delimiter);

                    resultBuilder.Append(row[col.ColumnName]);

                    if (!string.IsNullOrEmpty(delimiter))
                        resultBuilder.Append(delimiter);

                    resultBuilder.Append(separator);
                }

                if (resultBuilder.Length > 0)
                    resultBuilder.Length = resultBuilder.Length - 1;

                resultBuilder.Append(Environment.NewLine);
            }

            return resultBuilder.ToString();
        }

        public static void AddTableColumn(DataTable dataTable, string columnName, string columnType)
        {
            DataColumn dataColumn;

            switch (columnType.ToUpper())
            {
                case "I":
                    dataColumn = new DataColumn(columnName, typeof(int), null, MappingType.Element);
                    break;
                case "F":
                    dataColumn = new DataColumn(columnName, typeof(float), null, MappingType.Element);
                    break;
                case "D":
                    dataColumn = new DataColumn(columnName, typeof(decimal), null, MappingType.Element);
                    break;
                case "S":
                    dataColumn = new DataColumn(columnName, typeof(string), null, MappingType.Element);
                    break;
                case "DT":
                    dataColumn = new DataColumn(columnName, typeof(DateTime), null, MappingType.Element);
                    break;
                case "B":
                    dataColumn = new DataColumn(columnName, typeof(bool), null, MappingType.Element);
                    break;
                case "BY":
                    dataColumn = new DataColumn(columnName, typeof(byte), null, MappingType.Element);
                    break;
                case "L":
                    dataColumn = new DataColumn(columnName, typeof(long), null, MappingType.Element);
                    break;
                default:
                    dataColumn = new DataColumn(columnName, typeof(string), null, MappingType.Element);
                    break;
            }

            dataColumn.AllowDBNull = true;
            dataTable.Columns.Add(dataColumn);
        }

        // Refactored Repeater methods for MVC - using generic collections instead of WebForms controls
        public string FunEditForCollection(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar, bool allowMultiple = false)
        {
            try
            {
                string strcode = "";
                int selectedCount = 0;

                foreach (var item in items)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        selectedCount++;

                        if (!allowMultiple && selectedCount > 1)
                        {
                            return "MULTIPLE_SELECTION_ERROR";
                        }

                        if (blnIsVarchar)
                        {
                            strcode += "'" + item[codeField].ToString() + "',";
                        }
                        else
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                {
                    return "";
                }

                return strcode.Substring(0, strcode.Length - 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunEditForCollectionWithCustomField(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar, bool allowMultiple = false)
        {
            try
            {
                return FunEditForCollection(items, codeField, blnIsVarchar, allowMultiple);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunEditForCollectionWithoutMessage(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar)
        {
            try
            {
                string strcode = "";

                foreach (var item in items)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        if (blnIsVarchar)
                        {
                            strcode += "'" + item[codeField].ToString() + "',";
                        }
                        else
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                {
                    return "";
                }

                return strcode.Substring(0, strcode.Length - 1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunEditForCollectionAllowNone(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar)
        {
            try
            {
                var result = FunEditForCollectionWithoutMessage(items, codeField, blnIsVarchar);
                return string.IsNullOrEmpty(result) ? "" : result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string FunDeleteForCollection(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar)
        {
            try
            {
                string strcode = "";

                foreach (var item in items)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        if (blnIsVarchar)
                        {
                            strcode = item[codeField].ToString();
                            break; // Only get first selected for delete
                        }
                        else
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                {
                    return "";
                }

                if (!blnIsVarchar && strcode.EndsWith(","))
                {
                    strcode = strcode.Substring(0, strcode.Length - 1);
                }

                return strcode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Special case method for job-related functionality
        public string FunEditForCollectionJob(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar)
        {
            try
            {
                string strcode = "";
                int selectedCount = 0;

                foreach (var item in items)
                {
                    if (item.ContainsKey("IsSelected") && Convert.ToBoolean(item["IsSelected"]))
                    {
                        selectedCount++;

                        if (selectedCount > 1)
                        {
                            return "MULTIPLE_SELECTION_ERROR";
                        }

                        if (blnIsVarchar)
                        {
                            strcode += item[codeField].ToString() + ",";
                        }
                        else
                        {
                            strcode += item[codeField].ToString(); // No comma for non-varchar
                        }
                    }
                }

                if (string.IsNullOrEmpty(strcode))
                {
                    return "";
                }

                return strcode;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Customer survey specific method
        public string FunEditForCollectionCustomerSurvey(List<Dictionary<string, object>> items, string codeField, bool blnIsVarchar)
        {
            try
            {
                var result = FunEditForCollection(items, codeField, blnIsVarchar, false);

                if (result == "MULTIPLE_SELECTION_ERROR")
                {
                    return "X";
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Security and privilege methods
        public bool[] GetUserSecurity(string userType, string pageName)
        {
            bool[] flags = new bool[5];
            // 0 = Add Right, 1 = Edit Right, 2 = View Right, 3 = Delete Right, 4 = Report Right

            try
            {
                string query = $"select * from UserPrivilegeMaster upm,ScreenMaster sm where sm.ScreenName= '{pageName.Replace("_", ".")}' and upm.UserType= '{userType}'";
                var dataset = GetReturnDatasetFromProc(query);

                if (dataset.Tables[0].Rows.Count > 0)
                {
                    var row = dataset.Tables[0].Rows[0];
                    flags[0] = Convert.ToInt32(row["PrivilegeAdd"]) == 1;
                    flags[1] = Convert.ToInt32(row["PrivilegeEdit"]) == 1;
                    flags[2] = Convert.ToInt32(row["PrivilegeView"]) == 1;
                    flags[3] = Convert.ToInt32(row["PrivilegeDelete"]) == 1;
                    flags[4] = Convert.ToInt32(row["PrivilegeReports"]) == 1;
                }

                return flags;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Database CRUD operations
        public int InsertRecord(DataSet ds, string strProcName, string prKey, bool blnIsReturn)
        {
            int retVal = 0;

            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(strProcName, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                for (int cntRow = 0; cntRow < ds.Tables[0].Rows.Count; cntRow++)
                {
                    cmd.Parameters.Clear();

                    for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                    {
                        if (ds.Tables[0].Columns[x].ColumnName.ToUpper() != prKey.ToUpper())
                        {
                            cmd.Parameters.AddWithValue("@" + ds.Tables[0].Columns[x].ColumnName, ds.Tables[0].Rows[cntRow][x]);
                        }
                    }

                    if (blnIsReturn)
                    {
                        var outputParam = cmd.Parameters.Add("@prKey", SqlDbType.Int, 4);
                        outputParam.Direction = ParameterDirection.Output;
                    }

                    cmd.ExecuteNonQuery();

                    if (blnIsReturn)
                    {
                        retVal = Convert.ToInt32(cmd.Parameters["@prKey"].Value);
                    }
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertRecord(DataSet ds, string strProcName)
        {
            return InsertRecord(ds, strProcName, "", false);
        }

        public int InsertRecord(DataSet ds, string strProcName, string prKey)
        {
            return InsertRecord(ds, strProcName, prKey, true);
        }

        public int InsertRecord(DataRow dr, string strProcName, bool blnIsReturn)
        {
            int retVal = 0;

            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(strProcName, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                for (int x = 0; x < dr.Table.Columns.Count; x++)
                {
                    cmd.Parameters.AddWithValue("@" + dr.Table.Columns[x].ColumnName, dr[x]);
                }

                if (blnIsReturn)
                {
                    var outputParam = cmd.Parameters.Add("@prKey", SqlDbType.Int, 4);
                    outputParam.Direction = ParameterDirection.Output;
                }

                cmd.ExecuteNonQuery();

                if (blnIsReturn)
                {
                    retVal = Convert.ToInt32(cmd.Parameters["@prKey"].Value);
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsertRecord(DataTable dt, string strProcName, string prKey, bool blnIsReturn)
        {
            int retVal = 0;

            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(strProcName, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                for (int cntRow = 0; cntRow < dt.Rows.Count; cntRow++)
                {
                    cmd.Parameters.Clear();

                    for (int x = 0; x < dt.Columns.Count; x++)
                    {
                        if (dt.Columns[x].ColumnName != prKey)
                        {
                            cmd.Parameters.AddWithValue("@" + dt.Columns[x].ColumnName, dt.Rows[cntRow][x]);
                        }
                    }

                    if (blnIsReturn)
                    {
                        var outputParam = cmd.Parameters.Add("@prKey", SqlDbType.Int, 4);
                        outputParam.Direction = ParameterDirection.Output;
                    }

                    cmd.ExecuteNonQuery();

                    if (blnIsReturn)
                    {
                        retVal = Convert.ToInt32(cmd.Parameters["@prKey"].Value);
                    }
                }

                return retVal;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void UpdateRecord(DataSet ds, string strProcName)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(strProcName, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                for (int x = 0; x < ds.Tables[0].Columns.Count; x++)
                {
                    cmd.Parameters.AddWithValue("@" + ds.Tables[0].Columns[x].ColumnName, ds.Tables[0].Rows[0][x]);
                }

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void QueryExecution(string query)
        {
            try
            {
                using var connection = new SqlConnection(_connectionString);
                using var command = new SqlCommand(query, connection);

                command.CommandType = CommandType.Text;
                command.CommandTimeout = 999;

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Data selection methods
        public DataSet GetSelect(string criteria, string columnList, string tableName)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand("usp_Master_Select", connection);
                using var adapter = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 999;

                cmd.Parameters.AddWithValue("@Criteria", criteria);
                cmd.Parameters.AddWithValue("@ColumnList", columnList);
                cmd.Parameters.AddWithValue("@TableName", tableName);

                var dataset = new DataSet();
                connection.Open();
                cmd.ExecuteNonQuery();
                adapter.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet GetSelectByProc(string criteria, string storedProcName)
        {
            return GetSelectByProc(criteria, storedProcName, "");
        }

        public DataSet GetSelectByProc(string criteria, string storedProcName, string columnList)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(storedProcName, connection);
                using var adapter = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 999;

                if (!string.IsNullOrEmpty(criteria))
                {
                    cmd.Parameters.AddWithValue("@Criteria", criteria);
                }
                if (!string.IsNullOrEmpty(columnList))
                {
                    cmd.Parameters.AddWithValue("@ColumnList", columnList);
                }

                var dataset = new DataSet();
                connection.Open();
                cmd.ExecuteNonQuery();
                adapter.Fill(dataset);

                return dataset;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataRow[] GetSchema(string tableName)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand("old_usp_Columns", connection);
                using var adapter = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 999;
                cmd.Parameters.AddWithValue("@table_name", tableName);

                var dataset = new DataSet();
                connection.Open();
                cmd.ExecuteNonQuery();
                adapter.Fill(dataset);

                return dataset.Tables[0].Select();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable SelectTable(string criteria, string columnList, string tableName, string orderBy)
        {
            try
            {
                if (orderBy.Length > 1)
                {
                    orderBy = "Order By " + orderBy;
                }

                using var connection = GetConnection();
                using var cmd = new SqlCommand("usp_Master_Select", connection);
                using var adapter = new SqlDataAdapter(cmd);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Criteria", criteria);
                cmd.Parameters.AddWithValue("@ColumnList", columnList);
                cmd.Parameters.AddWithValue("@TableName", tableName);
                cmd.Parameters.AddWithValue("@OrderBy", orderBy);

                var dataTable = new DataTable();
                connection.Open();
                cmd.ExecuteNonQuery();
                adapter.Fill(dataTable);

                return dataTable;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Delete and Update operations
        public void UpdateRecordsByProc(string setValues, string procedure, string criteria)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(procedure, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 999;

                cmd.Parameters.AddWithValue("@setValues", setValues);
                cmd.Parameters.AddWithValue("@Criteria", criteria);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void DeleteRecordsByProc(string strCode, string procedure)
        {
            try
            {
                using var connection = GetConnection();
                using var cmd = new SqlCommand(procedure, connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandTimeout = 999;

                cmd.Parameters.AddWithValue("@Criteria", $" In({strCode}) ");

                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Utility methods for MVC
        public Dictionary<string, object> PopulateObjectFromDataRow(DataRow dr)
        {
            var result = new Dictionary<string, object>();

            try
            {
                foreach (DataColumn column in dr.Table.Columns)
                {
                    result[column.ColumnName] = dr[column.ColumnName] == DBNull.Value ? null : dr[column.ColumnName];
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void PopulateDataRowFromObject(ref DataRow dr, Dictionary<string, object> data, string primaryKeyField = "", object primaryKeyValue = null)
        {
            try
            {
                if (!string.IsNullOrEmpty(primaryKeyField) && primaryKeyValue != null)
                {
                    dr[primaryKeyField] = primaryKeyValue;
                }

                foreach (var item in data)
                {
                    if (dr.Table.Columns.Contains(item.Key))
                    {
                        dr[item.Key] = item.Value ?? DBNull.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Privilege checking methods
        public bool CheckUserPrivilege(string strPageName, int intUserId)
        {
            try
            {
                var ds = GetSelectByQuery($"Select * from ScreenMaster Where Description='{strPageName}'");

                if (ds.Tables[0].Rows.Count == 0)
                {
                    return false;
                }

                int screenCode = Convert.ToInt32(ds.Tables[0].Rows[0]["ScreenCode"]);
                ds.Dispose();

                if (screenCode != 0)
                {
                    ds = GetSelectByQuery($"Select * From UserPrivilegeMaster Where ScreenCode={screenCode} and UserId={intUserId}");
                    return ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0;
                }

                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Validation helper methods for MVC
        public bool IsValidEmail(string email)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                var emailRegex = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
                return emailRegex.IsMatch(email);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ValidateFormData(Dictionary<string, object> formData, Dictionary<string, string> validationRules)
        {
            try
            {
                var errors = new List<string>();

                foreach (var rule in validationRules)
                {
                    var fieldName = rule.Key;
                    var ruleType = rule.Value.ToUpper();

                    if (!formData.ContainsKey(fieldName))
                        continue;

                    var value = formData[fieldName]?.ToString() ?? "";

                    switch (ruleType)
                    {
                        case "REQUIRED":
                            if (string.IsNullOrWhiteSpace(value))
                                errors.Add($"{fieldName} is required");
                            break;

                        case "EMAIL":
                            if (!string.IsNullOrWhiteSpace(value) && !IsValidEmail(value))
                                errors.Add($"{fieldName} must be a valid email address");
                            break;

                        case "NUMERIC":
                            if (!string.IsNullOrWhiteSpace(value) && !decimal.TryParse(value, out _))
                                errors.Add($"{fieldName} must be a valid number");
                            break;
                    }
                }

                return errors.Count > 0 ? string.Join("; ", errors) : "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String EncodePassword(String str)
        {
            char[] Ar = str.ToCharArray();
            string retstr = "";
            int i;

            for (i = 0; i < Ar.Length; i++)
            {
                if (retstr == "")
                {
                    retstr = Strings.Chr(Strings.Asc(Ar[i]) + 3).ToString();
                }
                else
                {
                    retstr = retstr + "-" + Strings.Chr(Strings.Asc(Ar[i]) + 3).ToString();
                }
            }

            return retstr;
        }
        public String DecodePassword(String str)
        {
            string[] Ar = str.Split("-".ToCharArray());
            //char[] Ar = str.Split("-".ToCharArray()).ToString().ToCharArray();
            string retstr = "";
            int i;

            for (i = 0; i < Ar.Length; i++)
            {
                retstr = retstr + Strings.Chr(Strings.Asc(Ar[i]) - 3).ToString();
            }

            return retstr;
        }

        public double NumericVal(string anyString)
        {
            double NumericValue = 0;

            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                bool IsNumericFlag = double.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out NumericValue);
            }

            return NumericValue;
        }

        public bool IsNumeric(string anyString)
        {
            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                double dummyOut = new double();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return Double.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
            }
            else
            {
                return false;
            }
        }

        public decimal DecimalVal(string anyString)
        {
            decimal decimalValue = 0;

            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                bool IsdecimalFlag = decimal.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out decimalValue);
            }

            return decimalValue;
        }

        public bool IsDecimal(string anyString)
        {
            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                decimal dummyOut = new decimal();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return decimal.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
            }
            else
            {
                return false;
            }
        }

        public int IntVal(string anyString)
        {
            int IntValue = 0;

            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                bool IsIntFlag = int.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out IntValue);
            }

            return IntValue;
        }

        public long LongVal(string anyString)
        {
            long LongValue = 0;

            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                bool IsLongFlag = long.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out LongValue);
            }

            return LongValue;
        }

        public bool IsInteger(string anyString)
        {
            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                int dummyOut = new int();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return int.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
            }
            else
            {
                return false;
            }
        }

        public bool IsInt64(string anyString)
        {
            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                Int64 dummyOut = new Int64();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return Int64.TryParse(anyString, System.Globalization.NumberStyles.Any, cultureInfo.NumberFormat, out dummyOut);
            }
            else
            {
                return false;
            }
        }

        public bool IsDate(string anyString)
        {
            if (anyString == null) { anyString = ""; }
            if (anyString.Length > 0)
            {
                DateTime dummyOut = new DateTime();
                System.Globalization.CultureInfo cultureInfo = new System.Globalization.CultureInfo("en-US", true);
                return DateTime.TryParse(anyString, out dummyOut);
            }
            else
            {
                return false;
            }
        }
         public static string StripTagsRegex(string source)
        {
            return Regex.Replace(source, "<.*?>", string.Empty);
        }

        static Regex _htmlRegex = new Regex("<.*?>", RegexOptions.Compiled);

        public static string StripTagsRegexCompiled(string source)
        {
            return _htmlRegex.Replace(source, string.Empty);
        }

        public static string StripTagsCharArray(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
        
            public object fnWriteToLogFile(string strText, string mName)
            {
                string strFileName = null;
                string strFilePath = null;
                StreamWriter sw = null;
                strFileName = DateTime.Today.ToString("MMM") + "_" + DateTime.Today.Day + "_" + DateTime.Today.Year + ".txt";

                switch (mName)
                {
                    case "IMS":
                        var logFolder = _configuration["FileSettings:ErrorLogFolder"] ?? "LogFiles";
                        strFilePath = Path.Combine(logFolder, "IMS", strFileName);
                        break;
                }

                try
                {
                    var directory = Path.GetDirectoryName(strFilePath);
                    if (!Directory.Exists(directory))
                    {
                        Directory.CreateDirectory(directory);
                    }

                    if (!(File.Exists(strFilePath)))
                    {
                        sw = File.CreateText(strFilePath);
                    }
                    else
                    {
                        sw = File.AppendText(strFilePath);
                    }
                    sw.WriteLine(strText);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in fnWriteToLogFile");
                    throw ex;
                }

                return null;
            }

            
            public bool ApplyStyle(object ctl, bool Retval)
            {
                // This method would need to be adapted based on your UI framework
                // For MVC, you would typically handle styling through CSS classes and ModelState
                return Retval;
            }

            public bool EXTisOK(string sEXT)
            {
                bool functionReturnValue = false;
                string EXT;
                EXT = "";

                functionReturnValue = false;
                if (!sEXT.StartsWith(".")) sEXT = "." + sEXT;
                sEXT = sEXT.ToUpper();

                EXT = EXT + ".COM.EDU.GOV.NET.BIZ.ORG.TV";
                EXT = EXT + ".AF.AL.DZ.As.AD.AO.AI.AQ.AG.AP.AR.AM.AW.AU.AT.AZ.BS.BH.BD.BB.BY";
                EXT = EXT + ".BE.BZ.BJ.BM.BT.BO.BA.BW.BV.BR.IO.BN.BG.BF.MM.BI.KH.CM.CA.CV.KY";
                EXT = EXT + ".CF.TD.CL.CN.CX.CC.CO.KM.CG.CD.CK.CR.CI.HR.CU.CY.CZ.DK.DJ.DM.DO";
                EXT = EXT + ".TP.EC.EG.SV.GQ.ER.EE.ET.FK.FO.FJ.FI.CS.SU.FR.FX.GF.PF.TF.GA.GM.GE.DE";
                EXT = EXT + ".GH.GI.GB.GR.GL.GD.GP.GU.GT.GN.GW.GY.HT.HM.HN.HK.HU.IS.IN.ID.IR.IQ";
                EXT = EXT + ".IE.IL.IT.JM.JP.JO.KZ.KE.KI.KW.KG.LA.LV.LB.LS.LR.LY.LI.LT.LU.MO.MK.MG";
                EXT = EXT + ".MW.MY.MV.ML.MT.MH.MQ.MR.MU.YT.MX.FM.MD.MC.MN.MS.MA.MZ.NA";
                EXT = EXT + ".NR.NP.NL.AN.NT.NC.NZ.NI.NE.NG.NU.NF.KP.MP.NO.OM.PK.PW.PA.PG.PY";
                EXT = EXT + ".PE.PH.PN.PL.PT.PR.QA.RE.RO.RU.RW.GS.SH.KN.LC.PM.ST.VC.SM.SA.SN.SC";
                EXT = EXT + ".SL.SG.SK.SI.SB.SO.ZA.KR.ES.LK.SD.SR.SJ.SZ.SE.CH.SY.TJ.TW.TZ.TH.TG.TK";
                EXT = EXT + ".TO.TT.TN.TR.TM.TC.TV.UG.UA.AE.UK.US.UY.UM.UZ.VU.VA.VE.VN.VG.VI";
                EXT = EXT + ".WF.WS.EH.YE.YU.ZR.ZM.ZW";
                EXT = EXT.ToUpper();

                if (EXT.Contains(sEXT)) functionReturnValue = true;
                return functionReturnValue;
            }

            public bool IsValidEmail(object ctl)
            {
                // For MVC, this would receive a string value instead of a control
                // Modified to work with string input
                string strEmail = ctl.ToString().Trim();
                bool functionReturnValue = false;
                string strTmp;
                int n = 0;
                string sEXT;

                functionReturnValue = true;
                sEXT = strEmail;

                while (sEXT.Contains("."))
                {
                    sEXT = sEXT.Substring(sEXT.IndexOf(".") + 1);
                }

                if (strEmail == "")
                {
                    functionReturnValue = false;
                    // In MVC, you would add to ModelState instead
                }
                else if (!strEmail.Contains("@"))
                {
                    functionReturnValue = false;
                }
                else if (strEmail.IndexOf("@") == 0)
                {
                    functionReturnValue = false;
                }
                else if (strEmail.IndexOf("@") == strEmail.Length - 1)
                {
                    functionReturnValue = false;
                }
                else if (strEmail.Length < 6)
                {
                    functionReturnValue = false;
                }

                strTmp = strEmail;
                while (strTmp.Contains("@"))
                {
                    n++;
                    strTmp = strTmp.Substring(strTmp.IndexOf("@") + 1);
                }
                if (n > 1)
                {
                    functionReturnValue = false;
                }
                return functionReturnValue;
            }

            public bool IsBlank(object ctl)
            {
                bool Retval = true;
                string value = ctl.ToString().Trim();

                if (string.IsNullOrWhiteSpace(value) || value == "-1")
                {
                    Retval = false;
                    ApplyStyle(ctl, Retval);
                    return Retval;
                }

                return Retval;
            }

            public bool IsNumber(object ctl)
            {
                try
                {
                    bool Retval = true;
                    int converted_Val;
                    converted_Val = Convert.ToInt32(ctl.ToString());
                    return true;
                }
                catch (Exception ex)
                {
                    ApplyStyle(ctl, false);
                    return false;
                }
            }

            public bool IsValidString(object ctl)
            {
                bool Retval = true;
                string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ ";
                char Char;
                string sText = ctl.ToString().Trim();

                for (int i = 0; i < sText.Length; i++)
                {
                    Char = sText[i];
                    if (ValidChars.IndexOf(Char) == -1)
                    {
                        Retval = false;
                        ApplyStyle(ctl, Retval);
                        return Retval;
                    }
                }
                return Retval;
            }

            public bool IsAlphaNumeric(object ctl)
            {
                bool Retval = true;
                string ValidChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890 ";
                char Char;
                string sText = ctl.ToString().Trim();

                for (int i = 0; i < sText.Length; i++)
                {
                    Char = sText[i];
                    if (ValidChars.IndexOf(Char) == -1)
                    {
                        Retval = false;
                        ApplyStyle(ctl, Retval);
                        return Retval;
                    }
                }
                return Retval;
            }

            public bool CheckForValidation(object ctl, string ValidType, string CustomName)
            {
                MsgBlank = "Please enter " + CustomName;
                MsgNumber = "Please enter digits in " + CustomName + ".";
                MsgValidAlpha = "Please enter alphabetic characters in " + CustomName + ".";
                MsgValidAlphaNum = "Please enter alpha-numeric characters in " + CustomName + ".";
                MsgValidFloat = "Please enter valid number in " + CustomName + ".";
                MsgDecFormat = "Please enter only Decimal values";
                MsgValidEmail = "Please enter valid Email in " + CustomName + ".";
                MsgDateCompare = "Date should be less than or equal to current date";

                string[] Cases;
                string types;
                types = ValidType;
                Cases = types.Split(',');

                for (int i = 0; i < Cases.Length; i++)
                {
                    switch (Cases[i])
                    {
                        case "B":
                            if (Cases.Length == 1)
                            {
                                return IsBlank(ctl);
                            }
                            else
                            {
                                if ((i + 1) == Cases.Length)
                                {
                                    if (!IsBlank(ctl)) { return false; } else { return true; }
                                }
                                else
                                {
                                    if (!IsBlank(ctl)) { return false; }
                                }
                            }
                            break;

                        case "N":
                            if (Cases.Length == 1)
                            {
                                return IsNumber(ctl);
                            }
                            else
                            {
                                if ((i + 1) == Cases.Length)
                                {
                                    if (!IsNumber(ctl)) { return false; } else { return true; }
                                }
                                else
                                {
                                    if (!IsNumber(ctl)) { return false; }
                                }
                            }
                            break;

                        case "E":
                            if (Cases.Length == 1)
                            {
                                return IsValidEmail(ctl);
                            }
                            else
                            {
                                if ((i + 1) == Cases.Length)
                                {
                                    if (!IsValidEmail(ctl)) { return false; } else { return true; }
                                }
                                else
                                {
                                    if (!IsValidEmail(ctl)) { return false; }
                                }
                            }
                            break;

                        case "A":
                            if (Cases.Length == 1)
                            {
                                return IsValidString(ctl);
                            }
                            else
                            {
                                if ((i + 1) == Cases.Length)
                                {
                                    if (!IsValidString(ctl)) { return false; } else { return true; }
                                }
                                else
                                {
                                    if (!IsValidString(ctl)) { return false; }
                                }
                            }
                            break;

                        case "AN":
                            if (Cases.Length == 1)
                            {
                                return IsAlphaNumeric(ctl);
                            }
                            else
                            {
                                if ((i + 1) == Cases.Length)
                                {
                                    if (!IsAlphaNumeric(ctl)) { return false; } else { return true; }
                                }
                                else
                                {
                                    if (!IsAlphaNumeric(ctl)) { return false; }
                                }
                            }
                            break;
                    }
                }
                return true;
            }

           
            public DataSet GetSelectByQuery(string query)
            {
                try
                {
                    using (var connection = new SqlConnection(_connectionString))
                    {
                        using (var command = new SqlCommand(query, connection))
                        {
                            using (var adapter = new SqlDataAdapter(command))
                            {
                                var dataSet = new DataSet();
                                adapter.Fill(dataSet);
                                return dataSet;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in GetSelectByQuery: {Query}", query);
                    throw;
                }
            }

            public object send_mail_ChangeNew(string to_address, string cc_address, string Subject, string Body, string Attachment)
            {
                try
                {
                    if (EmailEnabled() == 1)
                    {
                        var emailSettings = _configuration.GetSection("EmailSettings");

                        using (var client = new SmtpClient(emailSettings["SmtpServer"]))
                        {
                            client.Port = int.Parse(emailSettings["SmtpPort"]);
                            client.Credentials = new System.Net.NetworkCredential(
                                emailSettings["SmtpUsername"],
                                emailSettings["SmtpPassword"]
                            );
                            client.EnableSsl = true;

                            using (var message = new MailMessage())
                            {
                                message.From = new MailAddress(emailSettings["FromEmail"]);
                                message.To.Add(to_address);
                                if (!string.IsNullOrEmpty(cc_address))
                                    message.CC.Add(cc_address);
                                message.Subject = Subject;
                                message.Body = !string.IsNullOrEmpty(Body) ? Body : "Please mail to Admin for Reply";
                                message.IsBodyHtml = true;

                                if (!string.IsNullOrEmpty(Attachment) && File.Exists(Attachment))
                                {
                                    message.Attachments.Add(new Attachment(Attachment));
                                }

                                client.Send(message);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in send_mail_ChangeNew");
                    throw ex;
                }
                return null;
            }

            public string funEditForRepeaterReqNo(object ctl, bool blnIsVarchar, object t)
            {
                // This method would need significant modification for MVC
                // as it's specific to Web Forms Repeater controls
                try
                {
                    string strcode = null;
                    // Implementation would depend on your MVC UI structure
                    return strcode;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in funEditForRepeaterReqNo");
                    throw ex;
                }
            }

            public int SMSEnabled()
            {
                int SMSFlag = 0;
                var smsEnabled = _configuration["ApplicationSettings:SMSEnabled"];
                if (string.Equals(smsEnabled, "YES", StringComparison.OrdinalIgnoreCase))
                {
                    SMSFlag = 1;
                }
                return SMSFlag;
            }

            public int EmailEnabled()
            {
                int EmailFlag = 0;
                var emailEnabled = _configuration["ApplicationSettings:EmailEnabled"];
                if (string.Equals(emailEnabled, "YES", StringComparison.OrdinalIgnoreCase))
                {
                    EmailFlag = 1;
                }
                return EmailFlag;
            }

            public void sendSMSOnly(object pg)
            {
                // SMS implementation would depend on your SMS provider
                // Modern approach would use HTTP client to call SMS API
            }

            public void sendSMS(object pg)
            {
                try
                {
                    if (SMSEnabled() == 1)
                    {
                        sendSMSOnly(pg);
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in sendSMS");
                }
            }

            public void sendSMS1(object pg)
            {
                try
                {
                    if (SMSEnabled() == 1)
                    {
                        // Modern approach would be to use background service instead of Process.Start
                        _logger.LogInformation("SMS sending triggered");
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error in sendSMS1");
                }
            }

            public static void ExportToExcel(String FileName, String commandText, String Extension)
            {
                if (string.IsNullOrEmpty(Extension))
                    Extension = ".xls";

                // This method would need HttpContext injection in MVC
                // For now, keeping the structure but noting it needs modification
            }

            public string ConvertDataViewToString(DataView srcDataView, string Delimiter, string Separator, string PrnCol)
            {
                StringBuilder ResultBuilder = new StringBuilder();
                ResultBuilder.Length = 0;

                if (PrnCol != "N")
                {
                    foreach (DataColumn aCol in srcDataView.Table.Columns)
                    {
                        if (!string.IsNullOrEmpty(Delimiter))
                        {
                            ResultBuilder.Append(Delimiter);
                        }
                        ResultBuilder.Append(aCol.ColumnName);
                        if (!string.IsNullOrEmpty(Delimiter))
                        {
                            ResultBuilder.Append(Delimiter);
                        }
                        ResultBuilder.Append(Separator);
                    }
                    if (ResultBuilder.Length > Separator.Length)
                    {
                        ResultBuilder.Length = ResultBuilder.Length - Separator.Length;
                    }
                    ResultBuilder.Append(Environment.NewLine);
                }

                foreach (DataRowView aRow in srcDataView)
                {
                    foreach (DataColumn aCol in srcDataView.Table.Columns)
                    {
                        if (!string.IsNullOrEmpty(Delimiter))
                        {
                            ResultBuilder.Append(Delimiter);
                        }
                        ResultBuilder.Append(aRow[aCol.ColumnName]);
                        if (!string.IsNullOrEmpty(Delimiter))
                        {
                            ResultBuilder.Append(Delimiter);
                        }
                        ResultBuilder.Append(Separator);
                    }
                    if (ResultBuilder.Length > 0)
                    {
                        ResultBuilder.Length = ResultBuilder.Length - 1;
                    }
                    ResultBuilder.Append(Environment.NewLine);
                }

                return ResultBuilder.ToString();
            }

            public static void ImportFromExcelErrorLog(String FileName, DataTable DT, String Extension, StringBuilder BeginText, StringBuilder EndText)
            {
                if (string.IsNullOrEmpty(Extension))
                    Extension = ".xls";

                // This method would need HttpContext injection in MVC
                // Implementation would be similar to ExportToExcel but adapted for MVC
            }
        
    }
}
