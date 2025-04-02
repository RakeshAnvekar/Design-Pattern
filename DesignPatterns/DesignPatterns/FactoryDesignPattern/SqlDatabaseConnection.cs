using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class SqlDatabaseConnection : IDataBaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Sql Database Connected");
            Console.ReadKey();
        }
    }
}
