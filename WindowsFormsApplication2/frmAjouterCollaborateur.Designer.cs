﻿namespace WindowsFormsApplication2
{
    partial class frmAjouterCollaborateur
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.gbxStatut = new System.Windows.Forms.GroupBox();
            this.rbrInactif = new System.Windows.Forms.RadioButton();
            this.rbtActif = new System.Windows.Forms.RadioButton();
            this.btnAjouterContrat = new System.Windows.Forms.Button();
            this.gpbContrats = new System.Windows.Forms.GroupBox();
            this.gbxStatut.SuspendLayout();
            this.gpbContrats.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(206, 377);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(287, 377);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 9;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // gbxStatut
            // 
            this.gbxStatut.Controls.Add(this.rbrInactif);
            this.gbxStatut.Controls.Add(this.rbtActif);
            this.gbxStatut.Location = new System.Drawing.Point(33, 244);
            this.gbxStatut.Name = "gbxStatut";
            this.gbxStatut.Size = new System.Drawing.Size(329, 64);
            this.gbxStatut.TabIndex = 10;
            this.gbxStatut.TabStop = false;
            this.gbxStatut.Text = "Statut :";
            // 
            // rbrInactif
            // 
            this.rbrInactif.AutoSize = true;
            this.rbrInactif.Location = new System.Drawing.Point(248, 19);
            this.rbrInactif.Name = "rbrInactif";
            this.rbrInactif.Size = new System.Drawing.Size(54, 17);
            this.rbrInactif.TabIndex = 1;
            this.rbrInactif.Text = "Inactif";
            this.rbrInactif.UseVisualStyleBackColor = true;
            // 
            // rbtActif
            // 
            this.rbtActif.AutoSize = true;
            this.rbtActif.Checked = true;
            this.rbtActif.Location = new System.Drawing.Point(123, 19);
            this.rbtActif.Name = "rbtActif";
            this.rbtActif.Size = new System.Drawing.Size(46, 17);
            this.rbtActif.TabIndex = 0;
            this.rbtActif.TabStop = true;
            this.rbtActif.Text = "Actif";
            this.rbtActif.UseVisualStyleBackColor = true;
            // 
            // btnAjouterContrat
            // 
            this.btnAjouterContrat.Location = new System.Drawing.Point(209, 19);
            this.btnAjouterContrat.Name = "btnAjouterContrat";
            this.btnAjouterContrat.Size = new System.Drawing.Size(114, 23);
            this.btnAjouterContrat.TabIndex = 11;
            this.btnAjouterContrat.Text = "Ajouter un Contrat";
            this.btnAjouterContrat.UseVisualStyleBackColor = true;
            // 
            // gpbContrats
            // 
            this.gpbContrats.Controls.Add(this.btnAjouterContrat);
            this.gpbContrats.Location = new System.Drawing.Point(33, 314);
            this.gpbContrats.Name = "gpbContrats";
            this.gpbContrats.Size = new System.Drawing.Size(329, 57);
            this.gpbContrats.TabIndex = 12;
            this.gpbContrats.TabStop = false;
            this.gpbContrats.Text = "Contrats :";
            // 
            // frmAjouterCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(379, 409);
            this.Controls.Add(this.gpbContrats);
            this.Controls.Add(this.gbxStatut);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Name = "frmAjouterCollaborateur";
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.btnAnnuler, 0);
            this.Controls.SetChildIndex(this.gbxStatut, 0);
            this.Controls.SetChildIndex(this.gpbContrats, 0);
            this.gbxStatut.ResumeLayout(false);
            this.gbxStatut.PerformLayout();
            this.gpbContrats.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxStatut;
        private System.Windows.Forms.RadioButton rbrInactif;
        private System.Windows.Forms.RadioButton rbtActif;
        internal System.Windows.Forms.Button btnOK;
        internal System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.GroupBox gpbContrats;
        internal System.Windows.Forms.Button btnAjouterContrat;
    }
}
