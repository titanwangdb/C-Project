using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.NameSpaceTest
{
    class MyNameSpace
    {
        Boolean flag;

        public MyNameSpace(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                FirstNameSpace.Class1 FNC = new FirstNameSpace.Class1();
                SecondNameSpace.Class1 SNC = new SecondNameSpace.Class1();
                FNC.abc();
                SNC.abc();

                Console.ReadKey();
            }
        }
    }
}

namespace TestProject.FirstNameSpace
{
    

    class Class1
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }

        public void abc()
        {
            Console.WriteLine("Inside first_space");
        }
    }

    class Class2
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }

        public void abc()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}

namespace TestProject.SecondNameSpace
{
    class Class1
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }

        public void abc()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
