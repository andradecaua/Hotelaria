namespace Hotelaria.Models
{
    public class Reserva()
    {
        private List<Pessoa> _hospedes = new List<Pessoa>();
        private Suite? _suite;
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
            if( _suite != null && _suite.Capacidade >= hospedes.Count)
            {
                _hospedes.AddRange(hospedes);                
                Console.WriteLine("\nHospedes adicionados!");
            }else if(_suite != null)
            {                
                Console.WriteLine($"\nA suite tem capacidade para apenas {_suite.Capacidade} hospedes");
            }
            else
            {
                Console.WriteLine($"\nVocê precisa cadastrar uma suite primeiro!");
            }
        }

        public void CadstrarSuite(Suite suite)
        {
            _suite = suite;
            Console.WriteLine("\nSuite cadastrada com sucesso!");
        }

        public int ObterQuantidadeDeHosepdes()
        {
            return _hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            if(_suite != null && _hospedes.Count > 0)
            {
                decimal valorTotal = _suite.ValorDiaria * _diasReservados;
                if(_diasReservados >= 10)
                {
                    return valorTotal - (valorTotal * 0.10M);
                }
                else
                {
                    return _suite.ValorDiaria * _diasReservados;                                    
                }
            }
            else if(_hospedes.Count < 0)
            {
                throw new ArgumentException("\nVocê precisa ter hospedes para calcular a diária");
            }
            else
            {
                throw new ArgumentException("\nVocê precisa ter uma suite cadastrada!");
            }
        }

    }
}