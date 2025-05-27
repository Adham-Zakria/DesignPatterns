using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAdapterAfter
{
    public class ThirdPartyPaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway _paymentGateway;

        public ThirdPartyPaymentAdapter(ThirdPartyPaymentGateway paymentGateway)
        {
            _paymentGateway = paymentGateway;
        }
        public void ProcessPayment(decimal amount, string curreny)
        {
            _paymentGateway.MakePayment(curreny, amount);   
        }
    }
}
