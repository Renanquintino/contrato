using exercicio.Entidade;
using exercicio.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Serviço
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract,int months)
        {
            double contabase =( contract.TotalValue / months);
            for(int i = 1; i <= months; i++)
            {
                DateTime data = contract.Date.AddMonths(i);
                double updatedQuota = contabase + _onlinePaymentService.Interest(contabase, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(data, fullQuota));
            }
        }
    }
}
