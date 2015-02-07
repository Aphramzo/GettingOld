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
			var tSwiftAgeFirstAlbum = Convert.ToDateTime("10/24/2006") - Convert.ToDateTime("12/13/1989");
			return View(new HomeViewModel
			{
				AgeTimeSpan = ageSpan,
				UntilNextAgeTimeSpan = (birthdate.AddYears(nextAge) - DateTime.Now),
				TSwiftTimeSpan = (Convert.ToDateTime("12/13/1989") - birthdate),
				TSwiftFirstAlbum = (birthdate.AddSeconds(tSwiftAgeFirstAlbum.TotalSeconds)),
				Name = ConfigurationManager.AppSettings["Name"],
				NextAge = nextAge
			});
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