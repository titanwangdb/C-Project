#define PI
#define DEBUG
#define VC_V10

using System;
using TestProject.ArraryTest;
using TestProject.DataTypesTest;
using TestProject.EnumTest;
using TestProject.InterfaceTest;
using TestProject.MethodTest;
using TestProject.OperatorsTest;
using TestProject.StringsTest;
using TestProject.StructsTest;
using TestProject.VariAblesConst;
using TestProject.NameSpaceTest;
using TestProject.ClassTest;
using TestProject.AttributesTest;
using TestProject.DirectoryFiles;
using TestProject.LibTest;
using TestProject.Example;
using TestProject.PropertyTest;
using TestProject.IndexerTest;
using TestProject.DelegateTest;
using TestProject.EventText;
using TestProject.CollectionTest;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // 解决控制台中文乱码
            //Console.OutputEncoding = Encoding.GetEncoding(936);

            // 常量
            //const double PI = 3.14159;  
            const string Const_Str = "Welcome to the C# Wrold.";
            Console.WriteLine(Const_Str);
            //Console.WriteLine(PI);

            // Array.cs 
            //MyArray ar = new MyArray();
            var ar = new MyArray();
            ar.Run();

            //ReferenceTypes Rer = new ReferenceTypes();
            //Rer.DynamicType();

            // Enum.cs
            MyEnum e = new MyEnum();
            e.Run();

            // Interface.cs
            MyInterface Inter = new MyInterface();
            Inter.Run();

            // Method.cs
            MyMethod Met = new MyMethod();
            Met.Run();

            // Operators.cs
            MyOperators OP = new MyOperators();
            OP.Run();

            // RegularExpression.cs 正则表达式
            MyRegularExpression RE = new MyRegularExpression();
            RE.Run();

            // StringTest.cs
            MyString str = new MyString();
            str.Run();

            // StrucTest.cs
            MyStruc st = new MyStruc();
            st.Run();

            // VariAblesConst.cs
            InputCustomers i = new InputCustomers();
            i.InputCustomer("Please input Int:");

            // NameSpace.cs
            MyNameSpace NS = new MyNameSpace();
            NS.Run();

            // DataTypes.cs
            MyDataType DT = new MyDataType();
            DT.Run();

            // MultipleInherit.cs
            InheritClass02 Inh02 = new InheritClass02();
            Inh02.Run();

            // RectangleText RT = new RectangleText(10, 20);

            // Polymorphism.cs
            MyPolymorphism PP = new MyPolymorphism();
            PP.Run();

            // FilesTest.cs
            MyFiles file = new MyFiles();
            file.Run();

            // DirectoryTest.cs
            MyDirectory Dir = new MyDirectory();
            Dir.Run();

            // AttributeTest.cs
            MyAttributes AB = new MyAttributes();
            AB.Run();

            // PropertyTest.cs
            MyProperty pp = new MyProperty();
            pp.Run();

            // IndexerTest.cs
            var id = new MyIndexer(5);
            id.Run();

            // DelegateTest.cs
            var DL = new MyDelegate();
            DL.Run();

            //
            MyEvent ee = new MyEvent();
            ee.Run();

            // CollectionTest.cs
            MyCollection cc = new MyCollection();
            cc.Run();

            #region 预处理指令
            // #define 定义一个符号，这个符号会作为一个表达式传递给 #if 指令，这个判断会得到 ture 的 结果。
            //#if (PI)
            //            Console.WriteLine("PI is defined");
            //#else
            //            Console.WriteLine("PI is not defined");
            //#endif

            //#if (DEBUG && !VC_V10)
            //            Console.WriteLine("DEBUG is defined");
            //#elif (!DEBUG && VC_V10)
            //            Console.WriteLine("VC_V10 is defined");
            //#elif (DEBUG && VC_V10)
            //            Console.WriteLine("DEBUG and VC_V10 are defined");
            //#else
            //           Console.WriteLine("DEBUG and VC_V10 are not defined");
            //#endif
            #endregion

            // RandomNumber.cs
            MyRandom rd = new MyRandom();
            rd.Run();

            // 
            MyTest tt = new MyTest();
            tt.Test();

            Console.ReadKey();
        }

        //保留关键字
        // 	as checked  case explicit extern fixed volatile
        // 	goto implicit is lock out (generic modifier) unchecked unsafe stackalloc

        // char\class\double\else\false\float\for\foreach\if\int\long\namespace\new\object\void
        // private\protected\public\return\short\sizeof\static\string\true\try\typeof\using\bool
        // const\this\do\enum\continue\decimal\byte\break\sbyte\interface\switch\catch\null\ulong
        // ushort\uint\while\default\finally\ref\out\params\operator\sealed\abstract\virtual\struct
        // internal\override\base\throw\in in (generic modifier)\readonly\delegate\event
        // 


        //上下文关键字
        // add alias ascending descending from group into let orderby partial(type) partial(method) remove

        // dynamic\global\join\get


        // 转义字符
        //  \   \ 字符         \'	' 字符       \"	" 字符
        // \?   ? 字符         \a   Alet 或 bell     \b   退格键
        // \f   换页符     \n   换行符     \r   回车    \t   水平制表符
        // \v   垂直制表符    \ooo     一到三位的八进制数    \xhh...  一个或多个数字的十六进制数
    }
}
