namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes
        {
            get;
            set;
        }
        public Suite Suite
        {
            get;
            set;
        }
        public int DiasReservados
        {
            get;
            set;
        }
        public Reserva() : this.Reserva(0);
        public Reserva(int diasReservados) => DiasReservados = diasReservados;
        public void CadastrarHospedes(List<Pessoa> hospedes) => CadastrarHospedes(hospedes);
        public void CadastrarHospedes(params Pessoa[] hospedes)
        {
            if (Suite.Capacidade >= hospedes.Length)
                Hospedes = hospedes;
            else
                throw new Exception();
        }
        public void CadastrarSuite(Suite suite) => Suite = suite;
        public int ObterQuantidadeHospedes() => Hospedes.Count;
        public decimal CalcularValorDiaria() => DiasReservados * Suite.ValorDiaria * (10 <= DiasReservados ? 9E-1M : 1M);
    };
};