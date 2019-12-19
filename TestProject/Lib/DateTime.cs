using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace TestProject.LibTest
{
    class DateTimeTest
    {
        public string GetTime()
        {
            string format = "D";
            string format02 = "yyyy-MM-dd hh:mm:ss";
            string format03 = "yyyyMMddhhmm";

            //24小时制： DateTime dt = DateTime.Now;
            //string dt24 = dt.ToString("yyyy-MM-dd HH:mm:ss");
            //12小时制： DateTime dt = DateTime.Now;
            //string dt12 = dt.ToString("yyyy-MM-dd hh:mm:ss");
            //H的大小写决定

            DateTime date = DateTime.Now;
            Console.WriteLine("date: " + date);     // 6/17/2019 2:42:52 PM
            Console.WriteLine("date: " + date.ToString(format, DateTimeFormatInfo.InvariantInfo)); // Monday, 17 June 2019
            Console.WriteLine("date: " + date.ToString(format02, DateTimeFormatInfo.InvariantInfo));  // 2019-06-17 02:45:22

            DateTime dt = new DateTime(2017, 4, 1, 13, 16, 32, 108);
            Console.WriteLine(string.Format("{0:y yy yyy yyyy}", dt)); // 17 17 2017 2017
            //string.Format("{0:M MM MMM MMMM}", dt);//4  04 四月 四月
            //string.Format("{0:d dd ddd dddd}", dt);//1  01 周六 星期六
            //string.Format("{0:t tt}", dt);//下 下午
            //string.Format("{0:H HH}", dt);//13 13
            //string.Format("{0:h hh}", dt);//1  01
            //string.Format("{0:m mm}", dt);//16 16
            //string.Format("{0:s ss}", dt);//32 32
            //string.Format("{0:F FF FFF FFFF FFFFF FFFFFF FFFFFFF}", dt);//1 1  108 108  108   108    108
            //string.Format("{0:f ff fff ffff fffff ffffff fffffff}", dt);//1 10 108 1080 10800 108000 1080000
            //string.Format("{0:z zz zzz}", dt);//+8 +08 +08:00

            //string.Format("{0:yyyy/MM/dd HH:mm:ss.fff}", dt);  //2017/04/01 13:16:32.108
            //string.Format("{0:yyyy/MM/dd dddd}", dt);      //2017/04/01 星期六
            //string.Format("{0:yyyy/MM/dd dddd tt hh:mm}", dt); //2017/04/01 星期六 下午 01:16
            //string.Format("{0:yyyyMMdd}", dt);         //20170401
            //string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", dt);　//2017-04-01 13:16:32.108

            return date.ToString(format03, DateTimeFormatInfo.InvariantInfo);
        }

        public int GetTimeStamp(DateTime dt)
        {
            DateTime dateStart = new DateTime(1970, 1, 1, 8, 0, 0);
            int timeStamp = Convert.ToInt32((dt - dateStart).TotalSeconds);
            return timeStamp;
        }

        //System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo("F:\\2012DMC");
        //DateTime DT = dir.CreationTime;//获取目录或者文件的创建 日期
    }
}
