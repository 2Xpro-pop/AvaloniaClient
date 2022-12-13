using System;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaClient.ViewModels;

namespace AvaloniaClient.Views;
public partial class LoginWindow : ReactiveWindow<LoginWindowViewModel>
{
    public LoginWindow()
    {
        InitializeComponent();
        ViewModel = new LoginWindowViewModel();

        ViewModel.LoginCommand.Subscribe(result =>
        {
            if (result)
            {
                Close();
                App.Current.MainWindow = new MainWindow()
                {
                    DataContext = new MainWindowViewModel()
                };
                App.Current.Run(App.Current.MainWindow);
                
            }
        });
    }
}
