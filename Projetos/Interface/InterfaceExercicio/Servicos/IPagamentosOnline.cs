using System;
namespace InterfaceExercicio.Servicos
{
    interface IPagamentosOnline
    { 
        double TaxaPagamento(double quantia);
        double Interesse(double quantia, int mes);
    }
}
