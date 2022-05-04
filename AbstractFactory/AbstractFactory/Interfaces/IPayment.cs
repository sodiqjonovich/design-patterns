using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IPayment
    {
        public double Percentage { get; }

        public double Cashback { get; }

        public bool Pay(string phoneNumber, double money);
    }
}
