namespace DbConnectionBeforeSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection01 = new DbConnection("Server = . ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");
            var connection02 = new DbConnection("Server = . ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");
     
        
        }
    }
}
