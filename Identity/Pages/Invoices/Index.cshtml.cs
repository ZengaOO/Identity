using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Identity;
using Identity.Data;

namespace Identity.Pages.Invoices
{
    public class IndexModel : PageModel
    {
        private readonly Identity.Data.ApplicationDbContext _context;

        public IndexModel(Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Invoice> Invoice { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Invoice != null)
            {
                Invoice = await _context.Invoice.ToListAsync();
            }
        }
    }
}
