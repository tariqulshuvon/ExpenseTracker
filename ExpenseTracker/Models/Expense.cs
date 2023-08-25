using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int ExpenseId { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        [Display(Name ="Expense amount")]
        public int Amount { get; set; }

        [Required]
        [Display(Name ="Date of the expense")]
        public DateTime Date { get; set; }
    }
}
