
namespace AppFicheClient
{
    partial class FormFiche
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiche));
            this.Civilité = new System.Windows.Forms.Label();
            this.Nom = new System.Windows.Forms.Label();
            this.Prenom = new System.Windows.Forms.Label();
            this.Adresse = new System.Windows.Forms.Label();
            this.CodePostal = new System.Windows.Forms.Label();
            this.Ville = new System.Windows.Forms.Label();
            this.validerBtn = new System.Windows.Forms.Button();
            this.civiliteTB = new System.Windows.Forms.TextBox();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.prenomTB = new System.Windows.Forms.TextBox();
            this.adresseTB = new System.Windows.Forms.TextBox();
            this.codePostalTB = new System.Windows.Forms.TextBox();
            this.villeTB = new System.Windows.Forms.TextBox();
            this.fermerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Civilité
            // 
            this.Civilité.AutoSize = true;
            this.Civilité.Location = new System.Drawing.Point(35, 35);
            this.Civilité.Name = "Civilité";
            this.Civilité.Size = new System.Drawing.Size(37, 13);
            this.Civilité.TabIndex = 0;
            this.Civilité.Text = "Civilité";
            this.Civilité.Click += new System.EventHandler(this.Civilité_Click);
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(35, 70);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 1;
            this.Nom.Text = "Nom";
            // 
            // Prenom
            // 
            this.Prenom.AutoSize = true;
            this.Prenom.Location = new System.Drawing.Point(35, 105);
            this.Prenom.Name = "Prenom";
            this.Prenom.Size = new System.Drawing.Size(43, 13);
            this.Prenom.TabIndex = 2;
            this.Prenom.Text = "Prénom";
            // 
            // Adresse
            // 
            this.Adresse.AutoSize = true;
            this.Adresse.Location = new System.Drawing.Point(35, 140);
            this.Adresse.Name = "Adresse";
            this.Adresse.Size = new System.Drawing.Size(45, 13);
            this.Adresse.TabIndex = 3;
            this.Adresse.Text = "Adresse";
            // 
            // CodePostal
            // 
            this.CodePostal.AutoSize = true;
            this.CodePostal.Location = new System.Drawing.Point(35, 175);
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.Size = new System.Drawing.Size(64, 13);
            this.CodePostal.TabIndex = 4;
            this.CodePostal.Text = "Code Postal";
            // 
            // Ville
            // 
            this.Ville.AutoSize = true;
            this.Ville.Location = new System.Drawing.Point(35, 205);
            this.Ville.Name = "Ville";
            this.Ville.Size = new System.Drawing.Size(26, 13);
            this.Ville.TabIndex = 5;
            this.Ville.Text = "Ville";
            // 
            // validerBtn
            // 
            this.validerBtn.Location = new System.Drawing.Point(38, 246);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(75, 23);
            this.validerBtn.TabIndex = 12;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // civiliteTB
            // 
            this.civiliteTB.Location = new System.Drawing.Point(165, 28);
            this.civiliteTB.Name = "civiliteTB";
            this.civiliteTB.Size = new System.Drawing.Size(140, 20);
            this.civiliteTB.TabIndex = 6;
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(165, 63);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(140, 20);
            this.nomTB.TabIndex = 7;
            // 
            // prenomTB
            // 
            this.prenomTB.Location = new System.Drawing.Point(165, 98);
            this.prenomTB.Name = "prenomTB";
            this.prenomTB.Size = new System.Drawing.Size(140, 20);
            this.prenomTB.TabIndex = 8;
            // 
            // adresseTB
            // 
            this.adresseTB.Location = new System.Drawing.Point(165, 133);
            this.adresseTB.Name = "adresseTB";
            this.adresseTB.Size = new System.Drawing.Size(140, 20);
            this.adresseTB.TabIndex = 9;
            // 
            // codePostalTB
            // 
            this.codePostalTB.Location = new System.Drawing.Point(165, 168);
            this.codePostalTB.Name = "codePostalTB";
            this.codePostalTB.Size = new System.Drawing.Size(140, 20);
            this.codePostalTB.TabIndex = 10;
            // 
            // villeTB
            // 
            this.villeTB.Location = new System.Drawing.Point(165, 205);
            this.villeTB.Name = "villeTB";
            this.villeTB.Size = new System.Drawing.Size(140, 20);
            this.villeTB.TabIndex = 11;
            // 
            // fermerBtn
            // 
            this.fermerBtn.Location = new System.Drawing.Point(230, 246);
            this.fermerBtn.Name = "fermerBtn";
            this.fermerBtn.Size = new System.Drawing.Size(75, 23);
            this.fermerBtn.TabIndex = 13;
            this.fermerBtn.Text = "Fermer";
            this.fermerBtn.UseVisualStyleBackColor = true;
            this.fermerBtn.Click += new System.EventHandler(this.fermerBtn_Click);
            // 
            // FormFiche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.fermerBtn);
            this.Controls.Add(this.villeTB);
            this.Controls.Add(this.codePostalTB);
            this.Controls.Add(this.adresseTB);
            this.Controls.Add(this.prenomTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.civiliteTB);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.Ville);
            this.Controls.Add(this.CodePostal);
            this.Controls.Add(this.Adresse);
            this.Controls.Add(this.Prenom);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.Civilité);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormFiche";
            this.Text = "Fiche Client";
            this.Load += new System.EventHandler(this.FormFiche_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Civilité;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label Prenom;
        private System.Windows.Forms.Label Adresse;
        private System.Windows.Forms.Label CodePostal;
        private System.Windows.Forms.Label Ville;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.TextBox civiliteTB;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox prenomTB;
        private System.Windows.Forms.TextBox adresseTB;
        private System.Windows.Forms.TextBox codePostalTB;
        private System.Windows.Forms.TextBox villeTB;
        private System.Windows.Forms.Button fermerBtn;
    }
}

