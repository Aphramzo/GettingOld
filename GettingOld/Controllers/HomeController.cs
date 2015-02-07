using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GettingOld.Controllers
{
	public class HomeController : Controller
	{
		
		public ActionResult Index()
		{
			var birthdate = Convert.ToDateTime(ConfigurationManager.AppSettings["Birthday"]);
			var ageSpan = (DateTime.Now - birthdate);
			var nextAge = ((int)Math.Round(((ageSpan.TotalDays / 365.25) + 5) / 10.0)) * 10;
			var person = GetComparison(birthdate);
			return View(new HomeViewModel
			{
				AgeTimeSpan = ageSpan,
				UntilNextAgeTimeSpan = (birthdate.AddYears(nextAge) - DateTime.Now),
				FamousPerson = person,
				Name = ConfigurationManager.AppSettings["Name"],
				NextAge = nextAge
			});
		}

		private FamousPerson GetComparison(DateTime yourBirthday)
		{
			//TODO: make this a little less manual
			var rnd = new Random();
			var number = rnd.Next(1,3);
			switch(number)
			{
				case 1: 
					return new FamousPerson
					{
						Name = "Taylor Swift",
						Description = "And she already has five multi platinum albums. The first of which she released when she was 17 years old.",
						Birthday = Convert.ToDateTime("12/13/1989"),
						FamousDate = Convert.ToDateTime("10/24/2006"),
						YourBirthday = yourBirthday
					};
				case 2:
				default:
					return new FamousPerson
					{
						Name = "Nathan MacKinnon",
						Description = "Was drafted #1 overall in the NHL and went on to win rookie of the year at 18 years old with 24 goals and 63 points.",
						Birthday = Convert.ToDateTime("9/1/1995"),
						FamousDate = Convert.ToDateTime("6/24/2014"),
						YourBirthday = yourBirthday
					};
			}
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}