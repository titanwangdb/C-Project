using System;
using System.Collections.Generic;
using System.Text;

// 变量

namespace TestProject.VariAblesConst
{
    class VariAblesConst
    {
        int i, j, k;
        char ch;
        float f, salary;
        double d;

        int g = 100;

        //int d = 3, f = 5;    /* 初始化 d 和 f. */
        byte z = 22;         /* 初始化 z. */
        double pi = 3.14159; /* 声明 pi 的近似值 */
        char x = 'x';        /* 变量 x 的值为 'x' */

        short a;
        int b;
        double c;

        VariAblesConst()
        {
            Console.WriteLine(i + j + k);
        }

        public void VariAble()
        {
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);
            Console.ReadLine();
        }
    }

    // 接受来自用户的输入
    class InputCustomers
    {

        Boolean flag;

        public InputCustomers(bool f = false)
        {
            flag = f;
        }

        public void InputCustomer(string str)
        {
            if (flag)
            {
                int num;
                Console.WriteLine(str);

                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input is:" + num);

                Console.ReadKey();
            }
        }
    }
}
