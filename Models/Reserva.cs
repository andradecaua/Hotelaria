namespace Hotelaria.Models
{
    public class Reserva()
    {
        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite _suite;
        private int _diasReservados;

        public int DiasReservados 
            {
                get => _diasReservados;
                set
                {
                    if(value < 1)
                    {
                         throw new ArgumentException("Não podemos ter reservas menores que 1 dia");
                    }                       
                     _diasReservados = value;
                }
            }  

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            _hospedes.AddRange(hospedes);
            Console.WriteLine("Hospedes adicionados!");
        }

        public void CadstrarSuite(Suite suite)
        {
            _suite = suite;
            Console.WriteLine("Suite cadastrada com sucesso!");
        }

        public int ObterQuantidadeDeHosepdes()
        {
            return _hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {

            return _suite.ValorDiaria * _diasReservados;
        }

    }
}