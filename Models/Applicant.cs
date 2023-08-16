using System.ComponentModel.DataAnnotations;

namespace Evaluator.Models
{
	public class Applicant
	{
		[Key]
        public int Id { get; set; }	
		public string AppName { get; set;}
    }
}
