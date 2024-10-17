namespace glasluisaS3B.Views;

public partial class Registro : ContentPage
{
	public Registro()
	{
		InitializeComponent();
	}

    private void btnGuardar_Clicked(object sender, EventArgs e)
    {
		String usuario = txtUsuarior.Text;
		string contrasena = txtContrasenar.Text;

		Navigation.PushAsync(new Views.login(usuario, contrasena));


    }
}