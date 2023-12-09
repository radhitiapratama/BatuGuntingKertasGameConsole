using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BatuGuntingKertasGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int human, com;
            string play_again;

        Start:

            Console.WriteLine("SELAMAT DATANG DI GAME BATU GUNTING KERTAS");
            Console.WriteLine("==============================================");
            Console.WriteLine("Silahkan Pilih");
            Console.WriteLine("1.Batu");
            Console.WriteLine("2.Gunting");
            Console.WriteLine("3.Kertas");
            Console.WriteLine("==============================================");
            Console.WriteLine("CREATED BY RADHITIA PRATAMA 2023 \n");
            Console.Write("Masukkan pilihan anda :");
            human = int.Parse(Console.ReadLine());

            if (human > 3)
            {
                Console.Clear();
                goto Start;
            }

            com = new Random().Next(1, 3);
            if (com == human)
            {
                Console.WriteLine("Seri");
            }
            else if (human == 1 && com == 2)
            {
                Console.WriteLine("Player Menang");
            }
            else if (human == 2 && com == 3)
            {
                Console.WriteLine("Player Menang");
            }
            else if (human == 3 && com == 1)
            {
                Console.WriteLine("Player Menang");
            }
            else
            {
                Console.WriteLine("Komputer Menang");
            }

            Console.WriteLine("\n");
            Console.Write("Main lagi ? (Y/N)");
            play_again = Console.ReadLine();
            if (play_again.ToUpper() == "Y")
            {
                Console.Clear();
                goto Start;
            }
            else
            {
                Console.WriteLine("TERIMA KASIH SUDAH BERMAIN");
            }

            Console.ReadKey();
        }
    }
}
