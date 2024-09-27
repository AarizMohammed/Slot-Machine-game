namespace SlotMachine;

public partial class GamePage : ContentPage
{

	private SlotMachine _machine = new SlotMachine();
	public GamePage()
	{
		InitializeComponent();
	}

    

    void SpinClicked_Clicked_1(System.Object sender, System.EventArgs e)
    {
       List<string> result = _machine.Spin(3);
        Image1.Source = result[0];
        Image2.Source = result[1];
        Image3.Source = result[2];
        BalanceLabel.Text = $"${_machine.Balance}";



    }


}
