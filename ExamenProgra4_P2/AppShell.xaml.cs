namespace ExamenProgra4_P2
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("ChistePage", typeof(Chistespage));
            Routing.RegisterRoute("AboutPage", typeof(MainPage));
        }
    }
}
