﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory.Entities
{
    public class Benz:ICarSupplier
    {
        public void Start()
        {
            Console.WriteLine("Hello Benz");
        }
    }
}
