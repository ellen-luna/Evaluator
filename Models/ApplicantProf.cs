using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluator.Models
{
	public class ApplicantProf
	{
		public int Id { get; set; }
		public int ApplicantId { get; set; }
		
		public string Description { get; set; }
		public DateTime ApplicationDate { get; set; }

		
	}
}
