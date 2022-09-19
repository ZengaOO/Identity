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
    public class DetailsModel : PageModel
    {
        private readonly Identity.Data.ApplicationDbContext _context;

        public DetailsModel(Identity.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Invoice Invoice { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Invoice == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoice.FirstOrDefaultAsync(m => m.InvoiceId == id);
            if (invoice == null)
            {
                return NotFound();
            }
            else 
            {
                Invoice = invoice;
            }
            return Page();
        }
    }
}
