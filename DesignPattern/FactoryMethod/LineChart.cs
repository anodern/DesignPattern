using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class LineChart:IChart {
        public void draw() => Console.WriteLine("绘制折线图");
    }
}
