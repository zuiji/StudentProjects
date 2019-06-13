using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Models;

namespace TicketSystem.Authorization
{
	public class RequestorsAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Case>
	{
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Case resource)
		{
			if (context.User == null || resource == null)
			{
				// Return Task.FromResult(0) if targeting a version of
				// .NET Framework older than 4.6:
				return Task.CompletedTask;
			}


			// If we're not asking for CRUD permission or approval/reject, return.
			if (requirement.Name != Constants.CreateOperationName &&
				requirement.Name != Constants.ReadOperationName &&
				requirement.Name != Constants.UpdateOperationName &&
				requirement.Name != Constants.DeleteOperationName &&
				requirement.Name != Constants.ApproveOperationName &&
				requirement.Name != Constants.RejectOperationName)
			{
				return Task.CompletedTask;
			}


			if (context.User.IsInRole(Constants.CaseRequestorsRole))
			{
				context.Succeed(requirement);
			}

			return Task.CompletedTask;
		}
	}
}
