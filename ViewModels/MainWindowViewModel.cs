using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;

namespace AvaloniaClient.ViewModels;
public class MainWindowViewModel : ViewModelBase, IScreen
{

    public RoutingState Router { get; } = new();

    public ReactiveCommand<Unit, IRoutableViewModel> GoBack
    {
        get;
    }

    public ReactiveCommand<Unit, IRoutableViewModel> GoToFillials
    {
        get;
    }
    public ReactiveCommand<Unit, IRoutableViewModel> GoToPersonals
    {
        get;
    }
    public ReactiveCommand<Unit, IRoutableViewModel> GoToInventaries
    {
        get;
    }
    public ReactiveCommand<Unit, IRoutableViewModel> GoToPalates
    {
        get;
    }

    public MainWindowViewModel()
    {
        GoToFillials = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new FillialsViewModel(this))
        );

        /*GoToPersonals = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new PersonalViewModel(this))
        );

        GoToInventaries = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new InventariesViewModel(this))
        );

        GoToPalates = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new PalatesViewModel(this))
        );*/

        GoBack = ReactiveCommand.CreateFromObservable(() => Router.NavigateBack.Execute());


    }
}
