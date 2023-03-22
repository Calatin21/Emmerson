namespace Emmerson {
    internal class Program {
        static void Main(string[] args) {
            //Noch ist nicht alles implementiert!!!
            Artickel a1 = new("Stuhl", 10);
            Artickel a2 = new("Tisch", 50);
            Artickel a3 = new("Pc", 1999);
            Artickel a4 = new("Laptop", 799);
            Artickel a5 = new("Bonbon", 0.2);
            Artickel a6 = new("Apfel", 2);
            Artickel a7 = new("Jeans", 70);
            Artickel a8 = new("Film", 9.99);
            Artickel a9 = new("Käse", 15);
            Kunde kunde1 = new Kunde();
            kunde1.SetName("Ich");
            kunde1.SetId(1);
            kunde1.StartBestellung(a7,1);
            
        }
    }
}