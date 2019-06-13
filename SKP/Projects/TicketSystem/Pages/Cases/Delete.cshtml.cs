using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Pages.Cases
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Case Case { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Case = await _context.Case
				.Include(c => c.Requestor)
				.Include(c => c.Operator)
				.Include(c => c.Status)
				.AsNoTracking()
				.FirstOrDefaultAsync(m => m.CaseID == id);

            if (Case == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Case = await _context.Case
				.AsNoTracking()
				.FirstOrDefaultAsync(c => c.CaseID == id);

            if (Case != null)
            {
                _context.Case.Remove(Case);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
