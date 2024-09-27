namespace SlotMachine;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
		EasyModeCheckBox.IsChecked = SlotMachine.IsEasy;
	}

    void EasyModeCheckBox_CheckedChanged(System.Object sender, Microsoft.Maui.Controls.CheckedChangedEventArgs e)
    {
		//if (EasyModeCheckBox.IsChecked)
		//	SlotMachine.IsEasy = true;

		//else
		//	SlotMachine.IsEasy = false;

		SlotMachine.IsEasy = EasyModeCheckBox.IsChecked;
    }
}
