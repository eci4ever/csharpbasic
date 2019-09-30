using System;

namespace accessspecifier
{
    class Program
    {
        static void Main(string[] args)
        {
            SameProNonChild s1 = new SameProNonChild();
        }
    }

    class SameProNonChild
    {
        public SameProNonChild()
        {
            access1 k = new access1();
            k.Test1();
            k.Test4();
            k.Test5();
        }
        
    }
}
