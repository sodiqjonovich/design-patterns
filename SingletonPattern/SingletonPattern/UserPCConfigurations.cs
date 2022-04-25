using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    // Bu class orqali User kompyuterida dasturda boladigan o'zgarishlarni
    // o'zgartirish funksiyalari yoziladi
    // Ya'ni Singleton Design Patternida instance bir yerda o'zgartirilsa 
    // Boshqa qismlarda ham o'zgarishini ko'rsatish uchun ushbu class ochildi
    public class UserPCConfigurations
    {
        public void CreateDefaultConfiguration()
        {
            MockUserSingleton mockUserSingleton = MockUserSingleton.GetInstance();
            mockUserSingleton.Language = Language.Ru;
            mockUserSingleton.DisplaySize.Width = 700;
            mockUserSingleton.DisplaySize.Height = 500;
        }
    }
}
