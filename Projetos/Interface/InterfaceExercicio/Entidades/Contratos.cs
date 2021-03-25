using System;
using System.Collections.Generic;
namespace InterfaceExercicio.Entidades
{
    class Contratos
    {
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public double ValorTotal { get; set; }
        public List<Prestacao> Prestacao { get; set; }

        public Contratos(int numero, DateTime data, double valorTotal)
        {
            Numero = numero;
            Data = data;
            ValorTotal = valorTotal;
            Prestacao = new List<Prestacao>();
        }

        public void AddPrestacao(Prestacao prestacao)
        {
            Prestacao.Add(prestacao);
        }
    }
}
