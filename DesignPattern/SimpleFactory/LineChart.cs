using System;
namespace anodern.DesignPattern.SimpleFactory {
    class LineChart:IChart {
        public void draw() => Console.WriteLine("绘制折线图");
    }
}
