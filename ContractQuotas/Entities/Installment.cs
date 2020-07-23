using System;
using System.Collections.Generic;
using System.Text;

namespace ContractQuotas.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }
        public double TotalPrice { get; set; }

        public Installment()
        {

        }

        public Installment(DateTime dueDate, double amount,double total)
        {
            DueDate = dueDate;
            Amount = amount;
            TotalPrice = total;
        }
        public override string ToString()
        {
            return DueDate.ToString("dd/MM/yyyy") + "---" + Amount.ToString("F2")+"--- Total: "+TotalPrice.ToString("F2");

        }
       
    }
}
