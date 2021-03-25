using System;
namespace Interface.Entidades
{
   class AluguelCarros
    {
        public DateTime Inicio { get; set; }
        public DateTime Termino { get; set; }
        public Veiculo Veiculo { get; private set; }
        public Fatura Fatura { get; set; }

        public AluguelCarros(DateTime inicio, DateTime termino, Veiculo veiculo)
        {
            Inicio = inicio;
            Termino = termino;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
