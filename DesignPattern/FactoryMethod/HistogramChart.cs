using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class HistogramChart:IChart {
        public void draw() => Console.WriteLine("绘制柱状图");
    }
}
