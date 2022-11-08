using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    class Bulding
    {
        private string address;
        string Address { get; set; }
        private double leght;
        double Leght
        {
            get { return leght; }
            set
            {
                if (value < 0)
                    leght = 0;
                else
                    leght = value;
            }
        }
        private double width;
        double Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                    width = 0;
                else
                    width = value;
            }
        }
        private double height;
        double Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                    height = 0;
                else
                    height = value;
            }
        }


        public Bulding(string address, double leght, double width, double height)
        {
            this.address = address;
            this.leght = leght;
            this.width = width;
            this.height = height;
        }
        public string Print()
        {
            return $"Адрес: {address} Длина: {leght} Ширина: {width} Высота: {height}";
        }
        public double GetArea()
        {
            return leght * width;
        }
    }
}
