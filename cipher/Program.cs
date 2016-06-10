using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string alpha = "abcdefghijklmnopqrstuvwxyz";
            while (true){
                string plain, key;
                int i, j;

                Console.WriteLine("--- Codieren ---");
                Console.Write("Klartext: ");
                plain = Console.ReadLine();
                Console.Write("Key: ");
                key = Console.ReadLine();
                Console.Write("Ciphertext: ");

                plain = plain.ToLower();
                key = key.ToLower();
                for (i = 0, j = 0; i < plain.Length; i++, j++)
                {
                    if (j == key.Length)
                    {
                        j = 0;
                    }
                    Console.Write(alpha[(alpha.IndexOf(plain[i]) + alpha.IndexOf(key[j])) % alpha.Length]);
                }
                Console.WriteLine("");

                Console.WriteLine("--- Decodieren ---");

                Console.Write("Ciphertext: ");
                plain = Console.ReadLine();
                Console.Write("Key: ");
                key = Console.ReadLine();
                Console.Write("Decoded: ");

                plain = plain.ToLower();
                key = key.ToLower();
                for (i = 0, j = 0; i < plain.Length; i++, j++)
                {
                    if (j == key.Length)
                    {
                        j = 0;
                    }
                    int buf = (alpha.IndexOf(plain[i]) - alpha.IndexOf(key[j])) % alpha.Length;
                    Console.Write(alpha[(buf < 0)? buf * (-1) : buf]);
                }
                Console.WriteLine("");
            }
        }
    }
}
