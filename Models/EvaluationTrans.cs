using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Evaluator.Models
{
	public class EvaluationTrans
	{
        public int Id { get; set; }
		
		public int EvaluationId { get; set; }
		public int CriteriaId { get; set; }
		[Precision(18, 2)]
		public decimal Score { get; set;}
    }
}
