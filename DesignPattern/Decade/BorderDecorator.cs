using System;
namespace anodern.DesignPattern.Decade {
    class BorderDecorator:ComponentDecorator {
        public BorderDecorator(VisualComponent component) : base(component) {

        }
        public override void display() {
            setBorder();
            base.display();
        }
        public void setBorder() {
            Console.WriteLine("给组件添加黑色边框");
        }
    }
}
