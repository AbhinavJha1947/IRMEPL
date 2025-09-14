using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class PrivilegeViewModel
    {
        public int PageId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public string PageName { get; set; } = string.Empty;
        public List<RightViewModel> Rights { get; set; } = new List<RightViewModel>();
    }

    public class RightViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool IsAssigned { get; set; }
    }
}
