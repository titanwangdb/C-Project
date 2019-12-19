using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.OperatorsTest
{
    class MyOperators
    {
        Boolean flag;

        public MyOperators(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------NullMerge--------------");
                NullMerge();

                Console.ReadKey();
            }
        }

        // 算术运算符
        public void ArithmeticTest()
        {
            // +   两个操作数相加                     A + B = 30
            // -   两个操作数相减(第一个减去第二个）	  A - B = -10
            // *   两个操作数相乘                     A * B = 200
            // /   分子除以分母                       B / A = 2
            // %   取模运算符，整除后的余数            B % A = 0
            // ++  自增运算符，整数值增加1             A++ = 11
            // --  自减运算符，整数值减少1             A-- = 9


            //c = a++: 先将 a 赋值给 c，再对 a 进行自增运算。
            //c = ++a: 先将 a 进行自增运算，再将 a 赋值给 c 。
            //c = a--: 先将 a 赋值给 c，再对 a 进行自减运算。
            //c = --a: 先将 a 进行自减运算，再将 a 赋值给 c 。
        }

        // 关系运算符
        public void RelationalTest()
        {
            // == 检查两个操作数的值是否相等，如果相等则条件为真(A == B)                   不为真
            // != 检查两个操作数的值是否相等，如果不相等则条件为真(A != B)                  为真
            // >  检查左边的操作数的值是否大于右操作数的值，如果是则条件为真(A > B)          不为真
            // <  检查左边的操作数的值是否小于右操作数的值，如果是则条件为真(A < B)          为真
            // >= 检查左边的操作数的值是否大于或等于右操作数的值，如果是则条件为真(A >= B)      不为真
            // <= 检查左边的操作数的值是否小于或等于右操作数的值，如果是则条件为真(A <= B)      为真
        }

        // 逻辑运算符
        public void LogicalTest()
        {
            //&& 称为逻辑与操作，如果两个操作数都非零，则条件为真(A && B) 结果为 false
            //|| 称为逻辑或操作，如果两个操作数中有任意一个非零，则条件为真(A || B) 结果为 true
            //!称为逻辑非运算符，用来逆转操作数的逻辑状态。如果条件为真则逻非运算符将使其为假
        }

        // 位运算符
        public void BitTest()
        {

        }

        // 赋值运算符
        public void AssignmentTest()
        {
            //= 简单的赋值运算符，把右边操作数的值赋给到左边操作数 C = A + B 把 A +B 的值赋给 C
            //+= 加且赋值运算符，把右边操作数加上左边操作数的结果赋值给左边操作数 C += A 相当于 C = C + A
            //-= 减且赋值运算符，把左边操作数减去右边操作数的结果赋值给左边操作数 C -= A 相当于 C = C - A
            //*= 乘且赋值运算符，把右边操作数乘以左边操作数的结果赋值给左边操作数 C = A 相当于 C = C A
            ///= 除且赋值运算符，把左边操作数除以右边操作数的结果赋值给左边操作数 C /= A 相当于 C = C / A
            //%= 求模且赋值运算符，求两个操作数的模赋值给左边操作数 C %= A 相当于 C = C % A
            //<<= 左移且赋值运算符    C <<= 2 相当于 C = C << 2
            //>>= 右移且赋值运算符    C >>= 2 相当于 C = C >> 2
            //&= 按位与且赋值运算符   C &= 2 相当于 C = C & 2
            //^= 按位异或且赋值运算符  C ^= 2 相当于 C = C ^ 2
            //|= 按位或且赋值运算符   C |= 2 相当于 C = C | 2
        }

        // 其它运算符
        public void OtherOperator()
        {
            // sizeof()    返回一个数据类型的大小 sizeof(int)，将返回 4
            Console.WriteLine("Size is:" + sizeof(int));

            // typeof()    返回一个类的类型    typeof(StreamReader)
            Console.WriteLine("Type is:" + typeof(string));

            // & 返回一个变量的地址 & a; 将给出变量的实际地址

            // * 指针的变量   *a; 将指向一个变量

            // ? : 条件表达式   如果条件为真，那么? 值为 X: 否则? 值为 Y
            int Max = 0, num1 = 10, num2 = 20;
            Max = num1 > num2 && num1 != 0 ? num1 : num2;
            Console.WriteLine("Max is:" + Max);

            // is 判断一个对象是否是特定的类型 If(Ford is Car) // 判断 Ford 对象是否属于 Car 类型

            // as 转换，如果转换失败则引发异常 Object obj = new StringReader("Hello"); StringReader r = obj as StringReader;
        }

        // 空合并运算符(??),如果第一个操作数的值为 null，则返回第二个操作数的值，否则返回第一个操作数的值。
        // NULL 检查运算符 ?
        public void NullMerge()
        {
            string str = null;
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            // a??b 当 a 为 null 时则返回 b，a 不为 null 时则返回 a 本身
            // a??b??c 的形式按 a??(b??c) 计算
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3); // Value of num3: 5.34

            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3); // Value of num3: 3.14157
        }
    }
}
