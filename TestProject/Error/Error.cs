using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TestProject.Error
{
    class ErrorTest
    {
        public void division(int num1, int num2)
        {
            int result = 0;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            catch (IOException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }

        //Exception类 描述
        //System.IO.IOException 处理 I/O 错误
        //System.IndexOutOfRangeException 处理的方法是指当一个数组索引超出范围的错误产生
        //System.ArrayTypeMismatchException 处理时，类型不匹配的数组类型产生的错误
        //System.NullReferenceException   处理从取消引用一个空对象产生的错误
        //System.DivideByZeroException 处理来自将一个除零而产生的错误
        //System.InvalidCastException 处理类型转换过程中产生的错误
        //System.OutOfMemoryException 处理来自可用内存不足产生的错误
        //System.StackOverflowException 处理从堆栈溢出产生的错误

        // 创建自定义异常
    }
}
