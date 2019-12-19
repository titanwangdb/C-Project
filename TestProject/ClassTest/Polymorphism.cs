using System;
using System.Collections.Generic;
using System.Text;

// 静态多态（static polymorphism
// 函数重载
// 运算符重载

// 动态多态性（ dynamic polymorphism）,通过 抽象类 和 虚方法 实现的。
// 抽象类（Abstract classes）
// 虚函数（virtual functions）,当有一个定义在类中的函数需要在继承类中实现时，可以使用虚方法。

namespace TestProject.ClassTest
{
    class MyPolymorphism
    {
        Boolean flag;

        public MyPolymorphism(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------Function overloading--------------");
                PrintInfo PL = new PrintInfo();
                PL.Print(1001);
                PL.Print(12.13);
                PL.Print("string type");

                Console.WriteLine("--------------Operator overloading--------------");
                OperateReload Box1 = new OperateReload();    // 声明 box1 为 box 类型
                OperateReload Box2 = new OperateReload();    // 声明 box2 为 box 类型
                OperateReload Box3 = new OperateReload();   // 声明 box3 为 box 类型
                double volume = 0.0;    // 在这里存放 box 的体积
                // box 1 
                Box1.setLength(6.0);
                Box1.setBreadth(7.0);
                Box1.setHeight(5.0);
                // box 2 
                Box2.setLength(12.0);
                Box2.setBreadth(13.0);
                Box2.setHeight(10.0);
                // box 1 体积
                Console.WriteLine("Volume of Box1 : {0}", Box1.getVolume());
                //  box 2 体积
                volume = Box2.getVolume();
                Console.WriteLine("Volume of Box2 : {0}", volume);
                // 将两个对象相加如下：
                Box3 = Box1 + Box2;
                // box 3 的体积
                volume = Box3.getVolume();
                Console.WriteLine("Volume of Box3 : {0}", volume);

                Console.WriteLine("--------------Abstract classes--------------");
                Abstract Abs = new Abstract(10, 5);
                Console.WriteLine(Abs.area());

                Console.WriteLine("--------------virtual functions--------------");
                Caller c = new Caller();
                Rectangle r = new Rectangle(10, 7);
                Triangle t = new Triangle(10, 5);
                c.CallArea(r);
                c.CallArea(t);

                Console.ReadKey();
            }
        }
    }

    // 函数重载
    class PrintInfo
    {
        public void Print(double d)
        {
            Console.WriteLine("this is double Print: " + d);
        }

        public void Print(int i)
        {
            Console.WriteLine("this is int Print: " + i);
        }

        public void Print(String s)
        {
            Console.WriteLine("this is String Print: " + s);
        }
    }


    // 运算符重载
    class OperateReload
    {
        private double length;   // box 的长度
        private double breadth;  // box 的宽度
        private double height;   // box 的高度

        public double getVolume()
        {
            return length * breadth * height;
        }

        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }

        // 重载 + operator 来增加两个 Box 对象
        public static OperateReload operator +(OperateReload b, OperateReload c)
        {
            OperateReload box = new OperateReload();
            box.length = b.length + c.length;
            box.breadth = b.breadth + c.breadth;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(OperateReload lhs, OperateReload rhs)
        {
            bool status = false;
            if (lhs.length == rhs.length && lhs.height == rhs.height && lhs.breadth == rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        public static bool operator !=(OperateReload lhs, OperateReload rhs)
        {
            bool status = false;
            if (lhs.length != rhs.length || lhs.height != rhs.height || lhs.breadth != rhs.breadth)
            {
                status = true;
            }
            return status;
        }

        //public static bool operator (Box lhs, Box rhs)
        //{
        //    bool status = false;
        //    if (lhs.length > rhs.length && lhs.height > rhs.height && lhs.breadth > rhs.breadth)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}

        //public static bool operator =(Box lhs, Box rhs)
        //{
        //    bool status = false;
        //    if (lhs.length >= rhs.length && lhs.height >= rhs.height && lhs.breadth >= rhs.breadth)
        //    {
        //        status = true;
        //    }
        //    return status;
        //}

        public override string ToString()
        {
            return String.Format("({0}, {1}, {2})", length, breadth, height);
        }

    }


    // 抽象类（Abstract classes）
    abstract class Shape02
    {
        // 抽象方法
        public abstract int area();
    }

    class Abstract : Shape02
    {
        private int length;
        private int width;

        public Abstract(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }

        public override int area()
        {
            Console.Write("Rectangle class area : ");
            return (width * length);
        }
    }



    // 虚函数（virtual functions）
    class Shape
    {
        protected int width, height;
        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.WriteLine("Parent class area :");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Rectangle class area :");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {

        }
        public override int area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height / 2);
        }
    }

    class Caller
    {
        public void CallArea(Shape sh)
        {
            int a;
            a = sh.area();
            Console.WriteLine("Area: {0}", a);
        }
    }
}
