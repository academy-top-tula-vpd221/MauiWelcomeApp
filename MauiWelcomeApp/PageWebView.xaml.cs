namespace MauiWelcomeApp;

public partial class PageWebView : ContentPage
{
	public PageWebView()
	{
		InitializeComponent();

		//WebView web = new WebView
		//{
		//	Source = new UrlWebViewSource { Url = "https://tula.top-academy.ru/" }
		//};

		//stack.Children.Add(web);

		//WebView htmlView = new();
		//HtmlWebViewSource html = new();
		//html.Html = @"<h1>Hello world</h1>
		//			<p>Hello people</p>";

		//htmlView.Source = html;

		//stack.Children.Add(htmlView);

		WebView webView = new WebView();
		webView.Source = "index.html";
		Content = webView;
	}
}