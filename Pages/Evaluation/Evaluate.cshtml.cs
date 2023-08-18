using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Evaluation
{
    public class EvaluateModel : PageModel
    {
		//Inject unit of work
		private readonly UnitOfWork _unitOfWork;

		public EvaluationHead ObjEvaluationHeader { get; set; }
		public IEnumerable<Criteria> ObjCriteriaList { get; set; }
		public IEnumerable<EvaluationTrans> ObjTransList { get; set; }

		public EvaluateModel(ApplicationDbContext db)
		{
			_db= db;
			ObjEvaluationHeader = new EvaluationHead();
		}
		public void OnGet(int? id)
        {
			_db.EvaluationHead.Find(id);
        }
    }
}
