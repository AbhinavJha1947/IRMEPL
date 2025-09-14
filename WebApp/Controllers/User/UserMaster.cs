using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.User;
using Core.Entities.User;
using WebApp.ViewModels;
using System.Data.SqlClient;
using Infrastructure.Data;

namespace WebApp.Controllers.User
{
    public class UserMaster : Controller
    {
        private readonly IUSRUserMasterService _userService;
        private readonly IUSRRoleMasterService _roleService;
        private readonly ICORPrivilegeMasterService _privilegeService;
        private readonly DbHelper _dbHelper;

        public UserMaster(
            IUSRUserMasterService userService,
            IUSRRoleMasterService roleService,
            ICORPrivilegeMasterService privilegeService,
            DbHelper dbHelper)
        {
            _userService = userService;
            _roleService = roleService;
            _privilegeService = privilegeService;
            _dbHelper = dbHelper;
        }

        // GET: UserMaster
        public IActionResult Index(string userName, int? roleId, int? status, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // Build criteria for search
                string criteria = "";
                if (!string.IsNullOrEmpty(userName))
                    criteria += $" AND U.USER_FirstName LIKE '%{userName}%'";
                if (roleId.HasValue)
                    criteria += $" AND U.User_Type = {roleId.Value}";
                if (status.HasValue)
                    criteria += $" AND U.USER_Status = {status.Value}";

                // Get users with pagination
                var users = _userService.GetUSRUserMasters("U.USER_FirstName", "ASC", pageIndex, pageSize, criteria);

                // Get roles for dropdown
                var roles = _roleService.GetUSRRoleMasters();
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName
                }).ToList();

                // Convert to ViewModels
                var userViewModels = users.Select(u => new UserViewModel
                {
                    Id = u.USER_ID,
                    UserId = u.USER_ID,
                    UserName = u.UserName,
                    FirstName = u.USER_FirstName,
                    LastName = u.USER_LastName,
                    Email = u.USER_EmailID,
                    Mobile = u.USER_MobileNo,
                    PhoneNumber = u.USER_PhoneNo,
                    RoleName = u.strUSER_Type,
                    Status = u.USER_Status == "Active" ? 1 : 0,
                    CreatedDate = DateTime.TryParse(u.USER_LastUpdateDate, out DateTime createdDate) ? createdDate : DateTime.Now
                }).ToList();

                ViewBag.Roles = roleViewModels;
                ViewBag.PageIndex = pageIndex;
                ViewBag.TotalPages = (int)Math.Ceiling((double)users.Count / pageSize);

                return View(userViewModels);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading users: " + ex.Message;
                return View(new List<UserViewModel>());
            }
        }

        // GET: UserMaster/Create
        public IActionResult Create()
        {
            try
            {
                var model = new UserViewModel();

                // Get roles for dropdown
                var roles = _roleService.GetUSRRoleMasters();
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName
                }).ToList();

                // Get privileges for the form
                var privileges = _privilegeService.GetFunctionalityRights();
                var privilegeViewModels = privileges.GroupBy(p => p.FunctionName)
                    .Select(g => new PrivilegeViewModel
                    {
                        ModuleName = g.Key,
                        PageName = g.First().FunctionName,
                        PageId = g.First().FunctionID,
                        Rights = g.Select(r => new RightViewModel
                        {
                            Id = r.FunctionID,
                            Name = r.FunctionName,
                            IsAssigned = false
                        }).ToList()
                    }).ToList();

                model.Privileges = privilegeViewModels;
                ViewBag.Roles = roleViewModels;

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading create form: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: UserMaster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var connection = _dbHelper.GetConnection();
                    connection.Open();
                    var transaction = connection.BeginTransaction();

                    try
                    {
                        // Convert ViewModel to Entity
                        var userEntity = new USRUserMaster
                        {
                            USER_FirstName = model.FirstName,
                            USER_LastName = model.LastName,
                            USER_EmailID = model.Email,
                            USER_LoginID = model.LoginId,
                            USER_Password = model.Password, // Note: Should be hashed in production
                            USER_MobileNo = model.Mobile,
                            USER_PhoneNo = model.PhoneNumber,
                            User_Type = model.RoleId ?? 0,
                            USER_Status = model.Status,
                            USER_LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            ROwVersion = 1
                        };

                        var result = _userService.InsertUSRUserMaster(userEntity, ref connection, ref transaction);

                        if (result.RetVal == 1)
                        {
                            transaction.Commit();
                            TempData["Success"] = "User created successfully.";
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            transaction.Rollback();
                            ModelState.AddModelError("", result.RetStr);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", "Error creating user: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }

                // Reload form data if validation fails
                var roles = _roleService.GetUSRRoleMasters();
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName
                }).ToList();
                ViewBag.Roles = roleViewModels;

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error creating user: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: UserMaster/Edit/5
        public IActionResult Edit(int id)
        {
            try
            {
                var user = _userService.GetUSRUserMaster(id);
                if (user == null)
                {
                    TempData["Error"] = "User not found.";
                    return RedirectToAction("Index");
                }

                var model = new UserViewModel
                {
                    Id = user.USER_ID,
                    UserId = user.USER_ID,
                    UserName = $"{user.USER_FirstName} {user.USER_LastName}",
                    FirstName = user.USER_FirstName,
                    LastName = user.USER_LastName,
                    Email = user.USER_EmailID,
                    LoginId = user.USER_LoginID,
                    Mobile = user.USER_MobileNo,
                    PhoneNumber = user.USER_PhoneNo,
                    RoleId = user.User_Type,
                    Status = user.USER_Status,
                    CreatedDate = DateTime.TryParse(user.USER_LastUpdateDate, out DateTime createdDate) ? createdDate : DateTime.Now
                };

                // Get roles for dropdown
                var roles = _roleService.GetUSRRoleMasters();
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName
                }).ToList();
                ViewBag.Roles = roleViewModels;

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading user: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: UserMaster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UserViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var connection = _dbHelper.GetConnection();
                    connection.Open();
                    var transaction = connection.BeginTransaction();

                    try
                    {
                        // Get existing user
                        var existingUser = _userService.GetUSRUserMaster(id);
                        if (existingUser == null)
                        {
                            TempData["Error"] = "User not found.";
                            return RedirectToAction("Index");
                        }

                        // Update user properties
                        existingUser.USER_FirstName = model.FirstName;
                        existingUser.USER_LastName = model.LastName;
                        existingUser.USER_EmailID = model.Email;
                        existingUser.USER_LoginID = model.LoginId;
                        existingUser.USER_MobileNo = model.Mobile;
                        existingUser.USER_PhoneNo = model.PhoneNumber;
                        existingUser.User_Type = model.RoleId ?? 0;
                        existingUser.USER_Status = model.Status;
                        existingUser.USER_LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        var result = _userService.UpdateUSRUserMaster(existingUser, ref connection, ref transaction);

                        if (result.RetVal == 1)
                        {
                            transaction.Commit();
                            TempData["Success"] = "User updated successfully.";
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            transaction.Rollback();
                            ModelState.AddModelError("", result.RetStr);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        ModelState.AddModelError("", "Error updating user: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }

                // Reload form data if validation fails
                var roles = _roleService.GetUSRRoleMasters();
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName
                }).ToList();
                ViewBag.Roles = roleViewModels;

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error updating user: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: UserMaster/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                var user = _userService.GetUSRUserMaster(id);
                if (user == null)
                {
                    TempData["Error"] = "User not found.";
                    return RedirectToAction("Index");
                }

                var model = new UserViewModel
                {
                    Id = user.USER_ID,
                    UserId = user.USER_ID,
                    UserName = $"{user.USER_FirstName} {user.USER_LastName}",
                    FirstName = user.USER_FirstName,
                    LastName = user.USER_LastName,
                    Email = user.USER_EmailID,
                    LoginId = user.USER_LoginID,
                    Mobile = user.USER_MobileNo,
                    PhoneNumber = user.USER_PhoneNo,
                    RoleId = user.User_Type,
                    Status = user.USER_Status
                };

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading user: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: UserMaster/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                var connection = _dbHelper.GetConnection();
                connection.Open();
                var transaction = connection.BeginTransaction();

                try
                {
                    var result = _userService.DeleteUSRUserMaster(id, ref connection, ref transaction);

                    if (result.RetVal == 1)
                    {
                        transaction.Commit();
                        TempData["Success"] = "User deleted successfully.";
                    }
                    else
                    {
                        transaction.Rollback();
                        TempData["Error"] = result.RetStr;
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["Error"] = "Error deleting user: " + ex.Message;
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error deleting user: " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}