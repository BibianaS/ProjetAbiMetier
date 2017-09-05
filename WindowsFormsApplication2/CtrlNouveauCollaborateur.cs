﻿using ABI;
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

        public MCollaborateur UnCollaborateur
        {
            get
            {
                return unCollaborateur;
            }
        }

        public DialogResult ResultatDialog
        {
            get
            {
                return resultatDialog;
            }

            set
            {
                resultatDialog = value;
            }
        }

        public CtrlNouveauCollaborateur()
        {
            //Affichag du frm Ajouter
            frmAjouter = new frmAjouterCollaborateur();
            this.frmAjouter.Text = "Ajouter un Nouveau Collaborateur";
            
            //Btn OK
            this.frmAjouter.btnOK.Click += new System.EventHandler(this.btnOK_Click);
           

            //Btn Ajouter un contrat
            this.frmAjouter.btnAjouterContrat.Click += new System.EventHandler(this.btnAjouterContrat_Click);


            ResultatDialog = this.frmAjouter.ShowDialog();
        }


        //creation d'un collaborateur
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.frmAjouter.Control())
            {
                if (this.frmAjouter.Instancie())
                {
                    this.frmAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.ResultatDialog = this.frmAjouter.DialogResult;

                    //recupertation du ref du collaborateur instancie par le form
                    //afin de l'envoyer au controlleur Lister pour l'ajouter a la liste
                    this.unCollaborateur = this.frmAjouter.NouvCollaborateur;
                    
                }
                else
                {
                    this.ResultatDialog = DialogResult.No;
                }
            }            
        }

        //Gestion du contrat
        private void btnAjouterContrat_Click(object sender, EventArgs e)
        {
            CtrlNouvContrat nouvContrat = new CtrlNouvContrat();

        }

    }
}
