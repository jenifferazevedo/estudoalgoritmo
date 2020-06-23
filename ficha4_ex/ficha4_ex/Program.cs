using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ficha4_ex
{
    class Program
    {
        static int absoluto(int num)
        {
            /*int res = num;
            if (num < 0)
            {
                res = num * -1;
            }
            return res;*/
            if (num < 0)
                return num * -1;
            return num;
        }
        static void absolutoWrite(int num)
        {
            if(num < 0)
                Console.WriteLine(num*-1);
            else
                Console.WriteLine(num);
        }
        static void Main(string[] args)
        {
            /*Console.WriteLine("Ficha 4 \n");

            Console.WriteLine("a)Ler um vector de N números inteiros e escrevê-lo pala mesma ordem.");
            int nElementos;
            Console.Write("Digite o número de elementos da array: ");
            nElementos = int.Parse(Console.ReadLine());
            int[] vec1 = new int[nElementos];
            Console.WriteLine("Inserir Vector:");
            for(int i = 0; i < vec1.Length; i++)
            {
                Console.Write("\tVec[" + i + "]: ");
                vec1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");
            Console.Write("Vector: [" + vec1[0]);
            for (int i = 1; i < (vec1.Length - 1); i++)
            {
                Console.Write(", " + vec1[i]);
            }
            Console.Write(", " + vec1[vec1.Length - 1] + "]\n\n");


            Console.WriteLine("b) Ler um vector de N e escrevê-lo pala ordem inversa.\n");
            Console.Write("Digite o número de elementos: ");
            int n1 = int.Parse(Console.ReadLine());
            double[] vecDoubleB = new double[n1];
            Console.WriteLine("Inserir Vector:");
            for (int i = 0; i < vecDoubleB.Length; i++)
            {
                Console.Write("\tVec[" + i + "]: ");
                vecDoubleB[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            Console.Write("\nVector: [" + vecDoubleB[vecDoubleB.Length - 1]);
            for (int i = (vecDoubleB.Length - 2); i > 0; i--)
            {
                Console.Write(", " + vecDoubleB[i]);
            }
            Console.Write(", " + vecDoubleB[0] + "]\n\n"); */

            Console.WriteLine("Funções\n");

            Console.WriteLine("Normal: ");
            Console.WriteLine("Escreva um número negativo: ");
            int numNeg = int.Parse(Console.ReadLine());
            /*int resAbs = Math.Abs(numNeg);
            Console.WriteLine("\nAbs: " + resAbs); */

            /*int resFunAbs = absoluto(numNeg);
            Console.WriteLine("\nAbs function: " + resFunAbs);*/

            absolutoWrite(numNeg);




            Console.ReadKey();
        }
    }
}
