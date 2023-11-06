using JoshsContactsApp.Model;
using JoshsContactsApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoshsNoteTakingApp.ViewModel.Commands
{
	internal class AddNoteCommand : ICommand
	{
        public MainWindowViewModel VM { get; set; }
        public event EventHandler? CanExecuteChanged;

        public AddNoteCommand(MainWindowViewModel VM)
        {
            this.VM = VM;	
        }

        public bool CanExecute(object? parameter)
		{
            return true;
		}

		public void Execute(object? parameter)
		{
            VM.CreateNote();
        }
	}
}
