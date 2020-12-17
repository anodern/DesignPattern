using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Facade {
    class TextFile:AbstractFile {
        public TextFile(string fileName) {
            this.fileName = fileName;
        }
        public override void add(AbstractFile element) {
            Console.WriteLine("不支持");
        }
        public override void remove(AbstractFile element) {
            Console.WriteLine("不支持");
        }
        public override void display() {
            Console.WriteLine("\t文本文件:{0}", fileName);
        }
    }
}
