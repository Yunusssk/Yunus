using Araç_Kiralama_Uygulaması;
using System.Collections.Concurrent;
using System.Threading.Channels;

namespace Araç_Kiralama_Uygulaması;
public class Program
{
    private static KiralikAraclar araba1;
    private static KiralikAraclar araba2;
    private static KiralikAraclar araba3;
    private static KiralikAraclar araba4;
    private static KiralikAraclar araba5;
    private static KiralikAraclar araba6;

    private static AracKiralayanKisiler kisi1;
    private static AracKiralayanKisiler kisi2;
    private static AracKiralayanKisiler kisi3;

    private static AracKonumu konum1;
    private static AracKonumu konum2;
    private static AracKonumu konum3;
    public static void Main(string[] args)
    {
        araba1 = new KiralikAraclar("Ford", 2022, 1000);
        araba2 = new KiralikAraclar("Toyota", 2023, 1500);
        araba3 = new KiralikAraclar("MG", 2019, 2000);
        araba4 = new KiralikAraclar("Nissan", 2002, 3000);
        araba5 = new KiralikAraclar("Renault", 2013, 500);
        araba6 = new KiralikAraclar("Peugeot", 2015, 5000);

        kisi1 = new AracKiralayanKisiler("Yigit", 18, 123456);
        kisi2 = new AracKiralayanKisiler("Ahmet", 44, 112233);
        kisi3 = new AracKiralayanKisiler("Yunus", 21, 223344);

        konum1 = new AracKonumu(12.001, -45.045);
        konum2 = new AracKonumu(34.321, 981.203);
        konum3 = new AracKonumu(71.300, 541.437);

        
        AnaMenu();
          
    }

    public static void AnaMenu()
    {
        Console.WriteLine("KIRAT RENT A CAR'A HOSGELDINIZ");
        Console.WriteLine("1) Kiralik Araclar");
        Console.WriteLine("2) Arac Kiralayan Kisiler");
        Console.WriteLine("3) Aracin Konumu");
        Console.WriteLine("Eger menuden cikmak istiyorsaniz 0'a basabilirsiniz");

        int secenek = int.Parse(Console.ReadLine());
        while (secenek != 0)
        {
            while (secenek < 4 || secenek > 0)
            {
                Console.WriteLine("1) Kiralik Araclar");
                Console.WriteLine("2) Arac Kiralayan Kisiler");
                Console.WriteLine("3) Aracin Konumu");
                Console.WriteLine("Eger menuden cikmak istiyorsaniz 0'a basabilirsiniz");

                secenek = int.Parse(Console.ReadLine());
                if (secenek == 0)
                    break;

                switch (secenek)
                {
                    case 1:
                        KiralikAraclarMenusu();
                        break;
                    case 2:
                        AracKiralayanKisiler();
                        break;
                    case 3:
                        AracKonumu();
                        break;
                    case 0:
                        break;
                }

            }
        }
    }

    public static void KiralikAraclarMenusu()
    {
        Console.WriteLine($"{araba1.Marka} aracimiz {araba1.Model} modelinde olup gunluk kirasi {araba1.GunlukFiyat}'dir.(23.09.2024 tarihine kadar KIRALANDI.)");
        Console.WriteLine($"{araba2.Marka} aracimiz {araba2.Model} modelinde olup gunluk kirasi {araba2.GunlukFiyat}'dir.(14.07.2024 tarihine kadar KIRALANDI.)");
        Console.WriteLine($"{araba3.Marka} aracimiz {araba3.Model} modelinde olup gunluk kirasi {araba3.GunlukFiyat}'dir.(03.01.2024 tarihine kadar KIRALANDI.)");
        Console.WriteLine($"{araba4.Marka} aracimiz {araba4.Model} modelinde olup gunluk kirasi {araba4.GunlukFiyat}'dir.(KIRALANABILIR)");
        Console.WriteLine($"{araba5.Marka} aracimiz {araba5.Model} modelinde olup gunluk kirasi {araba5.GunlukFiyat}'dir.(KIRALANABILIR)");
        Console.WriteLine($"{araba6.Marka} aracimiz {araba6.Model} modelinde olup gunluk kirasi {araba6.GunlukFiyat}'dir.(KIRALANABILIR)");
    }
    public static void AracKiralayanKisiler()
    {
        Console.WriteLine($"{kisi1.Isim} adli kisi {kisi1.Yas} yasinda, TC:{kisi1.TC} numarasidir ve {araba1.Marka} markali arabayi kiralamistir.");
        Console.WriteLine($"{kisi2.Isim} adli kisi {kisi2.Yas} yasinda, TC:{kisi2.TC} numarasidir ve {araba2.Marka} markali arabayi kiralamistir.");
        Console.WriteLine($"{kisi3.Isim} adli kisi {kisi3.Yas} yasinda, TC:{kisi3.TC} numarasidir ve {araba3.Marka} markali arabayi kiralamistir.");
    }

    public static void AracKonumu()
    {
        Console.WriteLine($"{araba1.Marka} markali aracin konum bilgileri: {konum1.Boylam} Boylam, {konum1.Enlem} Enlem");
        Console.WriteLine($"{araba2.Marka} markali aracin konum bilgileri: {konum2.Boylam} Boylam, {konum2.Enlem} Enlem");
        Console.WriteLine($"{araba3.Marka} markali aracin konum bilgileri: {konum3.Boylam} Boylam, {konum3.Enlem} Enlem");
    }



}

