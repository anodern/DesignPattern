using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.AbstractFactory {
    class SummerTextbox:ITextbox {
        public void draw() {
            Console.WriteLine("浅蓝色的文本框");
        }
    }
}
