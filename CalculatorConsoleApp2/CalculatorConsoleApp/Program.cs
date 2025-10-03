using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator Versi Console";

            Console.Write("Inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); // Casting

            Console.Write("Inputkan nilai b = ");
            var b = Convert.ToInt32(Console.ReadLine()); // Casting

            Console.WriteLine(); // Tambahkan baris kosong
            Console.WriteLine("Hasl Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
            Console.WriteLine("Hasl Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
            Console.WriteLine("Hasl Perkalian: {0} x {1} = {2}", a, b, Perkalian(a, b));
            Console.WriteLine("Hasl Pembagian: {0} / {1} = {2}", a, b, Pembagian(a, b));

            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }

    }
}
