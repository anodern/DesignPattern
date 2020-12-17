using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Decade {
    class Client {
        public static void Test() {
            VisualComponent frame, frame_s;
            frame = new Frame();
            frame_s = new ScrollbarDecorator(frame);
            frame_s.display();

            VisualComponent textbox, textbox_b;
            textbox = new Textbox();
            textbox_b = new BorderDecorator(textbox);
            textbox_b.display();

            VisualComponent listbox, listbox_s, listbox_sb;
            listbox = new Listbox();
            listbox_s = new ScrollbarDecorator(listbox);
            listbox_sb = new BorderDecorator(listbox_s);
            listbox_sb.display();
        }
    }
}
