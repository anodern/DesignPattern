using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Bridge {
    interface IMatrix {
        public void decode(string osType, string fileName);
    }
}
