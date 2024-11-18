
namespace MauiAppCadastroEventos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Views.EventoCadastro();
        }

        //Código da janela
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 400;

            window.MinimumWidth = 400;
            window.MinimumHeight = 600;

            return window;
        }

    }//Já estava aqui!
}
