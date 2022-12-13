using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;
public class AmountViewModel : ViewModelBase
{
    [Reactive] public string Label { get; set; } = "Amount";
    [Reactive] public double Amount { get; set; }

    public ReactiveCommand<Unit, double> Apply { get; }
    public ReactiveCommand<Unit, Unit> Cancel { get; }

    public AmountViewModel()
    {
        Apply = ReactiveCommand.Create(() =>
        {
            return Amount;
        });

        Cancel = ReactiveCommand.Create(() =>
        {

        });
    }
}
