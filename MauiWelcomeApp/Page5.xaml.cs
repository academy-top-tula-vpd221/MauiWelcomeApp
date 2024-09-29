using Microsoft.Maui.Controls.Shapes;

namespace MauiWelcomeApp;

public partial class Page5 : ContentPage
{
	Label dateLabel;

    public Page5()
	{
		InitializeComponent();

		//Image image = new()
		//{
		//	Source = ImageSource.FromFile("dotnet_bot.png"),
		//	Aspect = Aspect.Fill,
		//	IsOpaque = true,
		//	IsAnimationPlaying = true,
		//};
		//stack.Add(image);

		Border border = new()
		{
			Stroke = Colors.BlueViolet,
			StrokeThickness = 10,
			//StrokeDashArray = new(new[] { 5.0, 2.0 }),
			WidthRequest = 100,
			HeightRequest = 100,
			StrokeShape = new RoundRectangle() { CornerRadius = 100 },
			Content = new Image() { Source = ImageSource.FromFile("dotnet_bot.png"), Aspect = Aspect.AspectFill },
		};

		stack.Add(border);


		DatePicker datePicker = new()
		{
			Format = "d",
			MinimumDate = DateTime.Now.AddDays(+5),
			MaximumDate = DateTime.Now.AddDays(-5),
        };
        datePicker.DateSelected += DatePicker_DateSelected;

		stack.Add(datePicker);

		dateLabel = new();
		stack.Add(dateLabel);

		Stepper stepper = new()
		{
			Minimum = 10,
			Maximum = 50,
			Increment = 0.5,
			Value = 20
		};
        stepper.ValueChanged += Stepper_ValueChanged;

		stack.Add(stepper);

		Switch swch = new()
		{
			ThumbColor = Colors.Red,
			OnColor = Colors.Yellow,
			IsToggled = true,
		};
        swch.Toggled += Swch_Toggled;
		stack.Add(swch);

		CheckBox checkBox = new()
		{
			IsChecked = true,
			Color = Colors.Magenta
		};

        checkBox.CheckedChanged += CheckBox_CheckedChanged;



	}






    private void CheckBox_CheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        
    }

    private void Swch_Toggled(object? sender, ToggledEventArgs e)
    {

    }

    private void Stepper_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
		dateLabel.Text = $"Value = {e.NewValue}";
    }

    TimePicker timePicker = new();

    private void DatePicker_DateSelected(object? sender, DateChangedEventArgs e)
    {
		dateLabel.Text = e.NewDate.ToLongDateString();
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        dateLabel.Text = $"Value = {e.NewValue}";
    }

    private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
		if(sender is RadioButton rbtn)
			dateLabel.Text = $"Value = {rbtn.Value}";
    }
}