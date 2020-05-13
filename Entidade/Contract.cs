using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Entidade
{
    class Contract
    {
        public int number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installment { get; set; }
        public Contract()
        {
        }

        public Contract(int number, DateTime date, double totalValue)
        {
            this.number = number;
            Date = date;
            TotalValue = totalValue;
            Installment = new List<Installment>();

        }

        public void AddInstallment(Installment installment)
        {
            Installment.Add(installment);
        }
    }
}
