using System;
using System.Collections.Generic;
using System.Text;

/* 委托（Delegate）
 * 类似于 C 或 C++ 中函数的指针。存有对某个方法的引用的一种引用类型变量。
 * 引用可在运行时被改变。 
 * 委托（Delegate）特别用于实现事件和回调方法
 */

// 声明委托
delegate int NumberChange(int n);

namespace TestProject.DelegateTest
{
    class MyDelegate
    {
        Boolean flag;
        //private int num;
        static int num = 10;
        public MyDelegate(int num = 10, bool f = false) {
            //this.num = num;
            flag = f;
        }

        public void Run()
        {
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------Delegate--------------");
                    // 创建委托实例
                    NumberChange nc1 = new NumberChange(AddNum);
                    NumberChange nc2 = new NumberChange(MultNum);
                    Console.WriteLine(GetNum());
                    // 使用委托对象调用方法
                    nc1(10);    // num(3) + 10 = 13     num(10) + 10 = 20
                    Console.WriteLine(GetNum());
                    nc2(5);     // num(13) * 5 = 65     num(20) * 5 = 100
                    Console.WriteLine(GetNum());

                    Console.WriteLine("--------------Delegate Multicasting--------------");
                    NumberChange nc;
                    // 委托的多播, "+" 运算符进行合并,"-" 运算符可用于从合并的委托中移除组件委托
                    nc = nc1;
                    nc += nc2;
                    // 调用多播
                    nc(5);  // num(65) + 5 = 70 , num(70) * 5 = 350  num(100) + 5 = 105 , num(105) * 5 = 525
                    Console.WriteLine(GetNum());

                    Console.WriteLine("--------------Delegate Usage--------------");
                    PrintInfo pt = new PrintInfo(Print);
                    PrintInfo pt2 = new PrintInfo(Print02);
                    SendInfo(pt);   // Print(): SendInfo()
                    SendInfo(pt2);  // Print02(): SendInfo()

                    Console.WriteLine("--------------Delegate Case--------------");
                    delegatetest dt;
                    // 委托被附上了具体的方法
                    dt = Multiply;
                    Console.WriteLine($"2 * 3 = {dt(2, 3)}");
                    dt = Sum;
                    Console.WriteLine($"2 + 3 = {dt(2, 3)}");

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private int AddNum(int n)
        {
            num += n;
            return num;
        }

        private int MultNum(int n)
        {
            num *= n;
            return num;
        }

        private int GetNum() { return num; }


        /* 委托（Delegate）的用途 */
        public delegate void PrintInfo(string s);

        private void Print(string s) { Console.WriteLine($"Print(): {s}"); }

        private void Print02(string s) { Console.WriteLine($"Print02(): {s}"); }

        private void SendInfo(PrintInfo PS) { PS("SendInfo()"); } // 把委托作为参数，并使用它调用方法 


        /* Case */
        delegate double delegatetest(double a, double b);
        double Multiply(double a, double b) { return a * b; }
        double Sum(double a, double b) { return a + b; }
    }
}
