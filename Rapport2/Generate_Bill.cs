using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapport2
{
    public partial class Generate_Bill : Form
    { List<Produit> Pro = new List<Produit>();
        public Generate_Bill()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Generate_Click(object sender, EventArgs e)
        {
            Facture F = new Facture(Reference.Text, Client.Text,Pro);
            var fac = new Form1(F);
            fac.Show();
        }

        private void Add_Prod_Click(object sender, EventArgs e)
        {
            double Price,Quantity;
            bool su = double.TryParse(Quantites.Text, out Quantity);
            bool suc = double.TryParse(Prix.Text, out Price);
            Produit P = new Produit(Nom_produit.Text,Price,Quantity );
            if (su && suc)
            {
                Pro.Add(P);
                Quantites.Clear(); Prix.Clear();Nom_produit.Clear();
            }
            else { MessageBox.Show("Echec d'ajout de Produit", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void Generate_Bill_Load(object sender, EventArgs e)
        {

        }
    }
}
