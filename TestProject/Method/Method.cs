using System;
using System.Collections.Generic;
using System.Text;
using TestProject.LibTest;

//方法，是一组在一起执行任务的语句。每个 C# 程序都至少有一个含有方法的类，名为 Main

namespace TestProject.MethodTest
{
    /*<Access Specifier> <Return Type> <Method Name>(Parameter List)
    {
       Method Body
    }

    访问说明符：它用于从一个类中确定一个变量或方法的可见性。
    返回类型：方法可能会返回一个值。返回类型是方法返回值的数据类型。如果该方法不返回任何值，那么返回类型是 void。
    方法名称：方法名称是唯一的标识符，并区分大小写。它不能与在类中声明的任何其他标识符相同。
    参数列表：括号括起来，使用参数从方法中传递和接收数据。参数列表是指类型、顺序和方法的参数数目。参数是可选的；方法可能包含任何参数。
    方法主体：它包含的一组指令完成所需要的活动所需。 */

    class MyMethod
    {
        Boolean flag;

        public MyMethod(bool f = false)
        {
            flag = f;
        }

        int num;
        int num2;
        int tmp;

        public void Run()
        {
            MyRandom r = new MyRandom();
            num = r.CRandom();
            num2 = r.CRandom();

            if (flag)
            {
                int a = 10;
                int b = 20;

                Console.WriteLine("--------------FindMax--------------");
                Console.WriteLine("Num1 is: {0}, Num2 is: {1} Max is: {2}", num , num2, GetMax(num, num2));

                Console.WriteLine("--------------Recursive--------------");
                tmp = r.CRandom(2, 6);
                Console.WriteLine("{0} 阶乘(5*4*3*2*1): {1}", tmp, Recursive(tmp));

                Console.WriteLine("--------------RecursiveZero--------------");
                tmp = r.CRandom(2, 5);
                Console.WriteLine("{0} Recursive: ", tmp);
                RecursiveZero(tmp);

                Console.WriteLine("--------------ValuesPass--------------");
                a = 10;
                b = 20;
                // Before: a is 10 and b is 20
                Console.WriteLine("Before: a is {0} and b is {1}", a, b); 
                ValuesPass(a, b);
                // After: a is 10 and b is 20
                Console.WriteLine("After: a is {0} and b is {1}", a, b);

                Console.WriteLine("--------------RefPass--------------");
                a = 10;
                b = 20;
                // Before: a is 10 and b is 20
                Console.WriteLine("Before: a is {0} and b is {1}", a, b);
                RefPass(ref a, ref b);
                // After: a is 20 and b is 10
                Console.WriteLine("After: a is {0} and b is {1}", a, b);

                Console.WriteLine("--------------OutPass--------------");
                a = 10;
                // Before: a is 10
                Console.WriteLine("Before: a is {0}", a);
                OutPass(out a);
                // After: a is 99
                Console.WriteLine("After: a is {0}", a);

                Console.ReadKey();
            }
        }

        public int GetMax(int num, int num2)
        {
            return num > num2 ? num : num2;
        }

        // 递归方法调用
        public int Recursive(int num)
        {
            int result = 1;

            if (num == 1)
            {
                return result;
            }
            else
            {
                result = Recursive(num - 1) * num;
                return result;
            }

        }

        public void RecursiveZero(int num)
        {
            if (num == 0)
            {
                Console.WriteLine("num is 1:" + num);
            }
            else
            {
                RecursiveZero(num - 1);
                Console.WriteLine("num is 2:" + num);
            }

        }

        // 将参数传递给方法
        //值参数 此方法将参数的实际值复制到该函数的形参。对该参数在函数内部所做的更改没有对参数产生影响。
        public void ValuesPass(int x, int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        //引用参数 此方法将对实参的内存位置的引用复制到形参。这意味着对参数所做的更改会影响参数本身。
        public void RefPass(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        //输出参数 这种方法有助于返回多个值。
        public void OutPass(out int x)
        {
            int temp = 99;

            x = temp;
        }
    }
}
