using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_22
{
    internal class Program
    {
        enum Aylar
        {
            ocak = 1,
            subat,
            mart,
            nisan, 
            mayıs, 
            haziran, 
            temmuz, 
            agustos, 
            eylul, 
            ekim, 
            kasim, 
            aralik
        }
        static void Main(string[] args)
        {


            string soru, cevap;

            do
            {
                Console.WriteLine("*******************************************************************************************************");
                Console.WriteLine("Hoş Geldiniz Hangi Soru İstiyorsunuz Seçeniz ^_^ ");
                Console.WriteLine("*******************************************************************************************************");

                Console.WriteLine("(0).Çıkış.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(1).Araba Bilgileri Listesi ve Gösterme.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(2).Toplama ve Ortalama Hesaplama.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(3).Kullanıcı Girişi ve Doğrulama.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(4).Klasör Varlığı Kontrolü ve Kaldırma.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(5).Ay ve Mevsim Kontrolü.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(6).Asal Sayı Kontrolü.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(7).Sayının Rakamlarının Toplamı.");
                Console.WriteLine("------------------------------------------");

                Console.WriteLine("(8).Palindrom Kontrolü.");
                Console.WriteLine("------------------------------------------");


                Console.Write("Sorunuz Numarası Giriniz : ");
                soru = Console.ReadLine();
                Console.Clear();


                //****************************************************************************************************//

                if (soru == "1")
                {
                    do
                    {
                        List<Metodlar> arabalar = new List<Metodlar>();

                        Metodlar a1 = new Metodlar();
                        a1.marka = "Fiat";
                        a1.model = "Egea";
                        a1.km = 120000;
                        a1.yil = 2019;
                        arabalar.Add(a1);

                        Metodlar a2 = new Metodlar();
                        a2.marka = "Audi";
                        a2.model = "A4";
                        a2.km = 35000;
                        a2.yil = 2017;
                        arabalar.Add(a2);

                        foreach (var item in arabalar)
                        {
                            Console.WriteLine(item.marka);
                            Console.WriteLine(item.model);
                            Console.WriteLine(item.km);
                            Console.WriteLine(item.yil);
                            Console.WriteLine("--------------");

                        }
                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();


                }



                //***********************************************************************//

                else if (soru == "2")
                {
                    do
                    {
                        Console.Write("Kaç Adet Sayı Girmek İstersiniz: ");
                        int adet = int.Parse(Console.ReadLine());
                        int toplam = 0;
                        List<int> sayilar = new List<int>();
                        for (int i = 1; i <= adet; i++)
                        {
                            Console.Write(i + ".Sayıyı Giriniz: ");
                            int sayi = int.Parse(Console.ReadLine());
                            sayilar.Add(sayi);

                        }
                        foreach (var item in sayilar)
                        {
                            toplam += item;
                        }
                        double ort = (double)toplam / sayilar.Count;

                        Console.WriteLine("Sayıların Toplamı = " + toplam);
                        Console.WriteLine("Sayıların Ortalaması = " + Math.Round(ort, 2));

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();
                }



                ////***********************************************************************//

                else if (soru == "3")
                {
                    do
                    {
                        Metodlar k = new Metodlar();

                        Console.Write("Kullanıcı Adını Giriniz: ");
                        k.kullaniciAdi = Console.ReadLine();
                        Console.Write("Kullanıcı Şifre Giriniz: ");
                        k.parolaTanimla = Console.ReadLine();

                        k.Girisyap("Emcet", "emcet1997");


                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();
                    } while (true);
                    Console.Clear();

                }
                ////***********************************************************************//


                else if (soru == "4")
                {
                    do
                    {
                        string yol = @"C:\Users\amged\OneDrive\سطح المكتب\emcet";

                        bool varMi = Directory.Exists(yol);
                        if (varMi)
                        {
                            Console.WriteLine("Klasör Zaten Var.");
                        }
                        else
                        {
                            Console.WriteLine("Klasör Bulunamadı.");
                        }

                        //Directory.Delete(yol);

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }

                        else
                        {
                            Console.Clear();
                        }

                    } while (true);
                    Console.Clear();
                }


                ////***********************************************************************//

                else if (soru == "5")
                {

                    do
                    {
                        Console.Write("1-12 arasında bir değer giriniz: ");
                        int ay = int.Parse(Console.ReadLine());
                        switch (ay)
                        {
                            case (int)Aylar.aralik:
                            case (int)Aylar.ocak:
                            case (int)Aylar.subat:
                                Console.WriteLine("Kış Mevsimi.");
                                break;
                            case (int)Aylar.mart:
                            case (int)Aylar.nisan:
                            case (int)Aylar.mayıs:
                                Console.WriteLine("İlkbahar Mevsimi.");
                                break;
                            case (int)Aylar.haziran:
                            case (int)Aylar.temmuz:
                            case (int)Aylar.agustos:
                                Console.WriteLine("Yaz Mevsimi.");
                                break;
                            case (int)Aylar.eylul:
                            case (int)Aylar.ekim:
                            case (int)Aylar.kasim:
                                Console.WriteLine("Sonbahar Mevsimi.");
                                break;
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }

                ////***********************************************************************//

                else if (soru == "6")
                {
                    do
                    {
                        Console.Write("Bir Sayıyı Giriniz: ");
                        int sayi = int.Parse(Console.ReadLine());

                        if (Metodlar.AsalMi(sayi))
                        {
                            Console.WriteLine("Girdiğiniz Sayı Asaldır");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz Sayı Asal Değildir");
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }


                ////***********************************************************************//


                else if (soru == "7")
                {
                    do
                    {
                        Console.Write("Bir Sayıyı Giriniz: ");
                        int sayi = int.Parse(Console.ReadLine());
                        int toplam = 0;
                        while (sayi > 0)
                        {
                            toplam += (sayi % 10);
                            sayi /= 10;

                        }
                        Console.WriteLine("Girdiğiniz Sayının Rakamlarının Toplamı: " + toplam);

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();
                }


                ////***********************************************************************//

                else if (soru == "8")
                {
                    do
                    {
                        Console.Write("Bir Kelime Giriniz: ");
                        string kelime = Console.ReadLine();
                        int sol = 0, sag = kelime.Length - 1;
                        bool kontrol = true;
                        while (sol < sag)
                        {
                            if (char.ToLower(kelime[sol]) != char.ToLower(kelime[sag]))
                            {
                                kontrol = false;
                            }
                            sol++;
                            sag--;
                        }
                        if (kontrol)
                        {
                            Console.WriteLine("Girilen Kelime Bir Palindromdur.");
                        }
                        else
                        {
                            Console.WriteLine("Girilen Kelime Palindrom Değildir.");
                        }

                        Console.Write("Devam Etmek İstiyor Musunuz? (Evet İçin 'e' Veya 'E', Hayır İçin 'h' Veya 'H'): ");
                        cevap = Console.ReadLine();
                        if (cevap != "e" && cevap != "E")
                        {
                            break;
                        }
                        Console.Clear();

                    } while (true);
                    Console.Clear();

                }


            } while (soru != "0");

            Console.WriteLine("Programdan Çıkılıyor...");
            Console.ReadKey();
        }
    }
}