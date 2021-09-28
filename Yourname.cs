using System;
using System.Collections.Generic;
using System.Text;

namespace ThirdGT
{
    class Yourname
    {
        private string name;
        private string id;
        private string program;
        private int semester;
        private double cgpa;

        //property
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Program
        {
            get; set;
        }

        public double Cgpa
        {
            get; set;
        }

        public int Semester
        {
            get; set;
        }

        //empty
        public Yourname()
        {
            Console.WriteLine("Empty");
        }
        //param
        public Yourname(string name, int semester, double cgpa, string id, string program)
        {
            Console.WriteLine("Param");
            this.name = name;
            this.id = id;
            this.cgpa = cgpa;
            this.semester = semester;
            this.program = program;
        }
        //static
        static Yourname()
        {
            Console.WriteLine("Static Constructor");
        }

        //copy
        public Yourname(Yourname par)
        {
            name = par.name;
            id = par.id;
            semester = par.semester;
            program = par.program;
            cgpa = par.cgpa;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public void setSemester(int semester)
        {
            this.semester = semester;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setProgram(string program)
        {
            this.program = program;
        }
        public void setCgpa(double cgpa)
        {
            this.cgpa = cgpa;
        }

        public string getName()
        {
            return name;
        }

        public int getSemester()
        {
            return semester;
        }

        public double getCgpa()
        {
            return cgpa;
        }

        public string getProgram()
        {
            return program;
        }

        public string getId()
        {
            return id;
        }


        public void showDetails()
        {
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Semester: "+ semester);
            Console.WriteLine("ID: "+ id);
            Console.WriteLine("Program: "+ program);
            Console.WriteLine("CGPA: "+ cgpa);
        }

    }
}
