using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;
public class LoginWindowViewModel : ViewModelBase
{
    [Reactive] public string Login { get; set; }
    [Reactive] public string Password { get; set; }

    public ReactiveCommand<Unit, bool> LoginCommand { get; }

    public LoginWindowViewModel()
    {
        LoginCommand = ReactiveCommand.Create(() =>
        {
            return true;
        });
    }
}
