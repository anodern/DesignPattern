using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class PieChartFactory:IChartFactory {
        public IChart create() => new PieChart();
    }
}
