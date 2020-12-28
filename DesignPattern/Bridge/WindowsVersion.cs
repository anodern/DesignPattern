namespace anodern.DesignPattern.Bridge {
    class WindowsVersion:OperatingSystemVersion {
        public override void view(string fileName) {
            matrix.decode("Windows", fileName);
        }
    }
}
