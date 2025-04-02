using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingleTonDesignPattern_Monitor_Class
{
    public sealed class DataBaseConnection
    {
        private static DataBaseConnection _instance;
        private static readonly object lockObj = new object();
        private DataBaseConnection()
        {
            Console.WriteLine("Database Connection Initialized.");
        }

        public static DataBaseConnection GetInstance()
        {
            if (_instance==null)
            {
                try
                {
                 Monitor.Enter(lockObj);

                    if (_instance == null)
                    {
                        _instance= new DataBaseConnection();
                    }
                }
                finally
                {
                    Monitor.Exit(lockObj);
                }

            }
            return _instance;
        }
        public void Connect()
        {
            Console.WriteLine("Connected to the database.");
        }
    }
}
