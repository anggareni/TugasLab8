﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Lab8.ClassInduk
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string NIK { get; set; }
        public abstract double Gaji();
    }
}
