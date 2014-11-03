using System;
using System.Collections.Generic;

namespace Models
{
	public class Performance : BaseEntity
	{
		public PerformanceType Type { get; set; }

		public List<PerformanceCategory> Categories { get; set; }

		public DateTime Start { get; set; }

		public DateTime? End { get; set; }

		public List<Performer> Performers { get; set; }

		public Venue Location { get; set; }
	}
}

