using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Evaluation
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext _db;  //local instance of the database service

		public List<EvaluationHead> objEvaluationHeadList;  //our UI front end will support looping through and displaying Categories retrieved from the database and stored in a List
		public List<Criteria> objCritList;
		public IEnumerable<Applicant> Applicant { get; set; }
		public IndexModel(ApplicationDbContext db)  //dependency injection of the database service
		{
			_db = db;
			objEvaluationHeadList = new List<EvaluationHead>();
			objCritList = new List<Criteria>();
		}
		public IActionResult OnGet()
		{
			//There are five major sets of IActionResult Types the can be returned
			//1. Server Status Code Results
			//2. Server Status Code and Object Results
			//3. Redirect (to another webpage) Results
			//4. File Results
			//5. Content Results (like another Razor Web Page)
			Applicant = _db.Applicant;
			objEvaluationHeadList = _db.EvaluationHead.ToList();
			objCritList = _db.Criteria.ToList();
			return Page();    //render Page

		}
		public IActionResult OnPost()
		{
			return RedirectToPage();
		}
	}
}
