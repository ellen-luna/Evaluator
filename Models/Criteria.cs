using System.ComponentModel.DataAnnotations;

namespace Evaluator.Models
{
	public class Criteria
	{
		[Key]
        public int CritId { get; set; }
		[Required]
		public string Name { get; set; }
		public string Description { get; set; }
		public int Weight { get; set; }

    }
}
