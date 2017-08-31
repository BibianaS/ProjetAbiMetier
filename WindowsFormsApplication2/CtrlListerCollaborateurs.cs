using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    class CtrlListerCollaborateurs
    {
        public CtrlListerCollaborateurs()
        {
            //instanciation du frm principale 
            frmABI frmAbi = new frmABI();

            //affichage des Collaborateurs
            frmAbi.afficherCollaborateurs();

        }
    }
}
