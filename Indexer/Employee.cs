namespace Indexer
{
    public class Employee
    {
        int Eno;
        string Ename, EJob, EDname, ELocation;
        double Esalary;

        public Employee(int Eno, string Ename, string EJob, string EDname, string ELocation, double Esalary)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.EJob = EJob;
            this.EDname = EDname;
            this.ELocation = ELocation;
            this.Esalary = Esalary;
        }
        // Declaring Indexer
        public object this[int index]
        {
            get {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return EJob;
                else if (index == 3)
                    return EDname;
                else if (index == 4)
                    return ELocation;
                else if (index == 5)
                    return Esalary;
                return null;
            }
            set {
                if (index == 0)
                    Eno = (int)value;
                else if (index == 1)
                    Ename = (string)value;
                else if (index == 2)
                    EJob = (string)value;
                else if (index == 3)
                    EDname = (string)value;
                else if (index == 4)
                    ELocation = (string)value;
                else if (index == 5)
                    Esalary = (double)value;
                
            }
        }
        public object this[string name]
        {
            get {
                if (name.ToLower() == "eno")
                    return Eno;
                else if (name.ToLower() == "ename")
                    return Ename;
                else if (name.ToLower() == "ejob")
                    return EJob;
                else if (name.ToLower() == "edname")
                    return EDname;
                else if (name.ToLower() == "elocation")
                    return ELocation;
                else if (name.ToLower() == "esalary")
                    return Esalary;
                return null;
            }
            set {
                if (name.ToLower() == "ename")
                    Ename = (string)value;
            }
        }
    }
}