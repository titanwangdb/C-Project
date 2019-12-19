using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

// https://blog.csdn.net/cjolj/article/details/59484045

namespace TestProject.LibTest
{
    class MyRandom
    {
        Boolean flag;
        public MyRandom(bool f = false) { flag = f; }

        public void Run()
        {
            if (flag)
            {
                Console.WriteLine("--------------CRandom--------------");
                Console.WriteLine(CRandom());

                Console.WriteLine("--------------CGuid--------------");
                Console.WriteLine(CGuid("N"));
                Console.WriteLine(CGuid("D"));
                Console.WriteLine(CGuid("B"));
                Console.WriteLine(CGuid("P"));
                Console.WriteLine(CGuid("X"));
                Console.WriteLine(CGuid());

                Console.WriteLine(CGuidSeed());

                Console.WriteLine("--------------CRNG--------------");
                CRNG();
                // Console.WriteLine(CRNG(5));

                Console.ReadKey();
            }
        }

        public int CRandom(int min = 0, int max = 100)
        {
            /* 这种随机数可以达到一些要求较低的目标,但是如果在高并发的情况下,
             * Random类所取到的系统时钟种子接近甚至完全一样,就很有可能出现重复*/
            int result;

            Random rd = new Random();
            result = rd.Next(min, max); // 生成 min~max 之间的随机数，不包括 max

            return result;
        }

        public string CGuid(string f = "")
        {
            /* GUID (Globally Unique Identifier) 全球唯一标识符 
             * 计算出的128位整数(16字节)可以接近唯一的输出
             */
            string result;

            switch(f)
            {
                case "N":
                    result = Guid.NewGuid().ToString(f); // 90b07030fd68461fa12ad09453ee51d7
                    break;
                case "D":
                    result = Guid.NewGuid().ToString(f);  // 64bf2523-abcb-4445-b803-dec2c21efcc7
                    break;
                case "B":
                    result = Guid.NewGuid().ToString(f);  // {839c8d07-8821-405d-8a40-cbc1107467d7}
                    break;
                case "P":
                    result = Guid.NewGuid().ToString(f); // (054b0442-4532-49d4-80ee-ec3e70337a7e)
                    break;
                case "X":
                    result = Guid.NewGuid().ToString(f); // {0xb1cf55bc,0x7349,0x42a6,{0xa5,0xa2,0x3c,0xc5,0x04,0x40,0x1f,0x42}}
                    break;
                default:
                    result = Guid.NewGuid().ToString();     // 5939a1d7-ecef-4def-b7d7-a6c5ea689c71
                    break;
            }

            return result;
        }
        
        public int CGuidSeed()
        {
            return Guid.NewGuid().GetHashCode();
        }

        public int CRNG()
        {
            /* RNGCryptoServiceProvider 类 
             使用加密服务提供程序 (CSP) 提供的实现来实现加密随机数生成器 (RNG)
             */
            byte[] bytes = new byte[4];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            rng.GetBytes(bytes);


            Console.WriteLine(BitConverter.ToInt16(bytes, 0));
            Console.WriteLine(BitConverter.ToInt32(bytes, 0));

            return BitConverter.ToInt32(bytes, 0);
        }

        // Membership.GeneratePassword()
        // Response.Write(Membership.GeneratePassword(20, 1) + "<br>");
    }
}
