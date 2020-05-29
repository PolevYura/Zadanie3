using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void elementMassiva(int[] mass)
        {
            Random rand = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = -10 + rand.Next() % 20;
                Console.Write(mass[i] + " | ");
            }
            Console.WriteLine();

            int min = mass[0];
            int a;

            for (int i = 0; i < mass.Length; i++)
            {
                if (min < 0) min *= -1;

                a = mass[i];

                if (a < 0) a *= -1;

                if (a < min) min = a;
            }
            Console.Write(min);
        }


        static void element2(int[] mass)
        {
            Random rand = new Random();

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = -10 + rand.Next() % 20;
                Console.Write(mass[i] + " | ");
            }
            Console.WriteLine();

            int a = 0;
            int f = 0;

            Console.Write("Уникальные элементы: ");

            for (int i = 0; i < mass.Length; i++)
            {
                int c = 0;

                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[j] == mass[i])
                    {
                        c++;
                        a = mass[j];
                    }
                }

                if (c == 1)
                {
                    Console.Write(a + " | ");
                    f++;
                }
                else a = 0;
            }
            if (f == 0) Console.WriteLine("Нет уникальных элементов" );
        }


        static void element3(int[] mass)
        {
            Random rand = new Random();

            int[] mass1 = new int[10];

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = -10 + rand.Next() % 20;
                Console.Write(mass[i] + " | ");
            }
            Console.WriteLine();
            Console.Write("Положительные элементы: ");

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] >= 0) mass1[i] = mass[i];
                else continue;
                Console.Write(mass1[i] + " | ");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //1
            Console.WriteLine("№1: ");
            int[] mass = new int[10];
            elementMassiva(mass);
            Console.WriteLine("\n");

            //2
            Console.WriteLine("№2: ");
            element2(mass );
            Console.WriteLine("\n");

            //3
            Console.WriteLine("№3: ");
            element3(mass );
        }
    }
}
