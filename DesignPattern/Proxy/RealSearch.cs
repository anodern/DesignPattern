using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Proxy {
    class RealSearch:ISearch {
        public string search(string username, string context) {
            Console.WriteLine("用户'{0}'查询了'{1}'",username,context);
            return "查询结果";
        }
    }
}
