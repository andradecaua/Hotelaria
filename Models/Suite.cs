namespace Hotelaria.Models
{
   public class Suite
    {
        public Suite(string tipoSuite, int capacidade, decimal valorDiaria)
        {
            this._tipoSuite = tipoSuite;
            this._capacidade = capacidade;
            this._valorDiaria = valorDiaria;
        }

        private string _tipoSuite;
        private int _capacidade;
        private decimal _valorDiaria;
        public string TipoSuite => _tipoSuite.ToUpper();
        public int Capacidade => _capacidade;
        public decimal ValorDiaria => _valorDiaria;

    } 
}