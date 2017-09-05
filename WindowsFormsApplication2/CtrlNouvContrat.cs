using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class CtrlNouvContrat
    {
        frmContrat nouvContrat;
        public CtrlNouvContrat()
        {
            System.Windows.Forms.MessageBox.Show("Dans contrat");
            nouvContrat = new frmContrat();
            nouvContrat.ShowDialog();
        }
    }
}
