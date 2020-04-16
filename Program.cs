using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ormt
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                context.Database.CreateIfNotExsits();
                if (context.Student.Any())
                {
                   
                    object name = string.Name;
                }
                var Students = context.Student;
                foreach(var item in Student)
                {
                    Console.WriteLine("ID = " + item.Id);
                    Console.WriteLine("Name " + item.Name);
                    Console.WriteLine("Email" + item.Email);
                }
            }
            Console.ReadKey();


        }
    }
}
