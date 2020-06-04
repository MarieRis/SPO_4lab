using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;




namespace SPO4lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\admin\Documents\учебка\3 курс\6 семестр\программное обеспечение\СПО4лаба";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }


            Console.WriteLine($"Название каталога: {dirInfo.Name}");



            
        }
    }
}
