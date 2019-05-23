﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Areas.Identity.Data
{
	public class ApplicationUser : IdentityUser
	{
		public string FullName { get; set; }

		// Navigation Properties...
		public virtual ICollection<IdentityUserClaim<string>> Claims { get; set; }
		public virtual ICollection<IdentityUserLogin<string>> Logins { get; set; }
		public virtual ICollection<IdentityUserToken<string>> Tokens { get; set; }
		public virtual ICollection<IdentityUserRole<string>> UserRoles { get; set; }
	}
}
