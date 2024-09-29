using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWelcomeApp
{
    internal class MyPage : ContentPage
    {
        public MyPage()
        {
            //Content = new StackLayout
            //{
            //    Children = {
            //        new Label()
            //        {
            //            Text = "Welcome to my page!",
            //            HorizontalTextAlignment = TextAlignment.Center,
            //            VerticalTextAlignment = TextAlignment.Center
            //        }
            //    }
            //};

            Label hello = new Label()
            {
                Text = "Hello world",
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Colors.Aqua,
            };

            Label goodby = new Label()
            {
                Text = "Good By world",
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Colors.Red,
            };

            //StackLayout stack = new();
            VerticalStackLayout stack = new();
            stack.Children.Add(hello);
            stack.Children.Add(goodby);
            //stack.Orientation = StackOrientation.Vertical;

            Content = stack;

        }
    }
}
