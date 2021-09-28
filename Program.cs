using System;

namespace ThirdGT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Param Constructor with Static Constructor");
            Yourname p1 = new Yourname("Bruce Wayne", 10, 3.98, "15-29798-2", "CSSE");
            p1.showDetails();
            Console.WriteLine("**************");
            Console.WriteLine("Empty Constructor");
            Yourname p2 = new Yourname();
            p2.setSemester(12);
            p2.setName("Habib Rahman");
            p2.setCgpa(4);
            p2.setId("12-43234-5");
            p2.setProgram("SE");
            Console.WriteLine("Name: "+p1.getName());
            Console.WriteLine("ID: "+p1.getId());
            Console.WriteLine("Semester: "+p1.getSemester());
            Console.WriteLine("CGPA: "+p1.getCgpa());
            Console.WriteLine("Program: "+p1.getProgram());
            Console.WriteLine("**************");
            Console.WriteLine("Empty Constructor with Property");
            Yourname p3 = new Yourname();

            p3.Name = "Wade Wilson";
            Console.WriteLine("Name: " + p3.Name);
            p3.Id = "19-56473-7";
            Console.WriteLine("ID: " + p3.Id);
            p3.Cgpa = 2.9;
            Console.WriteLine("CGPA: " + p3.Cgpa);
            p3.Program = "CSE";
            Console.WriteLine("Program: " + p3.Program);
            p3.Semester = 48;
            Console.WriteLine("Semester: " + p3.Semester);

            Console.WriteLine();

            Console.WriteLine("**************");
            Console.WriteLine("Copy Constructor");
            Yourname p4 = new Yourname(p1);
            p4.showDetails();

            Console.ReadKey();

        }
    }
}
