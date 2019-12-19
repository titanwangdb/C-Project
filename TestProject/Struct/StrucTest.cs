using System;
using System.Collections.Generic;
using System.Text;

//结构体,一种值数据类型(值类型)。包含数据成员和方法成员。 struct 关键字是用于创建一个结构体。

//结构体的特征
//可以有方法，域，属性，索引器，操作方法，和事件。
//可以定义构造函数，但是不能构造析构函数。尽管如此，你还是不能定义一个结构体的默认构造函数。默认构造函数是自动定义的，且不能被改变。
//与类不同，结构体不能继承其他的结构体或这其他的类。
//不能用于作为其他结构或者类的基。
//可以实现一个或多个接口。
//成员不能被指定为抽象的，虚拟的，或者保护的对象。
//使用 New 运算符创建结构体对象时，将创建该结构体对象，并且调用适当的构造函数。与类不同的是，结构体的实例化可以不使用 New 运算符。
//如果不使用 New 操作符，那么在初始化所有字段之前，字段将保持未赋值状态，且对象不可用。

//类和结构体有以下几个主要的区别：
//类是引用类型，结构体是值类型
//结构体不支持继承
//结构体不能有默认构造函数


//结构体是用来代表一个记录。假设你想追踪一个图书馆的书。你可能想追踪每本书的属性如下：

struct Books
{
    // 定义结构体
    public string title;
    public string author;
    public string subject;
    public int book_id;

    public void GetValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }

    public void Display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("Book_id :{0}", book_id);
    }
}

namespace TestProject.StructsTest
{
    class MyStruc
    {

        Boolean Flag;

        public MyStruc(bool f = false)
        {
            Flag = f;
        }

        public void Run()
        {
            if (Flag)
            {
                Console.WriteLine("--------------CreateArrary--------------");
                StructText();

                Console.WriteLine("--------------CreateArrary--------------");
                StructText02();

                Console.ReadKey();
            }
        }

        public void StructText()
        {
            //声明Book1, Book2为 Book 类型
            Books Book1;
            Books Book2;

            Book1.title = "C Programming";
            Book1.author = "Nuha Ali";
            Book1.subject = "C Programming Tutorial";
            Book1.book_id = 6495407;

            Book2.title = "Telecom Billing";
            Book2.author = "Zara Ali";
            Book2.subject = "Telecom Billing Tutorial";
            Book2.book_id = 6495700;

            Console.WriteLine("Book 1 title : {0}", Book1.title);
            Console.WriteLine("Book 1 author : {0}", Book1.author);
            Console.WriteLine("Book 1 subject : {0}", Book1.subject);
            Console.WriteLine("Book 1 book_id :{0}", Book1.book_id);

            Console.WriteLine("Book 2 title : {0}", Book2.title);
            Console.WriteLine("Book 2 author : {0}", Book2.author);
            Console.WriteLine("Book 2 subject : {0}", Book2.subject);
            Console.WriteLine("Book 2 book_id : {0}", Book2.book_id);
        }

        public void StructText02()
        {
            Books Book1 = new Books();
            Books Book2 = new Books();

            Book1.GetValues("C Programming", "Nuha Ali", "C Programming Tutorial", 6495407);
            Book2.GetValues("Telecom Billing", "Zara Ali", "Telecom Billing Tutorial", 6495700);

            Book1.Display();
            Book2.Display();
        }
    }
}
