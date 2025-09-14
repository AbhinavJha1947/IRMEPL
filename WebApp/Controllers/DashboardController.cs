using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Application.Interfaces.User;
using Core.Entities.User;
using Core.Entities.Core;
using WebApp.ViewModels;
using System.Data;
using System.Text;
using Infrastructure.Data;
using Infrastructure.Helpers;
using Application.ServiceInterfaces.Core;

namespace WebApp.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IUSRUserMasterService _userService;
        private readonly ICORCompanyMasterService _companyService;
        private readonly ICORCenterMasterService _centerService;
        private readonly DbHelper _dbHelper;
        private readonly GeneralHelper _objGeneral;

        public DashboardController(
            IConfiguration config,
            IUSRUserMasterService userService,
            ICORCompanyMasterService companyService,
            ICORCenterMasterService centerService,
            DbHelper dbHelper,
            GeneralHelper objGeneral) : base(config)
        {
            _userService = userService;
            _companyService = companyService;
            _centerService = centerService;
            _dbHelper = dbHelper;
            _objGeneral = objGeneral;
        }

        // GET: Dashboard
        public IActionResult Index()
        {
            // Check if user is logged in
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("USER_Id")))
            {
                return RedirectToAction("Index", "Login");
            }

            var model = new DashboardViewModel();

            // Get user information from session
            model.UserName = HttpContext.Session.GetString("USER_Name");
            model.CenterName = HttpContext.Session.GetString("CENMST_Name");
            model.Designation = HttpContext.Session.GetString("Designation");
            model.UserType = HttpContext.Session.GetString("USER_Type");

            // Set current date and locking date
            model.CurrentDate = DateTime.Now.ToString("dd/MM/yyyy");

            // Get locking date from database or configuration
            try
            {
                // You might want to implement this based on your business logic
                var lockingDate = GetLockingDate();
                model.LockingDate = lockingDate.ToString("dd/MM/yyyy");
            }
            catch
            {
                model.LockingDate = DateTime.Now.ToString("dd/MM/yyyy");
            }

            // Load menu items based on user access rights
            model.MenuItems = GetUserMenuItems();

            // Set default page redirect
            ViewBag.DefaultPageUrl = "~/Reports/CenterwiseStatusReport";

            return View(model);
        }

        // GET: MainPage - For compatibility with existing Web Forms routing
        public IActionResult MainPage()
        {
            return RedirectToAction("Index");
        }

        private DateTime GetLockingDate()
        {
            // Implementation to get locking date from database or configuration
            // This should be replaced with your actual business logic
            return DateTime.Now.AddDays(-30);
        }

        private List<MenuItemViewModel> GetUserMenuItems()
        {
            var menuItems = new List<MenuItemViewModel>();

            try
            {
                // Get access rights from session
                string accessRightsXml = HttpContext.Session.GetString("dsAccessRights");
                if (!string.IsNullOrEmpty(accessRightsXml))
                {
                    DataSet dsAccessRights = new DataSet();
                    dsAccessRights.ReadXml(new StringReader(accessRightsXml));

                    // Process the access rights dataset to build menu structure
                    menuItems = BuildMenuFromAccessRights(dsAccessRights);
                }
            }
            catch (Exception ex)
            {
                // Log error and provide default menu structure
                Console.WriteLine($"Error loading menu: {ex.Message}");
            }

            return menuItems;
        }

        private List<MenuItemViewModel> BuildMenuFromAccessRights(DataSet dsAccessRights)
        {
            var menuItems = new List<MenuItemViewModel>();

            if (dsAccessRights.Tables.Count == 0)
                return menuItems;

            try
            {
                // Group menu items by module
                var groupedItems = dsAccessRights.Tables[0].AsEnumerable()
                    .GroupBy(row => row.Field<string>("ModuleName") ?? "")
                    .ToList();

                foreach (var moduleGroup in groupedItems)
                {
                    var moduleName = moduleGroup.Key;
                    if (string.IsNullOrEmpty(moduleName)) continue;

                    var menuItem = new MenuItemViewModel
                    {
                        Text = moduleName,
                        Url = "#",
                        SubItems = new List<MenuItemViewModel>()
                    };

                    foreach (var row in moduleGroup)
                    {
                        var subItem = new MenuItemViewModel
                        {
                            Text = row.Field<string>("PageName") ?? "",
                            Url = row.Field<string>("PageUrl") ?? "#",
                            HasAccess = Convert.ToBoolean(row.Field<object>("HasAccess") ?? false)
                        };

                        if (subItem.HasAccess)
                        {
                            menuItem.SubItems.Add(subItem);
                        }
                    }

                    if (menuItem.SubItems.Any())
                    {
                        menuItems.Add(menuItem);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error building menu: {ex.Message}");
                // Return default menu structure
                menuItems = GetDefaultMenuStructure();
            }

            return menuItems;
        }

        private List<MenuItemViewModel> GetDefaultMenuStructure()
        {
            return new List<MenuItemViewModel>
            {
                new MenuItemViewModel
                {
                    Text = "Master",
                    Url = "#",
                    SubItems = new List<MenuItemViewModel>
                    {
                        new MenuItemViewModel { Text = "User Master", Url = "~/User/UserMaster", HasAccess = true },
                        new MenuItemViewModel { Text = "Role Master", Url = "~/User/RoleMaster", HasAccess = true }
                    }
                },
                new MenuItemViewModel
                {
                    Text = "Reports",
                    Url = "#",
                    SubItems = new List<MenuItemViewModel>
                    {
                        new MenuItemViewModel { Text = "Centerwise Status Report", Url = "~/Reports/CenterwiseStatusReport", HasAccess = true }
                    }
                }
            };
        }

        // POST: FireMessage - For AJAX message display
        [HttpPost]
        public IActionResult FireMessage(string message, string type = "Danger")
        {
            TempData[$"Message_{type}"] = message;
            return Json(new { success = true });
        }
    }
}