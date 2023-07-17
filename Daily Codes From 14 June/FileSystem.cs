using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.MemoryMappedFiles;

namespace Daily_Codes_From_14_June
{
    internal class FileSystem
    {

class Test
    {
        public static void Main()
        {
            string path = @"C:\Users\Nimap\Desktop\MyText.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hi,");
                    sw.WriteLine("I'm");
                    sw.WriteLine("Somanath Barge");
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
}
