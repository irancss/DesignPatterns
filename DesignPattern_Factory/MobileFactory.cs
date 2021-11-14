using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Entities;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory
{
    public abstract class MobileFactory
    {
        public abstract IMobileFactory FactoryMethod();


        public string AddSystem()
        {
            return "Add New Os";
        }

    }

    public class Note5Creator : MobileFactory
    {
        public override IMobileFactory FactoryMethod()
        {
            return new Note5();
        }
    }
    public class Note10Creator : MobileFactory
    {
        public override IMobileFactory FactoryMethod()
        {
            return new Note10(5);
        }
    }
}
