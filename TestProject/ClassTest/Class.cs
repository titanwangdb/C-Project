using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.ClassTest
{
    class ClassTest01
    {
        public double Length, Breadth, Height;

        public ClassTest01()
        {
            Console.WriteLine("ClassTest Constructor.");
        }

        public ClassTest01(string s)
        {
            Console.WriteLine("ClassTest Constructor.");
        }

        public void SetLength(double len)
        {
            Length = len;
        }

        public void SetBreadth(double bre)
        {
            Breadth = bre;
        }

        public void SetHeight(double hei)
        {
            Height = hei;
        }

        public double getVolume()
        {
            return Length * Breadth * Height;
        }
    }
}
