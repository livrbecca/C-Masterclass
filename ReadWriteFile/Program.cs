using System;
using System.IO;

namespace ReadWriteFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string action;
            // IO not working
            InputOutput io = new InputOutput();
            do
            {
                Console.WriteLine("1 to create folder\n2 to create file\n3 to add content\n4 to read content\n 5 to search");
                action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        Console.WriteLine("Enter folder name with path");
                        string folderPath = Console.ReadLine();
                        io.CreateDir(folderPath);
                        break;

                    case "2":
                        Console.WriteLine("enter folder path");
                        string fpath = Console.ReadLine();
                        Console.WriteLine("enter file name");
                        string fName = Console.ReadLine();
                        io.CreateFile(fpath, fName);
                        break;
                    case "3":
                        Console.WriteLine("file name?");
                        string fNameToAdd = Console.ReadLine();
                        Console.WriteLine("conent?");
                        string fContent = Console.ReadLine();
                        io.CreateFile(fNameToAdd, fContent);
                        break;
                    case "4":
                        Console.WriteLine("file name?");
                        string fNameToRead = Console.ReadLine();
                        string readContent = io.ReadFile(fNameToRead);
                        Console.WriteLine("file content " + readContent);
                        break;
                    case "5":
                        Console.WriteLine("folder to search?");
                        break;

                }
            }


        }


    }
}
