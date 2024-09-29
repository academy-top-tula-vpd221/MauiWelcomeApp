namespace MauiWelcomeApp;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();

		StackLayout layout = new()
		{
			Orientation = StackOrientation.Vertical,
		};

		Button button = new()
		{
			WidthRequest = 200,
			HeightRequest = 100,
			Text = "Click me",
			Margin = new Thickness(20),
			Padding = new Thickness(20),
			HorizontalOptions = LayoutOptions.Center,
			VerticalOptions = LayoutOptions.Start,

			BackgroundColor = new Color(123, 78, 31), //Colors.Aquamarine,
			TextColor = new Color(0.2f, 0.7f, 0.31f),
		};
		button.Clicked += OnButtonClicked;


		int count = 0;

        Label label = new()
		{
			Text = $"Taps on Label {count}",
			FontFamily = "OpenSansRegular", //FontFamily = "Calibri",
			FontSize = 24,
			FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
			HorizontalTextAlignment = TextAlignment.Center,
			VerticalTextAlignment = TextAlignment.Start,

			//CharacterSpacing = 9,
			LineBreakMode = LineBreakMode.WordWrap,
			TextDecorations = TextDecorations.Underline,
			TextType = TextType.Text,

		};

		Entry login = new()
		{
			Text = "Hello world",
			FontSize = 20,
			ClearButtonVisibility = ClearButtonVisibility.WhileEditing,
			CursorPosition = 5,
			FontAutoScalingEnabled = true,
			IsPassword = false,
			Placeholder = "Input login",
			PlaceholderColor = Colors.LightGray,
			IsReadOnly = false,
			MaxLength = 20
		};

		login.Keyboard = Keyboard.Telephone;
		login.Keyboard = Keyboard.Create(KeyboardFlags.CapitalizeSentence);

        login.TextChanged += Login_TextChanged;
        login.Completed += Login_Completed;

		Entry password = new()
		{
			FontSize = 20,
			Placeholder = "Input login",
			PlaceholderColor = Colors.LightGray,
			IsPassword = true,

		};

		Editor editor = new()
		{
			WidthRequest = 300,
			HeightRequest = 400,
			FontSize = 22
		};

        TapGestureRecognizer tapGesture = new();
		tapGesture.NumberOfTapsRequired = 2;
		tapGesture.Tapped += (s, e) =>
		{
			count++;
			label.Text = $"Taps on Label {count}";

		};

		label.GestureRecognizers.Add(tapGesture);


		layout.Add(button);
		layout.Add(label);
		layout.Add(login);
        layout.Add(password);
		layout.Add(editor);
        Content = layout;
	}

    private void Login_Completed(object? sender, EventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Login_TextChanged(object? sender, TextChangedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {

    }

    private void Button_Pressed(object sender, EventArgs e)
    {

    }

    private void Button_Released(object sender, EventArgs e)
    {

    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
		if (sender is Button btn)
			btn.Text = "Thanks";
    }
}