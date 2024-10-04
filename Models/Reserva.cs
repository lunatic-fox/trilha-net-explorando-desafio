using System.Globalization;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else throw new Exception("Capacidade da suíte excedida!");
        }

        public void CadastrarSuite(Suite suite) => Suite = suite;
        
        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public string CalcularValorDiaria() 
        {
            decimal valor = DiasReservados >= 10 ? (Suite.ValorDiaria - (Suite.ValorDiaria * .1m)) * DiasReservados : Suite.ValorDiaria * DiasReservados;
            return valor.ToString("C2", new CultureInfo("pt-BR"));
        }
    }
}
