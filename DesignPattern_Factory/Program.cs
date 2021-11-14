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
            Console.ReadKey();
        }
    }
}
