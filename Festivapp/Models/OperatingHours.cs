using System;

namespace Models
{
	public class OperatingHours
	{
		public DayOfWeek Day { get; set; }

		public DateTime Open { get; set; }

		public DateTime Close { get; set; }
	}
}

