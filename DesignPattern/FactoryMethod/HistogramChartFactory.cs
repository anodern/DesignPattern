namespace anodern.DesignPattern.FactoryMethod {
    class HistogramChartFactory:IChartFactory {
        public IChart create() => new HistogramChart();
    }
}
