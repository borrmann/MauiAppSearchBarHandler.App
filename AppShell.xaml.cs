namespace MauiAppSearchBarHandler;

public partial class AppShell : Shell
{
	MainPage Page;
	public AppShell(MainPage page)
	{
		InitializeComponent();
        Page = page;
	}
}
