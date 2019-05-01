using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrog2338
{
    class Karyawan
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public int Gaji { get; set; }
        public int Bonus { get; set; }

        public Karyawan ( string nik, string nama, int gaji)
        {
            Nik = nik;
            Nama = nama;
            Gaji = gaji;
            Bonus = gaji + (gaji / 100 * 10);

            if (gaji < 0)
            {
                gaji = 0;
            }
        }
    }
}
