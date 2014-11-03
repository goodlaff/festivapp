using System;
using SQLite.Net.Attributes;

namespace Models
{
	public abstract class BaseEntity
	{
		[PrimaryKey, AutoIncrement]
		public int Id {	get; set; }

		public bool IsActive { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }
	}
}

