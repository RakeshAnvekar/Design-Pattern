using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class DataBaseConnectionFactory
    {
        public static IDataBaseConnection GetDataBaseConnection(string dbType)
        {
            switch (dbType.ToLower())
            {

                case "sql":
                    return new SqlDatabaseConnection();
                case "mongodb":
                    return new MongoDbConnection();
                default:
                    throw new ArgumentException("Invalid database type");
            }
        }
    }
}
