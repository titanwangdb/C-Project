using System;
using System.Collections.Generic;
using System.Text;

// 继承

namespace TestProject.ClassTest
{
    class InheritClass : RectangleText
    {
        public InheritClass(double w, double h) : base(w, h)
        {

        }

        public int getArea()
        {
            return (width * height);
        }

        public void Display02()
        {
            Console.WriteLine("Length is:" + height);
            Console.WriteLine("Width is:" + width);
            Console.WriteLine("Areas is:" + getArea());
        }
    }
}
