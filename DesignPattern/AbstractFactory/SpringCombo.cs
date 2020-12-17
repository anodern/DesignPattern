using System;
namespace anodern.DesignPattern.AbstractFactory {
    class SpringCombo:ICombo {
        public void draw() {
            Console.WriteLine("浅绿色的组合框");
        }
    }
}
