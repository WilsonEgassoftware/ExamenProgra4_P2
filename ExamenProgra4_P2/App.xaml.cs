namespace ExamenProgra4_P2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
        }
        private async void OnAppStart(object sender, EventArgs e)
        {
            // Navigate to the MainPage when the app starts
            await Shell.Current.GoToAsync("ChistePage");
        }
        private async void OnAboutClicked(object sender, EventArgs e)
        {
            // Navigate to the AboutPage when the About button is clicked
            await Shell.Current.GoToAsync("AboutPage");
        }
    }
}
