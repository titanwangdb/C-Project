using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.ClassTest
{
    class RectangleText
    {
        // member variables
        public double Length;
        private double Width;       // 封装

        // 派生类使用
        protected int width;
        protected int height;

        // static 静态变量被用于定义常数，因为他们的值可以通过调用不创建实例的类而被检索出来。
        // 静态变量可以在成员函数或者类的定义以外的地方初始化。你也可以在类的定义中初始化静态变量。
        public static int num;

        // 构造函数（constructor）是类的一种特殊的成员函数，当我们创建一个类的新的对象时执行该函数。
        // 构造函数与类具有相同的名称，但它没有任何返回类型。
        public RectangleText(double w, double L)
        {
            Length = L;
            Width = w;
            Console.WriteLine("RectangleText Constructor.");
        }

        // 参数化的构造函数（parameterized constructors）
        //public RectangleText(String str)
        //{
        //    Console.WriteLine("Parameterized constructors:" + str);
        //}

        // 析构函数（destructor）
        // 当类的对象在超出作用域时被执行的一种成员函数,不返回值，也不带任何参数
        ~RectangleText()
        {
            Console.WriteLine("RectangleText is being deleted.");
        }

        public void count()
        {
            num++;
        }

        public int GetNum()
        {
            return num;
        }

        // static functions
        public static int GetNum02()
        {
            return num;
        }

        // member function
        public void Acceptdetails()
        {
            Length = 3.0;
            Width = 3.0;
        }

        public void Acceptdetails02()
        {
            height = 12;
            width = 10;
        }

        public void SetLegth(double len)
        {
            Length = len;
        }

        public void SetWidth(double wid)
        {
            Width = wid;
        }

        public double GetAreas()
        {
            return Length * Width;
        }

        public void Display()
        {
            Console.WriteLine("Length is:" + Length);
            Console.WriteLine("Width is:" + Width);
            Console.WriteLine("Areas is:" + GetAreas());
        }
    }
}
