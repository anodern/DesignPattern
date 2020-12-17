using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace anodern.DesignPattern.SimpleFactory {
    class ChartFactory {
        public static IChart create(string type) {
            if("histogram".Equals(type, StringComparison.OrdinalIgnoreCase)) {
                return new HistogramChart();
            }else if("pie".Equals(type, StringComparison.OrdinalIgnoreCase)) {
                return new PieChart();
            } else if("line".Equals(type, StringComparison.OrdinalIgnoreCase)) {
                return new LineChart();
            } else {
                throw new UnsupportedException();
            }
        }
    }
}
