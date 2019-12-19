using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace TestProject.DirectoryFiles
{
    class MyDirectory
    {
        Boolean flag;

        public MyDirectory(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            string DirPath = @"D:\c#\TestProject";
            string CreDir = @"D:\c#\TestProject\TestProject\Resources\test";
            try
            {
                if (flag)
                {
                    Console.WriteLine("--------------Directory.Exists--------------");
                    if (IsExistDirectory(DirPath)) Console.WriteLine("There are {0}", DirPath);

                    Console.WriteLine("--------------Directory.CreateDirectory--------------");
                    CreateDirectory(CreDir);

                    Console.WriteLine("--------------Directory.GetFiles--------------");
                    string[] files = GetFilesName(DirPath);
                    foreach (string f in files) Console.WriteLine(f);
                    Array.Clear(files, 0, files.Length);

                    Console.WriteLine("--------------Directory.GetFiles(Child)--------------");
                    files = GetFilesName(DirPath, "*");
                    foreach (string f in files) Console.WriteLine(f);
                    Array.Clear(files, 0, files.Length);

                    Console.WriteLine("--------------Get All JSON Files--------------");
                    files = GetFilesName(DirPath, "*.json");
                    foreach (string f in files) Console.WriteLine(f);

                    Console.WriteLine("--------------Get Files Name--------------");
                    foreach (string f in files)
                        Console.WriteLine("File Name: " + GetFileName(f) + " File Name(No) : "
                            + GetFileName(f, "No") + " File Extension: "
                            + GetFileName(f, "Extension"));

                    Console.WriteLine("--------------Directory.GetDirectories--------------");
                    string[] dirs = GetDirectory(DirPath);
                    foreach (string d in dirs) Console.WriteLine(d);
                    Array.Clear(dirs, 0, dirs.Length);

                    Console.WriteLine("-------------Get All Directory(Child)--------------");
                    dirs = GetDirectory(DirPath, "*");
                    foreach (string d in dirs) Console.WriteLine(d);

                    Console.WriteLine("--------------Directory.GetDirectories--------------");
                    Console.WriteLine(IsEmptydirectory(DirPath) ? "the directory is empty" : "the directory does not empty.");

                    Console.WriteLine("--------------Directory.Delete--------------");
                    DeleteDirectory(CreDir);

                    Console.ReadKey();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public bool IsExistDirectory(string dir)
        {
            return Directory.Exists(dir);
        }

        public void CreateDirectory(string dir)
        {
            if (!IsExistDirectory(dir)) Directory.CreateDirectory(dir);
        }

        public void DeleteDirectory(string dir)
        {
            if (IsExistDirectory(dir)) Directory.Delete(dir);
        }

        public string[] GetFilesName(string dir)
        {
            if (!IsExistDirectory(dir)) throw new FileNotFoundException();
            return Directory.GetFiles(dir);
        }

        public string[] GetFilesName(string dir, string search, bool isSearchChild = true)
        {
            /* include child directory */
            if (!IsExistDirectory(dir)) throw new FileNotFoundException();

            if (isSearchChild)
                return Directory.GetFiles(dir, search, SearchOption.AllDirectories);
            else
                return Directory.GetFiles(dir, search, SearchOption.TopDirectoryOnly);
        }

        public string[] GetDirectory(string dir)
        {
            if (!IsExistDirectory(dir)) throw new FileNotFoundException();

            return Directory.GetDirectories(dir);
        }

        public string[] GetDirectory(string dir, string search, bool isSearchChild = true)
        {
            /* include child directory */
            if (!IsExistDirectory(dir)) throw new FileNotFoundException();

            if(isSearchChild)
                return Directory.GetDirectories(dir, search, SearchOption.AllDirectories);
            else
                return Directory.GetDirectories(dir, search, SearchOption.TopDirectoryOnly);
        }

        public bool IsEmptydirectory(string dir)
        {
            string[] fileName = GetFilesName(dir);
            string[] dirName = GetDirectory(dir);

            if (fileName.Length > 0 && dirName.Length > 0) return false; // not empty

            return true; // empty
        }

        public void CopyFolder(string Origin, string Target)
        {
            if (!IsExistDirectory(Origin)) return;

            CreateDirectory(Target);

            string[] directiory = GetDirectory(Origin, "*");


        }

        public string GetFileName(string dir, string flag = "ALL")
        {
            FileInfo f = new FileInfo(dir);
            switch (flag)
            {
                case ("ALL"): return f.Name;
                case ("No"): return f.Name.Split('.')[0];
                case ("Extension"): return f.Extension;
                default: return f.Name;
            }
        }

        public void Print()
        {
            string dirPath = @"D:\TestDir";
            string filePath = @"D:\TestDir\TestFile.txt";

            Console.WriteLine("Type is:" + typeof(string));

            Console.WriteLine("Size is:" + sizeof(int));

            // C:\Program Files\dotnet\dotnet.exe
            Console.WriteLine(Process.GetCurrentProcess().MainModule.FileName);

            // D:\c#\TestProject\TestProject\bin\Debug\netcoreapp2.0
            Console.WriteLine(Environment.CurrentDirectory);

            // D:\c#\TestProject\TestProject\bin\Debug\netcoreapp2.0
            Console.WriteLine(Directory.GetCurrentDirectory());

            // D:\c#\TestProject\TestProject\bin\Debug\netcoreapp2.0\
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory);

            // D:\c#\WpfApp1\ConsoleApp1\bin\Debug
            //Console.WriteLine(AppDomain.CurrentDomain.SetupInformation.ApplicationBase);

            //文件或文件夹所在目录
            Console.WriteLine(Path.GetDirectoryName(dirPath));
            Console.WriteLine(Path.GetDirectoryName(filePath));
            //文件扩展名
            Console.WriteLine(Path.GetExtension(filePath));         //.txt
            //文件名
            Console.WriteLine(Path.GetFileName(filePath));          //TestFile.txt
            Console.WriteLine(Path.GetFileName(dirPath));           //TestDir
            Console.WriteLine(Path.GetFileNameWithoutExtension(filePath)); //TestFile
            //绝对路径
            Console.WriteLine(Path.GetFullPath(filePath));          //D:\TestDir\TestFile.txt
            Console.WriteLine(Path.GetFullPath(dirPath));           //D:\TestDir  
            //更改扩展名
            Console.WriteLine(Path.ChangeExtension(filePath, ".jpg"));//D:\TestDir\TestFile.jpg
            //根目录
            Console.WriteLine(Path.GetPathRoot(dirPath));           //D:\  
        }
    }
}
