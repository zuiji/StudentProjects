using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Pages.Cases
{
    public class EditModel : TSCase_BasePageModel
    {
        public EditModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
			: base(context, authorizationService, userManager)
        {
        }

        [BindProperty]
        public Case Case { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
			// Check ID not null...
            if (id == null)
            {
                return NotFound();
            }

			// Load Case and related data from db...
            Case = await Context.Case
				.Include(o => o.Operator)
				.Include(r => r.Requestor)
				.Include(s => s.Status)
				.AsNoTracking()
				.FirstOrDefaultAsync(m => m.CaseID == id);

			// Check Case not null...
			if (Case == null)
			{
				return NotFound();
			}

			// Populate Drop Down Boxes...
			PopulateRequestorDropDownListAsync(Case.RequestorID).Wait();
			PopulateOperatorDropDownListAsync(Case.OperatorID).Wait();
			PopulateStatusDropDownList(Case.StatusID);

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

			// Load the case to update...
			Case CaseToUpdate = await Context.Case
				.Include(c => c.Requestor)
				.Include(c => c.Operator)
				.Include(c => c.Status)
				.AsNoTracking()
				.FirstOrDefaultAsync(c => c.CaseID == id);

			// Use TryUpdateModelAsync to prevent overposting!
			if (await TryUpdateModelAsync(
				CaseToUpdate,
				"case", // Prefix for form value.
				c => c.RequestorID,
				c => c.OperatorID,
				c => c.Description,
				c => c.Details,
				c => c.StatusID))
			{
				// Try save change to db async...
				try
				{
					Context.Update(Case);
					await Context.SaveChangesAsync();
					return RedirectToPage("./Index");
				}
				catch (DbUpdateConcurrencyException)
				{
					if (!CaseExists(Case.CaseID))
					{
						return NotFound();
					}
					else
					{
						throw;
					}
				}
			}

			// Populate Drop Down Boxes...
			PopulateRequestorDropDownListAsync(CaseToUpdate.RequestorID).Wait();
			PopulateOperatorDropDownListAsync(CaseToUpdate.OperatorID).Wait();
			PopulateStatusDropDownList(CaseToUpdate.StatusID);
			return Page();
        }

        private bool CaseExists(int id)
        {
            return Context.Case.Any(e => e.CaseID == id);
        }
    }
}
