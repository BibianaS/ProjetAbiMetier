namespace WindowsFormsApplication2
{
    partial class frmVIsuCollaborateur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblAfficheStatut = new System.Windows.Forms.Label();
            this.lblStatut = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblListeContrats = new System.Windows.Forms.Label();
            this.btnRevenir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(369, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(420, 186);
            this.dataGridView1.TabIndex = 9;
            // 
            // lblAfficheStatut
            // 
            this.lblAfficheStatut.AutoSize = true;
            this.lblAfficheStatut.Location = new System.Drawing.Point(66, 268);
            this.lblAfficheStatut.Name = "lblAfficheStatut";
            this.lblAfficheStatut.Size = new System.Drawing.Size(41, 13);
            this.lblAfficheStatut.TabIndex = 10;
            this.lblAfficheStatut.Text = "Statut :";
            // 
            // lblStatut
            // 
            this.lblStatut.AutoSize = true;
            this.lblStatut.Location = new System.Drawing.Point(184, 269);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(0, 13);
            this.lblStatut.TabIndex = 11;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(287, 281);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 12;
            this.btnModifier.Text = "Enregistrer";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // lblListeContrats
            // 
            this.lblListeContrats.AutoSize = true;
            this.lblListeContrats.Location = new System.Drawing.Point(368, 36);
            this.lblListeContrats.Name = "lblListeContrats";
            this.lblListeContrats.Size = new System.Drawing.Size(91, 13);
            this.lblListeContrats.TabIndex = 14;
            this.lblListeContrats.Text = "Liste de contrats :";
            // 
            // btnRevenir
            // 
            this.btnRevenir.Location = new System.Drawing.Point(368, 281);
            this.btnRevenir.Name = "btnRevenir";
            this.btnRevenir.Size = new System.Drawing.Size(75, 23);
            this.btnRevenir.TabIndex = 15;
            this.btnRevenir.Text = "Revenir";
            this.btnRevenir.UseVisualStyleBackColor = true;
            // 
            // frmVIsuCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(801, 356);
            this.Controls.Add(this.btnRevenir);
            this.Controls.Add(this.lblListeContrats);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.lblStatut);
            this.Controls.Add(this.lblAfficheStatut);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmVIsuCollaborateur";
            this.Text = "VIsualidation - mofication d\'un COllaborateur";
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.lblAfficheStatut, 0);
            this.Controls.SetChildIndex(this.lblStatut, 0);
            this.Controls.SetChildIndex(this.btnModifier, 0);
            this.Controls.SetChildIndex(this.lblListeContrats, 0);
            this.Controls.SetChildIndex(this.btnRevenir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblAfficheStatut;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblListeContrats;
        private System.Windows.Forms.Button btnRevenir;
    }
}
