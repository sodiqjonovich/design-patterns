using AbstractFactory.PaymentSystems;
using System;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----> Click
            //double money = 40000;
            //string phoneNumber = "+998976260619";
            //var payment = PaymentFactory.GetPaymentSystem("click");
            //payment.Pay(phoneNumber, money);

            // ----> Payme
            //double money = 45000;
            //string phoneNumber = "+998976260619";
            //var payment = PaymentFactory.GetPaymentSystem("payme");
            //payment.Pay(phoneNumber, money);

            // ----> Oson
            //double money = 45000;
            //string phoneNumber = "+998976260619";
            //var payment = PaymentFactory.GetPaymentSystem("oson");
            //payment.Pay(phoneNumber, money);

            // ----> Apelsin
            double money = 45000;
            string phoneNumber = "+998976260619";
            var payment = PaymentFactory.GetPaymentSystem("apelsin");
            payment.Pay(phoneNumber, money);
        }
    }
}
