
namespace MauiAppSearchBarHandler;

public partial class MainPage : ContentPage
{
	public MainPage(MonkeyViewModel viewModel, MonkeySearchHandler searchHandler)
	{
		InitializeComponent();

        this.BindingContext = viewModel;
        searchHandler.SearchBoxVisibility = SearchBoxVisibility.Collapsible;

        Shell.SetSearchHandler(this, searchHandler);
    }

}

