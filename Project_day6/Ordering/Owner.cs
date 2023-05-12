using Project_day6.BLL;
using Project_day6.Manage;
using System;

namespace Project_day6.Ordering
{
    class Owner
    {
        public static void Main()
        {
            DB objdb = new DB();
            Student temp = objdb.StudentDetails();
            Console.WriteLine("Your student id is: "+temp.StdID +"\n Your name is: "+ temp.StdName + "\n Your food name is: " + temp.Stdfood + "\n Your address is: " + temp.Stdadd);
        }
    }

}
