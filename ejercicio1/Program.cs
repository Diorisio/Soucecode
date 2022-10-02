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

    }
}
