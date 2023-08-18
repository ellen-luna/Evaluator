using Evaluator.Data;
using Evaluator.Interfaces;
using Evaluator.Models;

namespace Evaluator
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _dbContext;  //dependency injection of Data Source

		public UnitOfWork(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		private IGenericRepository<Applicant> _Applicant;
		public IGenericRepository<Applicant> Applicant
		{
			get
			{

				if (_Applicant == null)
				{
					_Applicant = new GenericRepository<Applicant>(_dbContext);
				}

				return _Applicant;
			}
		}
		private IGenericRepository<ApplicantProf> _ApplicantProf;
		public IGenericRepository<ApplicantProf> ApplicantProf
		{
			get
			{

				if (_ApplicantProf == null)
				{
					_ApplicantProf = new GenericRepository<ApplicantProf>(_dbContext);
				}

				return _ApplicantProf;
			}
		}
		private IGenericRepository<Criteria> _Criteria;
		public IGenericRepository<Criteria> Criteria
		{
			get
			{

				if (_Criteria == null)
				{
					_Criteria = new GenericRepository<Criteria>(_dbContext);
				}

				return _Criteria;
			}
		}
		private IGenericRepository<EvaluationHead> _EvaluationHead;
		public IGenericRepository<EvaluationHead> EvaluationHead
		{
			get
			{

				if (_EvaluationHead == null)
				{
					_EvaluationHead = new GenericRepository<EvaluationHead>(_dbContext);
				}

				return _EvaluationHead;
			}
		}
		private IGenericRepository<EvaluationTrans> _EvaluationTrans;
		public IGenericRepository<EvaluationTrans> EvaluationTrans
		{
			get
			{

				if (_EvaluationTrans == null)
				{
					_EvaluationTrans = new GenericRepository<EvaluationTrans>(_dbContext);
				}

				return _EvaluationTrans;
			}
		}
		private IGenericRepository<ApplicationUser> _ApplicationUser;
		public IGenericRepository<ApplicationUser> ApplicationUser
		{
			get
			{

				if (_ApplicationUser == null)
				{
					_ApplicationUser = new GenericRepository<ApplicationUser>(_dbContext);
				}

				return _ApplicationUser;
			}
		}
		//ADD ADDITIONAL METHODS FOR EACH MODEL HERE

		public int Commit()
		{
			return _dbContext.SaveChanges();
		}

		public async Task<int> CommitAsync()
		{
			return await _dbContext.SaveChangesAsync();
		}

		//additional method added for garbage disposal

		public void Dispose()
		{
			_dbContext.Dispose();
		}
	}
}

