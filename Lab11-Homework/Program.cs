using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_for_Lab11_Homework;

namespace Lab11_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Разработать структуру для решения линейного уравнения 0=kx+b.              *  
             *  Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
             *  Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
             *  Осуществить использование экземпляра в программе.*/

            Equation equation = new Equation();


            Console.WriteLine("Введите значения для решения линейного уравнения 0=kx+b.");
            Console.Write("Значение k: ");
            equation.K = Convert.ToInt32(Console.ReadLine());

            Console.Write("Значение b: ");
            equation.B = Convert.ToInt32(Console.ReadLine());           

            //Метод Root для поиска x = (0 - b) / k
            Root();
            void Root()
            {
                double x = (0 - equation.B) / equation.K;
                Console.WriteLine("Значение x: {0:f2}", x);
            }

            Console.ReadKey();
        }

        



    }
}

