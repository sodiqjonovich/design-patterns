using System;

namespace SingletonPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instance dan aynan shunday foydalanamiz
            MockUserSingleton mockUserSingleton = MockUserSingleton.GetInstance();

            // bir ikkita maydonlarini o'zgartirib ko'ramiz
            mockUserSingleton.Language = Language.En;
            mockUserSingleton.DisplaySize.Height = 500;

            // Biz ochgan Configuration classimizdan Default Configurationni sozlaymiz
            UserPCConfigurations userPCConfigurations = new UserPCConfigurations();
            userPCConfigurations.CreateDefaultConfiguration();

            // Natijani ekranga chiqaramiz
            Console.WriteLine("-------------- Result -----------");
            Console.WriteLine($"Language : {mockUserSingleton.Language.ToString()} ");
            Console.WriteLine($"Display Width : {mockUserSingleton.DisplaySize.Width}");
            Console.WriteLine($"Display Height : {mockUserSingleton.DisplaySize.Height}");

            // Dasturni ishga tushirsangiz guvohi bo'lasizki
            // Singelton design patternda biror class yagona instance ega bo'lishi
            // Va uni hamma yerdan o'zgartira olishimiz mumkin
            // Yoki u instance dan hamma yerda foydalana olamiz
            // Shuni yodda tutingki Instance yagona bo'ladi
            // Butun project bo'ylab yagona instance ishlatiladi !!!
        }
    }
}
