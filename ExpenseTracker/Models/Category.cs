using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Category
    {
        
        public int CategoryId { get; set; }

        [Required]
        [Display(Name ="Category Name")]
        [MaxLength(100)]
        public string? CategoryName { get; set; }
    }
}
