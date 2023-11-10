using JoshsContactsApp.ViewModel;
using JoshsNoteTakingApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;

			if (isButtonEnabled)
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Bold);
			}
			else
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.FontWeightProperty, FontWeights.Normal);
			}
		}

		private void btnItalic_Click(object sender, RoutedEventArgs e)
		{
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;

			if (isButtonEnabled)
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Italic);
			}
			else
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.FontStyleProperty, FontStyles.Normal);
			}
		}

		private void btnUnderline_Click(object sender, RoutedEventArgs e)
		{
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;

			if (isButtonEnabled)
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
			}
			else
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Baseline);
			}
		}

		private void btnStrikeThrough_Click(object sender, RoutedEventArgs e)
		{
			bool isButtonEnabled = (sender as ToggleButton).IsChecked ?? false;

			if (isButtonEnabled)
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Strikethrough);
			}
			else
			{
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Baseline);
			}
		}

		private void richTxtBoxContent_SelectionChanged(object sender, RoutedEventArgs e)
		{
			//Checking if Bold button is enabled 
			var selectedWeight = richTxtBoxContent.Selection.GetPropertyValue(FontWeightProperty);
			btnBold.IsChecked = (selectedWeight != DependencyProperty.UnsetValue) && (selectedWeight.Equals(FontWeights.Bold));

			//Checking if StrikeThrough button is enabled 
			//var strikeThroughSelected = richTxtBoxContent.Selection.GetPropertyValue(TextDecorations);

			//Checking if Underline button is enabled 
			//var selectedUnderline = richTxtBoxContent.Selection.GetPropertyValue(I)
		}
	}
}
