using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Authorization;
using TicketSystem.Data;
using TicketSystem.Models;

namespace TicketSystem.Pages.Cases
{
	public class TSCase_BasePageModel : PageModel
	{
		protected ApplicationDbContext Context { get; }
		protected IAuthorizationService AuthorizationService { get; }
		protected UserManager<ApplicationUser> UserManager { get; }
		public SelectList StatusSL { get; private set; }
		public SelectList OperatorSL { get; private set; }
		public SelectList RequestorSL { get; private set; }

		public TSCase_BasePageModel(ApplicationDbContext context, IAuthorizationService authorizationService, UserManager<ApplicationUser> userManager)
			: base()
		{
			Context = context;
			UserManager = userManager;
			AuthorizationService = authorizationService;
		}

		public void PopulateStatusDropDownList(object selectedStatus = null)
		{
			var itemsQuery = from i in Context.Status select i;

			StatusSL = new SelectList(itemsQuery.AsNoTracking(), "StatusID", "Description", selectedStatus);
		}

		public async Task PopulateOperatorDropDownListAsync(object selectedOperator = null)
		{
			var operatorsList = await UserManager.GetUsersInRoleAsync(Constants.CaseOperatorsRole);

			OperatorSL = new SelectList(operatorsList, "Id", "UserName", selectedOperator);
		}

		public async Task PopulateRequestorDropDownListAsync(object selectedRequestor = null)
		{
			var RequestorsList = await UserManager.GetUsersInRoleAsync(Constants.CaseRequestorsRole);

			RequestorSL = new SelectList(RequestorsList, "Id", "UserName", selectedRequestor);
		}
	}
}
