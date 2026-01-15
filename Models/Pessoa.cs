namespace Hotelaria.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            this._nome = nome;
            this._sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;

        public string Nome => _nome.ToUpper();
        public string NomeCompleto => $"{_nome} {_sobrenome}".ToUpper();
        
    }
}