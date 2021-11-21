using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Produit
    {
        public string Nom { get; set; }
        public double Prix { get; set; }
        public double Quantites { get; set; }
        public double Prix_total { get; set; }

        public Produit(string Nom, double Prix, double Quantites)
        {
            this.Nom = Nom;
            this.Prix = Prix;
            this.Quantites = Quantites;
            PTC();
        }
        public void PTC()
        {
            Prix_total = Prix * Quantites;
        }
    }
}
