using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.ApplicationProfs
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public IEnumerable<ApplicantProf> ApplicantProfs { get; set; }
		public IEnumerable<Applicant> Applicant { get; set; }

		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}

		public void OnGet()
        {
        }
    }
}
