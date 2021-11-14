using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_Factory.Entities
{

    public enum CoordinateSystem
    {
        Cartesian,
        Polar
    }
    public class Point
    {
        public double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        //Factory Method
        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta) , rho * Math.Sin(theta));
        }
    }

}
