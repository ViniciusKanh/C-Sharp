using System;
using System.Globalization;
using Interface.Entidades;
using Interface.Servicos;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os Dados");
            Console.Write("Modelo de Carro: ");
            string model = Console.ReadLine();
            Console.Write("Pagar (dd/MM/yyyy HH:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Retorno (dd/MM/yyyy HH:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarros aluguelCarro = new AluguelCarros(start, finish, new Veiculo(model));

            ServicoAluguel rentalService = new ServicoAluguel(hour, day, new ServicoImpostoBrasil());

            rentalService.ProcessandoFatura(aluguelCarro);

            Console.WriteLine("Fatura:");
            Console.WriteLine(aluguelCarro.Fatura);
        }
    }
}
