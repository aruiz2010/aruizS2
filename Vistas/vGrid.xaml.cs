namespace aruizS2.Vistas;

public partial class vGrid : ContentPage
{
	public vGrid()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
		String usuario = "uisrael";
		String contrase�a = "123";
		if (txtUsuario.Text==usuario && txtContrase�a.Text == contrase�a)
		{
			Navigation.PushAsync(new vInicio(usuario));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contrase�a inocrectos", "Cerrar");
		}
    }

    private void btnRegistar_Clicked(object sender, EventArgs e)
    {

    }
}