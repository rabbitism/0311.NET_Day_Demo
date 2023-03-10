using Avalonia.Controls;
using Avalonia.Interactivity;

namespace CarouselDemo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Button_OnClick(object? sender, RoutedEventArgs e)
    {
        carouse.Previous();
    }
    
    private void Button_OnClick2(object? sender, RoutedEventArgs e)
    {
        carouse.Next();
    }
}