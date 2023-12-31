using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Criterias
{
	[BindProperties]
	public class CreateModel : PageModel
    {
		private readonly ApplicationDbContext _db;
		public Criteria Criteria { get; set; }
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
				await _db.Criteria.AddAsync(Criteria);
				await _db.SaveChangesAsync();
				return RedirectToPage("Index");
			}

			return Page();
		}
	}
}
