using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern_Factory.Interface;

namespace DesignPattern_Factory.Entities
{
    public class Note10 : IMobileFactory
    {
        public Note10(byte type)
        {
            
        }
        public string CalcScreenSize()
        {
            return "Screen Size Note 10";
        }
    }

}
