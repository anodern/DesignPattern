namespace anodern.DesignPattern.FactoryMethod {
    class PieChartFactory:IChartFactory {
        public IChart create() => new PieChart();
    }
}
