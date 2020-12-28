using System;
using System.IO;
namespace anodern.DesignPattern.Facade {
    class FileWriter {
        public void write(string encryptText,string fileNameDes) {
            Console.WriteLine("保存密文,写入文件.");
            StreamWriter sw = new StreamWriter(fileNameDes);
            sw.Write(encryptText);
            sw.Close();
        }
    }
}
