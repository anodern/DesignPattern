using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.AbstractFactory {
    class SummerButton:IButton {
        public void draw() {
            Console.WriteLine("浅蓝色的按钮");
        }
    }
}
