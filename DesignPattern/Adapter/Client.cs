namespace anodern.DesignPattern.Adapter {
    class Client {
        public static void Test() {
            PoliceAlarm pAlarm = new PoliceAlarm();
            PoliceLight pLight = new PoliceLight();
            ICar car = new CarAdapter(pAlarm,pLight);
            car.alarm();
            car.light();
        }
    }
}
