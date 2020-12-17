using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Decade {
    class Textbox: VisualComponent {
        public override void display() {
            Console.WriteLine("显示文本框");
        }
    }
}
