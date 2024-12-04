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
    public class IndexModel : PageModel
    {
        private readonly RazorWithCodeFirst.Data.ProjectContext _context;

        public IndexModel(RazorWithCodeFirst.Data.ProjectContext context)
        {
            _context = context;
        }

        public IList<Expense> Expense { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Expense = await _context.Expenses
                .Include(e => e.ExpenseType).ToListAsync();
        }
    }
}
