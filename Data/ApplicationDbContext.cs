using Evaluator.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Evaluator.Data
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>

	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{

		}

		public DbSet<ApplicantProf> ApplicantProf { get; set; }
		public DbSet<Applicant> Applicant { get; set; }

		public DbSet<Criteria> Criteria { get; set; }

		public DbSet<EvaluationHead> EvaluationHead { get; set; }
		public DbSet<EvaluationTrans> EvaluationTrans { get; set; }
		public DbSet<User> users { get; set; }

		
	}

	
}
