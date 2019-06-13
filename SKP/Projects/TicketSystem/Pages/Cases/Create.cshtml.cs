using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Pages.Cases
{
    public class CreateModel : TSCase_BasePageModel
    {
        public CreateModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
			: base(context, authorizationService, userManager)
        {
        }

        [BindProperty]
        public Case Case { get; set; }

		public async Task<IActionResult> OnGetAsync()
		{
			PopulateStatusDropDownList();
			await PopulateOperatorDropDownListAsync();
			await PopulateRequestorDropDownListAsync();
			return Page();
		}

		public async Task<IActionResult> OnPostAsync()
        {
			if (!ModelState.IsValid)
			{
				return Page();
			}

			var emptyCase = new Case
			{
				OwnerID = UserManager.GetUserId(User)
			};

			// Use TryUpdateModelAsync to prevent overposting!
			if (await TryUpdateModelAsync(
				emptyCase,
				"case", // Prefix for form value.
				c => c.CaseID,
				c => c.StatusID,
				c => c.OperatorID,
				c => c.RequestorID,
				c => c.Description,
				c => c.Details,
				c => c.Created))
			{
				Context.Case.Add(emptyCase);
				await Context.SaveChangesAsync();
				return RedirectToPage("./Index");
			}

			// Select StatusID if TryUpdateModelAsync fails.
			PopulateStatusDropDownList(emptyCase.StatusID);
			PopulateOperatorDropDownListAsync(emptyCase.OperatorID).Wait();
			PopulateRequestorDropDownListAsync(emptyCase.RequestorID).Wait();
			return Page();
        }
    }
}