using System;

namespace PropertiesP1
{
    class RadiusClass
    {
        double _Radius  = 12.03;
        public double Radius 
        {
            get { return _Radius;}
            set { _Radius = value;}
        }
    }

    class CutiClass
    {
        public string Cuti { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RadiusClass r = new RadiusClass();
            Console.WriteLine(r.Radius);
            r.Radius = 15.05;
            Console.WriteLine(r.Radius);
            Console.WriteLine("Hello World!");
            CutiClass c = new CutiClass();
            c.Cuti = "Thursday";
            Console.WriteLine(c.Cuti);
        }
    }
}
