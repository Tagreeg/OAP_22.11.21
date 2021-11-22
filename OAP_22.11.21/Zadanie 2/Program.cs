using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Zadanie_2
{
    /*class Number
    {
        public float Num { get; set; }
        public int Pos { get; set; }
        public float Sqr { get; set; }
    }*/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vvedite razmer massiva");
            int size = 0;
            float n;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("OShibka vvoda. Vvedite chislo");
            }
            Console.WriteLine("Vvedite chisla v massiv");
            float[] array = new float[size];
            for (int i = 0; i < size; i++)
            {
                while (!float.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Oshibka vvoda. Vvedite chislo");
                }
                array[i] = n;
            }
            Console.WriteLine();


            var selectedNumber = from a in array
                           where (a * a) > 25
                           select a;

            foreach (int d in selectedNumber)
            {
                int ind = Array.IndexOf(array, d);
                Console.WriteLine("chislo " + d + " ind " + ind + " kv " + d * d);
            }
        }
    }
}
