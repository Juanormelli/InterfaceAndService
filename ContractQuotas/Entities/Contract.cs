using System;
using System.Collections.Generic;
using System.Text;

namespace ContractQuotas.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }
        public List<Installment> Installments { get; set; } = new List<Installment>();

        public Contract()
        {

        }

        public Contract(int number, DateTime date, double total)
        {
            Number = number;
            Date = date;
            Total = total;
            
        }

        public void InstallmentAdd(Installment installment)
        {
            Installments.Add(installment);
        }
    }
}
