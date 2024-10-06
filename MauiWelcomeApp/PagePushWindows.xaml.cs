namespace MauiWelcomeApp;

public partial class PagePushWindows : ContentPage
{
	public PagePushWindows()
	{
		InitializeComponent();


	}

    private async void btn_Clicked(object sender, EventArgs e)
    {
		await DisplayAlert("title alert", "message alert", "btn alert");
    }

    private async void btn2_Clicked(object sender, EventArgs e)
    {
        var action = await DisplayActionSheet("Cities", "Cancel", "Delete", "Moscow", "Kaluga", "Orel");
        tablo2.Text = action;
    }

    private async void btn3_Clicked(object sender, EventArgs e)
    {
        var city = await DisplayPromptAsync("City name", "City where you live", "Ok", "Cancel", "Input city name");
        tablo2.Text = city;
    }
}