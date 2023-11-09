using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshsNoteTakingApp.ViewModel.EditWindow_Commands
{
	class EditTitleWindowViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler? PropertyChanged;

		private string _title;
        public string Title 
		{ 
			get { return _title; }
			set
			{
				_title = value;
				OnPropertyChanged("Title");
			}
		
		}

		public ChangeNameCommand ChangeNameCommand {get; set;}

        public EditTitleWindowViewModel()
        {
            ChangeNameCommand = new ChangeNameCommand(this);
        }

		private void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
