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
        {   //ejercicio1
            Console.WriteLine("Escribe una frase");
            String cadena = Console.ReadLine();

            ejercicio1(cadena);
            //-------------
            //ejercicio 4
            Controlmodelo a =new Controlmodelo();
            a.getmodel();
            Console.ReadKey();
            //-----------
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

    }

    class Controlmodelo
    {
        public Controlmodelo()
        {
            listacarro=new List<Car>();

            listacarro.Add(new Car { Brand="BMW",Color="negro",Model=2020});
            listacarro.Add(new Car { Brand="Dacia",Color="azul",Model=2000});
            listacarro.Add(new Car { Brand="Infiniti",Color="verde",Model=2022});
            listacarro.Add(new Car { Brand="Kia",Color="rojo",Model=2021});
            listacarro.Add(new Car { Brand="Volkswagen",Color="morado",Model=2017});


        }
        public void getmodel()
        {
            IEnumerable<Car>modell=from model in listacarro where (2022-model.Model)<=5 select model;
            foreach (Car model1 in modell)
            {
                model1.getdatos();
            }
        }

        public List<Car> listacarro;
    }

     class Car
    {
        public string Brand {get;set;}
	    public string Color {get;set;}
        public int Model {get;set;}

	    public void getdatos()
        {
            Console.WriteLine("Carro {0} de color {1} y modelo {2}",Brand,Color,Model);
        }

    }

    
}
