using System;
class Duplrtd
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a String");
        String str=Console.ReadLine();
        int count=0;
        char[] strArray=str.ToCharArray();
        Console.WriteLine("Duplicate characters in string");
        for(int i=0; i<strArray.Length; i++)
        {
            for(int j=i+1; j<strArray.Length; j++)
            {
                if(strArray[i]==strArray[j])
                {
                    Console.WriteLine(strArray[j]);
                    count++;
                    break;
                }
            }
        }
        Console.WriteLine("Total duplicate characters found:"+count);
    }
}
