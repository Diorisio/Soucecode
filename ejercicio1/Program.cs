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
            //ejercicio 3

            ejercicio3();
            //------------

            //ejercicio 2
            ejercicio2();
            //-------
        }


        static void ejercicio3()
        {
            int p=0;
            Console.WriteLine("Escribe cuantos numeron ingresaras: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Ingrese los numeros");
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("Numeros organizados de mayor a menor");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+ ",");
            }
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i]%2==0)
                {
                    p += 1;
                }
            }
            Console.WriteLine("hay " + p + " numeros pares en la cadena");

            Console.ReadKey();
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
