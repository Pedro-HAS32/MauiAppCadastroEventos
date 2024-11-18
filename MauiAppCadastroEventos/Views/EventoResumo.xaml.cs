namespace MauiAppCadastroEventos.Views
{
    public partial class EventoResumo : ContentPage
    {
        public EventoResumo(Models.Evento evento)
        {
            InitializeComponent();

            BindingContext = evento;
        }
    }
}
