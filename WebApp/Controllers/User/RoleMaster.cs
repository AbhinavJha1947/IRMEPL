using Microsoft.AspNetCore.Mvc;
using Application.Interfaces.User;
using Core.Entities.User;
using WebApp.ViewModels;
using System.Data.SqlClient;
using Infrastructure.Data;

namespace WebApp.Controllers.User
{
    public class RoleMaster : Controller
    {
        private readonly IUSRRoleMasterService _roleService;
        private readonly DbHelper _dbHelper;

        public RoleMaster(IUSRRoleMasterService roleService, DbHelper dbHelper)
        {
            _roleService = roleService;
            _dbHelper = dbHelper;
        }

        // GET: RoleMaster
        public IActionResult Index(string roleName, int? status, int pageIndex = 1, int pageSize = 10)
        {
            try
            {
                // Build criteria for search
                string criteria = "";
                if (!string.IsNullOrEmpty(roleName))
                    criteria += $" AND R.ROLMST_RoleName LIKE '%{roleName}%'";
                if (status.HasValue)
                    criteria += $" AND R.ROLMST_RowStatus = {status.Value}";

                // Get roles with pagination
                var roles = _roleService.GetUSRRoleMasters("R.ROLMST_RoleName", "ASC", pageIndex, pageSize, criteria);

                // Convert to ViewModels
                var roleViewModels = roles.Select(r => new RoleViewModel
                {
                    RoleId = r.ROLMST_RoleID,
                    RoleName = r.ROLMST_RoleName,
                    RoleDescription = r.ROLMST_RoleDescription,
                    Status = r.ROLMST_RowStatus == "Active" ? 1 : 0,
                    RoleCount = r.rolecount,
                    IsActive = r.ROLMST_RowStatus == "Active",
                    CreatedDate = DateTime.Now // You might want to add this to the entity
                }).ToList();

                ViewBag.PageIndex = pageIndex;
                ViewBag.TotalPages = (int)Math.Ceiling((double)roles.Count / pageSize);

                return View(roleViewModels);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading roles: " + ex.Message;
                return View(new List<RoleViewModel>());
            }
        }

        // GET: RoleMaster/Create
        public IActionResult Create()
        {
            var model = new RoleViewModel();
            return View(model);
        }

        // POST: RoleMaster/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(RoleViewModel model)
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
                        var roleEntity = new USRRoleMaster
                        {
                            ROLMST_RoleName = model.RoleName,
                            ROLMST_RoleDescription = model.RoleDescription,
                            ROLMST_RowStatus = model.Status,
                            ROLMST_CreatedByUserID = 1, // You might want to get this from session
                            ROLMST_CreatedDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            ROLMST_UpdatedByUserID = 1,
                            ROLMST_LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
                            ROLMST_RowVersion = 1,
                            ROLMST_AUDITMID = 1
                        };

                        var result = _roleService.InsertUSRRoleMaster(roleEntity, ref connection, ref transaction);

                        if (result.RetVal == 1)
                        {
                            transaction.Commit();
                            TempData["Success"] = "Role created successfully.";
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
                        ModelState.AddModelError("", "Error creating role: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error creating role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: RoleMaster/Edit/5
        public IActionResult Edit(int id)
        {
            try
            {
                var role = _roleService.GetUSRRoleMaster(id);
                if (role == null)
                {
                    TempData["Error"] = "Role not found.";
                    return RedirectToAction("Index");
                }

                var model = new RoleViewModel
                {
                    RoleId = role.ROLMST_RoleID,
                    RoleName = role.ROLMST_RoleName,
                    RoleDescription = role.ROLMST_RoleDescription,
                    Status = role.ROLMST_RowStatus,
                    IsActive = role.ROLMST_RowStatus == 1,
                    CreatedDate = DateTime.TryParse(role.ROLMST_CreatedDate, out DateTime createdDate) ? createdDate : DateTime.Now,
                    LastModifiedDate = DateTime.TryParse(role.ROLMST_LastUpdateDate, out DateTime modifiedDate) ? modifiedDate : DateTime.Now
                };

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: RoleMaster/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, RoleViewModel model)
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
                        // Get existing role
                        var existingRole = _roleService.GetUSRRoleMaster(id);
                        if (existingRole == null)
                        {
                            TempData["Error"] = "Role not found.";
                            return RedirectToAction("Index");
                        }

                        // Update role properties
                        existingRole.ROLMST_RoleName = model.RoleName;
                        existingRole.ROLMST_RoleDescription = model.RoleDescription;
                        existingRole.ROLMST_RowStatus = model.Status;
                        existingRole.ROLMST_UpdatedByUserID = 1; // You might want to get this from session
                        existingRole.ROLMST_LastUpdateDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                        var result = _roleService.UpdateUSRRoleMaster(existingRole, ref connection, ref transaction);

                        if (result.RetVal == 1)
                        {
                            transaction.Commit();
                            TempData["Success"] = "Role updated successfully.";
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
                        ModelState.AddModelError("", "Error updating role: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                        connection.Dispose();
                    }
                }

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error updating role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: RoleMaster/Delete/5
        public IActionResult Delete(int id)
        {
            try
            {
                var role = _roleService.GetUSRRoleMaster(id);
                if (role == null)
                {
                    TempData["Error"] = "Role not found.";
                    return RedirectToAction("Index");
                }

                var model = new RoleViewModel
                {
                    RoleId = role.ROLMST_RoleID,
                    RoleName = role.ROLMST_RoleName,
                    RoleDescription = role.ROLMST_RoleDescription,
                    Status = role.ROLMST_RowStatus,
                    IsActive = role.ROLMST_RowStatus == 1
                };

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // POST: RoleMaster/Delete/5
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
                    var role = _roleService.GetUSRRoleMaster(id);
                    if (role == null)
                    {
                        TempData["Error"] = "Role not found.";
                        return RedirectToAction("Index");
                    }

                    var result = _roleService.DeleteUSRRoleMaster(role, ref connection, ref transaction);

                    if (result == 1)
                    {
                        transaction.Commit();
                        TempData["Success"] = "Role deleted successfully.";
                    }
                    else
                    {
                        transaction.Rollback();
                        TempData["Error"] = "Error deleting role.";
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    TempData["Error"] = "Error deleting role: " + ex.Message;
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
                TempData["Error"] = "Error deleting role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }

        // GET: RoleMaster/Details/5
        public IActionResult Details(int id)
        {
            try
            {
                var role = _roleService.GetUSRRoleMaster(id);
                if (role == null)
                {
                    TempData["Error"] = "Role not found.";
                    return RedirectToAction("Index");
                }

                var model = new RoleViewModel
                {
                    RoleId = role.ROLMST_RoleID,
                    RoleName = role.ROLMST_RoleName,
                    RoleDescription = role.ROLMST_RoleDescription,
                    Status = role.ROLMST_RowStatus,
                    IsActive = role.ROLMST_RowStatus == 1,
                    CreatedDate = DateTime.TryParse(role.ROLMST_CreatedDate, out DateTime createdDate) ? createdDate : DateTime.Now,
                    LastModifiedDate = DateTime.TryParse(role.ROLMST_LastUpdateDate, out DateTime modifiedDate) ? modifiedDate : DateTime.Now
                };

                return View(model);
            }
            catch (Exception ex)
            {
                TempData["Error"] = "Error loading role: " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}