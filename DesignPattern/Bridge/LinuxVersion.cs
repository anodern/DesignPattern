namespace anodern.DesignPattern.Bridge {
    class LinuxVersion:OperatingSystemVersion {
        public override void view(string fileName) {
            matrix.decode("Linux", fileName);
        }
    }
}
