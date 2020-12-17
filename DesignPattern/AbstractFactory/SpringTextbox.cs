using System;
namespace anodern.DesignPattern.AbstractFactory {
    class SpringTextbox:ITextbox {
        public void draw() {
            Console.WriteLine("浅绿色的文本框");
        }
    }
}
