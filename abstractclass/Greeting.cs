abstract class Greeting
{
    public abstract void Tegur(string x);
}

class Kawan : Greeting
{
    public override void Tegur(string x)
    {
        System.Console.WriteLine("hI {0}", x);
    }
}