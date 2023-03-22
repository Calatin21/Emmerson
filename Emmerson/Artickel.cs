namespace Emmerson {
    internal class Artickel {
        String name;
        Double preis;
        public Artickel(String name, Double preis) {
            this.name = name;
            this.preis = preis;
        }
        public void SetName(String name) {
            this.name = name;
        }
        public String GetName() {
            return this.name;
        }
        public void SetPreis(Double preis) {
            this.preis = preis;
        }
        public Double GetPreis() {
            return this.preis;
        }
    }
}
