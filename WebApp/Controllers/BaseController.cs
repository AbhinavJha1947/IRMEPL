using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Http;
using System;
using System.Data;
using System.Data.SqlClient;

namespace WebApp.Controllers
{
    public abstract class BaseController : Controller
    {
        protected readonly IConfiguration _config;

        // Report related settings
        protected string RptPDFPath;
        protected string RptUser;
        protected string RptPwd;
        protected string RptDSN;
        protected string RptDB;

        public BaseController(IConfiguration config)
        {
            _config = config;

            // Read from appsettings.json
            RptPDFPath = _config["RptPDFPath"];
            RptUser = _config["rptUsername"];
            RptPwd = _config["rptPassword"];
            RptDSN = _config["rptDSN"];
            RptDB = _config["rptDB"];
        }

        #region ---- Utilities ----

        protected static string CheckActiveInactive(object value) =>
            string.IsNullOrEmpty(Convert.ToString(value)) || Convert.ToString(value).ToLower() == "inactive"
                ? "<i class='inactive-dot fa fa-circle'></i> Inactive"
                : "<i class='active-dot fa fa-circle'></i> Active";

        protected static string CheckNull(object value) =>
            (value == DBNull.Value || string.IsNullOrWhiteSpace(Convert.ToString(value)))
                ? "&nbsp;"
                : Convert.ToString(value);

        protected static bool ConvBoolToBool(object value) =>
            Convert.ToString(value)?.Trim() == "1";

        #endregion

        #region ---- Transaction Helpers ----

        protected void BeginTransaction(out SqlConnection connection, out SqlTransaction transaction)
        {
            connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            connection.Open();
            transaction = connection.BeginTransaction();
        }

        protected void ReleaseTransaction(SqlConnection connection, SqlTransaction transaction)
        {
            transaction?.Dispose();
            connection?.Dispose();
        }

        #endregion

        #region ---- Session Helpers ----

        // Generic getters/setters for Session
        protected T GetSessionValue<T>(string key, T defaultValue = default)
        {
            var value = HttpContext.Session.GetString(key);
            return string.IsNullOrEmpty(value) ? defaultValue : (T)Convert.ChangeType(value, typeof(T));
        }

        protected void SetSessionValue(string key, object value) =>
            HttpContext.Session.SetString(key, value?.ToString());

        // Replacing old ViewState properties with Session
        protected int PageIndex
        {
            get => GetSessionValue("PageIndex", 1);
            set => SetSessionValue("PageIndex", value);
        }

        protected int PageSize
        {
            get => GetSessionValue("PageSize", 10);
            set => SetSessionValue("PageSize", value);
        }

        protected int MaxPage
        {
            get => GetSessionValue("MaxPage", 0);
            set => SetSessionValue("MaxPage", value);
        }

        protected int RecordsFound
        {
            get => GetSessionValue("RecordsFound", 0);
            set => SetSessionValue("RecordsFound", value);
        }

        protected int CurrentPage
        {
            get => GetSessionValue("CurrentPage", 1);
            set => SetSessionValue("CurrentPage", value);
        }

        protected string SortColumn
        {
            get => GetSessionValue("SortColumn", "");
            set => SetSessionValue("SortColumn", value);
        }

        protected string SortType
        {
            get => GetSessionValue("SortType", "ASC");
            set => SetSessionValue("SortType", value);
        }

        // DataTables can’t go directly into Session → serialize to JSON
        protected DataTable ExportDT
        {
            get => HttpContext.Items["ExportDT"] as DataTable; // per-request
            set => HttpContext.Items["ExportDT"] = value;
        }

        protected DataTable AccessRightsDS
        {
            get => HttpContext.Items["AccessRightsDS"] as DataTable;
            set => HttpContext.Items["AccessRightsDS"] = value;
        }

        protected int CurrentUser
        {
            get => GetSessionValue("CurrentUser", 0);
            set => SetSessionValue("CurrentUser", value);
        }

        protected string CurrentUserName
        {
            get => GetSessionValue("Emp_Name", "Guest");
            set => SetSessionValue("Emp_Name", value);
        }

        #endregion

        #region ---- Error Handling ----

        protected void HandleException(Exception ex)
        {
            var message = $"User ID: {CurrentUser} ({CurrentUserName}) {DateTime.Now}\n";
            message += $"Message: {ex.Message}\n";
            message += $"StackTrace: {ex.StackTrace}\n";

            if (ex.InnerException != null)
                message += $"InnerException: {ex.InnerException}\n";

            HttpContext.Session.SetString("ErrorMsg", message);

            // Redirect to global error page
            Response.Redirect("/Home/Error");
        }

        #endregion
    }
}
