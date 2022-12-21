using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaClient.ViewModels;

public class PersonalViewModel: ReactiveObject
{
    [Reactive] public string RxText { get; set; }

    public PersonalViewModel()
    {
        RxText = "Fody & RxUI ♡!";
    }
}
