using FirstProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectZERO
{
    class FirstProject
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SDA6! :-)");
            SecondProject sp = new SecondProject();
            Console.WriteLine(sp.Method1());
            int variable01 = 100;
            const int variable02 = 50;
            Console.WriteLine(variable01 > variable02);
            int x = 10;
            Console.WriteLine(x);
            Console.WriteLine(x++);
            Console.WriteLine(++x);
            if (x == 12)
            {
                x++;
                Console.WriteLine(x);
            }
            while (x < 20)
            {
                Console.Write(x + " ");
                x++;
            }
            Console.WriteLine();
            do
            {
                Console.Write(x + " ");
                x++;
            } while (x < 40);
            Console.WriteLine();
            for (x = 1; x < 20; x++)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine();

            // StringBuilder
            StringBuilder sb = new StringBuilder("Hello");
            sb.Insert(5, " Andrzej!");
            Console.WriteLine(sb);

            Course course = new Course();
            course.CourseName = "Java Programming";
            Console.WriteLine("Course name " + course.CourseName);
            
            Student s = new Student();
            s.PersonID = "123";
            s.Name = "Alex";
            s.Print();

            ForeignStudent fs = new ForeignStudent();
            fs.PersonID = "9873";
            fs.Name = "Igor";
            fs.HomeUni = "Moscow";
            fs.Print();

            Console.Read();
        }
    }
}