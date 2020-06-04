
using System;
using System.Security.AccessControl;
using System.IO;

namespace SPO4lab

{

    
       public class Program1
        {
        static public bool SetFullControl(string nameDir, string userName)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(nameDir);
                DirectorySecurity ds = dirInfo.GetAccessControl(AccessControlSections.Access);
                //Только для папок
                ds.AddAccessRule(new FileSystemAccessRule(userName,
                    FileSystemRights.FullControl,
                    InheritanceFlags.ContainerInherit,
                    PropagationFlags.InheritOnly,
                    AccessControlType.Denay));
                //Только для файлов
                ds.AddAccessRule(new FileSystemAccessRule(userName,
                    FileSystemRights.FullControl,
                    InheritanceFlags.ObjectInherit,
                    PropagationFlags.InheritOnly,
                    AccessControlType.Denay));
                //Только для этой папки
                ds.AddAccessRule(new FileSystemAccessRule(userName,
                    FileSystemRights.FullControl,
                    InheritanceFlags.None,
                    PropagationFlags.InheritOnly,
                    AccessControlType.Denay));
                dirInfo.SetAccessControl(ds);
                return true;
            }
            catch
            { return false; }
        }

    }
}
