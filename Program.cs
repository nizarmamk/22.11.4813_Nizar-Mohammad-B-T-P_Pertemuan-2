using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Kalkulator";
            Console.WriteLine("Pilih menu kalkulator : \n");
            Console.WriteLine("1. Penambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian \n");
            Console.Write("Masukkan nomor menu [1-4] : ");
            int action = Convert.ToInt32(Console.ReadLine());

            if (action >= 1 && action <= 4)
            {
                Console.Write("\nMasukkan nilai a : ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nMasukkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                int result = 0;

                switch (action)
                {
                    case 1:
                        result = Penambahan(a, b);
                        Console.Write("\nHasil Penambahannya adalah : " + a + " + " + b + " = " + result);
                        break;
                    case 2:
                        result = Pengurangan(a, b);
                        Console.Write("\nHasil Pengurangannya adalah : " + a + " - " + b + " = " + result);
                        break;
                    case 3:
                        result = Perkalian(a, b);
                        Console.Write("\nHasil Perkaliannya adalah : " + a + " x " + b + " = " + result);
                        break;
                    case 4:
                        if (b == 0)
                        {
                            Console.Write("\nTidak dapat didefinisikan.");
                            break;
                        }
                        else
                        {
                            result = Pembagian(a, b);
                            Console.Write("\nHasil Pembagiannya adalah : " + a + " / " + b + " = " + result);
                            break;
                        }
                }
                Console.WriteLine("\n\nTekan enter untuk keluar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nTerjadi kesalahan! Coba lagi.");
            }

        }
        // Penambahan
        public static int Penambahan(int a, int b)
        {
            int result = a + b;
            return result;
        }
        // Pengurangan
        public static int Pengurangan(int a, int b)
        {
            int result = a - b;
            return result;
        }
        // Perkalian
        public static int Perkalian(int a, int b)
        {
            int result = a * b;
            return result;
        }
        // Pembagian
        public static int Pembagian(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}
