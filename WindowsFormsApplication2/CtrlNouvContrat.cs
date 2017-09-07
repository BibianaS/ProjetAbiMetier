using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;

namespace ABI
{
    class CtrlNouvContrat
    {
        private frmContrat frmNouvContrat;
        private MContrat nouveauContrat;
        private DialogResult resultat;

        public CtrlNouvContrat()
        {
            frmNouvContrat = new frmContrat();

            this.frmNouvContrat.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            resultat = this.frmNouvContrat.ShowDialog();
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (frmNouvContrat.Controle())
            {
                if (frmNouvContrat.Instancie())
                {
                    frmNouvContrat.DialogResult = DialogResult.OK;
                    this.resultat = DialogResult.OK;
                    this.nouveauContrat = frmNouvContrat.NouveauContrat;
                }
                else
                {
                    this.resultat = DialogResult.Cancel;
                }
            }
        }


        public DialogResult Resultat
        {
            get
            {
                return resultat;
            }
        }

        public MContrat NouveauContrat
        {
            get
            {
                return nouveauContrat;
            }
        }
    }
}
