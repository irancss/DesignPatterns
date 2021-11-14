using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Entities;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory
{
    public static class CarFactory
    {
        public static ICarSupplier GetCar(string type)
        {
            ICarSupplier car = null;
            if (type == "Benz")
            {
                car = new Benz();
            }
            else if (type == "Ford")
            {
                car = new Ford();
            }
            else if (type=="BMW")
            {
                car = new BMW();
            }
            else
            {
                Console.WriteLine("Error");
            }
            return car;
        }
    }
}
