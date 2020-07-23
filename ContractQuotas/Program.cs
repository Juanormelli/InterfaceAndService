using ContractQuotas.Entities;
using ContractQuotas.Services;
using System;

namespace ContractQuotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Contract Data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date: (dd/mm/yyyy) ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract Value: ");
            double total = double.Parse(Console.ReadLine());
            Console.Write("Enter Number Od Installments: ");
            int months = int.Parse(Console.ReadLine());
            Contract contract = new Contract(number, date, total);

            
            ContractService myContract = new ContractService(new PaypalService());
            myContract.ProcessContract(contract, months);

            Console.WriteLine("Instalments: ");
            foreach(Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }

            
           
        }
    }
}
