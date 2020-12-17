using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Bridge {
    class TEST {
        public static void Test() {
            IMatrix file;
            OperatingSystemVersion os;
            file = new PNGFile();
            os = new WindowsVersion();
            os.setMatrix(file);
            os.view("wdnmd");
        }
    }
}
