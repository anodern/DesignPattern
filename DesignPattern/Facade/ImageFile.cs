using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Facade {
    class ImageFile:AbstractFile {
        public ImageFile(string fileName) {
            this.fileName = fileName;
        }
        public override void add(AbstractFile element) {
            Console.WriteLine("不支持");
        }
        public override void remove(AbstractFile element) {
            Console.WriteLine("不支持");
        }
        public override void display() {
            Console.WriteLine("\t图片文件:{0}", fileName);
        }
    }
}
