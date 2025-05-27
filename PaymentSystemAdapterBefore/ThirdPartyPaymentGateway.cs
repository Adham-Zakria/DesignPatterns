using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAdapterBefore
{
    public class ThirdPartyPaymentGateway
    {
        public void MakePayment(string currencyCode,decimal paymentAmount)
        {
            Console.WriteLine($"Process Third-Party Payment With {paymentAmount}-{currencyCode} Done ");

        }

    }
}
