using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Example
{
    class MyPrint
    {
        public static void Print(string i = "", string v = "")
        {
            Console.WriteLine(i + v);
        }

        public static void PrintReadKey()
        {
            Console.ReadKey();
        }

        public static void Print02()
        {
            Console.ReadKey();
        }
    }

    class TTT
    {
        public void TTTPrint()
        {
            MyPrint PP = new MyPrint();
            MyPrint.Print();

            Console.WriteLine("222");
            this.TTTPrint();

        }
    }
}
