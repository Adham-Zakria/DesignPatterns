﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentSystemAdapterAfter
{
    internal class PaymentService
    {
        private readonly IPaymentProcessor _paymentProcessor;

        public PaymentService(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }
        public void Pay(decimal amount ,string currency)
        {
            _paymentProcessor.ProcessPayment(amount, currency);
        }
    }
}
