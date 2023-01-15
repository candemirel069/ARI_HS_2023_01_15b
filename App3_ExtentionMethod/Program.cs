using System;
using System.Diagnostics.Tracing;

namespace App3_ExtentionMethod
{
    class Kisi
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }

    static class KisiExtentions
    {
        public static string TamAdi(this Kisi kisi)
        {
            return kisi.Adi + " " + kisi.Soyadi.ToUpper();
        }

        public static int ToInteger(this string str)
        {
            return Convert.ToInt32(str);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi { Adi = "Yusuf", Soyadi = "Öztürk" };
            Console.WriteLine(kisi.Adi);
            Console.WriteLine(kisi.TamAdi());
            Console.WriteLine("----");

            string str = "123";

            int sayi = str.ToInteger();


            Console.WriteLine(sayi*2);
        }
    }
}
