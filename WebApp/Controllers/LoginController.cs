using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.User;
using Application.ServiceInterfaces.Core;
using WebApp.ViewModels;
using System.Data;
using System.Text;
using Infrastructure.Data;
using Infrastructure.Helpers;

namespace WebApp.Controllers
{
    public class LoginController : BaseController
    {
        private readonly IUSRUserMasterService _userService;
        private readonly ICORCompanyMasterService _companyService;
        private readonly ICORCenterMasterService _centerService;
        private readonly IControlDetailMasterService _controlDetailService;
        private readonly DbHelper _dbHelper;
        private readonly GeneralHelper _objGeneral;
        private readonly DbManager _dbManager;
        public LoginController(
             IConfiguration config,
            IUSRUserMasterService userService,
            ICORCompanyMasterService companyService,
            ICORCenterMasterService centerService,
            IControlDetailMasterService controlDetailService,
            DbHelper dbHelper,
            GeneralHelper objGeneral,
            DbManager dbManager) : base(config)
        {
            _userService = userService;
            _companyService = companyService;
            _centerService = centerService;
            _controlDetailService = controlDetailService;
            _dbHelper = dbHelper;
            _objGeneral = objGeneral;
            _dbManager = dbManager;
        }

        public IActionResult Index()
        {
            // Clear any existing sessions
            HttpContext.Session.Clear();

            var model = new LoginViewModel();
            ViewBag.Title = _objGeneral.SiteTitle + "Login";

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(LoginViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string loginId = model.LoginID.Replace("'", "");
                    string password = _objGeneral.EncodePassword(model.Password.Replace("'", ""));

                    string criteria = $"where 1=1 And lower(USER_LoginID) COLLATE Latin1_General_CS_AS= '{loginId.ToLower()}' " +
                                    $"And lower(USER_Password) COLLATE Latin1_General_CS_AS= '{password.ToLower()}' " +
                                    $"AND USER_Status = 1";

                    var userList = _userService.GetUSRUserMasters("", "ASC", 0, 10, criteria);

                    if (userList.Count == 0)
                    {
                        TempData["Error"] = "Invalid User Id / Password";
                        return View(model);
                    }

                    var user = userList[0];

                    // Check password expiry
                    var controlDetails = _controlDetailService.GetControlDetailMasters("", "ASC", 0, 10, "and CH.CHM_ID=17");
                    int duration = int.Parse(controlDetails[0].CD_ControlType.ToString());

                    DateTime currentDate = DateTime.Now;
                    DateTime lastUpdateDate = DateTime.Parse(user.USER_LastUpdateDate.ToString());
                    TimeSpan timeDifference = currentDate.Subtract(lastUpdateDate);

                    if (((timeDifference.TotalDays) + 1) > duration)
                    {
                        // Password expired - redirect to change password
                        HttpContext.Session.SetString("USER_Id", user.USER_ID.ToString());

                        // Get access rights
                        StringBuilder sql = new StringBuilder();
                        sql.Append("EXEC usp_USRUSERPageAccessRights1 ");
                        sql.Append(user.USER_ID.ToString());
                        DataSet accessRights = _dbManager.GetDataSet(sql.ToString());
                        HttpContext.Session.SetString("dsAccessRights", accessRights.GetXml());

                        return RedirectToAction("ChangePassword", "CoreModule");
                    }

                    // Successful login - set session variables
                    HttpContext.Session.SetString("USER_Type", user.USER_Type.ToString());
                    HttpContext.Session.SetString("USER_Name", $"{user.USER_FirstName} {user.USER_LastName}");
                    HttpContext.Session.SetString("USER_Id", user.USER_ID.ToString());
                    HttpContext.Session.SetString("CMPM_Id", "1");
                    HttpContext.Session.SetString("Designation", user.DESI_Name ?? "Administrator");

                    // Get center information
                    var center = _centerService.GetCORCenterMaster(int.Parse(user.CENMST_CenterCode));
                    HttpContext.Session.SetString("CENMST_CenterPrefix", center.CENMST_CenterPrefix);
                    HttpContext.Session.SetString("CENMST_Name", user.CENMST_Name.ToString());
                    HttpContext.Session.SetString("CENMST_CenterCode", user.CENMST_CenterCode.ToString());

                    // Get access rights
                    StringBuilder sqlRights = new StringBuilder();
                    sqlRights.Append("EXEC usp_USRUSERPageAccessRights1 ");
                    sqlRights.Append(user.USER_ID.ToString());
                    DataSet dsRights = _dbManager.GetDataSet(sqlRights.ToString());
                    HttpContext.Session.SetString("dsAccessRights", dsRights.GetXml());

                    // Get lock date
                    try
                    {
                        // Assuming you have a service to get lock date
                        // var lockService = _serviceProvider.GetService<ICORLockMasterService>();
                        // var lockMaster = lockService.GetCORLOCKMASTER();
                        // HttpContext.Session.SetString("Lock_Date", lockMaster.LCK_DATE.ToString("dd-MMM-yyyy"));

                        // For now, set current date as lock date
                        HttpContext.Session.SetString("Lock_Date", DateTime.Now.ToString("dd-MMM-yyyy"));
                    }
                    catch
                    {
                        HttpContext.Session.SetString("Lock_Date", DateTime.Now.ToString("dd-MMM-yyyy"));
                    }

                    // Redirect to Dashboard instead of MainPage
                    return RedirectToAction("Index", "Dashboard");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return View(model);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ForgotPassword(string username)
        {
            try
            {
                if (string.IsNullOrEmpty(username))
                {
                    return Json(new { success = false, message = "Enter User Name" });
                }

                string criteria = $" '{username.Trim()}'";
                var forgotPasswordList = _userService.GetUSRUserMasters_forget(criteria);

                if (forgotPasswordList != null && forgotPasswordList.Count > 0)
                {
                    var userInfo = forgotPasswordList[0];
                    string userName = userInfo.USER_LoginID;
                    string emailAddress = userInfo.USER_EmailID;
                    string fullName = $"{userInfo.USER_FirstName} {userInfo.USER_LastName}";
                    string userPassword = _objGeneral.DecodePassword(userInfo.USER_Password.Replace("'", ""));

                    var company = _companyService.GetCORCompanyMaster(1);

                    string emailBody = $@"
                        <HTML>
                            <BODY>
                                <div>
                                    Dear {fullName},<br /><br />
                                    Your UserID and Password are given below. <br /><br />
                                    User ID:- {userName} <br />
                                    Password:- {userPassword}<br /><br />
                                    Thanks & Regards<br />
                                    {company.CMPMST_CompanyName}<br />
                                </div>
                            </BODY>
                        </HTML>";

                    string subject = "Forgot Password?";
                    _objGeneral.send_mail_ChangeNew(emailAddress, "", subject, emailBody, "");

                    return Json(new { success = true, message = "Check Your Registered Email for User Credentials" });
                }
                else
                {
                    return Json(new { success = false, message = "User Name does not exist" });
                }
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
    
}