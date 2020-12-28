namespace anodern.DesignPattern.Observer {
    class Client {
        public static void Test() {
            IInvestor investor1 = new ConcreteInvestor("队友1");
            IInvestor investor2 = new ConcreteInvestor("队友2");

            Player player = new Player("队友3",20);
            player.attatch(investor1);
            player.attatch(investor2);
            player.HP = 19;
        }
    }
}
