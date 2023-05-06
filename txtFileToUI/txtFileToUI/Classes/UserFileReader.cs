using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtFileToUI.Classes
{
    public class UserFileReader
    {
        public string filePath;

        public UserFileReader(string file)
        {
            filePath = file;
        }


        //Methods
        public string ReadFile()
        {
            string data;
            StreamReader reader;
            reader = new StreamReader(filePath);
            data = reader.ReadToEnd();
            Console.WriteLine(data);
            reader.Close();
            return data;
        }
    }
}
