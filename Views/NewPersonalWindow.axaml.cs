using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaClient.ViewModels;

namespace AvaloniaClient.Views;
public partial class NewPersonalWindow : ReactiveWindow<NewPersonalViewModel>
{
    public NewPersonalWindow()
    {
        InitializeComponent();
        ViewModel = new NewPersonalViewModel();
    }
}
