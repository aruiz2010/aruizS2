namespace aruizS2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Vistas.vGrid());//cambiar la pagina de ejecucion
        }
    }
}
