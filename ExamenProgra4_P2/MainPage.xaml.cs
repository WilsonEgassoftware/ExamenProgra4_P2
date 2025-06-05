namespace ExamenProgra4_P2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {

           
            await Shell.Current.GoToAsync("ChistePage");
        }
        private async void OnAboutClicked(object sender, EventArgs e)
        {
            
            await Shell.Current.GoToAsync("AboutPage");
        }

    }

}
