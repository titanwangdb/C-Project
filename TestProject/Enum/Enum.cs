using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.EnumTest
{
    class MyEnum
    {
        private Boolean flag = false;

        enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public MyEnum(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------EnumTest--------------");
                EnumTest();

                Console.ReadKey();
            }
        }

        public void EnumTest()
        {
            Console.WriteLine(Days.Fri);   // Fri

            int WeekdayStart = (int)Days.Mon;
            Console.WriteLine("Monday: {0}", WeekdayStart);     // Sun = 1
            Console.WriteLine("Friday: {0}", (int)Days.Fri);       // Sun = 5
        }
    }
}
