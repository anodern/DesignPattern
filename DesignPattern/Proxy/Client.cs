namespace anodern.DesignPattern.Proxy {
    class Client {
        public static void Test() {
            ISearch search = new ProxySearch();
            search.search("123", "keyword1");
            search.search("12345", "keyword2");
        }
    }
}
