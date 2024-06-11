using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace BorderDrawingIssue.ViewModels
{
    public class Item
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Filter { get; set; }
    }
    public partial class PageViewModel : ObservableObject
    {
        [ObservableProperty] 
        private bool filterActive = false;

        private List<Item> _source { get; set; } =
        [
            new Item() { Id = 1, Title = "Item 1", Filter = true },
            new Item() { Id = 2, Title = "Item 2", Filter = true },
            new Item() { Id = 3, Title = "Item 3", Filter = true },
            new Item() { Id = 4, Title = "Item 4", Filter = true },
            new Item() { Id = 5, Title = "Item 5", Filter = true },
            new Item() { Id = 6, Title = "Item 6", Filter = true },
            new Item() { Id = 7, Title = "Item 7", Filter = true },
            new Item() { Id = 8, Title = "Item 8", Filter = true },
            new Item() { Id = 9, Title = "Item 9", Filter = true },
            new Item() { Id = 10, Title = "Item 10", Filter = true },
            new Item() { Id = 11, Title = "Item 11", Filter = true },
            new Item() { Id = 12, Title = "Item 12", Filter = true },
            new Item() { Id = 13, Title = "Item 13", Filter = true },
            new Item() { Id = 14, Title = "Item 14", Filter = true },
            new Item() { Id = 15, Title = "Item 15", Filter = true },
            new Item() { Id = 16, Title = "Item 16", Filter = true },   
        ];

        public ObservableCollection<Item> Items { get; private set; } = [];


        [RelayCommand]
        private void Filter(bool show)
        {
            FilterActive = show;
            Search(show);
        }

        private void Search(bool showAllChats)
        {
            var searchResult = _source
                .Where(x => showAllChats || !x.Filter);
            Items = new(searchResult);
            OnPropertyChanged(nameof(Items));
        }

    }
}
