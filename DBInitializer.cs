using Evaluator.Data;
using Evaluator.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Evaluator
{
	public class DBInitializer
	{
		private readonly ApplicationDbContext _db;
		public DBInitializer(ApplicationDbContext db)
		{
			_db = db;
			//_userManager = userManager;
			//_roleManager = roleManager;
		}
		public void Initialize()
		{
			if (_db.Database.EnsureCreated())
			{
				try
				{
					if (_db.Database.GetPendingMigrations().Any())
					{
						_db.Database.Migrate();
					}
				}
				catch (Exception)
				{

				}
				var AppHead = new List<EvaluationHead>
			{
				new EvaluationHead { ApplicationId = 3}
			};
				foreach (var a in AppHead)
				{
					_db.EvaluationHead.Add(a);
				}
				_db.SaveChanges();
			}
		}
	}
}
