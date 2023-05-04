using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_StudentDozent_BibCollege
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Donald", "Duck");
            Console.WriteLine(p);
            Mitarbeiter m = new Mitarbeiter("Mickey", "Mouse", 1000.0f);
            Console.WriteLine(m);
            Student s = new Student("Tim", "Teuscher", "IBF2F20F");
            Console.WriteLine(s);
            Dozent d = new Dozent("Erich", "Eigen", 1000, "Informatik");
            Console.WriteLine(d);
        }
    }
}
