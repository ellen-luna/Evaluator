using Evaluator.Data;
using Evaluator.Interfaces;
using Evaluator.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Evaluator.Pages.Evaluation
{
    public class EvaluateModel : PageModel
    {
		//Inject unit of work
		private readonly UnitOfWork _unitOfWork;

		//public EvaluationHead ObjEvaluationHeader { get; set; }
		//public IEnumerable<Criteria> ObjCriteriaList { get; set; }
		public IEnumerable<EvaluationTrans> ObjTransList { get; set; }

		public EvaluateModel(UnitOfWork UnitOfWork)
		{
			_unitOfWork = UnitOfWork;
			//ObjEvaluationHeader = new EvaluationHead();
			//ObjCriteriaList = new List<Criteria>();
			ObjTransList = new List<EvaluationTrans>();
		}
		public IActionResult OnGet(int? id)
        {
			//ObjEvaluationHeader = _unitOfWork.EvaluationHead.Get(h=>h.ApplicationId==id);
			ObjTransList = _unitOfWork.EvaluationTrans.GetAll(a=>a.ApplicationProf.Id == id);
			//ObjCriteriaList = _unitOfWork.Criteria.GetAll();
			//if(ObjEvaluationHeader is  null) { ObjEvaluationHeader = new EvaluationHead(); }
			return Page();
		}
    }
}
