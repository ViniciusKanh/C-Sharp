using System;
using Interface.Entidades;
namespace Interface.Servicos
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }

        private ServiçoFiscal _ServicoFiscal;

        public ServicoAluguel(double precoHora, double precoDia, ServiçoFiscal servicoFiscal)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _ServicoFiscal = servicoFiscal;
        }

        public void ProcessandoFatura(AluguelCarros aluguelcarro)
        {

            TimeSpan duration = aluguelcarro.Termino.Subtract(aluguelcarro.Inicio);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PrecoHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PrecoDia * Math.Ceiling(duration.TotalDays);
            }

            double tax = _ServicoFiscal.Taxa(basicPayment);

            aluguelcarro.Fatura = new Fatura(basicPayment, tax);
        }
    }
}
