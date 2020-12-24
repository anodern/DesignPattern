using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Facade {
    class Client {
        public static void Test() {
            EncryptFacade ef = new EncryptFacade();
            ef.fileEncrypt("srcFacade.txt", "desFacade.txt");   
        }
    }
}
