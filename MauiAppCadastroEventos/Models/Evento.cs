using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppCadastroEventos.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public int Participantes { get; set; }
        public string Local {  get; set; }
        public decimal CustoParticipantes { get; set; }

        public int DuracaoDias
        {
            get
            {
                return (DataTermino - DataInicio).Days;
            }
        }

        public decimal CustoTotal
        {
            get
            {
                return Participantes * CustoParticipantes;
            }

        }
    }
}
