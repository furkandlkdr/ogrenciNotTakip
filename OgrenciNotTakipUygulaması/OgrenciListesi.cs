using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotTakipUygulaması
{
    internal class OgrenciListesi
    {
        List<Ogrenci> Ogrenciler = new List<Ogrenci>();
        List<Personel> Personeller = new List<Personel>();

        public void listMenu()
        {
            do
            {
                int secilen;
                Console.WriteLine("********* Not Takip Uygulamasi *********");
                Console.WriteLine("1- Ogrenci Ekle");
                Console.WriteLine("2- Ogrencileri Listele");
                Console.WriteLine("3- Personel Ekle");
                Console.WriteLine("3- Personelleri Listele");
                Console.WriteLine("4- Cikis");
                do
                {
                    try
                    {
                        secilen = Convert.ToInt32(Console.ReadLine());
                        if (secilen < 1 || secilen > 4) { throw new Exception("Hata!"); }
                        else { break; }
                    } catch (Exception e) { Console.WriteLine("Lutfen gecerli bir deger girin!");}
                    
                } while (true);
                
                switch (secilen)
                {
                    case 1:
                        ogrenciEkle();
                        Console.WriteLine("Devam etmek icin enter'a basin");
                        Console.ReadLine();
                        Console.Clear();
                        listMenu();
                        break;
                    case 2:
                        ogrenciListele();
                        Console.WriteLine("Devam etmek icin enter'a basin");
                        Console.ReadLine();
                        Console.Clear();
                        listMenu();
                        break;
                    case 3:
                        personelEkle();
                        Console.WriteLine("Devam etmek icin enter'a basin");
                        Console.ReadLine();
                        Console.Clear();
                        listMenu();
                        break;
                    case 4:
                        personelListele();
                        Console.WriteLine("Devam etmek icin enter'a basin");
                        Console.ReadLine();
                        Console.Clear();
                        listMenu();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        public void ogrenciEkle()
        {
            Console.Clear();
            Ogrenci yeniOgrenci = new Ogrenci();
            Console.Write("Ogrenci adi: ");
            yeniOgrenci.nufusBilgileri.ad = Console.ReadLine();
            Console.Write("Ogrenci soyadi: ");
            yeniOgrenci.nufusBilgileri.soyad = Console.ReadLine();
            Console.Write("Ogrenci numarasi: ");
            yeniOgrenci.numara = Convert.ToInt64(Console.ReadLine());

            int eklenecekNot;
            Console.Write("Eklemek istediginiz not sayisi: ");
            do
            {
                try
                {
                    eklenecekNot = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Hatali bir deger girdiniz!"); }
            } while (true);
            int notSayisi = eklenecekNot;
            for (; eklenecekNot > 0; eklenecekNot--)
            {
                Console.Write("{0}. not: ", notSayisi + 1 - eklenecekNot);
                do
                {
                    try
                    {
                        double not = Convert.ToDouble(Console.ReadLine());
                        yeniOgrenci.notlar.Add(not);
                        break;
                    }catch(Exception) { Console.WriteLine("Hatali bir deger girdiniz!"); }
                } while (true);
            }
            Ogrenciler.Add(yeniOgrenci);
            Console.WriteLine("Ogrenci basariyla eklendi!");
        }

        public void ogrenciListele()
        {
            Console.Clear();
            foreach (var ogrenci in Ogrenciler)
            {
                Console.WriteLine("Numara: {0} Ad: {1} Soyad: {2}", ogrenci.numara, ogrenci.nufusBilgileri.ad, ogrenci.nufusBilgileri.soyad);
                int count = 1;
                foreach(var item in ogrenci.notlar)
                {
                    Console.WriteLine("{0}. not: {1}", count++, item);
                }
            }
        }

        public void personelEkle()
        {
            Console.Clear();
            Personel yeniPersonel = new Personel();
            Console.Write("Personel adi: ");
            yeniPersonel.ad = Console.ReadLine();
            Console.Write("Personel soyadi: ");
            yeniPersonel.soyad = Console.ReadLine();
            Console.Write("Personelin gorevi: ");
            yeniPersonel.gorev = Console.ReadLine();

            Personeller.Add(yeniPersonel);
            Console.WriteLine("Personel basariyla eklendi!");
        }

        public void personelListele()
        {
             Console.Clear();
             foreach (var personel in Personeller)
             {
                 Console.WriteLine("Ad: {1} Soyad: {2}", personel.ad, personel.soyad);
                Console.WriteLine("Gorev {0}", personel.gorev);
             }
        }
    }
}
