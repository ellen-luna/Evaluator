using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.ApplicationProfs
{
	[BindProperties]
	public class EditModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public ApplicantProf ApplicantProf { get; set; }

		public Applicant Applicant { get; set; }

		public EditModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int Id)
		{
			Applicant = _db.Applicant.Find(Id);
			ApplicantProf = _db.ApplicantProf.Find(Id);
			
		}

		public async Task<IActionResult> OnPost()
		{

			if (ModelState.IsValid)
			{
				 _db.Applicant.Update(Applicant);


				await _db.SaveChangesAsync();
				ApplicantProf.ApplicantId = Applicant.Id; 
				 _db.ApplicantProf.Update(ApplicantProf);
				await _db.SaveChangesAsync();
				return RedirectToPage("Index");
			}

			return Page();
		}
	}
}
