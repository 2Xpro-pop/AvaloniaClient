using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using RestSharp;

namespace AvaloniaClient.ViewModels;
public class LoginWindowViewModel : ViewModelBase
{
    [Reactive] public string Login { get; set; }
    [Reactive] public string Password { get; set; }
    [Reactive] public string Status { get; set;}
    public ReactiveCommand<Unit, bool> LoginCommand { get; }

    public LoginWindowViewModel()
    {
        LoginCommand = ReactiveCommand.CreateFromTask(async () =>
        {
            var rest = new RestRequest($"auth/login/{Login}/{Password}");
            var token = await StaticData.RestClient.GetAsync(rest);

            if (token.IsSuccessful)
            {
                StaticData.Jwt = token.Content;
                return true;
            }

            return false;
        });

        LoginCommand.Subscribe(result =>
        {
            Status = result ? "" : "Incorrect login or password...";
        });

        LoginCommand.ThrownExceptions.Subscribe(exc =>
        {
            Status = "Something went wrong...";
        });
    }
}
