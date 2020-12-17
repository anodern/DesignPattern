using System;
using System.Collections;

namespace anodern.DesignPattern.Facade {
    class Folder:AbstractFile {
        private ArrayList fileList = new ArrayList();
        public Folder(string fileName) {
            this.fileName = fileName;
        }
        public override void add(AbstractFile element) {
            fileList.Add(element);
        }
        public override void display() {
            Console.WriteLine("文件夹 - {0} - 包含以下资料:", fileName);
            foreach(AbstractFile aFile in fileList) {
                aFile.display();
            }
        }
        public override void remove(AbstractFile element) {
            fileList.Remove(element);
        }
    }
}
