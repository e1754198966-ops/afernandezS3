namespace afernandezS3.Views;

public partial class vPrincipal : ContentPage
{
	public vPrincipal(string usuario)
	{
		InitializeComponent();
	DisplayAlertAsync("Bienvenido", $"¡Hola, {usuario}! Has iniciado sesión correctamente.", "Aceptar");
		lblUsuario.Text = $"Usuario Conectado: {usuario}";
    }
}