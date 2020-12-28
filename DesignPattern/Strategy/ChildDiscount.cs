namespace anodern.DesignPattern.Strategy {
    class ChildDiscount:IDiscount {
        public double calculate(double price) {
            return price>=20?price-10:price;
        }
    }
}
