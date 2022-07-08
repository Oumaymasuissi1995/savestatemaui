namespace SecurHub;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Isqlite aaa = new Isqlite();
		MainPage = new MainPage();
	}
}
