using System;
using System.Collections.Generic;
using System.Text;

// 多重继承

namespace TestProject.ClassTest
{
    class BaseClass
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }

        public void SetHeight(int h)
        {
            height = h;
        }

        public void Print()
        {
            Console.WriteLine("this is BaseClass Print()");
        }
    }

    public interface BaseClass02
    {
        int GetCost(int area);
    }

    class InheritClass02 : BaseClass, BaseClass02
    {
        Boolean flag;

        public InheritClass02(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                SetHeight(10);
                SetWidth(20);

                Console.WriteLine("--------------GetArea--------------");
                Console.WriteLine("Area is:" + this.GetArea());

                Console.WriteLine("--------------GetCost--------------");
                Console.WriteLine("Cost is:" + this.GetCost(this.GetArea()));

                Console.ReadKey();
            }
        }

        public int GetArea()
        {
            return (width * height);
        }

        public int GetCost(int area)
        {
            base.Print();
            return area * 10;
        }
    }
}
