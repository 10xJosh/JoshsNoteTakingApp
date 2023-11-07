using JoshsContactsApp;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshsNoteTakingApp.ViewModel.Helper
{
    public static class DataBaseHelper
    {
        public static bool Insert<T>(T item)
        {
            bool result = false;

            using(SQLiteConnection connnection = new SQLiteConnection(App.dbFile))
            {
                connnection.CreateTable<T>();
                int rows = connnection.Insert(item);

                if(rows > 0)
                {
                    result = true;
                }
            }

            return result;
        }

		public static bool Update<T>(T item)
		{
			bool result = false;

			using (SQLiteConnection connnection = new SQLiteConnection(App.dbFile))
			{
				connnection.CreateTable<T>();
				int rows = connnection.Update(item);

				if (rows > 0)
				{
					result = true;
				}


			}

			return result;
		}
		public static bool Delete<T>(T item)
		{
			bool result = false;

			using (SQLiteConnection connnection = new SQLiteConnection(App.dbFile))
			{
				connnection.CreateTable<T>();
				int rows = connnection.Delete(item);

				if (rows > 0)
				{
					result = true;
				}


			}

			return result;
		}

		public static List<T> Read<T>() where T : new()
		{
			List<T> list;

			using (SQLiteConnection connnection = new SQLiteConnection(App.dbFile))
			{
				connnection.CreateTable<T>();
				list = connnection.Table<T>().ToList();
			}

			return list;
		}
	}
}
