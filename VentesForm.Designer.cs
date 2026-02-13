namespace VentesApp_Projet
{
    partial class VentesForm
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
            this.listesDesCommandesButton = new System.Windows.Forms.Button();
            this.listeDesVentesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listesDesCommandesButton
            // 
            this.listesDesCommandesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listesDesCommandesButton.Location = new System.Drawing.Point(36, 41);
            this.listesDesCommandesButton.Margin = new System.Windows.Forms.Padding(4);
            this.listesDesCommandesButton.Name = "listesDesCommandesButton";
            this.listesDesCommandesButton.Size = new System.Drawing.Size(417, 62);
            this.listesDesCommandesButton.TabIndex = 0;
            this.listesDesCommandesButton.Text = "Liste des commandes d\'un client spécifique ";
            this.listesDesCommandesButton.UseVisualStyleBackColor = true;
            this.listesDesCommandesButton.Click += new System.EventHandler(this.listesDesCommandesButton_Click);
            // 
            // listeDesVentesButton
            // 
            this.listeDesVentesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listeDesVentesButton.Location = new System.Drawing.Point(36, 132);
            this.listeDesVentesButton.Margin = new System.Windows.Forms.Padding(4);
            this.listeDesVentesButton.Name = "listeDesVentesButton";
            this.listeDesVentesButton.Size = new System.Drawing.Size(417, 62);
            this.listeDesVentesButton.TabIndex = 1;
            this.listeDesVentesButton.Text = "Liste des ventes par année";
            this.listeDesVentesButton.UseVisualStyleBackColor = true;
            this.listeDesVentesButton.Click += new System.EventHandler(this.listeDesVentesButton_Click);
            // 
            // VentesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 273);
            this.Controls.Add(this.listeDesVentesButton);
            this.Controls.Add(this.listesDesCommandesButton);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "VentesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button listesDesCommandesButton;
        private System.Windows.Forms.Button listeDesVentesButton;
    }
}

