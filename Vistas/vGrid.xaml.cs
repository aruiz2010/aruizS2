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
		String contraseña = "123";
		if (txtUsuario.Text==usuario && txtContraseña.Text == contraseña)
		{
			Navigation.PushAsync(new vInicio(usuario));
		}
		else
		{
			DisplayAlert("Alerta", "Usuario/Contraseña inocrectos", "Cerrar");
		}
    }

    private void btnRegistar_Clicked(object sender, EventArgs e)
    {

    }
}