using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using TestProject.LibTest;

/*集合（Collection）专门用于数据存储和检索的类。
 * 提供了对栈（stack）、队列（queue）、列表（list）和哈希表（hash table）的支持。
 */
namespace TestProject.CollectionTest
{
    class MyCollection
    {
        Boolean flag;
        MyRandom rd = new MyRandom();

        public MyCollection(bool f = false) { flag = f; }

        public void Run()
        {
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------ArrayList--------------");
                    MyArrayList(10);

                    Console.WriteLine("--------------Hashtable--------------");
                    MyHashtable();
                    
                    Console.WriteLine("--------------SortedList--------------");

                    Console.WriteLine("--------------Stack--------------");

                    Console.WriteLine("--------------Queue--------------");

                    Console.WriteLine("--------------BitArray--------------");

                    Console.ReadKey();
                }
            } 
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /* 动态数组（ArrayList）	 代表了可被单独索引的对象的有序集合。*/
        public void MyArrayList(int len)
        {
            ArrayList al = new ArrayList();
            /* 属性 */
            // Capacity	获取或设置 ArrayList 可以包含的元素个数。
            // Count	获取 ArrayList 中实际包含的元素个数。
            // IsFixedSize	获取一个值，表示 ArrayList 是否具有固定大小。
            // IsReadOnly	获取一个值，表示 ArrayList 是否只读。
            // Item	获取或设置指定索引处的元素。

            /* 方法 */
            // Add( object value );  在 ArrayList 的末尾添加一个对象。
            Console.WriteLine("---Add---");
            for (int i = 0; i < len; i++)
            {
                al.Add(rd.CRandom(0, 100));
                Console.Write(al[i] + " ");
            }

            Console.WriteLine("\n---Capacity---" + al.Capacity);  // 16
            Console.WriteLine("---Count---" + al.Count);        // 10

            // AddRange( ICollection c );  在 ArrayList 的末尾添加 ICollection 的元素。

            // Contains( object item );  判断某个元素是否在 ArrayList 中。
            Console.WriteLine("---Contains---");
            Console.WriteLine("50 {0} in al.", (al.Contains(50) ? "has" : "does not"));

            // GetRange( int index, int count );  返回一个 ArrayList，表示源 ArrayList 中元素的子集。

            // IndexOf(object); 返回某个值在 ArrayList 中第一次出现的索引，索引从零开始。

            // Insert( int index, object value );  在 ArrayList 的指定索引处，插入一个元素。

            // InsertRange( int index, ICollection c );  在 ArrayList 的指定索引处，插入某个集合的元素。

            // Remove( object obj );  从 ArrayList 中移除第一次出现的指定对象。

            // RemoveAt( int index );  移除 ArrayList 的指定索引处的元素。 

            // RemoveRange( int index, int count ); 从 ArrayList 中移除某个范围的元素。

            // Reverse(); 逆转 ArrayList 中元素的顺序。
            Console.WriteLine("---Reverse---");
            al.Reverse();
            for (int i = 0; i < al.Count; i++) Console.Write(al[i] + " ");

            // SetRange( int index, ICollection c );  复制某个集合的元素到 ArrayList 中某个范围的元素上。

            // Sort(); 对 ArrayList 中的元素进行排序。
            Console.WriteLine("\n---Sort---");
            al.Sort();
            for (int i = 0; i < al.Count; i++) Console.Write(al[i] + " ");

            // TrimToSize(); 设置容量为 ArrayList 中元素的实际个数。

            // Clear(); 从 ArrayList 中移除所有的元素。
            Console.WriteLine("\n---Clear---");
            al.Clear();
            for (int i = 0; i < al.Count; i++) Console.Write(al[i] + " ");
        }

        /* 哈希表（Hashtable）	 使用键来访问集合中的元素。*/
        public void MyHashtable()
        {
            string[] lst = new string[] { "Zara Ali", "Abida Rehman", "Joe Holzner", "M. Amlan" , "M. Arif" };

            Hashtable ht = new Hashtable();

            /* 属性 */
            // Count	获取 Hashtable 中包含的键值对个数。
            // IsFixedSize	获取一个值，表示 Hashtable 是否具有固定大小。
            // IsReadOnly	获取一个值，表示 Hashtable 是否只读。
            // Item	获取或设置与指定的键相关的值。
            // Keys	获取一个 ICollection，包含 Hashtable 中的键。
            // Values	获取一个 ICollection，包含 Hashtable 中的值。

            /* 方法 */
            // Add( object key, object value ); 向 Hashtable 添加一个带有指定的键和值的元素。
            Console.WriteLine("---Add---");
            for (int i = 0; i < lst.Length; i++)
            {
                ht.Add(i, lst[i]);
                Console.Write(i + " " + lst[i] + " ");
            }

            Console.WriteLine("\n---Keys---");
            // 获取键的集合
            ICollection key = ht.Keys;
            foreach (int i in key) Console.Write(i + " ");

            // ContainsKey( object key ); 判断 Hashtable 是否包含指定的键。
            Console.WriteLine("\n---ContainsKey---");
            if (ht.ContainsKey(2)) Console.WriteLine("The ht key have 2.");

            // ContainsValue( object value ); 判断 Hashtable 是否包含指定的值。
            Console.WriteLine("---ContainsValue---");
            if (ht.ContainsValue("M. Amlan")) Console.WriteLine("The ht have M. Amlan.");

            // Remove( object key ); 从 Hashtable 中移除带有指定的键的元素。
            Console.WriteLine("---Remove---");

            // Clear(); 从 Hashtable 中移除所有的元素。
            Console.WriteLine("---Clear---");
        }

        /* 排序列表（SortedList） 可以使用键和索引来访问列表中的项。*/
        public void MySortedList()
        {
            /* 属性 */
            // Capacity	获取或设置 SortedList 的容量。
            // Count	获取 SortedList 中的元素个数。
            // IsFixedSize	获取一个值，表示 SortedList 是否具有固定大小。
            // IsReadOnly	获取一个值，表示 SortedList 是否只读。
            // Item	获取或设置与 SortedList 中指定的键相关的值。
            // Keys	获取 SortedList 中的键。
            // Values	获取 SortedList 中的值。

            /* 方法 */
            // public virtual void Add( object key, object value ); 向 SortedList 添加一个带有指定的键和值的元素。
            
            
            // public virtual void Clear(); 从 SortedList 中移除所有的元素。
            
            
            // public virtual bool ContainsKey( object key ); 判断 SortedList 是否包含指定的键。
            
            
            // public virtual bool ContainsValue( object value ); 判断 SortedList 是否包含指定的值。
            
            
            // public virtual object GetByIndex( int index ); 获取 SortedList 的指定索引处的值。
            
            
            // public virtual object GetKey( int index ); 获取 SortedList 的指定索引处的键。
            
            
            // public virtual IList GetKeyList(); 获取 SortedList 中的键。
            
            
            // public virtual IList GetValueList(); 获取 SortedList 中的值。
            
            
            // public virtual int IndexOfKey( object key ); 返回 SortedList 中的指定键的索引，索引从零开始。
            
            
            // public virtual int IndexOfValue( object value ); 返回 SortedList 中的指定值第一次出现的索引，索引从零开始。
            
            
            // public virtual void Remove( object key ); 从 SortedList 中移除带有指定的键的元素。
            
            
            // public virtual void RemoveAt( int index ); 移除 SortedList 的指定索引处的元素。
            
            
            // public virtual void TrimToSize(); 设置容量为 SortedList 中元素的实际个数。
        }

        /* 堆栈（Stack）	 代表了一个后进先出的对象集合。*/

        /* 队列（Queue）	 代表了一个先进先出的对象集合。*/

        /* 点阵列（BitArray）	 代表了一个使用值 1 和 0 来表示的二进制数组。*/

    }
}
