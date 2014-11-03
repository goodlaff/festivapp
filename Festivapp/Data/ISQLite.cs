using System;
using SQLite.Net;

namespace Data
{
	public interface ISQLite
	{
		SQLiteConnection GetConnection ();
	}
}

