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
            //ejercicio 1
            Console.WriteLine("Escribe una frase");
            String cadena = Console.ReadLine();

            ejercicio1(cadena);
            //------------

            //ejercicio 2
            ejercicio2();
            //-------
        }


        static void ejercicio1(string cadena)
        {
            if (cadena.Length < 20)
            {
                for (int i = 0; i < cadena.Length; i++)
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

        static void ejercicio2()
        {
            int n, primero = 0, segundo = 1, siguiente, r = 0;
            Console.Write("Ingrese numero: ");
            n = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (segundo <= n)
            {


                if (i <= 1)
                {
                    siguiente = i;
                }
                else
                {
                    siguiente = primero + segundo;
                    primero = segundo;
                    segundo = siguiente;
                }
                if (n == siguiente)
                {
                    r = 1;
                    Console.Write("El numero " + n + " si esta en la serie");
                }
                i++;
            }
            if (r == 0)
            {
                Console.Write("El numero " + n + " no esta en la serie");
            }

            Console.ReadKey();
        }

    }
}
