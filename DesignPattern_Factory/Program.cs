using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Entities;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = CarFactory.GetCar("Benz");
            car.Start();


            Console.WriteLine("-----------");

            var note10 = new Note10Creator();
            var note5 = new Note10Creator();

            note10.AddSystem();
            note5.AddSystem();

            note10.FactoryMethod().CalcScreenSize();
            note5.FactoryMethod().CalcScreenSize();


            Console.ReadKey();
        }
    }
}
