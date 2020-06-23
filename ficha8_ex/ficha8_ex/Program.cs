using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha8_ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu nome? ");
            string nomeUser = Console.ReadLine().ToLower();
            string nomeFinal = nomeUser.Substring(0, 1).ToUpper() + nomeUser.Substring(1);
            if (nomeUser == "bartolomeu")
                Console.WriteLine("Dá cá o meu");
            else
                Console.WriteLine("Olá " + nomeFinal + "!");


            Console.ReadKey();
        }
    }
}
