using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Decade {
    class ComponentDecorator:VisualComponent {
        private VisualComponent component;
        public ComponentDecorator(VisualComponent component) {
            this.component = component;
        }
        public override void display() {
            component.display();
        }
    }
}
