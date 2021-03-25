using System;
namespace Interface.Servicos
{
    class ServicoImpostoBrasil : ServiçoFiscal
    {

    public double Taxa(double amount)
        {
            if (amount <= 100.00)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }


    }
}
