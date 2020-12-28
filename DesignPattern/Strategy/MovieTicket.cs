namespace anodern.DesignPattern.Strategy {
    class MovieTicket {
        private double price;
        public IDiscount Discount { set; private get; }
        public double Price {
            get => Discount!=null ? Discount.calculate(price) : price;
            set => price = value;
        }
    }
}
