using System;
using InterfaceExercicio.Entidades;
namespace InterfaceExercicio.Servicos
{
    class ServicoContrato
    {

        private IPagamentosOnline _pagamentosOnline;
        private Paypal paypal;

        public ServicoContrato(IPagamentosOnline pagamentosOnline)
        {
            _pagamentosOnline = pagamentosOnline;
        }

        public ServicoContrato(Paypal paypal)
        {
            this.paypal = paypal;
        }

        public void ProcessContract(Contratos contratos, int mes)
        {
            double basicQuota = contratos.ValorTotal / mes;
            for (int i = 1; i <= mes; i++)
            {
                DateTime quantia = contratos.Data.AddMonths(i);
                double updatedQuota = basicQuota + _pagamentosOnline.Interesse(basicQuota, i);
                double fullQuota = updatedQuota + _pagamentosOnline.TaxaPagamento(updatedQuota);
                contratos.AddPrestacao(new Prestacao(quantia, fullQuota));
            }
        }
    }

}
