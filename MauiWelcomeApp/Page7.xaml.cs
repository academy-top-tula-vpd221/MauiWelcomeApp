using Microsoft.Maui.Controls;

namespace MauiWelcomeApp;

public partial class Page7 : ContentPage
{
	public Page7()
	{
		InitializeComponent();



		SwitchCell switchCell = new SwitchCell();
		switchCell.Text = "Married";
		switchCell.OnChanged += swMarried_OnChanged;

		EntryCell entryCell = new EntryCell();
		entryCell.Placeholder = "Input department";
		entryCell.Completed += txtDepart_Completed;

        tableView.Root.Add(
			new TableSection {
				new TextCell { Text = "Tommy" },
				switchCell,
				entryCell
				}
            );
	}

    private void swMarried_OnChanged(object sender, ToggledEventArgs e)
    {
		if(sender is SwitchCell switchCell)
		{
			tablo.Text = switchCell.On ? "Married" : "Not married";

        }
		
    }

    private void txtDepart_Completed(object sender, EventArgs e)
    {
		if( sender is EntryCell entryCell)
		{
			tablo.Text = entryCell.Text;

        }
    }
}