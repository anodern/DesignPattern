namespace anodern.DesignPattern.Strategy {
    class StudentDiscount:IDiscount {
        public double calculate(double price) {
            return price * 0.8;
        }
    }
}
