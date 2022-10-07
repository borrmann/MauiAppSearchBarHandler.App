using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSearchBarHandler
{
    public partial class MonkeyViewModel : ObservableObject
    {
        public MonkeyViewModel() 
        {
            SearchText = "Hello";
            Search("");
        }

        public static List<string> MonkeyList = new List<string>()
        {
            "Golden Snub-Nosed Monkey",
            "Mandrill",
            "Snow Monkey"
        };

        [ObservableProperty]
        public ObservableCollection<string> searchResult;

        [ObservableProperty]
        public string searchText;

        public void Search(string text)
        {
            SearchText = text;
            if(string.IsNullOrEmpty(text)) 
            {
                SearchResult = new ObservableCollection<string>(MonkeyList);
            }
            else
            {
                SearchResult = new ObservableCollection<string>(MonkeyList.Where(x => x.Contains(text)).ToList());
            }
        }

    }
}
