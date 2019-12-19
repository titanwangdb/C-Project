using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

// 特性（Attribute）是用于在运行时传递程序中各种元素（比如类、方法、结构、枚举、组件等）的行为信息的声明性标签。

namespace TestProject.AttributesTest
{
    // 列举特性

    //预定义特性：
    //AttributeUsage,描述用户定义的特性类是如何使用的。它规定了某个特性应用的项目类型。

    //Conditional,标记了一个条件方法，其执行依赖于特定的预处理标识符。它会引起方法调用的条件编译，取决于指定的值，
        // 比如 Debug 或 Trace。例如，当调试代码时显示变量的值。
    class MyAttributes
    {
        Boolean flag;

        public MyAttributes(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------AttributeTest--------------");
                AttributeTest AB = new AttributeTest();
                AB.function1();

                Console.WriteLine("--------------ObsoleteTest--------------");
                ObsoleteTest OL = new ObsoleteTest();
                // OL.OldMethod();
                OL.NewMethod();

                Console.ReadKey();
            }
            
        }

        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    class AttributeTest
    {
        public void function1()
        {
            MyAttributes.Message("In Function 1.");
            function2();
        }

        public void function2()
        {
            MyAttributes.Message("In Function 2.");
        }
    }

    //Obsolete,标记了不应被使用的程序实体。它可以让您通知编译器丢弃某个特定的目标元素。
    public class ObsoleteTest
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        public void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        public void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
    }

    // 创建自定义的特性
}
