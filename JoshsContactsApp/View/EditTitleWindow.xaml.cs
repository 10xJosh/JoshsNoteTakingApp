using JoshsContactsApp.Model;
using JoshsNoteTakingApp.ViewModel.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace JoshsNoteTakingApp.View
{
	/// <summary>
	/// Interaction logic for EditTitleWindow.xaml
	/// </summary>
	public partial class EditTitleWindow : Window
	{
		public Note Note { get; set; }
		
		public EditTitleWindow()
		{
			InitializeComponent();
		}

        public EditTitleWindow(Note note)
        {
            InitializeComponent();
			Note = note;
			txtNewTitle.Text = note.Title;
		}

		private void btnChangeName_Click(object sender, RoutedEventArgs e)
		{
			Note.Title = txtNewTitle.Text;
			DataBaseHelper.Update(Note);
			Close();
		}
	}
}
