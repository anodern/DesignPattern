using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class PieChart:IChart {
        public void draw() => Console.WriteLine("绘制饼状图");
    }
}
