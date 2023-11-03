using ReactiveUI;
using System.Collections.ObjectModel;

namespace ListBoxItemTappedInteractions.ViewModels;

public class MainViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    private int _counterA = 0;
    public int CounterA { get => _counterA; set => this.RaiseAndSetIfChanged(ref _counterA, value); }

    private int _counterB = 0;
    public int CounterB { get => _counterB; set => this.RaiseAndSetIfChanged(ref _counterB, value); }

    private ObservableCollection<int> _items = new ObservableCollection<int>() { 0, 1, 2, 3 };
    private ReadOnlyObservableCollection<int> _ROItems;
    public ReadOnlyObservableCollection<int> Items { get => _ROItems; }

    public MainViewModel() { _ROItems = new(_items); }
}
