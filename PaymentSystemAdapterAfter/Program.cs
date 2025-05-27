namespace PaymentSystemAdapterAfter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor localPaymentProcessor = new LocalPaymentProcessor();

            ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();
            //Adaptation
            IPaymentProcessor adapter = new ThirdPartyPaymentAdapter(thirdPartyPaymentGateway);

            PaymentService service = new PaymentService(adapter);

            service.Pay(30, "USD");
        }
    }
}
