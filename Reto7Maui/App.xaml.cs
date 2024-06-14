using Reto7Maui.Views;

namespace Reto7Maui
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CompraPage());
        }
    }
}
