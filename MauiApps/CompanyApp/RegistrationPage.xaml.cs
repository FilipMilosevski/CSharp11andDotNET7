namespace CompanyApp;

public partial class RegistrationPage : ContentPage
{
	public InitDatabase  initDatabase{get; set;}
	public RegistrationPage()
	{
		InitializeComponent();
		initDatabase = new InitDatabase();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		User user = new User();
		user.Name = name.Text;
		name.Text = "";
		user.Surname = surname.Text;
		surname.Text = "";
		user.Phone = phone.Text;
		phone.Text = "";
		user.UserName = username.Text;
		username.Text = "";
		user.WorkPosition = workposisiton.Text;
		workposisiton.Text = "";
		user.Education = education.Text;
		education.Text = "";
		user.Password = password.Text;
		password.Text = "";
		await initDatabase.SaveItemAsync(user);

		await DisplayAlert("Alert", "Succesfull registration", "OK");
		await Navigation.PopAsync();
    }
}