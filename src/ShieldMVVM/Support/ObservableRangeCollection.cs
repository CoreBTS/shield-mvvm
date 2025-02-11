using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace CoreBTS.Maui.ShieldMVVM.Support;

/// <summary>
/// Represents a dynamic data collection that provides notifications when items get added, removed, or when the whole list is refreshed.
/// </summary>
/// <typeparam name="T">The type of elements in the collection.</typeparam>
/// <remarks>
/// Adapted from: https://github.com/xamarin/XamarinCommunityToolkit/blob/main/src/CommunityToolkit/Xamarin.CommunityToolkit/ObjectModel/ObservableRangeCollection.shared.cs
/// </remarks>
public class ObservableRangeCollection<T> : ObservableCollection<T>
{
    /// <summary>
    /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class.
    /// </summary>
    public ObservableRangeCollection()
        : base()
    {
    }

    /// <summary>
    /// Initializes a new instance of the System.Collections.ObjectModel.ObservableCollection(Of T) class that contains elements copied from the specified collection.
    /// </summary>
    /// <param name="collection">collection: The collection from which the elements are copied.</param>
    /// <exception cref="System.ArgumentNullException">The collection parameter cannot be null.</exception>
    public ObservableRangeCollection(IEnumerable<T> collection)
        : base(collection)
    {
    }

    /// <summary>
    /// Adds the elements of the specified collection to the end of the ObservableCollection(Of T).
    /// </summary>
    public void AddRange(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection, nameof(collection));

        CheckReentrancy();

        // Special case for empty/single-item collection
        var incomingCount = collection.Count();
        if (incomingCount == 0) { return; }
        if (incomingCount == 1)
        {
            Add(collection.First());
            return;
        }

        var startIndex = Count;

        var itemsAdded = AddArrangeCore(collection);

        if (!itemsAdded)
        {
            return;
        }

        // UWP/WinUI do not support multi-item collection change events, so just fire the Reset event
        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            RaiseChangeNotificationEvents(action: NotifyCollectionChangedAction.Reset);
            return;
        }

        var changedItems = collection is List<T> list
            ? list
            : new List<T>(collection);

        RaiseChangeNotificationEvents(
            action: NotifyCollectionChangedAction.Add,
            changedItems: changedItems,
            startingIndex: startIndex);
    }

    /// <summary>
    /// Adds the elements of the specified collection to the given index of the ObservableCollection(Of T).
    /// </summary>
    /// <param name="index">The start index to add the elements.</param>
    /// <param name="collection">The elements to add.</param>
    /// <exception cref="ArgumentNullException"></exception>
    public void InsertRange(int index, IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection, nameof(collection));

        CheckReentrancy();

        // Force the insertion point to be in the list [or at the end]
        var insertIndex = Math.Max(0, Math.Min(index, Count));
        index = insertIndex; // rewrite the incoming param

        // Special case for empty/single-item collection
        var incomingCount = collection.Count();
        if (incomingCount == 0) { return; }
        if (incomingCount == 1)
        {
            InsertItem(insertIndex, collection.First());
            return;
        }

        foreach (var item in collection)
        {
            Insert(insertIndex++, item);
        }

        // UWP/WinUI do not support multi-item collection change events, so just fire the Reset event
        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            RaiseChangeNotificationEvents(action: NotifyCollectionChangedAction.Reset);
            return;
        }

        var changedItems = collection is List<T> list
            ? list
            : new List<T>(collection);

        RaiseChangeNotificationEvents(
            action: NotifyCollectionChangedAction.Add,
            changedItems: changedItems,
            startingIndex: index);
    }

    /// <summary>
    /// Removes the first occurrence of each item in the specified collection from ObservableCollection(Of T).
    /// </summary>
    /// <param name="collection">The elements to remove.</param>
    public void RemoveRange(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection, nameof(collection));

        CheckReentrancy();

        // Special case for empty/single-item collection
        var incomingCount = collection.Count();
        if (incomingCount == 0) { return; }
        if (incomingCount == 1)
        {
            Remove(collection.First());
            return;
        }

        if (DeviceInfo.Platform == DevicePlatform.WinUI)
        {
            foreach (var item in collection)
            {
                Items.Remove(item);
            }

            RaiseChangeNotificationEvents(action: NotifyCollectionChangedAction.Reset);
            return;
        }

        var changedItems = new List<T>(collection);
        for (var i = 0; i < changedItems.Count; i++)
        {
            if (!Items.Remove(changedItems[i]))
            {
                changedItems.RemoveAt(i); 
                i--;
            }
        }

        if (changedItems.Count == 0)
        {
            return;
        }

        RaiseChangeNotificationEvents(
            action: NotifyCollectionChangedAction.Remove,
            changedItems: changedItems);
    }

    /// <summary>
    /// Clears the current collection and replaces it with the specified item.
    /// </summary>
    /// <param name="item">The item to replace the existing items with.</param>
    public void Replace(T item) => ReplaceRange([item]);

    /// <summary>
    /// Clears the current collection and replaces it with the specified collection.
    /// </summary>
    /// <param name="collection">The elements to replace the existing items with.</param>
    public void ReplaceRange(IEnumerable<T> collection)
    {
        ArgumentNullException.ThrowIfNull(collection, nameof(collection));
        
        CheckReentrancy();

        var previouslyEmpty = Items.Count == 0;

        Items.Clear();

        AddArrangeCore(collection);

        var currentlyEmpty = Items.Count == 0;

        if (previouslyEmpty && currentlyEmpty)
        {
            return;
        }

        RaiseChangeNotificationEvents(action: NotifyCollectionChangedAction.Reset);
    }

    private bool AddArrangeCore(IEnumerable<T> collection)
    {
        var itemAdded = false;
        foreach (var item in collection)
        {
            Items.Add(item);
            itemAdded = true;
        }
        return itemAdded;
    }

    private void RaiseChangeNotificationEvents(NotifyCollectionChangedAction action, List<T>? changedItems = null, int startingIndex = -1)
    {
        OnPropertyChanged(new PropertyChangedEventArgs(nameof(Count)));
        OnPropertyChanged(new PropertyChangedEventArgs("Item[]"));

        MainThread.BeginInvokeOnMainThread(() =>
        {
            OnCollectionChanged(changedItems == null
                                ? new NotifyCollectionChangedEventArgs(action)
                                : new NotifyCollectionChangedEventArgs(action, changedItems: changedItems, startingIndex: startingIndex));
        });
    }
}
