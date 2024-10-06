using Microsoft.Maui.Controls;

namespace MauiWelcomeApp;

public partial class PageProgress : ContentPage
{
	public PageProgress()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        //while(progressBar.Progress < 1)
        //{
        //    //progressBar.Progress += 0.1;
        //    //tablo.Text = $"Progress {progressBar.Progress * 100}%";
        //    //await Task.Delay(500);

            
        //}

        int count = 1;
        indicator.IsRunning = true;
        while (count <= 100)
        {
            tablo.Text = count.ToString();
            count += 10;
            await Task.Delay(300);
        }
        indicator.IsRunning = false;
    }
}