using MauiAppCadastroEventos.Models;  // Adicione essa linha no topo do arquivo

namespace MauiAppCadastroEventos.Views;


public partial class EventoCadastro : ContentPage
{
    public Models.Evento Evento { get; set; }

    public EventoCadastro()
    {
        InitializeComponent();

        Evento = new Evento();
        BindingContext = Evento;
    }

    private void dtpck_DataInicio_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = sender as DatePicker;

        DateTime data_selecionada_inicio = elemento.Date;

        dtpck_DataTermino.MinimumDate = data_selecionada_inicio.AddDays(1);
        dtpck_DataTermino.MaximumDate = data_selecionada_inicio.AddDays(30);
    }

    //Evento para navegar para a página de resumo
    private async void Button_Cadastrar_Clicked(object sender, EventArgs e)
    {
        //Verifica se todos os campos estão preenchidos antes de navegar
        if (string.IsNullOrWhiteSpace(Evento.Nome) || Evento.Participantes <= 0 || Evento.CustoParticipantes <= 0)
        {
            await DisplayAlert("Erro", "Preencha todos os campos.", "Ok");
            return;
        }

        //Navegar para a página de resumo do evento
        await Navigation.PushAsync(new EventoResumo(Evento));
    }


    //Botão de avançar
    //private void Button_Clicked(object sender, EventArgs e)
    //{

    //}

    //private void dtpck_DataTermino_DateSelected(object sender, DateChangedEventArgs e)
    //{

    //}

}
