﻿namespace Server
{
    partial class frmServer
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
            this.btnDemarrer = new System.Windows.Forms.Button();
            this.btnArreter = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDemarrer
            // 
            this.btnDemarrer.Location = new System.Drawing.Point(65, 24);
            this.btnDemarrer.Name = "btnDemarrer";
            this.btnDemarrer.Size = new System.Drawing.Size(130, 50);
            this.btnDemarrer.TabIndex = 0;
            this.btnDemarrer.Text = "Démarrer";
            this.btnDemarrer.UseVisualStyleBackColor = true;
            this.btnDemarrer.Click += new System.EventHandler(this.btnDemarrer_Click);
            // 
            // btnArreter
            // 
            this.btnArreter.Location = new System.Drawing.Point(252, 24);
            this.btnArreter.Name = "btnArreter";
            this.btnArreter.Size = new System.Drawing.Size(130, 50);
            this.btnArreter.TabIndex = 1;
            this.btnArreter.Text = "Arrêter";
            this.btnArreter.UseVisualStyleBackColor = true;
            this.btnArreter.Click += new System.EventHandler(this.btnArreter_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 88);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(430, 256);
            this.textBox1.TabIndex = 2;
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 356);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnArreter);
            this.Controls.Add(this.btnDemarrer);
            this.Name = "frmServer";
            this.Text = "Serveur TFTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDemarrer;
        private System.Windows.Forms.Button btnArreter;
        private System.Windows.Forms.TextBox textBox1;
    }
}
