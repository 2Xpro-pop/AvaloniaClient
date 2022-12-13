using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaClient.ViewModels;

namespace AvaloniaClient.Views;
public partial class LoginWindow : ReactiveWindow<LoginWindowViewModel>
{
    public LoginWindow()
    {
        InitializeComponent();
        DataContext = new LoginWindowViewModel();
    }
}