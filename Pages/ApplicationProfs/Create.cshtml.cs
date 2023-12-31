using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.ApplicationProfs
{
	[BindProperties]
	public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public ApplicantProf ApplicantProf { get; set; }

		public Applicant Applicant { get; set; }

		public CreateModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
		{
		}

		public async Task<IActionResult> OnPost()
		{

			if (ModelState.IsValid)
			{
				await _db.Applicant.AddAsync(Applicant);


				await _db.SaveChangesAsync();
				ApplicantProf.ApplicantId = Applicant.Id; 
				await _db.ApplicantProf.AddAsync(ApplicantProf);
				await _db.SaveChangesAsync();
				return RedirectToPage("Index");
			}

			return Page();
		}
	}
}
