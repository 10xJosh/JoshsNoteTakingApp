using JoshsContactsApp.Model;
using JoshsNoteTakingApp.ViewModel.Commands;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
		public ObservableCollection<Note> Notes { get; set; }
		private Note selectedNote { get; set; }

		public Note SelectedNote
		{
			get { return selectedNote; }
			set 
			{ 
				selectedNote = value; 
				//TODO: get notes
			}
		}

		#region ViewModel Commands
		public AddNoteCommand AddNoteCommand { get; set; }
		public DelNoteCommand DelNoteCommand { get; set; }
		#endregion


		public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
			AddNoteCommand = new AddNoteCommand(this);
			DelNoteCommand = new DelNoteCommand(this);
        }

        private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public static List<Note> GetNotes()
		{
			List<Note> notes = new List<Note>();

			return notes;
		}

		public void test()
		{
			MessageBox.Show("Yeeahw");
		}
    }
}
