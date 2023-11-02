using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace JoshsContactsApp
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private static string databaseName = "contacts.db";
		public static string dbFile = System.IO.Path.Combine(Environment.CurrentDirectory, "notesDb.db3");
	}
}
