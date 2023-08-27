using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_22
{
    internal class Metodlar
    {

        ////************************** Soru 1 Metodlar *********************************************//
        
        public string marka, model;
        public int km, yil;

        ////************************** Soru 3 Metodlar *********************************************//

        public string kullaniciAdi;
        private string _parola;

        public string parolaTanimla
        {
            set { _parola = value; }
        }

        public void Girisyap(string kadi, string parola )
        {

            if (kadi == kullaniciAdi && parola == _parola)
            {
                Console.WriteLine("Giriş Yapıldı ^_^.");
            }
            else
            {
                Console.WriteLine("Hatalı şifre Veya Kullanıcı Adı.");
            }

        }

        ////************************** Soru 6 Metodlar *********************************************//

        public static bool AsalMi(int sayi)
        {

            if (sayi == 0 || sayi == 1)
            { return false; }
            if (sayi == 2 || sayi == 3)
            {
                return true;
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

    }
}
