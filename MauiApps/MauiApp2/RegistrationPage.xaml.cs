namespace MauiApp2;

public partial class RegistrationPage : ContentPage
{

    public RegistrationPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Alert", "Succesfull registration", "OK");
        await Navigation.PopAsync();
    }
}