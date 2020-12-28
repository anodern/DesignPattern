﻿namespace anodern.DesignPattern.FactoryMethod {
    class LineChartFactory:IChartFactory {
        public IChart create() => new LineChart();
    }
}
