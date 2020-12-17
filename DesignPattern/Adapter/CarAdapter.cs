using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Adapter {
    class CarAdapter:ICar {
        PoliceAlarm m_alarm;
        PoliceLight m_light;

        public CarAdapter(PoliceAlarm alarm,PoliceLight light) {
            m_alarm = alarm;
            m_light = light;
        }

        public void alarm() {
            m_alarm.alarm();
        }
        public void light() {
            m_light.light();
        }
    }
}
