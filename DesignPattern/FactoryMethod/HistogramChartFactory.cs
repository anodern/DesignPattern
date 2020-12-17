using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class HistogramChartFactory:IChartFactory {
        public IChart create() => new HistogramChart();
    }
}
