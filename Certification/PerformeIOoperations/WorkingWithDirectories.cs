using System;
using System.IO;
using System.Security.AccessControl;

namespace PerformIOoperations
{
    public class WorkingWithDirectories
    {
        public static void Main1(string[] args)
        {
            // creating new directory
            var dir = Directory.CreateDirectory(@"C:\Temp\ProgrammingInCSharp\Directory");
            // or DirectoryInfo object can be initialized with a non-existing folder.
            var dirInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\Directory");
            dirInfo.Create();

            // deleting existing dir

            if (Directory.Exists(@"C:\Temp\ProgrammingInCSharp\Directory"))
            {
                Directory.Delete(@"C:\Temp\ProgrammingInCSharp\Directory");
            }

            // or

            var directoryInfo = new DirectoryInfo(@"C:\Temp\ProgrammingInCSharp\DirectoryInfo");
            if (directoryInfo.Exists)
            {
                directoryInfo.Delete();
            }

            // Setting access control for a directory

            DirectoryInfo di = new DirectoryInfo("TestDirectory");
            di.Create();
            DirectorySecurity directorySecurity = di.GetAccessControl();
            directorySecurity.AddAccessRule(new FileSystemAccessRule("everyone", 
                FileSystemRights.ReadAndExecute, AccessControlType.Allow));
            di.SetAccessControl(directorySecurity);

        }

        public void ListDirectories(DirectoryInfo directoryInfo, string searchPattern, int maxLevel, int currentLevel)
        {
            if (currentLevel >= maxLevel)
            {
                return;
            }
            string indent = new string('-', currentLevel);
            try
            {
                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories(searchPattern);
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    Console.WriteLine(indent + subDirectory.Name);
                    ListDirectories(subDirectory, searchPattern, maxLevel, currentLevel + 1);
                }
            }
            catch (UnauthorizedAccessException)
            {
                // You don’t have access to this folder.
                Console.WriteLine(indent + "Can't access: " + directoryInfo.Name);
                return;
            }
            catch (DirectoryNotFoundException)
            {
                // The folder is removed while iterating
                Console.WriteLine(indent + "Can’t find: " + directoryInfo.Name);
                return;
            }
        }

        
    }
}
