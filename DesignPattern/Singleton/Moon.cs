using System;
namespace anodern.DesignPattern.Singleton {
    class Moon {
        private static Moon _instance;
        public static Moon Instance {
            get {
                if(_instance==null) _instance=new Moon();
                return _instance;
            }
        }

        public void watch() {
            Console.WriteLine("月球的半径是1738.0km,距地球363300.0km");
        }
    }
}
