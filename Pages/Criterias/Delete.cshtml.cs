using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Criterias
{
	[BindProperties]
	public class DeleteModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public Criteria Criteria { get; set; }
		public DeleteModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet(int Id)
        {
			Criteria = _db.Criteria.Find(Id);
        }

		public async Task<IActionResult> OnPost()
		{

			if (ModelState.IsValid)
			{
				 _db.Criteria.Remove(Criteria);
				await _db.SaveChangesAsync();
				return RedirectToPage("Index");
			}

			return Page();
		}
	}
}
