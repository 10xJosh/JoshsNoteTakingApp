using JoshsContactsApp.Model;
using JoshsContactsApp.ViewModel;
using JoshsNoteTakingApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace JoshsNoteTakingApp.ViewModel.Commands
{
	internal class EditNoteNameCommand : ICommand
	{
		public MainWindowViewModel VM { get; set; }

		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

        public EditNoteNameCommand(MainWindowViewModel VM)
        {
            this.VM = VM;
        }

        public bool CanExecute(object? parameter)
		{
			var selectedNote = parameter as Note;

			if (selectedNote != null)
			{
				return true;
			}
			else
				return false;
		}

		public void Execute(object? parameter)
		{
			EditTitleWindow editTitleWindow = new EditTitleWindow();

			editTitleWindow.Show();
		}
	}
}
