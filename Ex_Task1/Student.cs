using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Task1
{
    internal class Student:Man
    {
        string university;

        public Student(string name, int bithdayDate, string city, string university)
            :base (name,bithdayDate, city)
        { 
            this.university = university;
        }

        public string Print()
        {
            string result = base.Print();
            result += $" {university}";
            return result;
        }
    }


}
