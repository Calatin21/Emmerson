using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emmerson {
    internal class Kunde {
        int id;
        String name;
        Bestellung bestellung;
        public void SetId(int id) {
            this.id = id;
        }
        public int GetId() {
            return id;
        }
        public void SetName(String name) {
            this.name = name;
        }
        public String GetName() {
            return name;
        }
        public void StartBestellung(Artickel artickel, int menge) {
            bestellung =new(artickel, menge);
        }
        public void AddArtickel(Artickel artickel, int menge) {
            bestellung.Addartickel(artickel, menge);
        }
        public void RemoveArtickel(Artickel artickel)
        {
            bestellung.RemoveArtickel(artickel);
        }
        public void PrintArtickel()
        {
            bestellung.PrintBestellung();
        }
        public void ChangeMenge(Artickel artickel, int menge)
        {
            bestellung.ChangeMenge(artickel, menge);
        }
    }
}
