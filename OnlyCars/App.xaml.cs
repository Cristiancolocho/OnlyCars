using OnlyCars.Autos;
using OnlyCars.Views;

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
