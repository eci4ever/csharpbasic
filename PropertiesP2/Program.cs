using System;

namespace PropertiesP2
{
    public enum Cities { Jerteh, KualaLumpur, Melaka, Putrajaya }
    class Customer
    {
        int _CustId;
        string _CustName;
        bool _CustStatus;
        double _CustBalance;
        Cities _City;

        public Customer(int CustId, string CustName, bool CustStatus, double CustBalance, Cities City)
        {
            _CustId = CustId;
            _CustName = CustName;
            _CustStatus = CustStatus;
            _CustBalance = CustBalance;
        }

        public int CustId
        {
            get { return _CustId; }
        }
        public string CustName 
        { 
            get { return _CustName; } 
            set { _CustName = value; }
        }
        public bool CustStatus
        {
            get { return _CustStatus; }
        }
        public double CustBalance
        {
            get { return _CustBalance; }
            set {
                if(value > 500)
                _CustBalance = value;
            }
        }
        public Cities City
        {
            get { return _City; }
            set { _City = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(101,"Nmfairus", false, 5000.00, Cities.KualaLumpur);
            Console.WriteLine(obj.CustId);
            Console.WriteLine($"Customer Name is : {obj.CustName}");
            obj.CustName = "Eci";
            Console.WriteLine($"New Customer Name is : {obj.CustName}");
            Console.WriteLine($"Customer Balance is : {obj.CustBalance}");
            obj.CustBalance -= 2000;
            Console.WriteLine($"Customer New Balance is : {obj.CustBalance}");
            obj.CustBalance -= 5000;
            Console.WriteLine($"Customer New Balance is : {obj.CustBalance}");
            Console.WriteLine($"Customer City is : {obj.City}");
            obj.City = Cities.Putrajaya;
            Console.WriteLine($"Customer New City is : {obj.City}");
            Console.WriteLine("Hello World!");
        }
    }
}
