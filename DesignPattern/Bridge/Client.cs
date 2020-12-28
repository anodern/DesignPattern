namespace anodern.DesignPattern.Bridge {
    class Client {
        public static void Test() {
            IMatrix file;
            OperatingSystemVersion os;
            file = new PNGFile();
            os = new WindowsVersion();
            os.setMatrix(file);
            os.view("pic3");
        }
    }
}
