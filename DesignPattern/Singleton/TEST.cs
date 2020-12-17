using System;
namespace anodern.DesignPattern.Singleton {
    class TEST {

        public static void Test() {
            Zhangsan();
            Lisi();
        }

        private static void Zhangsan() {
            Console.Write("张三 ");
            Moon.Instance.watch();
        }

        private static void Lisi() {
            Console.Write("李四 ");
            Moon.Instance.watch();
        }
    }
}
