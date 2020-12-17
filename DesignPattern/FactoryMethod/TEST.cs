using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.FactoryMethod {
    class TEST {

        internal IChartFactory IChartFactory {
            get => default;
            set {
            }
        }

        internal IChart IChart {
            get => default;
            set {
            }
        }

        public static void Test() {
            IChart chart;
            IChartFactory factory;

            factory = new PieChartFactory();
            chart = factory.create();
            chart.draw();
        }
    }
}
