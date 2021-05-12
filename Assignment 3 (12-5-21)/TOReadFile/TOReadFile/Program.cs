using System;
using System.Collections.Generic;
using System.IO;

namespace TOReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            string path = @"C:\training\Training From Home\Files for File handling\abc.txt";
            //Directory.CreateDirectory(path); create new directory if not exist
            //Console.WriteLine(Directory.GetCurrentDirectory());  returns path of the currrent directory
            //Directory.Exists(path); checked if directory exits and returns ture or false 
            //Directory.GetFiles(path); retruns path in string array
            //string[] getfile = Directory.GetFiles(path, "*.*", SearchOption.TopDirectoryOnly); search option in top directory give top directory with given search pattern
            //string[] getfile=  Directory.GetFiles(path,"*.txt"); gives file with txt extension
            //Directory.Delete(path); delete if exist else gives exception
            //IEnumerable<string> str = Directory.EnumerateDirectories(path, "*.data"); same as getFile but return enumrable collection of directory
            //Directory.EnumerateFiles(path,"*.");  same as getFile but return enumrable collection of files
            //IEnumerable<string> str = Directory.EnumerateFileSystemEntries(path); retrun all files and directories in enumerable collection
            //----------------- Directory.Equals()
            // Console.WriteLine(Directory.GetCreationTime(path)); retruns creation date time 
            //Console.WriteLine(Directory.GetCreationTimeUtc(path)); returns univeral data time of creation
            //Console.WriteLine(Directory.GetCurrentDirectory());
            //string[] arr = Directory.GetDirectories(path); returns path of directories in string array
            //Console.WriteLine(Directory.GetDirectoryRoot(path)); retruns drive of current path
            //Directory.GetFiles(path);
            //Directory.GetFileSystemEntries(path); returns all file and directory in string array
            //Console.WriteLine(Directory.GetLastAccessTime(path)); returns the date and time of file when last accessed
            //Console.WriteLine(Directory.GetLastAccessTimeUtc(path));
            //Console.WriteLine(Directory.GetLastWriteTime(@"C:\training\Training From Home\Files for File handling\xyz.csv"));
            //string[] arr = Directory.GetLogicalDrives(); returns all the drives instring of array
            //Console.WriteLine(Directory.GetParent(path).Name); .Name gives only name else it will returns all the path in string
            //Directory.Move(); move data to new destination but not the directory abd delete to previous data and directory of source
            //string sourceDirectory = @"C:\source";
            //string destinationDirectory = @"C:\destination";
            //try
            //{
            //    Directory.Move(sourceDirectory, destinationDirectory);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //------------------Directory.ReferenceEquals();
            //--------------TO ASK----------Directory.SetCreationTime(path, new DateTime(2011,12,01,11,11,11)  );
            //Directory.SetCurrentDirectory(path); //IT will change the current directory path and then we can easilt apply read get and write operation form another directory
            //string[] arr = Directory.GetFiles(   Directory.GetCurrentDirectory());
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}
            // Directory.SetLastAccessTime(path, DateTime.Now); //set last access time to gmt
            //Directory.SetLastAccessTimeUtc(path, DateTime.UtcNow); // set last access time to utc
            //Directory.SetLastWriteTime(path, DateTime.Now);  // set last write time to GMT
            //Directory.SetLastWriteTimeUtc(path, DateTime.UtcNow); // set last write time to GMT







            //--------------------------------FIles------------------------------------
            //File.Exists(path);
            //File.Delete(path);
            //File.Move(path, path);// selcted file and destination directory
            //File.Copy(path, path);// selected file can be copied to destination ;
            //File.Create(path);//wil create a new file
            //File.Encrypt(path);//to encrypt a file in a manner that account which encrypted can only decrypt it
            //File.Open(path, FileMode.Append); //to open file in append mode
            //File.OpenRead(path); // to open file in read mode
            //File.Replace(path, path, path); // replaces the original file and creates a backup of it
            string paaathtxt = @"C:\training\Training From Home\Files for File handling\abc.txt";
            string paaathdata = @"C:\training\Training From Home\Files for File handling\xyz.csv";

            //  Console.WriteLine(File.ReadAllText(paaathtxt));
            // File.Encrypt(paaathtxt);//to put a lock icon on the file
            //File.Decrypt(paaathtxt);//to remove that lock icon
            // File.WriteAllText(paaathtxt, "this is new");
            //File.AppendAllText(paaathtxt, "purana wala hai na ?");
            //string[] str = new string[]{"A","B"};
            //File.WriteAllLines(paaathtxt, str);   // to add data in new line
            //IEnumerable<string> m_oEnum = new List<string>() { "1", "2", "3" };
            //File.AppendAllLines(paaathtxt, m_oEnum); // to append data in new line
            //FileAttributes var = File.GetAttributes(paaathtxt); display property that read only /archieved /hidden or etc
            //Console.WriteLine(var);
            //File.AppendText(path);// open file in append mode
            //File.OpenText()// open text file in reading mode
            //-----------TO ASK----------byte[] bte = File.ReadAllBytes(paaathdata);
            //foreach(byte b in bte)
            //{
            //    Console.WriteLine(b);
            //}

            //File.SetAttributes(paaathtxt, FileAttributes.Hidden);//to set attribute
            //File.WriteAllLines(paaathtxt,string[]); to write all in new line      
        }
    }
}
