using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student();
                Console.WriteLine("What is the students first name?");
                student.FirstName = Console.ReadLine();
                Console.WriteLine("What is the students last name?");
                student.LastName = Console.ReadLine();
                Console.WriteLine("What is the students grade level?");
                student.GradeLevel = Console.ReadLine();

                context.Students.Add(student);

                context.SaveChanges();
            }
        }
    }
}
