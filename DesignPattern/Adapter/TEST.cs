using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Adapter {
    class TEST {
        public static void Test() {
            PoliceAlarm pAlarm = new PoliceAlarm();
            PoliceLight pLight = new PoliceLight();
            ICar car = new CarAdapter(pAlarm,pLight);
            car.alarm();
            car.light();
        }
    }
}
