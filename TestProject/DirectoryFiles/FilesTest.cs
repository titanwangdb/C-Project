using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using TestProject.Example;

namespace TestProject.DirectoryFiles
{
    /*I/O 类   
        BinaryReader    从二进制流读取原始数据
        BinaryWriter    以二进制形式写入原始数据
        BufferedStream  字节流的临时存储
        Directory   用于操作目录结构
        DirectoryInfo   用于创建复合条件指令。
        DriveInfo 用于执行目录操作
        --File 用于操作文件
        FileInfo 用于执行文件操作
        --FileStream 用于读写文件中任意位置的内容
        MemoryStream 用于随机存取存储器中存储的流数据
        Path 用于执行有关路径信息的操作
        --StreamReader 用于从字节流中读取字符
        --StreamWriter 用于向流中写字符
        --StringReader 用于读取字符串数组
        StringWriter 用于写入字符串数组
        */

    class MyFiles
    {
        Boolean flag;

        public MyFiles(bool f = false)
        {
            flag = f;
        }

        public void Run()
        {
            string TxTFile = @"D:\c#\TestProject\TestProject\Resources\Demo.json";
            string NewTxtFile = @"D:\c#\TestProject\TestProject\Resources\Create.txt";
            string OriginFile = @"D:\c#\TestProject\TestProject\Resources\Origin\Origin.json";
            string TargetFile = @"D:\c#\TestProject\TestProject\Resources\Target\Target.json";
            string Movefile = @"D:\c#\TestProject\TestProject\Resources\Target\Target.txt";


            try
            {
                if (flag)
                {
                    // File.Open()

                    MyPrint.Print("--------------File.Create--------------");
                    FileStream NewTxt = CreateFile(NewTxtFile);
                    NewTxt.Close();

                    MyPrint.Print("--------------File.Delete--------------");
                    if (IsExistFile(NewTxtFile)) DeleteFile(NewTxtFile);

                    MyPrint.Print("--------------File.Copy--------------");
                    CopyFile(OriginFile, TargetFile);

                    MyPrint.Print("--------------File.Exists--------------");
                    if (IsExistFile(TargetFile)) MyPrint.Print("There are file {0}.", TargetFile);

                    MyPrint.Print("--------------File.Move--------------");
                    if (IsExistFile(Movefile))
                        DeleteFile(Movefile);
                    MoveFile(TargetFile, Movefile);

                    //  设置文件属性方法：File.SetAttributes

                    MyPrint.Print("--------------FileStream(TxTReaderWrite)--------------");
                    TxTReaderWrite(TxTFile);

                    MyPrint.Print("--------------FileStream(TxTReaderWrite02)--------------");
                    TxTReaderWrite02(TxTFile);

                    MyPrint.PrintReadKey();
                }  
            }
            catch (Exception e)
            {
                MyPrint.Print(e.Message);
            }
        }

        public FileStream CreateFile(string file)
        {
            return File.Create(file);
        }

        public bool IsExistFile(string file)
        {
            return File.Exists(file);
        }

        public void DeleteFile(string file)
        {
            File.Delete(file);
        }

        public void MoveFile(string OriginFile, string TargetFile)
        {
            File.Move(OriginFile, TargetFile);
        }

        public void CopyFile(string OriginFile, string TargetFile)
        {
            File.Copy(OriginFile, TargetFile, true);
        }

        // 文本文件的读写: StreamReader 和 StreamWrite
        public void TxTReaderWrite(string Path)
        {
            /*FileMode fileMode 定义了各种方法来打开文件。
                Append: 打开一个已有的文件，并将光标放置在文件的末尾。如果文件不存在，则创建文件。
                Create: 它创建一个新的文件
                CreateNew: 指定操作系统应创建一个新的文件。如果文件已存在，则抛出异常。
                Open: 它会打开一个现有的文件
                OpenOrCreate: 指定操作系统应打开一个已有的文件。如果文件不存在，则用指定的名称创建一个新的文件打开。
                Truncate: 打开一个已有的文件，文件一旦打开，就将被截断为零字节大小。

            FileAccess FileAccess：Read，ReadWrite 和 Write。

            FileShare FileShare：
                Inheritable: 允许文件句柄可由子进程继承。
                None: 它拒绝共享当前文件
                Read: 它允许打开文件进行读取
                ReadWrite: 它允许打开文件进行读取和写入
                Write: 它允许打开文件写入*/

            string TargetFiles = Path.Replace(".json", ".txt");
            List<string> Lines = new List<string>();

            FileStream FS = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamReader SR = new StreamReader(FS))
            {
                string line = SR.ReadToEnd();
                Lines.Add(line);
                Console.WriteLine(line);
            }

            if (IsExistFile(TargetFiles)) DeleteFile(TargetFiles);

            using (StreamWriter SW = new StreamWriter(TargetFiles))
            {
                foreach (string line in Lines) SW.WriteLine(line);
            }
        }

        public void TxTReaderWrite02(string Path)
        {
            string TargetFiles = Path.Replace(".json", "02.txt");
            List<string> Lines = new List<string>();

            try
            {
                using (StreamReader SR = new StreamReader(Path))
                {
                    string line;

                    while ((line = SR.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        Lines.Add(line);
                    }
                }

                using (StreamWriter SW = new StreamWriter(TargetFiles))
                {
                    foreach(string line in Lines)
                        SW.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("---FileReaderByte end---");
            }
        }

        // 二进制文件的读写: BinaryReader 和 BinaryWriter 
    }
}
