using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Evaluator.Models
{
	public class EvaluationHead
	{
		[Key]
        public int Id { get; set; }
		[Required]
		public int ApplicationId { get; set; }
		[Required]
		public string JudgesId { get; set; }
		[ForeignKey("ApplicationId")]
		public virtual ApplicantProf ApplicantProf { get; set; }
		[ForeignKey("JudgesId")]
		public virtual ApplicationUser ApplicationUser { get; set; }
	}
}
