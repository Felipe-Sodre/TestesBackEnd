namespace TestesBackEnd.Paginas;


public partial class Propriedades : ContentPage
{
    int a = 1;

    public Propriedades()
	{
		InitializeComponent();
	}

    private void Botão1_Clicked(object sender, EventArgs e)
    {
        
        Botão1.Text = a.ToString();
        a = a + 1;
    }
}