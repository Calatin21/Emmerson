namespace Emmerson {
    internal class Bestellung {
        List<BstPosition> bstPositionen;
        public Bestellung(Artickel artickel, int menge) {
            bstPositionen = new();
            bstPositionen.Add(new BstPosition(artickel, menge));
        }
        public BstPosition SucheArtickel(Artickel artickel) {
            BstPosition ergebnis = null;
            for (int i = 0; i < bstPositionen.Count(); i++) {
                if (bstPositionen[i].GetArtickel() == artickel) {
                    ergebnis = bstPositionen[i];
                }
            }
            return ergebnis;
        }
        public void Addartickel(Artickel artickel, int menge) {
            bstPositionen.Add(new(artickel, menge));
        }
        public void RemoveArtickel(Artickel artickel) {
            bstPositionen.Remove(this.SucheArtickel(artickel));
        }
        public void PrintBestellung() {
            foreach (BstPosition item in bstPositionen) {
                item.PrintPosition();
            }
        }
    }
}
