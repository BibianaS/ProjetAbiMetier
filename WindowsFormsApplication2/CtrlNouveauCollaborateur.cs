using ABI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class CtrlNouveauCollaborateur
    {
        frmAjouterCollaborateur frmAjouter;
        private DialogResult resultatDialog;
        private MCollaborateur unCollaborateur;
        private MListeCollaborateurs listeCollabo;

        public MCollaborateur UnCollaborateur
        {
            get
            {
                return unCollaborateur;
            }
        }

        public CtrlNouveauCollaborateur()
        {
            frmAjouter = new frmAjouterCollaborateur();
            this.frmAjouter.Text = "Ajouter un Nouveau Collaborateur";
            
            this.frmAjouter.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            resultatDialog = this.frmAjouter.ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.frmAjouter.Control())
            {
                if (this.frmAjouter.Instancie())
                {
                    this.frmAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.resultatDialog = this.frmAjouter.DialogResult;
                    this.unCollaborateur = this.frmAjouter.NouvCollaborateur;
                    listeCollabo.Ajouter(this.unCollaborateur);
                    //MessageBox.Show("Dans l'instanciation");
                }
                else
                {
                    this.resultatDialog = DialogResult.No;
                }

            }
            
        }
        
    }
}
