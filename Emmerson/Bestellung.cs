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
            double gesamtpreis = 0;
            int position = 1;
            foreach (BstPosition item in bstPositionen) {
                Console.Write("Position " + position + ": "); 
                item.PrintPosition();
                gesamtpreis = gesamtpreis + item.GetArtickel().GetPreis() * item.GetMenge();
                position++;
            }
            Console.WriteLine("Total: "+gesamtpreis);
        }
        public void ChangeMenge(Artickel artickel, int menge)
        {
            foreach (BstPosition item in bstPositionen)
            {
                if(item.GetArtickel() == artickel)
                {
                    item.ChangeMenge(menge);
                }
            }
        }
    }
}
