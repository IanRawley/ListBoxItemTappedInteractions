using Avalonia.Controls;
using ListBoxItemTappedInteractions.ViewModels;

namespace ListBoxItemTappedInteractions.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void Button_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if (this.DataContext is MainViewModel vm) { vm.CounterA++; }
    }

    private void Border_Tapped(object? sender, Avalonia.Input.TappedEventArgs e)
    {
        if(this.DataContext is MainViewModel vm) { vm.CounterB++; }
    }

}
