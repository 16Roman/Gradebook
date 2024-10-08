using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gradebook_Giannuzzi
{

    
   public  class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double FinalGrade { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public static  List<Student> GenerateMockStudents()
        {
            var students = new List<Student>
            {
                new Student("Roman", "Giannuzzi"),
                new Student("Joe", "Mama"),
                new Student("Josepth", "Joe"),
               

            };
            return students;
            
        }

    }

}
