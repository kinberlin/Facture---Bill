using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
   public  class Facture
    {

        public string Reference { get; set; }
        public string Nom_Client { get; set; }
        public double PRIXtotal { get; set; }
        public List<Produit> Pro;
        public DateTime Date_delivrance { get; set; }

        public void SetDate_delivrance()
        {
            DateTime j = DateTime.Now;
                Date_delivrance = j;
        }
        public Facture()
        {

        }
        public void PrixTTC(List<Produit> p)
        {
            double Somme = 0;
            foreach (var P in p)
            {
                Somme = P.Prix_total + Somme;
            }
            PRIXtotal = Somme;
        }
        public Facture(string reference, string nom_Client, List<Produit> P)
        {
            this.Pro = P;
            this.Reference = reference;
            this.Nom_Client = nom_Client;
            PrixTTC(P);
            SetDate_delivrance();
        }
        public Facture(string reference, string nom_Client)
        {
            this.Reference = reference;
            this.Nom_Client = nom_Client;
            SetDate_delivrance();
        }

    }
}
