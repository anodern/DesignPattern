using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.SimpleFactory {
    class HistogramChart:IChart {
        public void draw() => Console.WriteLine("绘制柱状图");
    }
}
