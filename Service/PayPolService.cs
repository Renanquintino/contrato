using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio.Service
{
    class PayPolService : IOnlinePaymentService
    {
        private const double PorcentagemFee = 0.02;
        private const double juros = 0.01;

        public double Interest(double amount, int months)
        {
            return amount * juros  * months;
        }
        public double PaymentFee(double amount)
        {
            return amount * PorcentagemFee;
        }
    }
}
