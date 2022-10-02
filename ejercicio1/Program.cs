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

            Controlmodelo a =new Controlmodelo();
            a.getmodel();
            Console.ReadKey();
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
