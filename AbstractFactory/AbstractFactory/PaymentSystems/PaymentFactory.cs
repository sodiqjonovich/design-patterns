using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PaymentSystems
{
    public class PaymentFactory
    {
        private static IDictionary<string, IPayment> _payments
            = new Dictionary<string, IPayment>()
            {
                { "click", new Click() },
                { "payme", new Payme() },
                { "oson", new Oson() },
                { "apelsin", new Apelsin() }
            };

        public static IPayment GetPaymentSystem(string paymentType)
        {
            IPayment payment = _payments[paymentType];
            return payment;
        }
    }
}
