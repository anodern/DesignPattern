namespace anodern.DesignPattern.AbstractFactory {
    class SummerFactory:ISkinFactory {
        public IButton createButton() => new SummerButton();
        public ITextbox createTextbox() => new SummerTextbox();
        public ICombo createCombo() => new SummerCombo();
    }
}
