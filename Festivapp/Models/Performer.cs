using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;

namespace Models
{
	[Table ("Performers")]
	public class Performer : BaseEntity
	{
		public PerformerType Type { get; set; }

		public List<int> MemberIds { get; set; }

		[Ignore]
		public List<Performer> Members { get; set; }

		public string Biography { get; set; }

		public List<string> Websites { get; set; }

		public List<string> Emails { get; set; }

		public List<string> Socials { get; set; }

		public string Phone { get; set; }

		public Address Address { get; set; }
	}
}