using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace ReadWriteFile
{
    class test
    {
        public void CreateDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }


        public void CreateFile(string folderPath, string fileName)
        {
            if (!File.Exists($"{folderPath}/{fileName}"))
            {
                File.Create($"{folderPath}/{fileName}");
            }
        }

        public string ReadFile(string filePath)
        {
            string str = "";
            StreamReader reader = new StreamReader(filePath);

            while (reader.EndOfStream == false)
            {
                str = str + reader.ReadLine() + Environment.NewLine;
            }
            reader.Close();
            return str;
        }

        public void SearchForText(string filePath, string searchText)
        {
            int counter = 0;
            FileInfo info = new FileInfo(filePath);
            string fileContent = ReadFile(filePath);
            string[] lines = fileContent.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                if (line.Contains(searchText))
                {
                    counter++;
                }
            }
            if (counter > 0)
            {
                Console.WriteLine($"The text appeared {counter} times in {info.Name}");
            } else
            {
                Console.WriteLine($"text not found in {info.Name}" );
            }
        }

        public string[] GetAllFiles(string folderpath)
        {
            string[] files = Directory.GetFiles(folderpath);
            return files;
        }

    }
}
