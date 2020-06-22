using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tugas_Lab8.ClassAnak;
using Tugas_Lab8.ClassInduk;

namespace Tugas_Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 8 - Inheritance, Polymorphsim, Abstraction & Collection";

            // Membuat Objek Untuk Semua Karyawan

            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "123-456-789";
            karyawanTetap.Nama = "Fajrial permadi";
            karyawanTetap.GajiBulanan = 4000000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "810-988-367";
            karyawanHarian.Nama = "Tria Natali";
            karyawanHarian.UpahPerJam = 13000;
            karyawanHarian.JumlahJamKerja = 8;

            Sales sales = new Sales();
            sales.NIK = "432-765-980";
            sales.Nama = "Andre Lininker";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;

            // Objek class collection
            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int NoUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3}", NoUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                NoUrut++;
            }

            Console.ReadLine();
        }
    }
}
