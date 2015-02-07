using System;

namespace GettingOld
{
	public class HomeViewModel
	{
		public string Name { get; set; }
		public int NextAge { get; set; }
		public TimeSpan AgeTimeSpan { get; set; }
		public TimeSpan UntilNextAgeTimeSpan { get; set; }
		public FamousPerson FamousPerson { get; set; }
	}
}