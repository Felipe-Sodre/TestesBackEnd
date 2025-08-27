namespace TestesBackEnd.Paginas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    public async void Enviar_Clicked(object sender, EventArgs e)
		
	
	{
        string usuario = txtUsuario.Text;
        string senha = txtSenha.Text;

		 if (usuario == "Felipe" && senha == "1002")
		{
            await Navigation.PushAsync(new MainPage()); 
		}

    }
}