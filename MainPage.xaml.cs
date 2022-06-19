namespace ConhecendoMAUI;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private async void RedirectToLink(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
        {
            Uri uri = new Uri("https://www.instagram.com/iamhericaa/");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        else
        {
            Uri uri = new Uri("https://letmegooglethat.com/?q=por+que+as+pessoas+clicam+tantas+vezes+em+um+bot%C3%A3o%3F");
            await Browser.Default.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        }
        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

