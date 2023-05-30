namespace CompanyApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        public InitDatabase InitDatabase {get; set;}
        public MainPage()
        {
            InitializeComponent();
            InitDatabase = new InitDatabase();

            
        }
        private List<User> users = new List<User>();
        public List<User> customList { get { return users; } set { users = value; OnPropertyChanged(); } } 
       

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistrationPage());
        }
        


        public class Test
        {
            public string MyProperty { get; set; }
        }

        private async void ContentPage_Appearing(object sender, EventArgs e)
        {
            customList = await InitDatabase.GetItemsAsync();
            BindingContext = this;
        }

        private void ContentPage_Appearing_1(object sender, EventArgs e)
        {

        }

        private void ContentPage_Appearing_2(object sender, EventArgs e)
        {

        }

        private void ContentPage_Appearing_3(object sender, EventArgs e)
        {

        }

        private void ContentPage_Appearing_4(object sender, EventArgs e)
        {

        }
    }
}