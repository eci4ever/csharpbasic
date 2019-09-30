namespace accessspecifier
{
    public class access1
    {
        public void Test1()
        {
            System.Console.WriteLine("Test1 : Public Method");
        }   
        private void Test2()
        {
            System.Console.WriteLine("Test2 : Private Method");
        }
        protected void Test3()
        {
            System.Console.WriteLine("Test3: Protected Method");
        }
        internal void Test4()
        {
            System.Console.WriteLine("Test4: Internal Method ");
        }
        protected internal void Test5()
        {
            System.Console.WriteLine("Test5: Protected Internal Method");
        }
    }
}