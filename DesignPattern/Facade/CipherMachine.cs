using System;
using System.Text;
namespace anodern.DesignPattern.Facade {
    class CipherMachine {
        public string encrypt(string plainText) {
            Console.WriteLine("数据加密,将明文转换为密文.");
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i<plainText.Length; i++) {
                sb.Append(plainText[i]%7);
            }
            return sb.ToString();
        }
    }
}
