using System;
using System.Collections.Generic;
using System.Text;

// 字符串,使用 string 关键字来声明一个字符串变量

namespace TestProject.StringsTest
{
    class MyString
    {
        public readonly string URL;

        Boolean flag;

        public MyString(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------CString--------------");
                CString();

                Console.WriteLine("--------------StringMethods--------------");
                StringMethods();

                Console.ReadKey();
            }

        }

        //通过指定一个字符串给一个字符串变量
        //通过使用 String 类的构造函数
        //通过检索属性或调用返回一个字符串的方法

        public void CString()
        {
            string fname, lname;
            fname = "Rowan";
            lname = "Atkinson";

            //通过使用字符串连接运算符(+)
            Console.WriteLine("Full Name: {0}", fname + lname);  //Full Name: RowanAtkinson

            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings); //Greetings: Hello

            string[] sarray = { "Hello", "From", "Tutorials", "Point" };
            string message = String.Join("-", sarray);
            Console.WriteLine("Message: {0}", message); //Message: Hello-From-Tutorials-Point

            //通过调用格式化方法的值或对象转换成它的字符串表示
            DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Message: {0}", chat);
            //Message: Message sent at 5:58 PM on Wednesday, October 10, 2012
        }

        public void StringMethods()
        {
            string fname = "Rowan Atkinson";
            string lname = "Welcome boy.";
            string[] sarray = { "Hello", "From", "Tutorials", "Point" };

            Console.WriteLine("Name is: " + fname);

            // String 类的属性
            Console.WriteLine("Name Length: " + fname.Length); // Length 获取字符在当前字符串对象的数目
            // Chars 获取在当前字符串对象中的指定位置的字符对象


            // String 类的方法

            //Compare(string strA, string strB)
            //比较两个指定的字符串对象，并返回一个整数，指示其在排序顺序相对位置
            Console.WriteLine("---Compare(string strA, string strB)---");
            if (String.Compare(fname, lname) == 0)
                Console.WriteLine("'{0}' equal '{1}'", fname, lname);
            else
                Console.WriteLine("'{0}' not equal '{1}'", fname, lname);

            //Compare(string strA, string strB, bool ignoreCase)
            //比较两个指定的字符串对象，并返回一个整数，指示其在排序顺序相对位置。但是，它忽略情况下，如果布尔参数为true
            Console.WriteLine("---Compare(string strA, string strB, bool ignoreCase)---");
            int index = String.Compare(fname, lname, true); // -1
            if (index == 0)
                Console.WriteLine("'{0}' equal '{1}'", fname, lname);
            else
                Console.WriteLine("'{0}' not equal '{1}'", fname, lname);

            //Concat(string str0, string str1) 连接两个字符串对象
            //Concat(string str0, string str1, string str2) 拼接三个字符串对象
            //Concat(string str0, string str1, string str2, string str3) 连接四个字符串对象

            //Contains(string value)  返回(true\false)
            Console.WriteLine("---Contains(string value)---");
            string contain = "Atkinson1";
            Console.WriteLine("'{0}' {2} '{1}'", fname, contain, fname.Contains(contain) ? "Contains" : "not Contains");

            //Copy(string str)
            //创建具有相同的值作为指定字符串的新String对象

            //CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count)
            //复制从字符串对象到指定位置Unicode字符数组的指定位置指定的字符数

            //EndsWith(string value)
            //确定字符串对象的末尾是否与指定的字符串匹配
            Console.WriteLine("---EndsWith(string value)---");
            var flag = contain.EndsWith("1") ? "ok" : "Pok";
            Console.WriteLine(contain.EndsWith("1") ? "ok" : "Pok");

            //Equals(string value)
            //确定当前字符串对象，并指定字符串对象是否具有相同的值

            //Equals(string a, string b)
            //确定两个指定的String对象是否具有相同的值

            //Format(string format, Object arg0)
            //替换指定的字符串指定对象的字符串表示在一个或多个格式项

            //IndexOf(char value)
            //返回当前字符串指定Unicode字符中第一次出现从零开始的索引

            //IndexOf(string value)
            //返回在这种情况下指定字符串中第一次出现从零开始的索引

            //IndexOf(char value, int startIndex)
            //返回此字符串指定Unicode字符中第一次出现从零开始的索引，搜索开始在指定的字符位置

            //IndexOf(string value, int startIndex)
            //返回在这种情况下指定字符串中第一次出现的从零开始的索引，搜索开始在指定的字符位置

            //IndexOfAny(char[] anyOf)
            //返回Unicode字符指定数组中第一次出现的任何字符的这个实例从零开始的索引

            //IndexOfAny(char[] anyOf, int startIndex)
            //返回Unicode字符指定数组，开始搜索从指定字符位置中第一次出现的任何字符的这个实例从零开始的索引

            //Insert(int startIndex, string value)
            //返回在指定的字符串被插入在当前字符串对象指定索引位置一个新的字符串

            //IsNullOrEmpty(string value) 指示指定的字符串是否为空或空字符串

            //Join(string separator,params string[] value) 连接字符串数组中的所有元素，使用指定的分隔
            Console.WriteLine("---Join(string separator,params string[] value)---");
            string str = String.Join("-", sarray);
            Console.WriteLine(str);  // Hello-From-Tutorials-Point

            //Join(string separator, string[] value, int startIndex, int count)
            Console.WriteLine("---Join(string separator, string[] value, int startIndex, int count)---");
            str = String.Join("-", sarray, 1, 2);
            Console.WriteLine(str);     // From-Tutorials

            //LastIndexOf(char value)
            //返回当前字符串对象中指定的Unicode字符的最后出现从零开始的索引位置

            //LastIndexOf(string value)
            //返回当前字符串对象中的指定字符串最后一次出现的从零开始的索引位置

            //Remove(int startIndex)
            //删除在当前实例中的所有字符，开始在指定的位置，并继续通过最后位置，并返回字符串

            //Remove(int startIndex, int count)
            //删除在当前字符串的字符开始的指定位置的指定数量，并返回字符串

            //Replace(char oldChar, char newChar)
            //替换与指定的Unicode字符当前字符串对象指定的Unicode字符的所有匹配，并返回新的字符串

            //Replace(string oldValue, string newValue)
            //替换用指定的字符串当前字符串对象指定的字符串的所有匹配，并返回新的字符串

            //Split(params char[] separator)
            //返回一个字符串数组，其中包含的子字符串在当前字符串对象，由指定的Unicode字符数组的元素分隔

            //Split(char[] separator, int count)
            //返回一个字符串数组，其中包含的子字符串在当前字符串对象，由指定的Unicode字符数组的元素分隔。整型参数指定的子串返回最大数量

            //3StartsWith(string value) 确定此字符串实例的开头是否与指定的字符串匹配

            //ToCharArray() 返回一个Unicode字符数组，在当前字符串对象中的所有字符

            //ToCharArray(int startIndex, int length)
            //返回一个Unicode字符数组，在当前字符串对象中的所有字符，从指定的索引开始，并到指定的长度

            //ToLower() 转换为小写

            //ToUpper() 转换为大写

            //Trim() 去除所有开头和结尾的空白字符

            // Substring 获取一个子字符串
            Console.WriteLine("---Substring---");
            string substr = fname.Substring(6);
            Console.WriteLine(substr);  // Atkinson
        }

    }
}
