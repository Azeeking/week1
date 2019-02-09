using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public string yearofstudy;
       

        public Student(string name, string id, string yearofstudy)
        {
            this.name = name;
            this.id = id;
            this.yearofstudy = yearofstudy;
            
        }
        public void Taken()
        {
            Console.WriteLine(name + " " + id + " " + yearofstudy);
            
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ktk = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            ktk.Taken();

        }
    }
}