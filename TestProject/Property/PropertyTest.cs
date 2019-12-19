using System;
using System.Collections.Generic;
using System.Text;

/*
    属性（Property） 是类（class）、结构（structure）和接口（interface）的命名（named）成员。
    类或结构中的成员变量或方法称为 域（Field）。
    属性（Property）是域（Field）的扩展，且可使用相同的语法来访问。
    使用 访问器（accessors） 让私有域的值可被读写或操作。

    访问器（Accessors）,get 访问器、set 访问器,获取（读取或计算）或设置（写入）属性的可执行语句
     */
namespace TestProject.PropertyTest
{
    class MyProperty
    {
        Boolean flag;

        public MyProperty(bool f = false) { flag = f; }

        public void Run()
        {
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------Properties--------------");
                    MyProperty pro = new MyProperty();  // code: N.A name: Null age: 0

                    Console.WriteLine(pro.Print());
                    // 设置 MyProperty 的 code、name 和 age
                    pro.Code = "C#";
                    pro.name = "Titan";
                    pro.age = 36;
                    Console.WriteLine(pro.Print()); // code: C# name: Titan age: 36

                    Console.WriteLine("--------------Abstract Properties--------------");
                    var ps = new Student()
                    {
                        Code = "001",
                        Name = "Zara",
                        Age = 10
                    };
                    Console.WriteLine(ps.Print());  // code:001, name:Zara, age:10

                    ps.Age++;
                    Console.WriteLine(ps.Print());  // code:001, name:Zara, age:11

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private string code = "N.A";
        private string name = "Null";
        private int age = 0;

        // 声明类型为 string 的 Code 属性
        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        // 声明类型为 string 的 Name 属性
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // 声明类型为 int 的 Age 属性
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Print()
        {
            return "code: " + Code + " name: " + Name + " age: " + Age;
        }

        // 抽象属性（Abstract Properties）
        public abstract class Person
        {
            public abstract string Name { get; set; }
            public abstract int Age { get; set; }
        }

        public class Student : Person
        {
            public string Code { get; set; } = "N.A";
            public override string Name { get; set; } = "N.A";
            public override int Age { get; set; } = 0;

            public string Print()
            {
                return $"code:{Code}, name:{Name}, age:{Age}";
            }
        }
    }
}
