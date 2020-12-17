using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Facade {
    class Client {
        public static void Test() {
            AbstractFile file1, file2, file3, file4, folder1, folder2, folder3;
            file1 = new ImageFile("图片1.gif");
            file2 = new ImageFile("图片2.png");
            file3 = new TextFile("文本1.txt");
            file4 = new TextFile("文本2.docx");

            folder1 = new Folder("涩图");
            folder1.add(file1);
            folder1.add(file2);

            folder2 = new Folder("文本");
            folder2.add(file3);
            folder2.add(file4);

            folder3 = new Folder("root");
            folder3.add(folder1);
            folder3.add(folder2);

            folder3.display();
        }
    }
}
