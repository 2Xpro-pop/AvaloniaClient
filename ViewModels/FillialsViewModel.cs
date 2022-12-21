using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Text;
using AvaloniaClient.Models;
using System.Threading.Tasks;
using System.Windows.Input;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using RestSharp;
using DynamicData;
using AvaloniaClient.Views;

namespace AvaloniaClient.ViewModels;

public class FillialsViewModel : ViewModelBase, IRoutableViewModel
{
    public string? UrlPathSegment => Guid.NewGuid().ToString().Substring(0, 5);

    public IScreen HostScreen
    {
        get;
    }

    public ObservableCollection<Fillial> Fillials
    {
        get => _fillials;
        set => this.RaiseAndSetIfChanged(ref _fillials, value);

    }
    private ObservableCollection<Fillial> _fillials = new();

    public Fillial? SelectedFillial
    {
        get => _selectedFillial;
        set => this.RaiseAndSetIfChanged(ref _selectedFillial, value);
    }
    private Fillial? _selectedFillial;
    public ICommand Add
    {
        get;
    }
    public ReactiveCommand<Unit, Task> AddBudget
    {
        get;
    }

    public ReactiveCommand<Unit, Unit> Save
    {
        get;
    }

    public FillialsViewModel(IScreen screen)
    {
        HostScreen = screen;

        Task.Run(async () =>
        {
            var fillials = await StaticData.RestClient.GetJsonAsync<List<Fillial>>("office/showAll");

            _fillials.Clear();
            _fillials.AddRange(fillials);
        });

        Add = ReactiveCommand.Create(async () =>
        {
            /*var dialog = new FillialWindow();

            var result = await dialog.ShowDialog<Fillial>(App.Current.MainWindow);

            if (result == null)
            {
                return;
            }

            _fillials.Add(result);
            SelectedFillial = result;*/
        });

        AddBudget = ReactiveCommand.Create(async () =>
        {
            /*var dialog = new AmountWindow();

            var result = await dialog.ShowDialog<double>(App.Current.MainWindow);

            if (result == null)
            {
                return;
            }

            var fillial = _fillials.First(f => f.Id == result.FillialId);
            fillial.Budget += result.Action;

            BudgetHistorieVms.Add(new BudgetHistoryVm
            {
                Currency = result.Action,
                Fillial = fillial.Name,
                Description = result.Description
            });*/
        });
    }

}