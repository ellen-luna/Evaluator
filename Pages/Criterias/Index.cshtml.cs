using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Criterias
{
    public class IndexModel : PageModel
    {
		private readonly ApplicationDbContext _db;

        public IEnumerable<Criteria> Criterias { get; set; }

		public IndexModel(ApplicationDbContext db)
		{
			_db = db;
		}
		public void OnGet()
        {
			Criterias = _db.Criteria;

		}
    }
}
