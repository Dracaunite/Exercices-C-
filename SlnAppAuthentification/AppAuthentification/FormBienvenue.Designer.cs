
namespace AppAuthentification
{
    partial class FormBienvenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBienvenue));
            this.msgLb = new System.Windows.Forms.Label();
            this.fermerBtn = new System.Windows.Forms.Button();
            this.fermerToutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msgLb
            // 
            this.msgLb.AutoSize = true;
            this.msgLb.Location = new System.Drawing.Point(30, 30);
            this.msgLb.Name = "msgLb";
            this.msgLb.Size = new System.Drawing.Size(35, 13);
            this.msgLb.TabIndex = 1;
            this.msgLb.Text = "label1";
            // 
            // fermerBtn
            // 
            this.fermerBtn.Location = new System.Drawing.Point(30, 70);
            this.fermerBtn.Name = "fermerBtn";
            this.fermerBtn.Size = new System.Drawing.Size(185, 23);
            this.fermerBtn.TabIndex = 2;
            this.fermerBtn.Text = "Fermer";
            this.fermerBtn.UseVisualStyleBackColor = true;
            this.fermerBtn.Click += new System.EventHandler(this.fermerBtn_Click);
            // 
            // fermerToutBtn
            // 
            this.fermerToutBtn.Location = new System.Drawing.Point(30, 115);
            this.fermerToutBtn.Name = "fermerToutBtn";
            this.fermerToutBtn.Size = new System.Drawing.Size(185, 23);
            this.fermerToutBtn.TabIndex = 3;
            this.fermerToutBtn.Text = "Fermer toutes les fenêtres";
            this.fermerToutBtn.UseVisualStyleBackColor = true;
            this.fermerToutBtn.Click += new System.EventHandler(this.fermerToutBtn_Click);
            // 
            // FormBienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 211);
            this.Controls.Add(this.fermerToutBtn);
            this.Controls.Add(this.fermerBtn);
            this.Controls.Add(this.msgLb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBienvenue";
            this.Text = "Bienvenue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label msgLb;
        private System.Windows.Forms.Button fermerBtn;
        private System.Windows.Forms.Button fermerToutBtn;
    }
}