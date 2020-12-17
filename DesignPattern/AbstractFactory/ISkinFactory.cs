namespace anodern.DesignPattern.AbstractFactory {
    interface ISkinFactory {
        public IButton createButton();
        public ITextbox createTextbox();
        public ICombo createCombo();
    }
}
