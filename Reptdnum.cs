using System;
    class Reptdstr
    {
         static void Main(string[] args)
        {
            string str=" ";
            Console.WriteLine("Enter the String");
            str =Console.ReadLine();
            while(str.Length > 0)
            {
                int count=0;
                Console.WriteLine(str[0]+" ");
            for(int i=0; i<str.Length; i++)
            {
                
                    if(str[0]==str[i])
                    {
                        count++;
                    }
            }
                    Console.WriteLine(count);
                    str=str.Replace(str[0].ToString(), string.Empty);
                    Console.ReadLine();
            }
            
        }
    }

