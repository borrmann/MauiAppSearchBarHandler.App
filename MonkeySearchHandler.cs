using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppSearchBarHandler
{
    public class MonkeySearchHandler : SearchHandler
    {
        public MonkeyViewModel _viewModel;
        public Type SelectedItemNavigationTarget { get; set; }

        public MonkeySearchHandler(MonkeyViewModel viewModel)
        {
            ShowsResults = false;
            _viewModel = viewModel;
        }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            _viewModel.Search(newValue);
        }

        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

        }
    }
}
