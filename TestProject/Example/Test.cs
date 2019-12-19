using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace TestProject.Example
{
    class MyTest
    {
        public void Test(bool flag = false)
        {
            if (flag)
            {
                string aa = "123";
                Console.WriteLine($"aa is: {aa}");

                // 
                string[] arr = { "110", "120", "119" };

                foreach (string i in arr) Console.WriteLine("Arr is: " + i);

                arr.Initialize();   // does not work
                foreach (string i in arr) Console.WriteLine("Arr is: " + i);

                Array.Clear(arr, 0, arr.Length); // ok
                foreach (string i in arr) Console.WriteLine("Arr is: " + i);

                // 
                FileVersionInfo VersionInfo = FileVersionInfo.GetVersionInfo(@"c:\Windows\Notepad.exe");
                Console.WriteLine("File: " + VersionInfo.FileDescription + '\n' + "Version number: " + VersionInfo.FileVersion);


                Console.ReadKey();
            }
        }
    }
}
