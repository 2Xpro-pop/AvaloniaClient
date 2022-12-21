using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.ReactiveUI;
using AvaloniaClient.ViewModels;
using ReactiveUI;
using System;

namespace AvaloniaClient.Views;

	public partial class PersonalView : ReactiveUserControl<PersonalViewModel>
	{
		public PersonalView ()
		{
			InitializeComponent ();

        ViewModel = new PersonalViewModel();
		}
	}