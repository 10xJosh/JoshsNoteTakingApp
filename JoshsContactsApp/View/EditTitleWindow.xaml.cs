﻿using JoshsContactsApp.Model;
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
		public EditTitleWindow()
		{
			InitializeComponent();
		}

        public EditTitleWindow(Note note)
        {
            InitializeComponent();
			txtNewTitle.Text = note.Title;
		}

		
    }
}
