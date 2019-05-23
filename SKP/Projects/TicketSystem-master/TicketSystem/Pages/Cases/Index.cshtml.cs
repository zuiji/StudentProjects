using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Authorization;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Pages.Cases
{
    public class IndexModel : TSCase_BasePageModel
    {
        public IndexModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
			: base(context, authorizationService, userManager)
        {
        }

        public IList<Case> Case { get; set; }

        public async Task OnGetAsync()
        {
            Case = await Context.Case
				.Include(o => o.Operator)
				.Include(r => r.Requestor)
				.Include(s => s.Status)
					.ToListAsync();
        }
    }
}
