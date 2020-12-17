using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.AbstractFactory {
    class SummerCombo:ICombo {
        public void draw() {
            Console.WriteLine("浅蓝色的组合框");
        }
    }
}
