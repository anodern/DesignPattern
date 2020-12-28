using System;
namespace anodern.DesignPattern.Bridge {
    class GIFFile:IMatrix {
        public void decode(string osType, string fileName) {
            Console.WriteLine("格式为GIF的图像{0}在{1}中显示。", fileName, osType);
        }
    }
}
