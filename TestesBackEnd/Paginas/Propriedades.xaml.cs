namespace TestesBackEnd.Paginas;


public partial class Propriedades : ContentPage
{
    int a = 1;

    public Propriedades()
	{
		InitializeComponent();
	}

    private void Bot�o1_Clicked(object sender, EventArgs e)
    {
        
        Bot�o1.Text = a.ToString();
        a = a + 1;
    }
}