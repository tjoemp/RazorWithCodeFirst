using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWithCodeFirst.Data;
using RazorWithCodeFirst.Model;

namespace RazorWithCodeFirst.Pages.Expenses
{
    public class DetailsModel : PageModel
    {
        private readonly RazorWithCodeFirst.Data.ProjectContext _context;

        public DetailsModel(RazorWithCodeFirst.Data.ProjectContext context)
        {
            _context = context;
        }

        public Expense Expense { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses.FirstOrDefaultAsync(m => m.ID == id);

            if (expense is not null)
            {
                Expense = expense;

                return Page();
            }

            return NotFound();
        }
    }
}
