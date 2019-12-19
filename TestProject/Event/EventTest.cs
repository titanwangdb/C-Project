using System;
using System.Collections.Generic;
using System.Text;

/* 事件（Event）
 * 包含事件的类用于发布事件。这被称为 发布器（publisher）类。
 * 其他接受该事件的类被称为 订阅器（subscriber）类
 */

namespace TestProject.EventText
{
    class MyEvent
    {
        Boolean flag;

        public MyEvent(bool f = false) { flag = f; }

        public void Run()
        {
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------Event--------------");
                    /* 实例化对象,第一次没有触发事件 */
                    EventTest e = new EventTest();
                    /* 实例化对象 */
                    subscribEvent s = new subscribEvent();
                    /* 注册 */
                    e.ChangeNum += new EventTest.NumManipulationHandler(s.Print); // event not fire

                    e.SetValue(6);  // event fire
                    e.SetValue(10); // event fire

                    Console.WriteLine("--------------Event Case--------------");

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    /* 发布器（publisher）类 */
    public class EventTest
    {
        /* 在类的内部声明事件，首先必须声明该事件的委托类型
         * 声明事件本身，使用 event 关键字
         */
        private int value;
        // 定义了一个名为 NumManipulationHandler 的委托
        public delegate void NumManipulationHandler();
        // 定义了一个名为 ChangeNum 的事件, 该事件在生成的时候会调用委托
        public event NumManipulationHandler ChangeNum;

        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }

        protected virtual void OneMumChanged()
        {
            if (ChangeNum != null) ChangeNum(); /* 事件被触发 */
            else Console.WriteLine("event not fire");
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OneMumChanged();
            }
        }
    }

    /* 订阅器（subscriber）类*/
    public class subscribEvent
    {
        public void Print() { Console.WriteLine("event fire"); }
    }

    /* Case */

}
