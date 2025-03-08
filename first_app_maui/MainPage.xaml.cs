namespace first_app_maui;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnButtonClicked(object sender, EventArgs e)
	{
		string nome = NomeEntry.Text;
		MensagemLabel.Text = $"Olá, {nome}! Bem-vindo ao .NET MAUI!";
	}

	private async void OnNavegarClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Pages.SecondPage());

	}

}

