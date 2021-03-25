using System;
using System.Globalization;
namespace InterfaceExercicio.Entidades
{
    class Prestacao
    {
        private object quantia;
        private double fullQuota;

        public double Quantia { get; set; }
        public DateTime DueDate { get; set; }

        public Prestacao(double quantia, DateTime dueDate)
        {
            Quantia = quantia;
            DueDate = dueDate;
        }

        public Prestacao(object quantia, double fullQuota)
        {
            this.quantia = quantia;
            this.fullQuota = fullQuota;
        }

        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Quantia.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
