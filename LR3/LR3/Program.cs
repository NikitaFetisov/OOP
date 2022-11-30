using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixx
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float a;
                float b;
                float c;
                float d;
                float r1;
                float r2;
                float r3;

                Console.WriteLine("Введите числитель первой дроби >");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите числитель первой дроби >");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Первая дробь - " + a + "/" + b + "\n");

                Console.WriteLine("Введите числитель второй дроби >");
                c = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите числитель второй дроби >");
                d = int.Parse(Console.ReadLine());
                Console.WriteLine("Вторая дробь - " + c + "/" + d + "\n");

                r1 = a / b;
                r2 = c / d;
                r3 = r1 / r2;

                Console.WriteLine(a + "/" + b + " разделить на " + c + "/" + d + " = " + r3 + "\n" + "-----------------------------");

            }
        }
    }
}
