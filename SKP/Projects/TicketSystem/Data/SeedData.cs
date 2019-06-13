using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Models;

namespace TicketSystem.Data
{
	public static class SeedData
	{
		public static async Task SeedDatabaseAsync(ApplicationDbContext context)
		{
			if (context.Status.Any())
			{
				return;		// Status table are seeded...
			}

			// Seed database table "Status" with static data...
			var statuses = new Status[]
			{
				new Status { Description = "Oprettet" },
				new Status { Description = "Igang" },
				new Status { Description = "Lukket" }
			};

			await context.Status.AddRangeAsync(statuses);
			await context.SaveChangesAsync();
		}
	}
}
