namespace TestesBackEnd
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }


        //Botão para pagina calculadora
        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NovaPasta.Calculadora());
        }

        //Botão para pagina Notificação
        private void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Notificacao());
        }

        //Botão para pagina de Internet
        private void ToolbarItem_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Internet());
        }

        //Botão para pagina de Jogo
        private void ToolbarItem_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Jogo());
        }

        //Botão para pagina de Informações 
        private void ToolbarItem_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Informacao());
        }

        //Botão para pagina de Ateatório
        private void ToolbarItem_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Aleatorio());
        }

        //Botão para pagina de Cores
        private void ToolbarItem_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Cores());
        }

        private void SQLite(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.SQLite());
        }

        private void SQL(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.SQL());
        }

        // Botão para pagina Midia
        private void ToolbarItem_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Midia());
        }

        // Botão para pagina Propriedades
        private void ToolbarItem_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Propriedades());
        }

        private void ToolbarItem_Clicked_9(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Paginas.Login());
        }
    }

}
