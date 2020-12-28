namespace anodern.DesignPattern.Strategy {
    class VIPDiscount:IDiscount {
        public double calculate(double price) {
            System.Console.WriteLine("增加积分");
            return price * 0.5;
        }
    }
}
