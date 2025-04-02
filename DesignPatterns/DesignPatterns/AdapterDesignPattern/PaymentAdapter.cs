using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern
{
    public class PaymentAdapter : IPaymentGateWay
    {
        #region Fields
        private readonly ThirdPartyPaymentService _paymentService;
        #endregion

        #region Constructor
        public PaymentAdapter(ThirdPartyPaymentService paymentService)
        {
            _paymentService = paymentService;  
        }
        #endregion

        #region Methods
        public void ProcessPayment(decimal amount)
        {
            _paymentService.MakePayment(amount);
        }
        #endregion
    }
}
