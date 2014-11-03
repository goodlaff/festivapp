using System;
using System.Collections.Generic;

namespace Models
{
	public class Venue : BaseEntity
	{
		public VenueType Type { get; set; }

		public Address Address { get; set; }

		public float Lat { get; set; }

		public float Lng { get; set; }

		public int Capacity { get; set; }

		public List<OperatingHours> Hours { get; set; }
	}
}

