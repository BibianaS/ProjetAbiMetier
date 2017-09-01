using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class CtrlNouveauCollaborateur
    {
        public CtrlNouveauCollaborateur()
        {
            frmAjouterCollaborateur frmAjouter = new frmAjouterCollaborateur();
            frmAjouter.Text = "Ajouter un Nouveau Collaborateur";
            frmAjouter.ShowDialog();
        }
    }
}
