using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int la;
            int lac;
            double tot;
            la = int.Parse(Console.ReadLine());
            lac = int.Parse(Console.ReadLine());
            Consumo cons = new Consumo(la,lac);
            tot = cons.GetConsumo();
            Console.WriteLine(tot);
            Console.ReadLine();
        }
    }
    internal class Consumo
    {
      
        private const double first_level = 33;
        private const double second_level = 86.5;
        private const double third_level = 158;
        private const double fourth_level = 281;
        private const double fifth_level = 431;
        private const double sixth_level = 631;
        private const double seventh_level = 881;
        private const double eighth_level = 1.181;
        private const double ninth_level = 1531;
        private const double tenth_level = 2451;
        private const double eleventh_level = 3396;
        private const double twelveth_level = 6351;
        private const double thirdteenth_level = 14991;
        private const double fourteenth_level = 24431;
        private const double fifhteenth_level = 34751;
        private const double sixteenth_level = 45911;
        private const double seventeenth_level = 57911;
        private int lectura_anterior;
        private int lectura_actual;
        private int consumo;
        private double total;

        public Consumo(int a, int b)
        {
            this.lectura_anterior = a;
            this.lectura_actual = b;
            consumo = lectura_actual - lectura_anterior;
        }

        public int LecturaAnterior
        {
            get { return lectura_anterior; }
            set { lectura_anterior = value; }
        }
        public int LecturaActual
        {
            get { return lectura_actual; }
            set { lectura_actual = value; }
        }
        public int ConsumoKw
        {
            get { return consumo; }
            set { consumo = value; }
        }
        public double TotalConsumo
        {
            get { return total; }
            set { total = value; }
        }

        public double GetConsumo()
        {
            if (consumo < 100)
            {
                total = consumo * 0.33;
            }
            else if (consumo >= 101 && consumo <= 150)
            {
                total = ((consumo - 100) * 1.07) + first_level;
            }
            else if (consumo >= 151 && consumo <= 200)
            {
                total = ((consumo - 150) * (1.43)) + second_level;
            }
            else if (consumo >= 201 && consumo <= 250)
            {
                total = ((consumo - 200) * (2.46)) + third_level;
            }
            else if (consumo >= 251 && consumo <= 300)
            {
                total = ((consumo - 250) * (3.0)) + fourth_level;
            }
            else if (consumo >= 301 && consumo <= 350)
            {
                total = ((consumo - 300) * (4.0)) + fifth_level;
            }
            else if (consumo >= 351 && consumo <= 400)
            {
                total = ((consumo - 350) * (5.0)) + sixth_level;
            }
            else if (consumo >= 401 && consumo <= 450)
            {
                total = ((consumo - 400) * (6.0)) + seventh_level;
            }
            else if (consumo >= 451 && consumo <= 500)
            {
                total = ((consumo - 450) * (7.0)) + eighth_level;
            }
            else if (consumo >= 501 && consumo <= 600)
            {
                total = ((consumo - 500) * (9.20)) + ninth_level;
            }
            else if (consumo >= 601 && consumo >= 700)
            {
                total = ((consumo - 600) * (9.45)) + tenth_level;
            }
            else if (consumo >= 701 && consumo <= 1000)
            {
                total = ((consumo - 1000) * (9.48)) + eleventh_level;
            }
            else if (consumo >= 1001 && consumo <= 1800)
            {
                total = ((consumo - 1000) * (10.80)) + twelveth_level;
            }
            else if (consumo >= 1801 && consumo <= 2600)
            {
                total = ((consumo - 1800) * (11.80)) + thirdteenth_level;
            }
            else if (consumo >= 2601 && consumo <= 3400)
            {
                total = ((consumo - 2600) * (12.90)) + fourteenth_level;
            }
            else if (consumo >= 3401 && consumo <= 4200)
            {
                total = ((consumo - 3400) * (13.95)) + fifhteenth_level;
            }
            else if (consumo >= 4201 && consumo <= 5000)
            {
                total = ((consumo - 4200) * 15.0) + sixteenth_level;
            }
            else
            {
                total = ((consumo - 5000) * 20.0) + seventeenth_level;
            }


            return total;
        }

    }
}
