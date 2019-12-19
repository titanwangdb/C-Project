using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

// 正则表达式

// https://www.runoob.com/csharp/csharp-regular-expressions.html

namespace TestProject.LibTest
{
    class MyRegularExpression
    {

        Boolean flag;
        string str = "A Thousand Splendid Suns";
        string str2 = "make maze and manage to measure it";
        private string str3 = "/home/grapecity/Databinding_Details_XY.json";

        public MyRegularExpression(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------GetMatch--------------");
                GetMatch(str, @"\bS\S*");           // s 开头的单词
                GetMatch(str2, @"\bm\S*e\b");       // m 开头 e 结尾的单词

                Console.WriteLine("--------------ReplaceOne--------------");
                ReplaceOne(str3);

                Console.ReadKey();
            }
            
        }

        public void GetMatch(string text, string expr)
        {
            Console.WriteLine("The Expression: " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
                Console.WriteLine(m);
        }

        public void ReplaceOne(string s)
        {
            Console.WriteLine("Orign: " + s);
            Regex r = new Regex("_");
            s = r.Replace(s, "/", 1);
            Console.WriteLine("After: " + s);
        }
    }
}
