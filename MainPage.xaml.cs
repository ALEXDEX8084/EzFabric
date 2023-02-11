namespace EzFabric;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
		
	}

    private void BtnReg_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new NavigationPage(new Registratiom());
    }
}

