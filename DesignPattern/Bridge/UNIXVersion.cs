namespace anodern.DesignPattern.Bridge {
    class UNIXVersion:OperatingSystemVersion {
        public override void view(string fileName) {
            matrix.decode("UNIX", fileName);
        }
    }
}
