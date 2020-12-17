using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Bridge {
    class PNGFile:IMatrix {
        public void decode(string osType, string fileName) {
            Console.WriteLine("格式为PNG的图像{0}在{1}中显示。", fileName, osType);
        }
    }
}
