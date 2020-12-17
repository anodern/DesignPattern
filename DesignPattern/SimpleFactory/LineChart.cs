using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.SimpleFactory {
    class LineChart:IChart {
        public void draw() => Console.WriteLine("绘制折线图");
    }
}
