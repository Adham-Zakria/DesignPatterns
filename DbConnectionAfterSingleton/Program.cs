namespace DbConnectionAfterSingleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connection01 =  DbConnection.CreateInstance("Server=DESKTOP-4M2VPDA\\MSSQLSERVER02 ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");
            var connection02 =  DbConnection.CreateInstance("Server=DESKTOP-4M2VPDA\\MSSQLSERVER02 ; Database =TESTBeforeSingleton ; Trusted_Connection =true ;TrustServerCertificate=true");

        }
    }
}
