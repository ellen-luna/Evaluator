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
				new EvaluationHead { ApplicationId = 3},
				new EvaluationHead { ApplicationId = 4},
				new EvaluationHead { ApplicationId = 17},
				new EvaluationHead { ApplicationId = 0},
				new EvaluationHead { ApplicationId = 20}
			};
				foreach (var a in AppHead)
				{
					_db.EvaluationHead.Add(a);
				}
				_db.SaveChanges();
				var Crit = new List<Criteria>
				{
					new Criteria {Name = "Fav Color",Description = "",Weight=25},
					new Criteria {Name = "Fav Birb",Description = "",Weight=25},
					new Criteria {Name = "Can you sing?",Description = "",Weight=25},
					new Criteria {Name = "What is your typing speed?",Description = "",Weight=25}
				};
				foreach (var c in Crit)
				{
					_db.Criteria.Add(c);
				}
				_db.SaveChanges();
			}
		}
	}
}
