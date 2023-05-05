using System;
class StaticVar
{
    public static string name="Invia pvt. ltd ";
}
class Company
{
    static void Main(string[] args)
    {
        Console.WriteLine(StaticVar.name);
    }
}