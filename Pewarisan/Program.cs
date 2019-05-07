using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pewarisan
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Dina";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Vicka";
            teacher.Age = 20;
            teacher.TeacherId = "190302";
            teacher.Subject = "Math";
            teacher.GetNameAndAge();

            Students students = new Students();
            students.Name = "Sara";
            students.Age = 20;
            students.StudentsId = "10506";
            students.Email = "sara1234@amikom.ac.id";
            students.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
