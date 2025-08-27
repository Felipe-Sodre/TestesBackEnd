namespace TestesBackEnd
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Paginas.Login();
            MainPage = new NavigationPage(new Paginas.Login());
            //MainPage = new AppShell();
        }
    }
}
