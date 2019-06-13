using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TicketSystem.Areas.Identity.Data;

namespace TicketSystem.Models
{
	public class Case
	{
		[Key]
		public int CaseID { get; set; }

		[Display(Name = "Rekvirent")]
		public string RequestorID { get; set; }						// FK.
		public virtual ApplicationUser Requestor { get; set; }		// Navigation Property.

		[Display(Name = "Sagsbehandler")]
		public string OperatorID { get; set; }						// FK.
		public virtual ApplicationUser Operator { get; set; }		// Navigation Property.

		[Display(Name = "Beskrivelse")]
		[StringLength(50, MinimumLength = 10, ErrorMessage = "Kort beskrivelse skal være mellem 10 og 50 tegn!")]
		public string Description { get; set; }

		[Display(Name = "Detaljeret beskrivelse")]
		[StringLength(255, MinimumLength = 10, ErrorMessage = "Detaljeret beskrivelse skal være mellem 10 og 255 tegn!")]
		public string Details { get; set; }

		[Display(Name = "Oprettet")]
		public DateTime Created { get; set; }

		[Display(Name = "Lukket")]
		public DateTime? Closed { get; set; }

		[Display(Name = "Status")]
		public int StatusID { get; set; }			// Status FK navigation property.
		public Status Status { get; set; }			// Navigation property for Status.

		public string OwnerID { get; set; }
	}
}
