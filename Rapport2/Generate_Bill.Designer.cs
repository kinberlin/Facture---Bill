
namespace Rapport2
{
    partial class Generate_Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Nom_produit = new System.Windows.Forms.TextBox();
            this.Quantites = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Prix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Add_Prod = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.Client = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Reference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de produit :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nom_produit
            // 
            this.Nom_produit.Location = new System.Drawing.Point(183, 140);
            this.Nom_produit.Name = "Nom_produit";
            this.Nom_produit.Size = new System.Drawing.Size(200, 20);
            this.Nom_produit.TabIndex = 1;
            // 
            // Quantites
            // 
            this.Quantites.Location = new System.Drawing.Point(183, 173);
            this.Quantites.Name = "Quantites";
            this.Quantites.Size = new System.Drawing.Size(200, 20);
            this.Quantites.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantites :";
            // 
            // Prix
            // 
            this.Prix.Location = new System.Drawing.Point(183, 209);
            this.Prix.Name = "Prix";
            this.Prix.Size = new System.Drawing.Size(200, 20);
            this.Prix.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prix :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Add_Prod
            // 
            this.Add_Prod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Prod.Location = new System.Drawing.Point(198, 250);
            this.Add_Prod.Name = "Add_Prod";
            this.Add_Prod.Size = new System.Drawing.Size(167, 27);
            this.Add_Prod.TabIndex = 6;
            this.Add_Prod.Text = "Ajouter  Produit";
            this.Add_Prod.UseVisualStyleBackColor = true;
            this.Add_Prod.Click += new System.EventHandler(this.Add_Prod_Click);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Aqua;
            this.Generate.FlatAppearance.BorderSize = 0;
            this.Generate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(198, 309);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(167, 27);
            this.Generate.TabIndex = 7;
            this.Generate.Text = "Generer Facture";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // Client
            // 
            this.Client.Location = new System.Drawing.Point(181, 21);
            this.Client.Name = "Client";
            this.Client.Size = new System.Drawing.Size(200, 20);
            this.Client.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nom de Client :";
            // 
            // Reference
            // 
            this.Reference.Location = new System.Drawing.Point(181, 55);
            this.Reference.Name = "Reference";
            this.Reference.Size = new System.Drawing.Size(200, 20);
            this.Reference.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reference :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-13, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(560, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "................................................................................." +
    ".............................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gabriola", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(504, 28);
            this.label7.TabIndex = 13;
            this.label7.Text = "Generer la facture apres avoir enregistree tout les produits que contiendracelui " +
    "ci pour un client specifique ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-13, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(560, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "................................................................................." +
    ".............................";
            // 
            // Generate_Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 348);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Reference);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Client);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Add_Prod);
            this.Controls.Add(this.Prix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Quantites);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom_produit);
            this.Controls.Add(this.label1);
            this.Name = "Generate_Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate_Bill";
            this.Load += new System.EventHandler(this.Generate_Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nom_produit;
        private System.Windows.Forms.TextBox Quantites;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Add_Prod;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox Client;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Reference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}