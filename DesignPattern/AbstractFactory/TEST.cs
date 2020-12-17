using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.AbstractFactory {
    class TEST {
        public static void Test() {
            ISkinFactory factory;
            IButton button;
            ITextbox textbox;
            ICombo combo;

            factory = new SummerFactory();
            button = factory.createButton();
            textbox = factory.createTextbox();
            combo = factory.createCombo();

            button.draw();
            textbox.draw();
            combo.draw();
        }
    }
}
