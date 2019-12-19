using System;
using System.Collections.Generic;
using System.Text;

/*
 索引器（Indexer）
     */
namespace TestProject.IndexerTest
{
    class MyIndexer
    {
        Boolean flag;
        // public static int size = 10;
        // private string[] list = new string[size];
        public int size;
        private string[] list;

        public MyIndexer(int size = 10, bool f = false)
        {
            flag = f;
            this.size = size;
            list = new string[size];

            for (int i = 0; i < size; i++) list[i] = "N.A";
        }

        public void Run()
        {
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------Indexer--------------");
                    var names = new MyIndexer();
                    names[0] = "Zara";
                    names[1] = "Riz";

                    for(int i = 0; i < size; i++) Console.WriteLine(names[i]);

                    Console.WriteLine("--------------Indexer()--------------");
                    Console.WriteLine(names["Riz"]);

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if( index >= 0 && index <= size -1) tmp = list[index];
                else tmp = "";
                return tmp;
            }
            set
            {
                if (index >= 0 && index <= size - 1) list[index] = value;
            }
        }

        // 重载索引器（Indexer）
        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (list[index] == name) return index;
                    index++;
                }
                return index;
            }
        }
    }
}
