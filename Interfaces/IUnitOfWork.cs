using Evaluator.Models;

namespace Evaluator.Interfaces
{
	public interface IUnitOfWork
	{
		//public IGenericRepository<Category> Category { get; } Example
		public IGenericRepository<Applicant> Applicant { get; }
		public IGenericRepository<ApplicantProf> ApplicantProf { get; }
		public IGenericRepository<Criteria> Criteria { get; }
		public IGenericRepository<EvaluationHead> EvaluationHead { get; }
		public IGenericRepository<EvaluationTrans> EvaluationTrans { get; }

		public IGenericRepository<ApplicationUser> ApplicationUser { get; }
		//ADD other Models/Tables here as you create them so UnitOfWork will have access

		//save changes to the data source

		int Commit();

		Task<int> CommitAsync();

	}

}
