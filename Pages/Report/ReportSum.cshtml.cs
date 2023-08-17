using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Report
{
	[BindProperties]
	public class ReportSumModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public IEnumerable<Applicant> Applicant { get; set; }
		public IEnumerable<ApplicantProf> ApplicantProfs {get; set;	}

		public ReportSumModel(ApplicationDbContext db)
		{
			_db = db;
		}

		public void OnGet()
        {
			Applicant = _db.Applicant;
			ApplicantProfs = _db.ApplicantProf;
		}
    }
}
