using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab8.ClassInduk;

namespace Tugas_Lab8.ClassAnak
{
    public class Sales : Karyawan
    {
        public int JumlahPenjualan { get; set; }
        public int komisi { get; set; }
        public override double Gaji()
        {
            return JumlahPenjualan * komisi;
        }
    }
}
