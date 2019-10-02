using System;
using System.Globalization;

namespace ApplyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string noKP = "790427115413";
            string year = noKP.Substring(0,2);
            string month = noKP.Substring(2,2);
            string day = noKP.Substring(4,2);
            string bday = month + "-" + day + "-" + year;
            DateTime parsedDate;
            DateTime.TryParseExact(bday, "MM-dd-yy", null, DateTimeStyles.None, out parsedDate);
            //DateTime mydate = DateTime.Parse(bday);
            System.Console.WriteLine(parsedDate);
            Console.WriteLine(bday);
        }
    }
}
