using JoshsNoteTakingApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace JoshsNoteTakingApp.ViewModel.EditWindow_Commands
{
	class ChangeNameCommand : ICommand
	{
		public EditTitleWindowViewModel VM { get; set; }
		public event EventHandler? CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}

		public ChangeNameCommand(EditTitleWindowViewModel VM)
        {
            this.VM = VM;
        }

        public bool CanExecute(object? parameter)
		{
			var textBlock = parameter as TextBox;

			if (textBlock != null && !string.IsNullOrEmpty(textBlock.Text)) 
			{
				return true;
			}
			else
				return false;
		}

		public void Execute(object? parameter)
		{
			return;
		}
	}
}
