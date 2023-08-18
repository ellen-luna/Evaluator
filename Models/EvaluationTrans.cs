using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Evaluator.Models
{
	public class EvaluationTrans
	{
        public int Id { get; set; }
		[Required]
		public int EvaluationId { get; set; }
		[Required]
		public int CriteriaId { get; set; }
		[Precision(18, 2)]
		public decimal Score { get; set;}
		[ForeignKey("EvaluationId")]
		public virtual EvaluationHead EvaluationHead { get; set; }
		[ForeignKey("CriteriaId")]
		public virtual Criteria Criteria { get; set; }
	}
}
