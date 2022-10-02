using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe una frase");
            String cadena = Console.ReadLine();
            if (cadena.Length < 20)
            {
                for (int i=0;i<cadena.Length;i++) 
                {
                    Console.Write(cadena[i]);
                }
                    Console.Write("...");
                
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.Write(cadena[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
