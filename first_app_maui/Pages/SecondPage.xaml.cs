using Microsoft.Maui.Controls;
namespace first_app_maui.Pages

{
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnQuestionButtonClicked(object sender, EventArgs e)
        {
            string result = await DisplayPromptAsync(
                "Pergunta 2",
                "Quanto é 5 + 5?",
                initialValue: "10",
                maxLength: 2,
                keyboard: Keyboard.Numeric
            );

            if (!string.IsNullOrWhiteSpace(result))
            {
                await DisplayAlert("Resposta", $"Você respondeu: {result}", "OK");
            }
        }
    }
}