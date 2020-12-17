using System;
namespace anodern.DesignPattern.AbstractFactory {
    class SpringButton:IButton {
        public void draw() {
            Console.WriteLine("浅绿色的按钮");
        }
    }
}
