using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }

        [Required(ErrorMessage = "Role name is required")]
        [StringLength(50, ErrorMessage = "Role name cannot exceed 50 characters")]
        public string RoleName { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Role description cannot exceed 200 characters")]
        public string? RoleDescription { get; set; }

        public int Status { get; set; }
        public int RoleCount { get; set; }
        public bool IsActive { get; set; } = true;

        public DateTime CreatedDate { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public int CreatedBy { get; set; }

        public int? ModifiedBy { get; set; }
    }
}
