namespace anodern.DesignPattern.FactoryMethod {
    class Client {
        public static void Test() {
            IChart chart;
            IChartFactory factory;

            factory = new HistogramChartFactory();
            chart = factory.create();
            chart.draw();
        }
    }
}
