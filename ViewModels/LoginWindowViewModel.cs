using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;
public class LoginWindowViewModel : ViewModelBase
{
    [Reactive] public string Login { get; set; }
    [Reactive] public string Password { get; set; }
}
