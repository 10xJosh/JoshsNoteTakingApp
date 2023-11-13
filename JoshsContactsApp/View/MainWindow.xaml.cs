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
				TextDecorationCollection textDecorations;

				(richTxtBoxContent.Selection.GetPropertyValue(Inline.TextDecorationsProperty) as TextDecorationCollection).TryRemove(TextDecorations.Underline, out textDecorations);
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, textDecorations);
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
				TextDecorationCollection textDecorations;

				(richTxtBoxContent.Selection.GetPropertyValue(Inline.TextDecorationsProperty) as TextDecorationCollection).TryRemove(TextDecorations.Strikethrough, out textDecorations);
				richTxtBoxContent.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, textDecorations);
			}
		}

		private void richTxtBoxContent_SelectionChanged(object sender, RoutedEventArgs e)
		{
			//Checking if buttons are enabled and if not updated them
			var selectedWeight = richTxtBoxContent.Selection.GetPropertyValue(FontWeightProperty);
			btnBold.IsChecked = (selectedWeight != DependencyProperty.UnsetValue) && (selectedWeight.Equals(FontWeights.Bold));

			var selectedStyle = richTxtBoxContent.Selection.GetPropertyValue(Inline.FontStyleProperty);
			btnItalic.IsChecked = (selectedStyle != DependencyProperty.UnsetValue) && (selectedStyle.Equals(FontStyles.Italic));

			//Checking if StrikeThrough button is enabled 
			var selectedUnderlineStyle = richTxtBoxContent.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			btnUnderline.IsChecked = (selectedUnderlineStyle != DependencyProperty.UnsetValue) && (selectedUnderlineStyle.Equals(TextDecorations.Underline));

			//Checking if Underline button is enabled 
			var selectedStrikeThrough = richTxtBoxContent.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
			btnStrikeThrough.IsChecked = (selectedUnderlineStyle != DependencyProperty.UnsetValue) && (selectedUnderlineStyle.Equals(TextDecorations.Strikethrough));
		}
	}
}
