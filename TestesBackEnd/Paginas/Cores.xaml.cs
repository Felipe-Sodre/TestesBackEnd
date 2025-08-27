namespace TestesBackEnd.Paginas;

public partial class Cores : ContentPage
{
	public Cores()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (this.BackgroundColor == Colors.OrangeRed)
        {
            this.BackgroundColor = Colors.Blue;
        }
        else
        {
            this.BackgroundColor = Colors.OrangeRed;
        }
    }
}