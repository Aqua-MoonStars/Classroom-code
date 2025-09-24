using System;
using System.Collections.Generic;
using System.Linq;
namespace Classroomcode
{
    public class Classroom
    {

        public string Classname { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
       
   
        public void AddStudent(Student student)
        {
            Students.Add(student);

        }

        public class Student
        {
            public string Name { get; set; }
            public int grade { get; set; }

        }
         
        public void DisplayStudents()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.grade}");
            }
        }



     public void DisplayClassInfo()
     {
         Console.WriteLine($"Class Name: {Classname}");
         DisplayStudents();
         if (Students.Count > 0)
         {
             var averageGrade = Students.Average(s => s.grade);
             Console.WriteLine($"Average Grade: {averageGrade}");
         }
         else
         {
             Console.WriteLine("No students in the class.");
         }
     }


       
    }
    
    
    }

    






    