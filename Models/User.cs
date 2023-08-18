using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Evaluator.Models
{
	public class User : IdentityUser
	{
		
		public int UserId { get; set; }
	}

}
