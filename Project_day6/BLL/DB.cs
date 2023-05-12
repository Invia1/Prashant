using Project_day6.Manage;
using System;

namespace Project_day6.BLL
{
    class DB
    {
        public Student StudentDetails()
        {
            Student obj = new Student();
            Console.WriteLine("Please enter your student id for food:");
            obj.StdID = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            obj.StdName = Console.ReadLine();
            Console.WriteLine("Enter the name of food, which you want to prefer:");
            obj.Stdfood = Console.ReadLine();
            Console.WriteLine("Enter your Address:");
            obj.Stdadd = Console.ReadLine();
            return obj;

        }
    }

}
