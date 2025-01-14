using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payments
{
    class Program
    {
        static void Main()
        {
            var paymentContext = new PaymentContext();

            paymentContext.SetPaymentStrategy(new CreditCardPayment());
            paymentContext.Pay(21.37m);

            paymentContext.SetPaymentStrategy(new PayPalPayment());
            paymentContext.Pay(69.420m);

            paymentContext.SetPaymentStrategy(new CryptoPayment());
            paymentContext.Pay(1337m);
        }
    }

}
