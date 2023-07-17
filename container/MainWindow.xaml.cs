using Microsoft.UI.Xaml;

namespace container;

public sealed partial class MainWindow : Window
{
    private int _currentStart = 0;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void OnLoaded(object _0, RoutedEventArgs _1)
    {
        for (int i = 0; i < 100; i++)
        {
            list.Items.Add(i.ToString());
        }
    }

    private void OnClick(object _0, RoutedEventArgs _1)
    {
        list.Items.Insert(0, (--_currentStart).ToString());
    }
}
