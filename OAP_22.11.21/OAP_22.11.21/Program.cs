using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAP_22._11._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite razmer massiva");
            int size = 0, n;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("OShibka vvoda. Vvedite chislo");
            }
            Console.WriteLine("Vvedite chisla v massiv");
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Oshibka vvoda. Vvedite chislo");
                }
                array[i] = n;
            }
            Console.WriteLine();

            var selected = from p in array
                           where (p % 2) == 0
                           select p;
            foreach (int s in selected)
            {
                Console.Write(s + " ");
            }
        }
    }
}
