class Switch_Case
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Heeyyy! Welcome");
        Console.WriteLine("Enter-1 to perform factorial task:");
        Console.WriteLine("Enter-2 to perform the fibonacci series:");
        Console.WriteLine("Enter-3 to check the value is prime or not");

        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 3)
        {
            Console.WriteLine("You've entered a wrong value, please try again!");
        }
        else
        {
            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the Number");
                        int f = int.Parse(Console.ReadLine());
                        int fact = 1;
                        for (int i = 1; i <= f; i++)
                        {
                            fact = fact * i;
                        }
                        Console.WriteLine(fact);
                    }
                    break;

                case 2:
                    {
                        int n1 = 0, n2 = 1, n3;
                        Console.WriteLine("Enter the Number");
                        int inp = int.Parse(Console.ReadLine());
                        for (int i = 2; i <= inp; i++)
                        {
                            n3 = n2 + n1;
                            Console.WriteLine(" " + n3);
                            n1 = n2;
                            n2 = n3;
                        }
                    }
                    break;

                case 3:
                    {
                        int m = 0;
                        Console.WriteLine("Enter the Number");
                        int n = int.Parse(Console.ReadLine());
                        if (n == 0 || n == 1)
                        {
                            Console.WriteLine("Heyyy! Sorry in prime number the value must be greater than one.");
                        }
                        else
                        {
                            for (int i = 2; i < n; i++)
                            {
                                if (n % i == 0)
                                {
                                    m++;
                                    break;
                                }
                            }
                        }
                        if (m == 0)
                        {
                            Console.WriteLine("The given number is prime number");
                        }
                        else
                        {
                            Console.WriteLine("The given number is not prime number");
                        }
                    }
                    break;
            }
        }
    }
}
