using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic06
{
    public class Mobil
    {
        public double kecepatan;
        public double bensin;
        public double posisi;
        public string nama;

        public void percepat()
        {
            this.kecepatan += 10;
            this.bensin += 5;

        }
        public void maju()
        {
            this.posisi += this.kecepatan;
            this.bensin -= 2;

        }

        public void IsiBensin(double bensin)
        {
            this.bensin += bensin;

        }
    }
}
