using System;
using SQLite.Net;
using Xamarin.Forms;
using System.Collections.Generic;
using Models;
using System.Linq;

namespace Data
{
	public class DataAccess
	{
		static object locker = new object ();

		SQLiteConnection database;

		public DataAccess ()
		{
			database = DependencyService.Get<ISQLite> ().GetConnection ();

			if (database == null)
				throw new Exception ("Database not found");

			// create tables if don't exist
			if (database.GetTableInfo ("Performer").Count == 0) {
				database.CreateTable<Performer> ();
			}
		}

		public IEnumerable<Performer> Get ()
		{
			lock (locker) {
				return (from i in database.Table<Performer> ()
				        select i).ToList ();
			}
		}

		public IEnumerable<Performer> GetActive ()
		{
			lock (locker) {
				return database.Query<Performer> ("SELECT * FROM [Performers] WHERE [IsActive] = 'true'");
			}
		}

		public Performer Get (int id)
		{
			lock (locker) {
				return database.Table<Performer> ().FirstOrDefault (x => x.Id == id);
			}
		}

		public int Save (Performer item)
		{
			lock (locker) {
				if (item.Id != 0) {
					database.Update (item);
					return item.Id;
				} else {
					return database.Insert (item);
				}
			}
		}

		public int Delete (int id)
		{
			lock (locker) {
				return database.Delete<Performer> (id);
			}
		}
	}
}

