using System;
namespace InterfaceExercicio.Servicos
{
    class Paypal
    {

        private const double PorcentagemLivre = 0.02;
        private const double JurosMensais = 0.01;

        public double Interesse(double quantia, int mes)
        {
            return quantia * JurosMensais * mes;
        }

        public double TaxaPagamentoe(double quantia)
        {
            return quantia * PorcentagemLivre;
        }

    }
}
