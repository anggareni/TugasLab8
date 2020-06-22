using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab8.ClassInduk;

namespace Tugas_Lab8.ClassAnak
{
    public class KaryawanHarian : Karyawan
    {
        public int JumlahJamKerja { get; set; }
        public int UpahPerjam { get; set; }
        public override double Gaji()
        {
            return JumlahJamKerja * UpahPerjam;
        }
    }
}
