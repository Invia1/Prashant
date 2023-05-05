using System;
namespace Programs
{
class Palindromestr
{
    public static void Main(String[] args)
    {
       Console.Write("Enter to check the string is palindrome or not:");
       string name=Console.ReadLine().ToLower();
       //string lname =name.ToLower();
       string reverse=string.Empty;

       for(int i=name.Length-1; i>=0; i--)
       {
        reverse = reverse + name[i];
       }
       if(name==reverse)
       {
        Console.WriteLine("The String is Palindrome");
       }
       else{
        Console.WriteLine("The given string is not palindrome");
       }
    }
}
}