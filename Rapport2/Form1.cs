using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace Rapport2
{
    public partial class Form1 : Form
    { public List<Produit> Pro = new List<Produit>();
        public Facture Fa = new Facture();
        public List<string> DonneeUtil = new List<string>();
        public List<Facture> Fac = new List<Facture>();
               
        public Form1(Facture pro )
        {
            Pro = pro.Pro;
            Fa = pro;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Fac.Add(Fa);
            this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Factures",Fac));
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Produit", Pro));
            this.reportViewer1.SetDisplayMode( Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
