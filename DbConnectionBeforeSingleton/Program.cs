namespace DbConnectionBeforeSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection01 = new DbConnection("Server=DESKTOP-4M2VPDA\\MSSQLSERVER02 ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");
            var connection02 = new DbConnection("Server=DESKTOP-4M2VPDA\\MSSQLSERVER02 ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");
     
        
        }
    }
}
