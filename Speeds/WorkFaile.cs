using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speeds
{
    class WorkFaile
    {
        public static string ListSpeeds()
        {
            using (FileStream fstream = File.OpenRead("input.txt"))
            {
             
                byte[] array = new byte[fstream.Length];
               
                fstream.Read(array, 0, array.Length);
               
                string textFromFile = Encoding.Default.GetString(array);

                return textFromFile;
            }
        }

        public static void WriteFaile(string text,string fileName)
        {
            using (FileStream fstream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
              
                byte[] array = Encoding.Default.GetBytes(text);
               
                fstream.Write(array, 0, array.Length);              
            }
        }
    }
}
