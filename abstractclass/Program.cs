using System;

namespace abstractclass
{
    abstract class Kiraan 
    {
        public abstract void Darab(int x, int y);
        public abstract void Bahagi(int x, int y);
        public void Tambah(int x, int y)
        {
            Console.WriteLine(x+y);
        }

        public void Tolak(int x, int y)
        {
            System.Console.WriteLine(x - y);
        }
    }

    class Mate : Kiraan
    {
        public override void Darab(int x, int y)
        {
            System.Console.WriteLine(x * y);
        }

        public override void Bahagi(int x, int y)
        {
            System.Console.WriteLine(x / y);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Lawan l = new Lawan();
            l.Tegur("Lawanku   ");
            // Kawan k = new Kawan();
            // k.Tegur("Salam");
            //Mate m = new Mate();
            //m.Tambah(3,4);
            //Kiraan k = new Kiraan();
            //Console.WriteLine("Hello World!");
        }
    }
}
