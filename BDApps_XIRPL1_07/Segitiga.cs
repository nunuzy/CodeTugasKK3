﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_07
{
    class Segitiga : Bangun_datar
    {
        public float alas;
        public float tinggi;

        public override float luas()
        {
            float luas = 0.5f * alas * tinggi;
            Console.WriteLine("Luas Segitiga :" + luas);
            return luas;
        }

        public override float keliling()
        {
            float keliling = 3 * alas;
            Console.WriteLine("Luas Keliling :" + keliling);
            return keliling;
        }

    }
}
