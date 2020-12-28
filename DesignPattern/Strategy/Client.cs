using System;
namespace anodern.DesignPattern.Strategy {
    class Client {
        public static void Test() {
            MovieTicket mt = new MovieTicket {
                Price = 40.0
            };
            Console.WriteLine("原价：{0}", mt.Price);
            Console.WriteLine("=========================");

            mt.Discount = new StudentDiscount();
            Console.WriteLine("学生票折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");

            mt.Discount = new ChildDiscount();
            Console.WriteLine("儿童票折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");

            mt.Discount = new VIPDiscount();
            Console.WriteLine("VIP折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");
            Console.WriteLine();


            mt = new MovieTicket {
                Price = 15.0
            };
            Console.WriteLine("原价：{0}", mt.Price);
            Console.WriteLine("=========================");

            mt.Discount = new StudentDiscount();
            Console.WriteLine("学生票折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");

            mt.Discount = new ChildDiscount();
            Console.WriteLine("儿童票折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");

            mt.Discount = new VIPDiscount();
            Console.WriteLine("VIP折后价为：{0}", mt.Price);
            Console.WriteLine("-------------------------");
        }
    }
}
