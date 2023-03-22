namespace Emmerson {
    internal class BstPosition {
        Artickel artickel;
        int menge;
        public BstPosition(Artickel artickel, int menge) {
            this.artickel = artickel;
            this.menge = menge;
        }
        public void ChangeMenge(int menge) {
            this.menge = menge;
        }
        public int GetMenge() {
            return this.menge;
        }
        public Artickel GetArtickel() {
            return artickel;    
        }
        public void PrintPosition() {
            Console.WriteLine("Position: " + artickel.GetName() + " Menge: " + menge + " Preis: " + artickel.GetPreis() * menge);
        }
    }
}
