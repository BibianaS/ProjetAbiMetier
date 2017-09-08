using ABI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{
    public partial class frmModification : ABI.frmCollaborateur
    {
        MCollaborateur monCollabo;
        public frmModification(MCollaborateur unCollabo)
        {
            InitializeComponent();
            this.monCollabo = unCollabo;
            init();
        }

        public void init()
        {
            this.txtMatricule.Text = monCollabo.Matricule.ToString();
            this.txtPrenom.Text = monCollabo.PrenomCollabo;
            this.txtNom.Text = monCollabo.NomCollabo;
            this.txtSS.Text = monCollabo.NumeroSS;
            this.lblStatut.Text = monCollabo.StatutCollaborateur;
        }

        private void btnRevenir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public MCollaborateur ModifCollaborateur()
        {
            monCollabo.Matricule = Int32.Parse(txtMatricule.Text);
            monCollabo.PrenomCollabo = txtPrenom.Text;
            monCollabo.NomCollabo = txtNom.Text;
            monCollabo.NumeroSS = txtSS.Text;

            return monCollabo;
        }

        
    }
}
