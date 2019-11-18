using System;

namespace ExceptionP1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Enter the 1st Number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number:");
            int y = int.Parse(Console.ReadLine());
            int z = x / y;
            Console.WriteLine("The result is : " + z);
            }
            catch (DivideByZeroException ex1)
            {
                Console.WriteLine("Error " + ex1.Message);
            }
            catch (FormatException ex2)
            {
                Console.WriteLine("Error : " + ex2.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
            Console.WriteLine("End of Program!!");
        }
    }
}
