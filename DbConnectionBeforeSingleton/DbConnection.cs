using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnectionBeforeSingleton
{
    public class DbConnection
    {
        private readonly SqlConnection _connection;
        private static int _numOfConnections = 0;

        public DbConnection(string connectionString)
        {
            _connection=new SqlConnection(connectionString);
            _connection.Open();
            _numOfConnections++;
            Console.WriteLine($"Database Connection {_numOfConnections} Is Opened ! ");
        }
    }
}
