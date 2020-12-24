using System;
using System.Collections.Generic;
using System.Text;

namespace anodern.DesignPattern.Proxy {
    class ProxySearch:ISearch {
        RealSearch realSearch = new RealSearch();
        public string search(string username, string context) {
            if(validate(username)) {

                log(username);
                return realSearch.search(username,context);
            } else {
                Console.WriteLine("用户'{0}'验证失败",username);
                return null;
            }
        }

        private bool validate(string username) {
            return username.Equals("123");
        }

        private void log(string username) {
            Console.WriteLine("日志:{0}", username);
        }
    }
}
