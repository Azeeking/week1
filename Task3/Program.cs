using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split();
            int[] b = new int[n];   // объявляем новый массив 
            for (int i = 0; i < n; i++)  // размер массива 
            {
                b[i] = int.Parse(a[i]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");  // вывод с дубликатом чисел
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
