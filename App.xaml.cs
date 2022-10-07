namespace MauiAppSearchBarHandler;

public partial class App : Application
{
	public App(MainPage page)
	{
		InitializeComponent();

		MainPage = new AppShell(page);
	}
}

