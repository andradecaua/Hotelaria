using Hotelaria.Models;

bool sistemaRodando = true;
string menu = "\n1 - Cadastrar Suite\n2 - Cadastrar Hospedes\n3 - Ver quantiade de hospedes\n4 - Encerrar diária\n5 - Sair";

Console.Clear();
Reserva  reserva = new Reserva();
while(sistemaRodando)
{

    Console.WriteLine(menu);
    ConsoleKeyInfo opcao = Console.ReadKey();
    try
    {
        switch(opcao.KeyChar)
        {
            case '1':

                Console.WriteLine("\nDigite o tipo de suite que deseja cadastrar");
                string tipoSuite = Console.ReadLine();
                if(tipoSuite == "")
                {
                    throw new ArgumentException("O tipo de suite deve ser informado corretamente!");
                }
                Console.WriteLine("\nDigite a capacidade da Suite");
                int.TryParse(Console.ReadLine(), out int capacidade);
                if(capacidade <= 0)
                {
                    throw new ArgumentException("A suite deve ter capacidade maior que 0");
                }
                Console.WriteLine("\nDigite o valor da diária: ");
                decimal.TryParse(Console.ReadLine(), out decimal valorDiaria);

                if(valorDiaria <= 0)
                {
                    throw new ArgumentException("O valor da diária deve ser maior que 0");
                }
                Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

                reserva.CadstrarSuite(suite);

                break;
            case '2':
                            
                Console.WriteLine("\nQuantos dias irão ficar hospedados?");
                int.TryParse(Console.ReadLine(), out int diasReservados);

                reserva.DiasReservados = diasReservados;  

                Console.WriteLine("\nDigite o nome dos hospedes separados por virgula (,)");

                string stringHospedes = Console.ReadLine();
                List<Pessoa> hospedes = new List<Pessoa>();

                List<string> listaHospedes = new List<string>(stringHospedes.Split(","));

                foreach(string hospede in listaHospedes)
                {
                    if(!hospede.Contains(' '))
                    {
                        throw new ArgumentException("\nDeve informar o sobrenome do hospede!");                        
                    }
                    string[] dadosHospede = hospede.Split(" ");
                    Pessoa pessoa = new Pessoa(dadosHospede[0], dadosHospede[1]);
                    hospedes.Add(pessoa);
                }

                reserva.CadastrarHospedes(hospedes);            

                break;  

            case '3':
                Console.WriteLine($"\nNesta reserva temos {reserva.ObterQuantidadeDeHosepdes()} pessoas hospedadas");
                break;
            case '4': 
                Console.WriteLine($"\nO valor total da diária ficou em {reserva.CalcularValorDiaria():C2}");           
                break;
            case '5':
                Console.WriteLine("\nSaindo do sistema!");
                sistemaRodando = false;
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nOpção inválida...");
                break;
        }
        
    }catch(Exception exception)
    {
        Console.WriteLine(exception.Message);
    }

    Console.WriteLine("\nPressione qualquer tecla para continuar");
    Console.ReadKey();
    Console.Clear();
}