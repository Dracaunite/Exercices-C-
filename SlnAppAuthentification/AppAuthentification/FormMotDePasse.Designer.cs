
namespace AppAuthentification
{
    partial class FormMotDePasse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMotDePasse));
            this.label1 = new System.Windows.Forms.Label();
            this.nomTB = new System.Windows.Forms.TextBox();
            this.mdpTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.validerBtn = new System.Windows.Forms.Button();
            this.femerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nomTB
            // 
            this.nomTB.Location = new System.Drawing.Point(117, 28);
            this.nomTB.Name = "nomTB";
            this.nomTB.Size = new System.Drawing.Size(151, 20);
            this.nomTB.TabIndex = 3;
            // 
            // mdpTB
            // 
            this.mdpTB.Location = new System.Drawing.Point(117, 54);
            this.mdpTB.Name = "mdpTB";
            this.mdpTB.PasswordChar = '*';
            this.mdpTB.Size = new System.Drawing.Size(151, 20);
            this.mdpTB.TabIndex = 4;
            this.mdpTB.TextChanged += new System.EventHandler(this.mdpTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe";
            // 
            // validerBtn
            // 
            this.validerBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.validerBtn.Location = new System.Drawing.Point(43, 102);
            this.validerBtn.Name = "validerBtn";
            this.validerBtn.Size = new System.Drawing.Size(75, 23);
            this.validerBtn.TabIndex = 5;
            this.validerBtn.Text = "Valider";
            this.validerBtn.UseVisualStyleBackColor = true;
            this.validerBtn.Click += new System.EventHandler(this.validerBtn_Click);
            // 
            // femerBtn
            // 
            this.femerBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.femerBtn.Location = new System.Drawing.Point(193, 102);
            this.femerBtn.Name = "femerBtn";
            this.femerBtn.Size = new System.Drawing.Size(75, 23);
            this.femerBtn.TabIndex = 6;
            this.femerBtn.Text = "Fermer";
            this.femerBtn.UseVisualStyleBackColor = true;
            this.femerBtn.Click += new System.EventHandler(this.femerBtn_Click);
            // 
            // FormMotDePasse
            // 
            this.AcceptButton = this.validerBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 161);
            this.Controls.Add(this.femerBtn);
            this.Controls.Add(this.validerBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mdpTB);
            this.Controls.Add(this.nomTB);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMotDePasse";
            this.Text = "Formulaire d\'authentification";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMotDePasse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomTB;
        private System.Windows.Forms.TextBox mdpTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button validerBtn;
        private System.Windows.Forms.Button femerBtn;
    }
}

