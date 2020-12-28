namespace anodern.DesignPattern.SimpleFactory {
    class Client {
        public static void Test() {
            IChart chart = ChartFactory.create("pie");
            chart.draw();
        }
    }
}
