using JoshsContactsApp.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace JoshsContactsApp.ViewModel
{
	class MainWindowViewModel : INotifyPropertyChanged
	{
		private string Title;

		public string Query
		{
			get { return Title; }
			set 
			{
				OnPropertyChanged("Query"); 
			}
		}


		public event PropertyChangedEventHandler? PropertyChanged;

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public static List<Note> GetNotes()
		{
			List<Note> notes = new List<Note>();

			return notes;
		}

		private void test()
		{
			MessageBox.Show("Yeeahw");
		}
    }
}
