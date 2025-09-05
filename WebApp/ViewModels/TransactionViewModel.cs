using System.ComponentModel.DataAnnotations;

namespace WebApp.ViewModels
{
    public class TransactionViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Transaction number is required")]
        [StringLength(50, ErrorMessage = "Transaction number cannot exceed 50 characters")]
        public string TransactionNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than 0")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = "Transaction type is required")]
        [StringLength(20, ErrorMessage = "Transaction type cannot exceed 20 characters")]
        public string TransactionType { get; set; } = string.Empty;

        [Required(ErrorMessage = "Status is required")]
        [StringLength(20, ErrorMessage = "Status cannot exceed 20 characters")]
        public string Status { get; set; } = string.Empty;

        [Required(ErrorMessage = "User ID is required")]
        public int UserId { get; set; }

        public string? UserName { get; set; }

        [Required(ErrorMessage = "Transaction date is required")]
        public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

        [StringLength(100, ErrorMessage = "Reference number cannot exceed 100 characters")]
        public string? ReferenceNumber { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
