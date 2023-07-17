using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;

namespace container;

internal class CustomListView : ListView
{
    private Dictionary<string, ListViewItem> _items = new();

    protected override void PrepareContainerForItemOverride(DependencyObject element, object item)
    {
        base.PrepareContainerForItemOverride(element, item);

        if (_items.ContainsKey((string)item))
        {
            ItemsPanelRoot.Children.Remove(_items[(string)item]); // remove redundant container
        }

        _items[(string)item] = (ListViewItem)element;
    }

    protected override void ClearContainerForItemOverride(DependencyObject element, object item)
    {
        _items.Remove((string)item);

        base.ClearContainerForItemOverride(element, item);
    }
}
