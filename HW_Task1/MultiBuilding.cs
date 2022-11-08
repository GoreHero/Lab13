using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    sealed class MultiBuilding : Bulding
    {
        private int numFloors;
        int NumFloors
        {
            get { return numFloors; }
            set
            {
                if (value < 0)
                    numFloors = 0;
                else
                    numFloors = value;
            }
        }
        public MultiBuilding(string address, double leght, double width, double height, int numFloors)
            : base(address, leght, width, height)
        {
            this.numFloors = numFloors;
        }
        public new string Print()
        {
            string res = base.Print();
            res += $" Этажность: {numFloors}";
            return res;
        }
    }
}
