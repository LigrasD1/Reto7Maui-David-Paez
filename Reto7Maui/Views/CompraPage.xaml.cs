namespace Reto7Maui.Views;

public partial class CompraPage : ContentPage
{
	public CompraPage()
	{
		InitializeComponent();
	}

    private void ButtonComprar_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }
}