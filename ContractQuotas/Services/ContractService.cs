using ContractQuotas.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContractQuotas.Services
{
    class ContractService
    {


        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double BasicQuota = contract.Total / months;
            double total = 0;
            for (int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double UpdateQuota = BasicQuota + _onlinePaymentService.Interest(BasicQuota, i);
                double FullQuota = UpdateQuota + _onlinePaymentService.PaymentFee(UpdateQuota);
                total += FullQuota;

                contract.Installments.Add(new Installment(date, FullQuota, total));

            }

        }
    }
}
