using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Example;

// 数组存储一个大小固定的顺序集合中相同类型的元素。

// Array 类 定义在系统命名空间中，它是基类所有的数组，并使用数组提供了各种属性和方法
namespace TestProject.ArraryTest
{
    class MyArray
    {
        // 声明数组
        int[] IntArray = new int[] { };
        int[] IntArray2 = { };
        string[] StrArray = { };
        
        // 在声明数组的同时给它赋值
        public double[] balance = { 1.0, 2.0, 3.0 };

        // 创建和初始化一个数组
        int[] marks = new int[5] { 99, 98, 92, 97, 95 };
        int[] marks2 = new int[] { 99, 98, 92, 97, 95 };

        // 可以将一个数组变量赋给另一个目标,两个数组都指向同一内存地址。
        int[] marks3 = new int[] { 99, 98, 92, 97, 95 };
        // 报错  int[] score = marks3;

        private Boolean flag = false;

        public MyArray(bool f = false) { flag = f; }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------CreateArrary--------------");
                CreateArrary(5);

                Console.WriteLine("--------------MultipleArray--------------");
                MultipleArray();

                Console.WriteLine("--------------PassArray--------------");
                int[] balance = new int[] { 1000, 2, 3, 17, 50 };
                PassArray(balance, balance.Length);

                Console.WriteLine("--------------ParamsArray--------------");
                Console.WriteLine(ParamsArray(10, 20, 30, 17, 50));

                Console.WriteLine("--------------ArrayMethod--------------");
                ArrayMethod();

                Console.ReadKey();
            }
        }

        private int[] CreateArrary(int num)
        {
            int[] IntArrary = new int[num];

            for (int i = 0; i < num; i++)
            {
                IntArrary[i] = i;
                Console.WriteLine("Count {0} and value is {1}", i, IntArrary[i]);
            }

            // 使用 foreach 遍历数组
            foreach (int j in IntArrary)
            {
                Console.WriteLine("IntArrary is {0}", IntArrary[j]);
            }

            return IntArrary;
        }

        // 多维数组(矩阵)
        private void MultipleArray()
        {
            string[,] names;    // 二维数组

            int[,,] m;      // 三维数组

            int[,] MultipleArrayX = new int[2, 3] {
                {1, 2, 3},  /*  初始化索引号为 0 的行 */
                {4, 5, 6}   /*  初始化索引号为 1 的行 */
            };

            int rank = MultipleArrayX.Rank;
            Console.WriteLine("Multiple is {0}", rank);
            int xLength = MultipleArrayX.GetLength(1);
            Console.WriteLine("Multiple {0} have {1} element", 1, rank);

            for (int i = 0; i < 2; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine("MultipleArrayX[{0},{1}] is {2}", i, j, MultipleArrayX[i, j]);
                }
            }

            int[,,] muarr = new int[2, 2, 3] {
              {{1,2,3},{4,5,6}},
              {{7,8,9},{2,3,4}}
            };
        }

        // 交错数组(数组的数组)
        private void JaggedArray()
        {
            int[][] scores = new int[5][];
            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = new int[4];
            }

            int[][] scores1 = new int[2][] { new int[] { 92, 93, 94 }, new int[] { 85, 66, 87, 88 } };


        }

        // 传递数组给函数
        private void PassArray(int[] arr, int size)
        {
            double avg;
            int sum = 0;

            for (int i = 0; i < size; ++i)
            {
                sum += arr[i];
            }

            avg = (double)sum / size;
            Console.WriteLine("avg is : " + avg);
        }

        // 参数数组
        private int ParamsArray(params int[] arr)
        {
            int sum = 0;

            foreach(int i in arr) sum += i;

            return sum;
        }

        // Array类的属性
        private void ArrayProperty()
        {
            //IsFixedSize,获取一个值，该值指示数组是否带有固定大小。
            //IsReadOnly,获取一个值，该值指示数组是否只读。
            //Length,获取一个 32 位整数，该值表示所有维度的数组中的元素总数。
            //LongLength,获取一个 64 位整数，该值表示所有维度的数组中的元素总数。
            //Rank,获取数组的秩（维度）。
        }

        // Array 类的方法
        private void ArrayMethod()
        {
            int[] marks1 = { 99, 98, 92, 97, 95 };
            int[] marks2 = { };

            Console.Write("Origin: ");
            foreach (int i in marks1)
                Console.Write(i + " ");

            //Clear, 根据元素的类型，设置数组中某个范围的元素为零、为 false 或者为 null。
            //Array.Clear(marks1, 0, marks1.Length);

            //Copy(Array, Array, Int32)
            //从数组的第一个元素开始复制某个范围的元素到另一个数组的第一个元素位置。长度由一个 32 位整数指定。

            //CopyTo(Array, Int32)
            //从当前的一维数组中复制所有的元素到一个指定的一维数组的指定索引位置。索引由一个 32 位整数指定。

            //GetLength, 获取一个 32 位整数，该值表示指定维度的数组中的元素总数。

            //GetLongLength, 获取一个 64 位整数，该值表示指定维度的数组中的元素总数。

            //GetLowerBound, 获取数组中指定维度的下界。

            //GetType, 获取当前实例的类型。从对象（Object）继承。

            //GetUpperBound, 获取数组中指定维度的上界。

            //GetValue(Int32), 获取一维数组中指定位置的值。索引由一个 32 位整数指定。

            //IndexOf(Array, Object), 搜索指定的对象，返回整个一维数组中第一次出现的索引。

            //Reverse(Array), 逆转整个一维数组中元素的顺序。
            Array.Reverse(marks1);
            Console.WriteLine("\nReverse is: ");
            foreach (int i in marks1)
                Console.Write(i + " ");

            //SetValue(Object, Int32)
            //给一维数组中指定位置的元素设置值。索引由一个 32 位整数指定。

            //Sort(Array), 使用数组的每个元素的 IComparable 实现来排序整个一维数组中的元素。
            Array.Sort(marks1);
            Console.WriteLine("\nSort is: ");
            foreach (int i in marks1)
                Console.Write(i + " ");

            //ToString, 返回一个表示当前对象的字符串。从对象（Object）继承。
        }
    }
}
