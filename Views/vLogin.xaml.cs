namespace afernandezS3.Views;

public partial class vLogin : ContentPage
{
    string usuario = "";
    string contrasena = "";
    public vLogin()
	{
		InitializeComponent();
	}

    public vLogin(string usuarioNuevo, string contrasenaNueva)
    {
        InitializeComponent();
        usuario = usuarioNuevo;
        contrasena = contrasenaNueva;
    }

    private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
    {

        try
        {
            string usuarioingresado = txtUsuario.Text;
            string contrasenaingresada = txtContrasena.Text;

            if (usuarioingresado == usuario && contrasenaingresada == contrasena)
            {
                // Iniciar sesión

                await Navigation.PushAsync(new Views.vPrincipal(usuario));
            }
            else
            {
                // Mostrar mensaje de error
                DisplayAlert("Error", "Usuario o contraseña incorrectos", "Aceptar");
            }
        }
        catch (Exception ex)
        {

            await DisplayAlert("Error", "Ocurrió un error al iniciar sesión: " + ex.Message, "Aceptar");
        }
    }

    private async void btnRegistrarUsuario_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.vRegistro());

    }
}