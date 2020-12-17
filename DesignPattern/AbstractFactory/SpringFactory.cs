namespace anodern.DesignPattern.AbstractFactory {
    class SpringFactory : ISkinFactory {
        public IButton createButton() => new SpringButton();
        public ITextbox createTextbox() => new SpringTextbox();
        public ICombo createCombo() => new SpringCombo();
    }
}
