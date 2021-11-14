﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory.Entities
{
    public class Ship:ITransport
    {
        public void Deliver()
        {
            Console.WriteLine("Transport With Ship");
        }
    }
}
