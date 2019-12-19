using System;
using System.Collections.Generic;
using System.Text;


/*数据类型:
    值类型（Value types）,可以直接分配给其一个值。
    引用类型（Reference types）,指向的是一个内存位置。内置的引用类型有：object、dynamic 和 string。 
        对象（Object）类型
        动态（Dynamic）类型
        字符串（String）类型
    指针类型（Pointer types）*/

namespace TestProject.DataTypesTest
{
    class MyDataType
    {

        Boolean flag;

        public MyDataType(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------ReferenceTypes--------------");
                ReferenceTypes RT = new ReferenceTypes();
                RT.ObjectType();
                RT.DynamicType();
                RT.StringType();

                Console.WriteLine("--------------PointerTypes--------------");


                Console.WriteLine("--------------NullTypes--------------");
                NullTypes NT = new NullTypes();
                NT.NullType();

                Console.ReadKey();
            }
        }
    }
    
    class ReferenceTypes
    {
        
        // 对象类型
        public void ObjectType()
        {
            object Obj;
            Obj = 101;      // 装箱
            // 当一个值类型转换为对象类型时，则被称为装箱；当一个对象类型转换为值类型时，被称为拆箱。
            Console.WriteLine("Obj is:" + Obj);
        }

        // 动态类型
        public void DynamicType()
        {
            // 在动态数据类型变量中存储任何类型的值。这些变量的类型检查是在运行时进行的。
            dynamic temp = 20;
            Console.WriteLine("Temp is: {0} Type is: {1}", temp, "typeof");

            temp = "this is string type.";
            Console.WriteLine("Temp is:" + temp);
        }

        // 字符串类型
        public void StringType()
        {
            string str = "string type";
            Console.WriteLine("String Type is:" + str);

            str = @"C:\Windows";  // @ 将转义字符（\）当作普通字符对待
        }
    }



    class PointerTypes
    {
        
        public void PointTest()
        {
            //char* cptr;
            //int* iptr;
        }
    }


    class NullTypes
    {
        // < data_type> ? <variable_name> = null;

        // 可空类型,一个特殊的数据类型
        public void NullType()
        {
            int i;      //默认值0
            int? ii;    //默认值null

            int? num1 = null;
            int? num2 = 45;
            double? num3 = new double?();
            double? num4 = 3.14157;

            bool? boolval = new bool?();

            // Nullables at Show: , 45, , 3.14157
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            // A Nullable boolean value:
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
        }

        // 空合并运算符(??)
        public void MergeNull()
        {
            double? num1 = null;
            double? num2 = 3.14157;
            double num3;
            num3 = num1 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
            num3 = num2 ?? 5.34;
            Console.WriteLine(" Value of num3: {0}", num3);
        }
    }
}
