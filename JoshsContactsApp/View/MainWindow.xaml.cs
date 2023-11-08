using JoshsContactsApp.ViewModel;
using JoshsNoteTakingApp.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JoshsContactsApp
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}

		private void btnBold_Click(object sender, RoutedEventArgs e)
		{
			if (richTxtBoxContent.Selection.GetPropertyValue(Run.FontWeightProperty) is FontWeight && ((FontWeight)richTxtBoxContent.Selection.GetPropertyValue(Run.FontWeightProperty)) == FontWeights.Normal)
				richTxtBoxContent.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Bold);
			else
				richTxtBoxContent.Selection.ApplyPropertyValue(Run.FontWeightProperty, FontWeights.Normal);
		}

		private void btnItalic_Click(object sender, RoutedEventArgs e)
		{
			if (richTxtBoxContent.Selection.GetPropertyValue(Run.FontStyleProperty) is FontStyle && ((FontStyle)richTxtBoxContent.Selection.GetPropertyValue(Run.FontStyleProperty)) == FontStyles.Normal)
				richTxtBoxContent.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Italic);
			else
				richTxtBoxContent.Selection.ApplyPropertyValue(Run.FontStyleProperty, FontStyles.Normal);
		}

		private void spellChecker_Checked(object sender, RoutedEventArgs e)
		{

		}

		private void spellChecker_Unchecked(object sender, RoutedEventArgs e)
		{

		}
	}
}
