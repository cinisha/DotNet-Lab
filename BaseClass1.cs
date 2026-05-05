//Example of access modifiers in C#
using System;
class BaseClass1
{
    public int pub = 1;
    private int priv = 2;
    protected int prot = 3;
    internal int inter = 4;
    protected internal int protInternal = 5;
    private protected int privProt = 6;

    public void ShowBase()
    {
        Console.WriteLine(priv);
        Console.WriteLine(privProt);
    }
}
class DerivedClass1 : BaseClass1
{
    public void ShowDerived()
    {
        Console.WriteLine(pub);
        Console.WriteLine(prot);
        Console.WriteLine(inter);
        Console.WriteLine(protInternal);
        Console.WriteLine(privProt);

        // Console.WriteLine(priv); // private (not accessible)
    }
}


