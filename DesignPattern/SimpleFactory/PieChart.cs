using System;
namespace anodern.DesignPattern.SimpleFactory {
    class PieChart:IChart {
        public void draw() => Console.WriteLine("绘制饼状图");
    }
}
