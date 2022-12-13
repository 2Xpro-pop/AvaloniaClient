using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;
public class NewPersonalViewModel : ViewModelBase
{
    [Reactive] public string Name { get; set; }
    [Reactive] public string Surname { get; set; }
    [Reactive] public double Salary { get; set; }
    [Reactive] public bool IsProcent { get; set; }
    [Reactive] public double Procent { get; set; } = 15.3d;
}
