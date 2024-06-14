using Reto7Maui.Views;

namespace Reto7Maui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAddCaffUno_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CompraPage());
        }
    }

}
