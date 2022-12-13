using Avalonia.Controls;
using Avalonia.ReactiveUI;
using AvaloniaClient.ViewModels;

namespace AvaloniaClient.Views;
public partial class AmountWindow : ReactiveWindow<AmountViewModel>
{
    public AmountWindow()
    {
        InitializeComponent();
        ViewModel = new AmountViewModel();
    }
}
