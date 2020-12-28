namespace anodern.DesignPattern.Bridge {
    abstract class OperatingSystemVersion {
        protected IMatrix matrix;
        public void setMatrix(IMatrix mat) => matrix = mat;
        public abstract void view(string fileName);
    }
}
