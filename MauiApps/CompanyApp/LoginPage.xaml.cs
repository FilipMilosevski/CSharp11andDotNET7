namespace CompanyApp;

public partial class LoginPage : ContentPage
{
	public InitDatabase initdatabase { get; set; } = new InitDatabase();
	public LoginPage()
	{
		InitializeComponent();
	}
	private async void Button_Clicked_1(object sender, EventArgs e)
	{
		User user = await initdatabase.GetItemAsync(uname.Text, password.Text);
		if (!string.IsNullOrEmpty(user.Name) || user !=null) 
		{
			await Navigation.PushAsync(new MainPage());
			uname.Text = "";
			password.Text = "";
		} else
		{
			await DisplayAlert("", "Invalid login", "ok");
		}
    }
}