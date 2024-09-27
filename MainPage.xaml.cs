namespace SlotMachine;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	

    void SettingBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new SettingsPage());
    }

    void PlayBtn_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new GamePage());

    }
}


