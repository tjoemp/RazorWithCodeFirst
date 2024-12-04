using System.ComponentModel.DataAnnotations;

namespace RazorWithCodeFirst.Model
{
    public class ExpenseType
    {
        public int ID { get; set; }

        [Display(Name = "Expense Type")]
        public required string Name{ get; set; } = string.Empty;
    }
}