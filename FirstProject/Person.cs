using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public abstract class Person
    {
        private string personID;
        private string name;
        public string PersonID { get => personID; set => personID = value; }
        public string Name { get => name; set => name = value; }
    }

    public class Student : Person
    {
        private string program;

        public string Program { get => program; set => program = value; }
    
        public virtual void Print()
        {
            Console.WriteLine("Student with name " + Name + " has student ID " + PersonID);
        }
    }

    public class ForeignStudent : Student 
    {
        private string homeUni;

        public string HomeUni { get => homeUni; set => homeUni = value; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Home university of foreign student is " + HomeUni);
        }
    }

    public class Teacher : Person 
    { 
        private string certificate;

        public string Certificate { get => certificate; set => certificate = value; }
    }
}
