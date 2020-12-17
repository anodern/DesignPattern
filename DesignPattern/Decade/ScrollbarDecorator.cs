using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Decade {
    class ScrollbarDecorator:ComponentDecorator {
        public ScrollbarDecorator(VisualComponent component) : base(component) {
            
        }
        public override void display() {
            setScrollbar();
            base.display();
        }

        public void setScrollbar() {
            Console.WriteLine("给组件添加滚动条");
        }
    }
}
