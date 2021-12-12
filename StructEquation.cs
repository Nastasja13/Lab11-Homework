using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEquation
{
    public struct Equation
    {
        double k;
        double b;

        public double K
        {
            set
            {
                if (value > 0)
                {
                    k = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            get
            {
                return k;
            }
        }

        public double B
        {
            set
            {
                if (value > 0)
                {
                    b = value;
                }
                else
                {
                    Console.WriteLine("Введите положительное число");
                }
            }
            get
            {
                return b;
            }
        }


    }
}
