using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorWithCodeFirst.Model
{
    public class Expense
    {
        public int ID { get; set; }
        public required string Description { get; set; } = string.Empty;

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime DateIncurred { get; set; }

        public string Location { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public double Price { get; set; }

        // Expense Type ID (foreign key)
        [Display(Name = "Expense Type")]
        public int ExpenseTypeID { get; set; }

        // Expense Type
        public ExpenseType? ExpenseType { get; set; }

        // User ID
        public int UserID { get; set; }
    }
}
