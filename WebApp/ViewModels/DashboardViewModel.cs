using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class DashboardViewModel
    {
        public string UserName { get; set; } = "";
        public string CenterName { get; set; } = "";
        public string Designation { get; set; } = "";
        public string UserType { get; set; } = "";
        public string CurrentDate { get; set; } = "";
        public string LockingDate { get; set; } = "";
        public List<MenuItemViewModel> MenuItems { get; set; } = new List<MenuItemViewModel>();
        public string DefaultPageUrl { get; set; } = "";
    }

    public class MenuItemViewModel
    {
        public string Text { get; set; } = "";
        public string Url { get; set; } = "#";
        public bool HasAccess { get; set; } = false;
        public List<MenuItemViewModel> SubItems { get; set; } = new List<MenuItemViewModel>();
        public string CssClass { get; set; } = "";
        public string Icon { get; set; } = "";
    }

    public class MessageViewModel
    {
        public string Text { get; set; } = "";
        public string Type { get; set; } = "Danger"; // Success, Info, Warning, Danger
        public bool IsVisible { get; set; } = false;
    }
}