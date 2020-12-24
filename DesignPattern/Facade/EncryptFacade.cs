using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Facade {
    class EncryptFacade {
        FileReader reader;
        FileWriter writer;
        CipherMachine cipher;

        public EncryptFacade() {
            reader = new FileReader();
            writer = new FileWriter();
            cipher = new CipherMachine();
        }

        public void fileEncrypt(string fileNameSrc, string fileNameDes) {
            string plainText = reader.read(fileNameSrc);
            string encryptText = cipher.encrypt(plainText);
            writer.write(encryptText, fileNameDes);
        }
    }
}
