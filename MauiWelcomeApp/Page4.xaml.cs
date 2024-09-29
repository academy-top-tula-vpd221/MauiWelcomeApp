namespace MauiWelcomeApp;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();

		//BoxView box = new BoxView()
		//{
		//	Color = Colors.LightBlue,
		//	CornerRadius = 10,
		//	WidthRequest = 300,
		//	HeightRequest = 100
		//};

		//Entry entry = new()
		//{
		//	FontSize = 24
		//};

		//layout.Add(box);
		//layout.Add(entry);

		//layout.SetLayoutBounds(box, new Rect(50, 50, 250, 150));
		//      layout.SetLayoutBounds(entry, new Rect(55, 55, 250, 150));

		//ScrollView scroll = new();
		//scroll.VerticalOptions = LayoutOptions.Fill;
		//      stack.Add(scroll);

		//      StackLayout innerStack = new();
		//      innerStack.VerticalOptions = LayoutOptions.Fill;
		//      scroll.Content = innerStack;


		for (int i = 0; i < 10; i++)
		{
			BoxView box = new()
			{
				WidthRequest = 200,
				HeightRequest = 200,
				Margin = 20,
				Color = Colors.Red
			};

			stack.Add(box);
		}
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await scroll.ScrollToAsync(0, 0, true);
    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
		await scroll.ScrollToAsync(0, stack.Height, true);
    }
}