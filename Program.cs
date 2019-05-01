using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2338
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrograman ";

            Karyawan ky1 = new Karyawan("12342332", "Nur  ", 100000);
            Karyawan ky2 = new Karyawan("12342333","Fikri",200000);

            Console.WriteLine(" Nik          Nama        Gaji bulanan");
            Console.WriteLine("--------------------------------------");
            Cetakhasil(ky1);
            Cetakhasil(ky2);

            Console.WriteLine("\n---------------------------------");
            Console.WriteLine("| Akhirnya Kenaikan Gaji 10%!!! |");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("\n Nik          Nama        Gaji bulanan");
            Console.WriteLine("--------------------------------------");
            Cetakbonus(ky1);
            Cetakbonus(ky2);
            Console.ReadKey();

        }
        static void Cetakhasil(Karyawan ky)
        {
            Console.WriteLine(" {0}     {1}     {2}", ky.Nik, ky.Nama, ky.Gaji);   
        }

        static void Cetakbonus(Karyawan ky)
        {
            Console.WriteLine(" {0}     {1}     {2}", ky.Nik, ky.Nama, ky.Bonus);
        }
    }
}
