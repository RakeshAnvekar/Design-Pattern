using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class ThirdPartyPaymentService
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine("ThirdParty Payment..");
            Console.ReadKey();
        }
    }
}
