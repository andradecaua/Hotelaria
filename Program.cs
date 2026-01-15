using Hotelaria.Models;

bool sistemaRodando = true;
string menu = "1 - Cadastrar Hospedes\n2 - Cadastrar Suite\n3 - Ver quantiade de hospedes\n4 - Encerrar diária\n5 - Sair";

Reserva reserva = new Reserva();

while(sistemaRodando)
{

    Console.WriteLine(menu);
    ConsoleKeyInfo opcao = Console.ReadKey();

    switch(opcao.KeyChar)
    {
        case '1':

            Console.WriteLine("Digite o nome dos hospedes separados por espaço");

            string stringHospedes = Console.ReadLine();
            List<Pessoa> hospedes = new List<Pessoa>();

            List<string> listaHospedes = new List<string>(stringHospedes.Split(" "));

            break;  
        case '2':
            break;
        case '3':
            break;
        case '4':            
            break;
        case '5':
            Console.WriteLine("Saindo do sistema!");
            Environment.Exit(0);
            break;
        default:
            Console.Clear();            
            break;
    }
}