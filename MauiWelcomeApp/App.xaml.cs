namespace MauiWelcomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new SecondPage(); //new MyPage(); //new AppShell();
            //MainPage = new NewPage1();
            MainPage = new PageProgress();
        }
    }
}
