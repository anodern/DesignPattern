using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class LineChartFactory:IChartFactory {
        public IChart create() => new LineChart();
    }
}
