namespace afernandezS3.Views;

public partial class vRegistro : ContentPage
{
	public vRegistro()
	{
		InitializeComponent();
	}

    private async void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        string usuarioNuevo = txtUsuarioNuevo.Text;
        string contrasenaNueva = txtContrasenaNueva.Text;
    
    await Navigation.PushAsync(new Views.vLogin(usuarioNuevo, contrasenaNueva));

        DisplayAlertAsync("BIENVENIDO", "Usuario registrado correctamente", "Aceptar");

    }


    private async void btnCancelar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vLogin());
    }
}