using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotTakipUygulaması
{
    internal class Ogrenci
    {
        internal class Insan
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public Insan() { }
        }
        public Insan nufusBilgileri = new Insan();
        public double numara {  get; set; }
        public List<Double> notlar {  get; set; }
        public static void ortHesapla(Ogrenci secilen)
        {
            double toplam = 0;
            double count = 0;
            if (secilen.notlar.Count <= 0)
            {
                Console.WriteLine("Hesaplanacak not bulunamadı!");
                return;
            }
            foreach (var not in secilen.notlar)
            {
                toplam += not;
                count++;
            }
            Console.WriteLine(toplam / count);
        }
    }
}
