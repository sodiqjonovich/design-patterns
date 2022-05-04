using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PaymentSystems
{
    public class Apelsin : IPayment
    {
        private double _percentage = 0.0;
        private double _cashback = 0.0;
        public double Percentage
        {
            get => _percentage;
        }

        public double Cashback
        {
            get => _cashback;
        }

        public bool Pay(string phoneNumber, double money)
        {
            try
            {
                Console.WriteLine("----------------- Apelsin Payment --------------");
                Console.WriteLine(" Phone Number : " + phoneNumber);
                Console.WriteLine(" Amount Of Payment : " + money + " UZS");
                double pOfPC = money * _percentage;
                Console.WriteLine(" Percentage of Peyment Commission : " + pOfPC + " UZS");
                double cOfPC = money * _cashback;
                Console.WriteLine(" Amount Of Cashback : " + cOfPC + " UZS");
                double fullmoney = money + pOfPC - cOfPC;
                Console.WriteLine(" Total Amount : " + fullmoney + " UZS");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
