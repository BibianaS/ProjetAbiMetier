using ABI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class ctrlVisuModifCollaborateur
    {
        MCollaborateur monCollaborateur;
        MCollaborateur colModifie;
        MListeCollaborateurs maListe;
        frmModification frmModif;
        public ctrlVisuModifCollaborateur(MCollaborateur unCollaborateur)
        {
            this.monCollaborateur = unCollaborateur;
            frmModif = new frmModification(this.monCollaborateur);
            this.frmModif.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            frmModif.ShowDialog();
        }
        private void btnModifier_Click(object sender, EventArgs e)
        {

            colModifie = frmModif.ModifCollaborateur();
            maListe.Modifier(colModifie);
            //TODO finit d'enregistrer les modif, faut'il appelelr les methodes ici? 

        }

    }
}
