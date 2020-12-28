using System;
namespace anodern.DesignPattern.AbstractFactory {
    class SummerButton:IButton {
        public void draw() {
            Console.WriteLine("浅蓝色的按钮");
        }
    }
}
