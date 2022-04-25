namespace SingletonPattern
{
    public class MockUserSingleton
    {
        // Bu qismda ayna shu class imizdan private instance olishimiz kerak
        // Sababi hamma class aynan shu instance ni ishlatadi
        private static MockUserSingleton _mockUserSingleton;

        // User biror tilni tanlasa u saqlanib qolishi uchun til qo'shib qo'ydik
        // Ya'ni biror bir tanlansa ushbu class imizning instance si yagona bo'lgani uchun
        // Projectni hohlagan yerida tilni o'zgartirsak hamma joyida bir hil o'zgaradi
        public Language Language = Language.En;

        // Ekranni o'lchovlarini saqlab qolish uchun 
        // Ekranni bo'yi va enini saqlab turuvchi class ochib qoyildi
        // Ya'ni siz uzingiz hohlagan class yoki enum ... ni qo'shishingiz mumkin
        public DisplaySize DisplaySize = new DisplaySize();

        // Constructor ni private qilish Singelton Design Patternning asosiy ishi xisoblanadi
        // Ushbu class dan new MockUserSingleton() qilib hech qayerda instance ola olmaymiz
        private MockUserSingleton()
        {

        }

        // Ushbu method ham Singleton Design Patternning asosiy ishlaridan xisoblanadi
        // Ya'ni qayerda ushbu class objectidan foydalanmoqchi bo'lsak yagona instance ni qaytarib beradi
        // U public yoki Internal bo'lishi kerak va static qilish kerak
        // static qilinishini sababi ushbu class imizdan object olib bolmaydi sababi constructor private
        // Shuning uchun static bolishi kerak
        public static MockUserSingleton GetInstance()
        {
            if (_mockUserSingleton is null) _mockUserSingleton = new MockUserSingleton();
            return _mockUserSingleton;
        }
    }
}
