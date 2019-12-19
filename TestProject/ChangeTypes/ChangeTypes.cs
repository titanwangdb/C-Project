using System;
using System.Collections.Generic;
using System.Text;

// 内置的类型转换方法
//  ToBoolean 如果可能的话，把类型转换为布尔型。
//  ToByte 把类型转换为字节类型。
//  ToChar 如果可能的话，把类型转换为单个 Unicode 字符类型。
//  ToDateTime 把类型（整数或字符串类型）转换为日期-时间结构。
//  ToDecimal 把浮点型或整数类型转换为十进制类型。
//  ToDouble 把类型转换为双精度浮点型。
//  ToInt16 把类型转换为 16 位整数类型。
//  ToInt32 把类型转换为 32 位整数类型。
//  ToInt64 把类型转换为 64 位整数类型。
//  ToSbyte 把类型转换为有符号字节类型。
//  ToSingle 把类型转换为小浮点数类型。
//  ToString 把类型转换为字符串类型。
//  ToType 把类型转换为指定类型。
//  ToUInt16 把类型转换为 16 位无符号整数类型。
//  ToUInt32 把类型转换为 32 位无符号整数类型。
//  ToUInt64 把类型转换为 64 位无符号整数类型。

namespace TestProject.ChangeTypes
{
    class ChangeTypesTest
    {
        // 显式类型转换 
        public void ChangeType()
        {
            double d = 5673.74;
            int i;

            // 强制转换 double 为 int
            i = (int)d;
            Console.WriteLine(i);
        }
    }
}
