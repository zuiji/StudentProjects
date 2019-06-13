using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Areas.Identity.Data;
using TicketSystem.Authorization;

namespace TicketSystem.Data
{
	public class SeedUsersAndRoles
	{
		public static async Task SeedData(IServiceProvider serviceProvider, string adminUserPWD)
		{
			// Initializing Role and Usermanager 
			var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
			var UserManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

			await SeedRoles(RoleManager);
			await SeedUsers(UserManager, adminUserPWD);
		}


		// Seed User Roles...
		private static async Task SeedRoles(RoleManager<IdentityRole> roleManager)
		{
			// Create array of roles to add...
			string[] roleNames = { "Administrator", "Sagsbehandler", "Medarbejder" };

			// Initialize IdentityResult...
			IdentityResult roleResult;

			// Loop through roles and add...
			foreach (var roleName in roleNames)
			{
				var roleExist = await roleManager.RoleExistsAsync(roleName);

				if (!roleExist)
				{
					//create the roles and seed them to the database: Question 1
					roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
				}
			}
		}


		// Seed Default Users...
		private static async Task SeedUsers(UserManager<ApplicationUser> userManager, string adminUserPWD)
		{
			// Create List of admin users to add...
			var administrators = new ApplicationUser[]
			{
				new ApplicationUser
				{
					UserName = "lass897g@zbc.dk",
					Email = "lass897g@zbc.dk",
					EmailConfirmed = true
				},
				new ApplicationUser
				{
					UserName = "pete646a@zbc.dk",
					Email = "pete646a@zbc.dk",
					EmailConfirmed = true
				},
				new ApplicationUser
				{
					UserName = "mich612i@zbc.dk",
					Email = "mich612i@zbc.dk",
					EmailConfirmed = true
				}
			};

			// Loop through the users and add them...
			foreach (ApplicationUser user in administrators)
			{
				// Ensure you have these values in your appsettings.json file...
				var _user = await userManager.FindByEmailAsync(user.Email);

				// Check users not already exist...
				if (_user == null)
				{
					var createUser = await userManager.CreateAsync(user, adminUserPWD);
					if (createUser.Succeeded)
					{
						// here we tie the new user to the Administrator role...
						await userManager.AddToRoleAsync(user, Constants.CaseAdministratorsRole);
					}
				}
			}

			// Create default operator users...
			var operators = new ApplicationUser[]
			{
				new ApplicationUser
				{
					UserName = "operator1@zbc.dk",
					Email = "operator1@zbc.dk",
					EmailConfirmed = true
				},
				new ApplicationUser
				{
					UserName = "operator2@zbc.dk",
					Email = "operator2@zbc.dk",
					EmailConfirmed = true
				},
				new ApplicationUser
				{
					UserName = "operator3@zbc.dk",
					Email = "operator3@zbc.dk",
					EmailConfirmed = true
				}
			};

			// Loop through operators and add them...
			foreach (ApplicationUser user in operators)
			{
				// Ensure you have these values in your appsettings.json file...
				var _user = await userManager.FindByEmailAsync(user.Email);

				// Check users not already exist...
				if (_user == null)
				{
					var createUser = await userManager.CreateAsync(user, adminUserPWD);
					if (createUser.Succeeded)
					{
						// here we tie the new user to the Administrator role...
						await userManager.AddToRoleAsync(user, Constants.CaseOperatorsRole);
					}
				}
			}


			// Create default requestor users...
			var requestors = new ApplicationUser[]
			{
				new ApplicationUser
				{
					UserName = "requestor1@zbc.dk",
					Email = "requestor1@zbc.dk",
					EmailConfirmed = true,
				},
				new ApplicationUser
				{
					UserName = "requestor2@zbc.dk",
					Email = "requestor2@zbc.dk",
					EmailConfirmed = true,
				},
				new ApplicationUser
				{
					UserName = "requestor3@zbc.dk",
					Email = "requestor3@zbc.dk",
					EmailConfirmed = true,
				}
			};

			// Loop through requestors and add them...
			foreach (ApplicationUser user in requestors)
			{
				// Ensure you have these values in your appsettings.json file...
				var _user = await userManager.FindByEmailAsync(user.Email);

				// Check users not already exist...
				if (_user == null)
				{
					var createUser = await userManager.CreateAsync(user, adminUserPWD);
					if (createUser.Succeeded)
					{
						// here we tie the new user to the Administrator role...
						await userManager.AddToRoleAsync(user, Constants.CaseRequestorsRole);
					}
				}
			}
		}
	}
}
