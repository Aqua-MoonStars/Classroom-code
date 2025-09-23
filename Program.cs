using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
public class Classname

{
    public String StudentName;
    public int StudentGrade;
}

public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Student Elements    
        List<Student> students = new List<Student>();
        students.Add(new Student { Name = "Lucy", Grade = 20 });
        students.Add(new Student { Name = "Ray", Grade = 22 });
        students.Add(new Student { Name = "Eri", Grade = 19 });
        students.Add(new Student { Name = "Ben", Grade = 21 });

    }
}
