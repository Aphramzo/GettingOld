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
			return View(new HomeViewModel
			{
				AgeTimeSpan = (DateTime.Now - birthdate)
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