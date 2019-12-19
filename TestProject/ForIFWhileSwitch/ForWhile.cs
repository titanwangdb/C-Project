using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.ForIFWhileSwitch
{
    class ForClass
    {
        //for 循环 多次执行一个语句序列，简化管理循环变量的代码。

        //break 语句 终止 loop 或 switch 语句，程序流将继续执行紧接着 loop 或 switch 的下一条语句。
        //continue 语句 引起循环跳过主体的剩余部分，立即重新开始测试条件。

        public void ForTest()
        {
            int[] IntArray = new int[] {1, 2, 3, 4};
            string[] StrArray = new string[] { };


        }
    }

    class WhileClass
    {
        //while 循环 当给定条件为真时，重复语句或语句组。它会在执行循环主体之前测试条件。
        //do...while 循环 除了它是在循环主体结尾测试条件外，其他与 while 语句类似。
        //嵌套循环 您可以在 do...while 循环内使用一个或多个循环。

        public void WhileTest()
        {
            int a = 10;

            do
            {
                Console.WriteLine(a);
                a--;
            } while (a <= 0);
        }
    }
}
