using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bulding bulding = new Bulding("Moscow",20,30,45);
            Console.WriteLine($"{bulding.Print()} Площадь здания: {bulding.GetArea()}");
            MultiBuilding multiBuilding = new MultiBuilding("Moscow", 20, 30, 45, 24);
            Console.WriteLine($"{multiBuilding.Print()} Площадь здания: {bulding.GetArea()}");
            Console.ReadKey();
        }
    }
}
