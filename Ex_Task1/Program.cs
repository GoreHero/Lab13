using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man("Petrov", 2000, "Moscow");
            Console.WriteLine(man.Print()); 
            Student student = new Student("Sidorov", 2000, "Moskow","GUZ");
            Console.WriteLine(student.Print());
            Console.ReadKey();
        }
    }
}
