using System;

namespace ExtMethod
{
    static class ExtClass
    {
        public static void Test3(this SealClass x)
        {
            Console.WriteLine("Test Ext Class 3");
        }

        public static long Factorial(this Int32 x)
        {
            if (x == 1)
                return 1;
            else if (x == 2)
                return 2;
            else
                return x * Factorial(x-1);
        }

        public static string toProper(this String oldStr)
        {
            String newStr = null;
            if (oldStr.Trim().Length > 0)
            {
                oldStr = oldStr.ToLower();
                string[] sarr = oldStr.Split(' ');
                foreach (string str in sarr)
                {
                    char[] carr = str.ToCharArray();
                    carr[0] = Char.ToUpper(carr[0]);
                    if (newStr == null)
                        newStr = new string(carr);
                    else
                        newStr += new string(carr);
                }
                return newStr;
            }
            else
            {
                return oldStr;
            }
        }
    }
}