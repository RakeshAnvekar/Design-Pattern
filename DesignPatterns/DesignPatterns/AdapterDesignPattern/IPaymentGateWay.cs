using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryDesignPattern;

public interface IPaymentGateWay
{
    #region Methods
    public void ProcessPayment(decimal amount);
    #endregion
}
