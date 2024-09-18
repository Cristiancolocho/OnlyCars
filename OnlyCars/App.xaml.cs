using OnlyCars.Autos;

namespace OnlyCars
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AutosOC();
        }
    }
}
