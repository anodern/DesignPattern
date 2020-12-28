using System;
namespace anodern.DesignPattern.SimpleFactory {
    class HistogramChart:IChart {
        public void draw() => Console.WriteLine("绘制柱状图");
    }
}
