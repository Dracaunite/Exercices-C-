
namespace AppFicheClient
{
    partial class FormAffichage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAffichage));
            this.fermerBtn = new System.Windows.Forms.Button();
            this.affichageLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fermerBtn
            // 
            this.fermerBtn.Location = new System.Drawing.Point(80, 140);
            this.fermerBtn.Name = "fermerBtn";
            this.fermerBtn.Size = new System.Drawing.Size(220, 30);
            this.fermerBtn.TabIndex = 0;
            this.fermerBtn.Text = "Fermer";
            this.fermerBtn.UseVisualStyleBackColor = true;
            this.fermerBtn.Click += new System.EventHandler(this.fermerBtn_Click);
            // 
            // affichageLb
            // 
            this.affichageLb.AutoSize = true;
            this.affichageLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.affichageLb.Location = new System.Drawing.Point(77, 30);
            this.affichageLb.Name = "affichageLb";
            this.affichageLb.Size = new System.Drawing.Size(46, 17);
            this.affichageLb.TabIndex = 1;
            this.affichageLb.Text = "label1";
            this.affichageLb.Click += new System.EventHandler(this.affichageLb_Click);
            // 
            // FormAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 191);
            this.Controls.Add(this.affichageLb);
            this.Controls.Add(this.fermerBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAffichage";
            this.Text = "Affichage des données client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button fermerBtn;
        private System.Windows.Forms.Label affichageLb;
    }
}