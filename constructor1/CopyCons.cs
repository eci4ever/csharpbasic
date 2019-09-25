class CopyCons
{
    private string name;

    public CopyCons(string s)
    {
        name = s;
    }

    public CopyCons(CopyCons obj)
    {
        name = obj.name;
    }

    public void Display()
    {
        System.Console.WriteLine(name);
    }
}