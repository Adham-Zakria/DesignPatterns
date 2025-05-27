using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAdapterAfter
{
    internal class LocalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount, string curreny)
        {
            Console.WriteLine($"Process Local Payment With {amount}-{curreny} Done ");
        }
    }
}
