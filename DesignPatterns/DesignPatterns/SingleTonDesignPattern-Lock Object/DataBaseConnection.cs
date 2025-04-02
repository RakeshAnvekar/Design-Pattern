using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingleTonDesignPattern;

public sealed class DataBaseConnection
{
    private static DataBaseConnection instance;
    private static readonly object lockObj= new object();
    private DataBaseConnection()
    {
        Console.WriteLine("Database Connection Initialized.");
    }

    public static DataBaseConnection GetInstance()
    {
        if (instance==null)
        {
            lock (lockObj) {

                if (instance==null)
                {
                    instance = new DataBaseConnection();

                }
            }
        }
        return instance;
    }
    public void Connect()
    {
        Console.WriteLine("Connected to the database.");
        Console.ReadKey();
    }

}
