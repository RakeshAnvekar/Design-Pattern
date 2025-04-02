using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class Client
    {
        private readonly IPaymentGateWay _paymentGateWay;
        public Client(IPaymentGateWay paymentGateWay)
        {
            _paymentGateWay = paymentGateWay; 
        }
        public void MakePayment(decimal amount)
        {
            _paymentGateWay.ProcessPayment(amount);
        }
    }
}
