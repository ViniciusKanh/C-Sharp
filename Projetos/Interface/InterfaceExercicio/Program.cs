using System;
using InterfaceExercicio.Entidades;
using InterfaceExercicio.Servicos;
using System.Globalization;

namespace InterfaceExercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Entre com os Dados do Contrato");
            Console.Write("Numero: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments: ");
            int months = int.Parse(Console.ReadLine());

            Contratos myContract = new Contratos(contractNumber, contractDate, contractValue);

            ServicoContrato servicoContrato = new ServicoContrato(new Paypal());
            servicoContrato.ProcessContract(myContract, months);

            Console.WriteLine("Installments:");
            foreach (Prestacao installment in myContract.Prestacao)
            {
                Console.WriteLine(installment);
            }








        }
    }
}
