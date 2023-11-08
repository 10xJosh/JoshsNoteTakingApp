using JoshsContactsApp.Model;
using JoshsNoteTakingApp.ViewModel.Commands;
using JoshsNoteTakingApp.ViewModel.Helper;
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
				OnPropertyChanged("SelectedNote");
			}
		}

		#region ViewModel Commands
		public AddNoteCommand AddNoteCommand { get; set; }
		public DelNoteCommand DelNoteCommand { get; set; }
		public EditNoteNameCommand EditNoteNameCommand { get; set; }
		#endregion

		#region Other options
		private bool isSpellCheckEnabled = true;
		public bool IsSpellCheckEnabled
		{
			get 
			{ 
				return isSpellCheckEnabled;
			}
			set
			{
				if(isSpellCheckEnabled != true) 
				{
					isSpellCheckEnabled = true;
					isSpellCheckEnabled = value;
				}
				else if(isSpellCheckEnabled != false)
				{
					isSpellCheckEnabled = false;
					isSpellCheckEnabled = value;
				}
				OnPropertyChanged("IsSpellCheckEnabled");
			}
		} 
		#endregion

		public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
			AddNoteCommand = new AddNoteCommand(this);
			DelNoteCommand = new DelNoteCommand(this);
			EditNoteNameCommand = new EditNoteNameCommand(this);

			Notes = new ObservableCollection<Note>();
			GetNotes();
        }

        private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		public void CreateNote()
		{
			Note newNote = new Note()
			{
				Title = "New note",
				Notes = ""
			};

			DataBaseHelper.Insert<Note>(newNote);

			GetNotes();
		}

		private void GetNotes()
		{
			var notes = DataBaseHelper.Read<Note>();

			Notes.Clear();

			foreach (var note in notes)
			{
				Notes.Add(note);
			}
		}

		public void DeleteNote(Note note)
		{
			DataBaseHelper.Delete<Note>(note);

			GetNotes();
		}

		public void UpdateNote(Note note)
		{
			DataBaseHelper.Update<Note>(note);
			GetNotes();
		}
    }
}
