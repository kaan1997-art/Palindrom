using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir kelime giriniz: ");
            string kelime = Console.ReadLine();
            string kelimetersi = "";
            while (kelime != "q")
            {
                if (kelime.Length >= 2)
                {
                    for (int i = kelime.Length - 1; i >= 0; i--)
                    {
                        kelimetersi += kelime[i];

                    }
                    Console.WriteLine("\nKelimenin tersten yazılısı = " + kelimetersi);
                    if (kelime == kelimetersi)
                    {
                        Console.WriteLine("\nGirilen kelime Palindrom bir kelimedir.");
                    }
                    else //if (kelimetersi != kelime)
                    {
                        Console.WriteLine("\nGirilen kelime Palindrom bir kelime değildir.");
                    }
                }
                else
                {
                    Console.WriteLine("İki harften az giremezsiniz!");
                }
                Console.ReadLine();
            }
        }
    }
}
