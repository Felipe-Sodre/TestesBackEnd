
namespace TestesBackEnd.Paginas;

public partial class Notificacao : ContentPage
{
	public Notificacao()
	{
		InitializeComponent();
	}


    private void Enviar_Clicked(object sender, EventArgs e)
    {
		string campo = Campo1.Text;
		

		DisplayAlert("DisplayAlert", campo, "Ok");

		//Cria um hist�rico
        Texto1.Text += campo + Environment.NewLine;
    }

}