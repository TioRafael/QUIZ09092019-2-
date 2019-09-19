using System;

namespace QUIZ09092019
{
    class BangunRuang
    {
        public void volumebalok()
        {
            Console.WriteLine("Menghitung Volume Balok");
            Console.WriteLine("------------------------");

            int panjang, lebar, tinggi, volume;
            Console.Write("Panjang: ");
            panjang = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lebar");
            lebar = Convert.ToInt32(Console.ReadLine());

            Console.Write("Tinggi: ");
            tinggi = Convert.ToInt32(Console.ReadLine());

            volume = panjang * lebar * tinggi;
            Console.WriteLine("Volume Balok adalah "+volume);
            Console.WriteLine("          ");
         }
   
        public void volumekubus()
        {
            Console.WriteLine("Menghitung Volume Kubus");
            Console.WriteLine("-----------------------");

            int sisi, volume;
            Console.Write("Sisi ");
            sisi = Convert.ToInt32(Console.ReadLine());

            volume = sisi * sisi * sisi;
            Console.WriteLine("Volmue Kubus adalah "+volume);
            Console.WriteLine("              ");
        }
   
   
    }
}