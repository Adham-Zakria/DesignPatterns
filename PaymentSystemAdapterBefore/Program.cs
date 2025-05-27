namespace PaymentSystemAdapterBefore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaymentProcessor localPaymentProcessor = new LocalPaymentProcessor();

            ThirdPartyPaymentGateway thirdPartyPaymentGateway = new ThirdPartyPaymentGateway();


            PaymentService service = new PaymentService(localPaymentProcessor);

            service.Pay(30, "USD");
        }
    }
}
