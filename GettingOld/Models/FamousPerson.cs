using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GettingOld
{
	public class FamousPerson
	{
		public string Name { get;set;}
		public DateTime Birthday { get;set;}
		public DateTime FamousDate { get; set; }
		public DateTime YourBirthday{get;set;}
		public string Description { get; set; }

		public string YourComparisonAge
		{
			get
			{
				return String.Format("{0} years {1} months", ((Birthday - YourBirthday).TotalDays / 365.25).ToString("F0"), (((Birthday - YourBirthday).TotalDays % 365.25) / 30).ToString("F0"));
			}
		}

		public DateTime YourFamousAge
		{
			get
			{
				return (YourBirthday.AddSeconds((FamousDate - Birthday).TotalSeconds));
			}
		}
	}
}