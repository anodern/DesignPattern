using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Composite {
    abstract class AbstractFile {
        protected string fileName;
        public abstract void add(AbstractFile element);
        public abstract void remove(AbstractFile element);
        public abstract void display();
    }
}
