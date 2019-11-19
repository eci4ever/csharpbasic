using System;

namespace ExceptionP2
{
    class DivideByOddNumberException : ApplicationException
    {
        public override string Message
        {
            get 
            {
                return "Attemp to divide by Odd number.";
            }
        }
    }

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
            if (y == 1)
            {
                return; // this line will return the program out from class, but the finally block is still executed.
            }
            if ( y % 2 > 0)
            {
                //throw new ApplicationException(); throw Application exception with parameter
                //throw new ApplicationException("Try to divide with odd bunber");
                throw new DivideByOddNumberException();

            }
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
            finally
            {
                //finally block will executes in both condition whether Exception is occured or not
                Console.WriteLine("Finally block is Executed!!");
            }
            Console.WriteLine("End of Program!!");
        }
    }
}
