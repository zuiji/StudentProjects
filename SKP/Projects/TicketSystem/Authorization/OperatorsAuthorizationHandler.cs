using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Models;

namespace TicketSystem.Authorization
{
	public class OperatorsAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Case>
	{
		protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, OperationAuthorizationRequirement requirement, Case resource)
		{
			if (context.User == null || resource == null)
			{
				// Return Task.FromResult(0) if targeting a version of
				// .NET Framework older than 4.6:
				return Task.CompletedTask;
			}


			// If we're not asking for following permission, return.
			if (requirement.Name != Constants.ApproveOperationName &&
				requirement.Name != Constants.RejectOperationName &&
				requirement.Name != Constants.DeleteOperationName)
			{
				return Task.CompletedTask;
			}


			if (context.User.IsInRole(Constants.CaseOperatorsRole))
			{
				context.Succeed(requirement);
			}

			return Task.CompletedTask;
		}
	}
}
