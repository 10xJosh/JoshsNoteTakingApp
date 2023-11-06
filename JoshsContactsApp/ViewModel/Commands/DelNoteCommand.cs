using JoshsContactsApp.Model;
using JoshsContactsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoshsNoteTakingApp.ViewModel.Commands
{
	internal class DelNoteCommand : ICommand
	{
		public event EventHandler? CanExecuteChanged;
		public MainWindowViewModel VM{ get; set; }

        public DelNoteCommand(MainWindowViewModel VM)
        {
            this.VM = VM;
        }

        public bool CanExecute(object? parameter)
		{
			Note SelectedNote = parameter as Note;
			if (SelectedNote != null)
			{
				return true;
			}
			
			return false;
		}

		public void Execute(object? parameter)
		{
			Note SelectedNote = parameter as Note;

			MessageBoxResult dialogResult = MessageBox.Show("Are you sure you want to delete this entry?", "Delete Entry?"
				, MessageBoxButton.YesNo, MessageBoxImage.Warning);

			if(dialogResult == MessageBoxResult.Yes)
			{
				MessageBox.Show("Deleted");
			}
			else
			{
				MessageBox.Show("Not deleted");
			}
		}
	}
}
