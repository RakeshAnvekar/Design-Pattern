using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class MongoDbConnection : IDataBaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("mongoDB Database Connected");
            Console.ReadKey();
        }
    }
}
