using System;
using System.IO;
namespace anodern.DesignPattern.Facade {
    class FileReader {
        public string read(string fileNameSrc) {
            Console.WriteLine("读取文件,获得明文.");
            StreamReader sr = new StreamReader(fileNameSrc);
            string text = sr.ReadToEnd();
            sr.Close();
            return text;
        }
    }
}
