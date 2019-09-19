using System;

namespace QUIZ09092019
{
    class BangunDatar
    {
        public void luasPersegi()
        {
            Console.WriteLine("Menghitung Luas Persegi");
            Console.WriteLine("-----------------------");

            int sisi, luas;
            Console.Write("Sisi : ");
            sisi = Convert.ToInt32(Console.ReadLine());

            luas = sisi * sisi;
            Console.WriteLine("Luas persegi : "+luas);
            Console.WriteLine("          ");
        }

        public void luasSegitiga()
        {
            Console.WriteLine("Menghitung Luas Segitiga");
            Console.WriteLine("------------------------");

            int alas,tinggi,luas;
            Console.Write("Alas : ");
            alas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi : ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            luas = alas * tinggi / 2;
            Console.WriteLine("Luas Segitiga adalah "+luas);

            Console.WriteLine("            ");
        }

        public void luasLingkaran()
        {
            Console.WriteLine("Menghitung Luas Lingkaran");
            Console.WriteLine("-------------------------");

            int  ruas;

    
            Console.Write(" Ruas : ");
            ruas = Convert.ToInt32(Console.ReadLine());

            double luas;

            luas = ruas * ruas * 22/7;

            Console.Write("Luas Lingkaran : "+luas);
            Console.WriteLine("           ");
            Console.WriteLine("                  ");


        }
   }
}
