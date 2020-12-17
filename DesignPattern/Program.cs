using System;

namespace anodern.DesignPattern {
    class Program {
        static void Main(string[] args) {
            //FactoryMethod.TEST.Test();
            //AbstractFactory.TEST.Test();
            //Singleton.TEST.Test();

            //Adapter.TEST.Test();
            //Console.WriteLine();
            //Bridge.TEST.Test();

            Facade.Client.Test();
            Console.WriteLine();
            Decade.Client.Test();
        }
    }
}
