using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;
public class AmountViewModel : ViewModelBase
{
    [Reactive] public string Label { get; set; } = "Amount";
    [Reactive] public double Amount { get; set; }
}
